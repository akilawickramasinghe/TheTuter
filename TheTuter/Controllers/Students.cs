using System;
using System.Collections.Generic;
using System.Linq;
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
    public class Students : ControllerBase
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly IConfigurationSection _jwtSettings;
        private readonly ApplicationDbContext _dbContext;
        private readonly IWebHostEnvironment _webhost;
        private readonly IHttpContextAccessor _httpCOntext;

        public Students(IHttpContextAccessor httpContextAccessor, IWebHostEnvironment WebHostEnvironment, IMapper mapper, UserManager<User> userManager, IConfiguration configuration, ApplicationDbContext applicationDbContext)
        {
            _httpCOntext = httpContextAccessor;
            _webhost = WebHostEnvironment;
            _mapper = mapper;
            _userManager = userManager;
            _dbContext = applicationDbContext;
            _jwtSettings = configuration.GetSection("JwtSettings");
        }


        [HttpGet]
        public  ActionResult<IEnumerable<GetAllLectureByTeacher>> GetTeacherBySubject(string subject)
        {

            var findUser = _userManager.Users.Where(m => m.Role == "Teacher" && m.Subject.Contains(subject)).ToList();
            return Ok(findUser);
        }

        [HttpGet]
        public ActionResult<IEnumerable<GetQuizesViewModel>> GetAllQuizByTeacherId(int startIndex = 0, int maxRows = 1, string selectedAnswer = null, int countedAnswer = 0)
        {
            var result = _dbContext.Quizes.ToList();
            var subject = _dbContext.StudentPaymentInfos.ToList();
            int totalCount = 0;
            foreach (var item in subject)
            {
                foreach (var items in result)
                {
                    if(item.Subject == items.Subject)
                    {
                        totalCount = totalCount + 1;
                    }
                }
                break;
            }

            if (startIndex == 0 && selectedAnswer == null)
            {
                var getAllQuizes = (from user in _dbContext.StudentPaymentInfos
                                    join quiz in _dbContext.Quizes
                                    //where user.TeacherId == quiz.UserId  
                                    on user.TeacherId equals quiz.UserId
                                    where user.Subject == quiz.Subject

                                    select new GetQuizesViewModel
                                    {
                                        UserId = quiz.UserId,
                                        Subject = quiz.Subject,
                                        Title = quiz.Title,
                                        OptionA = quiz.OptionA,
                                        OptionB = quiz.OptionB,
                                        OptionC = quiz.OptionC,
                                        OptionD = quiz.OptionD,
                                        Answer = quiz.Answer,
                                        AnswerCount = countedAnswer
                                    }).OrderBy(quizes => quizes.UserId)
                                       .Skip(startIndex)
                                       .Take(maxRows).ToList();

                var obj = new QuizCalculationViewModel();
                obj.QuizesList = getAllQuizes;
                obj.Total = totalCount;
                obj.Answer = countedAnswer;
                return Ok(obj);
            }
            else
            {
                foreach (var item in result)
                {
                    if (item.Answer != null && item.Answer == selectedAnswer)
                    {
                        countedAnswer = countedAnswer + 1;
                    }
                }
                var getAllQuizes = (from user in _dbContext.StudentPaymentInfos
                                    join quiz in _dbContext.Quizes
                                     on user.TeacherId equals quiz.UserId
                                    where user.Subject == quiz.Subject
                                    select new GetQuizesViewModel
                                    {
                                        UserId = quiz.UserId,
                                        Subject = quiz.Subject,
                                        Title = quiz.Title,
                                        OptionA = quiz.OptionA,
                                        OptionB = quiz.OptionB,
                                        OptionC = quiz.OptionC,
                                        OptionD = quiz.OptionD,
                                        Answer = quiz.Answer,
                                        AnswerCount = countedAnswer
                                    }).OrderBy(quizes => quizes.UserId)
                   .Skip(startIndex)
                   .Take(maxRows).ToList();

                var obj = new QuizCalculationViewModel();
                obj.QuizesList = getAllQuizes;
                obj.Total = totalCount;
                obj.Answer = countedAnswer;
                return Ok(obj);
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<GetAllLectureByTeacher>> GetAllLectureByTeacherId([FromQuery] string searchTerm)
        {
            if (searchTerm != null && searchTerm != "")
            {
                var findUserByClass = _dbContext.Lectures.Where(m => m.Class.Contains(searchTerm)).ToList();
                return Ok(findUserByClass);
            }
            else
            {

                var showUser = (from user in _dbContext.Users
                                join lecture in _dbContext.Lectures
                                 on user.Id equals lecture.UserId

                                select new UploadLectureViewModel
                                {
                                    UserId = user.Id,
                                    Batch = lecture.Batch,
                                    Class = lecture.Class,
                                    Lesson = lecture.Lesson,
                                    Path = lecture.Path
                                }).ToList();
                return Ok(showUser);
            }
        }   
        
        [HttpPost]
        public IActionResult StudentPayment(PaymentInfoViewModel model)
        {
            var payment = new PaymentInformation();
            payment.StudentId = model.StudentId;
            payment.TeacherId = model.TeacherId;
            payment.Price = model.Price;
            payment.Subject = model.Subject;
            payment.IsActive = true;
            if(model.CardNumber != null)
            {
                payment.CardNumber = model.CardNumber;
            }    
             if(model.MonthExpiry != null) {
                payment.MonthExpiry = int.Parse(model.MonthExpiry);
            }
             if(model.YearExpiry != null) {
                payment.YearExpiry = int.Parse(model.YearExpiry);
            }
             if(model.Cvv != null) {
                payment.Cvv = int.Parse(model.Cvv);
            }
          
            var data = _dbContext.StudentPaymentInfos.Add(payment);
            var result = _dbContext.SaveChanges();
            if(result > 0){
                return Ok("true");
            }
            else
            {
                return Ok("false");
            }
        }
    }
}
