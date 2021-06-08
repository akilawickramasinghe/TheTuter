using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TheTuter.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Http;
using TheTuter.Data;
using TheTuter.ViewModel;
using TheTuter.Helper;
using TheTuter.DTO;

namespace TheTuter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _db;
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IConfigurationSection _jwtSettings;

        public AccountsController(ApplicationDbContext db, IMapper mapper, UserManager<User> userManager, IConfiguration configuration)
        {
            _db = db;
            _mapper = mapper;
            _userManager = userManager;
            _configuration = configuration;
            _jwtSettings = configuration.GetSection("JwtSettings");
        }

        [Authorize(Roles = "Visitor")]
        [HttpGet("Test")]
        public String Test()
        {
            return "accounts controller";
        }


        [HttpPost("Register")]
        public async Task<ActionResult> Register(UserRegistrationModel userModel)
        {
            //var user = _mapper.Map<User>(userModel);
            var user = new User();
            user.FirstName = userModel.FirstName;
            user.LastName = userModel.LastName;
            user.Email = userModel.Email;
            user.PhoneNumber = userModel.PhoneNumber;
            user.Role = userModel.Role;
            user.UserName = userModel.Email;
            if (userModel.Price != null)
            {
                user.Price = decimal.Parse(userModel.Price);
            }
            if (userModel.Subject != null)
            {
                user.Subject = userModel.Subject;
            }
            user.Address = userModel.Address;

            var result = await _userManager.CreateAsync(user, userModel.Password);
            HttpContext.Session.SetString("UserId", user.Id.ToString());
            if (!result.Succeeded)
            {
                return Ok(result.Errors);
            }
            if (userModel.Role == "Student")
            {
                await _userManager.AddToRoleAsync(user, "Student");
                return StatusCode(200);
            }
            else
            {
                await _userManager.AddToRoleAsync(user, "Teacher");
                //await _userManager.AddToRoleAsync(user, "Visitor");
                return StatusCode(200);
            }

        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserLoginModel userModel)
        {
            var user = await _userManager.FindByEmailAsync(userModel.Email);
            if (user != null && await _userManager.CheckPasswordAsync(user, userModel.Password))
            {
                var signingCredentials = GetSigningCredentials();
                var claims = GetClaims(user);
                var tokenOptions = GenerateTokenOptions(signingCredentials, await claims);
                var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                return Ok(user);
            }
            return Ok("EmailPasswordIncorrect");
        }

        [HttpPost("ContactUs")]
        public async Task<IActionResult> ContactUs(ContactUsViewModel model)
        {
            var contact = new ContactUs();
            contact.FullName = model.FullName;
            contact.Email = model.Email;
            contact.Phone = model.Phone;
            contact.Message = model.Message;

            _db.Contacts.Add(contact);
            _db.SaveChanges();

            EmailHelper helper = new EmailHelper();
            string htmlmessage = string.Empty;
            string subject = "Contact Us";

            var body = "Hi admin,<br/> <br/> " + model.FullName + " " + "Please reach out him/her.<br>" +
              "<br> Email: " + model.Email + "<br> Phone: " + model.Phone + "<br/> <b>Message: </b>" + model.Message;
            helper = new EmailHelper(_configuration["EmailSettings:EmailUser"], model.Email.Trim(), subject, null, body, null);


            helper = new EmailHelper(_configuration["EmailSettings:EmailUser"], model.Email.Trim(), subject, null, body, null, null);

            EmailDetailsDTO emailDetails = new EmailDetailsDTO()
            {
                Server = _configuration.GetValue<string>("EmailSettings:EmailServer") == null ? string.Empty : _configuration.GetValue<string>("EmailSettings:EmailServer"),
                Port = Convert.ToInt32(_configuration["EmailSettings:EmailPort"]),
                User = _configuration["EmailSettings:EmailUser"] == null ? string.Empty : _configuration["EmailSettings:EmailUser"].ToString(),
                Password = _configuration["EmailSettings:EmailPassword"] == null ? string.Empty : _configuration["EmailSettings:EmailPassword"].ToString(),
                UseSsl = Convert.ToBoolean(_configuration["EmailSettings:EmailUseSsl"]),
                RequiresAuthentication = Convert.ToBoolean(_configuration["EmailSettings:EmailRequiresAuthentication"])
            };



            bool result = await Task.Run(() => helper.SendEmailAsync(emailDetails));
            if (result == true)
            {
                return Ok("EmailSuccessfully");
            }
            else
            {
                return Ok("EmailNotSuccessfully");
            }
        }


        private SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes(_jwtSettings.GetSection("securityKey").Value);
            var secret = new SymmetricSecurityKey(key);

            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var tokenOptions = new JwtSecurityToken(
                issuer: _jwtSettings.GetSection("validIssuer").Value,
                audience: _jwtSettings.GetSection("validAudience").Value,
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(_jwtSettings.GetSection("expiryInMinutes").Value)),
                signingCredentials: signingCredentials);

            return tokenOptions;
        }

        private async Task<List<Claim>> GetClaims(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Email)
            };
            var roles = await _userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            return claims;
        }
    }
}
