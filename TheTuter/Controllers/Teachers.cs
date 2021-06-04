using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TheTuter.Data;
using TheTuter.Models;
using TheTuter.ViewModel;

namespace TheTuter.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class Teachers : ControllerBase
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly IConfigurationSection _jwtSettings;
        private readonly ApplicationDbContext _dbContext;
        private readonly IWebHostEnvironment _webhost;
        private readonly IHttpContextAccessor _httpCOntext;

        public Teachers(IHttpContextAccessor httpContextAccessor, IWebHostEnvironment WebHostEnvironment, IMapper mapper, UserManager<User> userManager, IConfiguration configuration , ApplicationDbContext applicationDbContext)
        {
            _httpCOntext = httpContextAccessor;
            _webhost = WebHostEnvironment;
            _mapper = mapper;
            _userManager = userManager;
            _dbContext = applicationDbContext;
            _jwtSettings = configuration.GetSection("JwtSettings");
        }

        [HttpGet]
        public ActionResult<IEnumerable<TeacherViewModel>> GetAllTeacher([FromQuery] string searchTerm)
        {
            if(searchTerm != null && searchTerm != "")
            {
                var findUserByName = _userManager.Users.Where(m => m.Role == "Teacher" && m.Subject.Contains(searchTerm)).ToList();
                return Ok(findUserByName);
            }
            else
            {
                var roleName = "Teacher";
                var showUser = (from user in _dbContext.Users
                                where user.Role == roleName
                                select new TeacherViewModel
                                {
                                    UserId = user.Id,
                                    FirstName = user.FirstName,
                                    LastName = user.LastName,
                                    Email = user.Email,
                                    Price = user.Price,
                                    Subject = user.Subject,
                                    Phone = user.PhoneNumber
                                }).ToList();
                return Ok(showUser);
            }
          
        }

        [HttpPost]
        public async Task<ActionResult> UploadQuizes(UploadQuizesViewModel model)
        {
            try
            {

                UploadQuizes quizes = new UploadQuizes();
                {
                    quizes.UserId = model.UserId;
                    quizes.Subject = model.Subject;
                    quizes.Title = model.Title;
                    quizes.OptionA = model.OptionA;
                    quizes.OptionB = model.OptionB;
                    quizes.OptionC = model.OptionC;
                    quizes.OptionD = model.OptionD;
                    quizes.Answer = model.Answer;
                }

                var db = _dbContext.Quizes.Add(quizes);
                var result = _dbContext.SaveChanges();
                if (result > 0)
                {
                    return Ok("Success");
                }
                else
                {
                    return Ok("False");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        [HttpPost]
        public async Task<ActionResult> UploadLecture( UploadLectureViewModel model)
        {
            try
            {
                var currentUrl = @"https://localhost:44319\";
                string datetime = DateTime.Now.ToString("dd/mm/yyyy:mm:hh");
                datetime = datetime.Replace("/", "").Replace(":", "");

                var fileName = Path.GetFileNameWithoutExtension(model.File.FileName);
                var fileExt = Path.GetExtension(model.File.FileName);
                fileName = fileName + datetime;
                var uploading = Path.Combine(_webhost.WebRootPath, @"UploadFiles", fileName + fileExt);
                model.Path = Path.Combine(currentUrl, @"UploadFiles", fileName + fileExt);
                var stream = new FileStream(uploading, FileMode.Create);
                await model.File.CopyToAsync(stream);
                stream.Close();

                UploadLecture lecture = new UploadLecture();
            {
                lecture.UserId = model.UserId;
                lecture.Batch = model.Batch;
                lecture.Class = model.Class;
                lecture.Lesson = model.Lesson;
                lecture.Path = model.Path;
            }

                var db = _dbContext.Lectures.Add(lecture);
                var result = _dbContext.SaveChanges();
                if (result > 0)
                {
                    return Ok("Success");
                }
                else
                {
                    return Ok("False");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }


    }
}
