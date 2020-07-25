using AutoMapper;
using IQTest.Api.Models;
using IQTest.Core.Entities;
using IQTest.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace IQTest.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/questions")]
    public class QuestionController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public QuestionController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<QuestionWithoutOptionsDto>> GetQuestions()
        {
            var questions = _unitOfWork.Questions.GetAll();

            var questionsDto = _mapper.Map<IEnumerable<QuestionWithoutOptionsDto>>(questions);

            return Ok(questionsDto);
        }

        [AllowAnonymous]
        [HttpGet("full")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<QuestionWithOptionsDto>> GetQuestionsWithOptions()
        {
            var questions = _unitOfWork.Questions.Find(null, "Options");

            var questionsDto = _mapper.Map<IEnumerable<QuestionWithOptionsDto>>(questions);

            return Ok(questionsDto);
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public ActionResult<QuestionWithOptionsDto> GetQuestion(int id)
        {
            var question = _unitOfWork.Questions.Find((Question x) => x.Id == id, "Options").SingleOrDefault();

            var questionDto = _mapper.Map<QuestionWithOptionsDto>(question);

            return Ok(questionDto);
        }

        [HttpDelete("{id}")]
        public ActionResult<Question> DeleteQuestion(int id)
        {
            var question = _unitOfWork.Questions.GetById(id);

            _unitOfWork.Questions.Remove(question);
            _unitOfWork.Complete();

            return Ok(question);
        }

        [HttpPost("new")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddQuestion([FromForm] NewQuestionModel question, [FromForm] string options)
        {
            var questionOptions = JsonConvert.DeserializeObject<List<NewOptionModel>>(options);

            if (question.QuestionImage == null || question.QuestionImage.Length == 0)
            {
                return BadRequest(new { message = "Please select a valid question image" });
            }

            // SETUP FOLDER
            var questionImagesFolderPath = Path.Combine("Resources", "QuestionImages");
            var questionOptionsFolderPath = Path.Combine("Resources", "QuestionOptionImages");

            var questionImagesFolderFullPath = Path.Combine(Directory.GetCurrentDirectory(), questionImagesFolderPath);
            var questionOptionsFolderFullPath = Path.Combine(Directory.GetCurrentDirectory(), questionOptionsFolderPath);

            if (!Directory.Exists(questionImagesFolderFullPath))
            {
                Directory.CreateDirectory(questionImagesFolderFullPath);
            }
            if (!Directory.Exists(questionOptionsFolderFullPath))
            {
                Directory.CreateDirectory(questionOptionsFolderFullPath);
            }

            // UPLOAD QUESTION IMAGE
            var uniqueQuestionImageFileName = $"{Guid.NewGuid()}_question{Path.GetExtension(question.QuestionImage.FileName)}";
            var uniqueQuestionImageFillNameFullpath = Path.Combine(questionImagesFolderFullPath, uniqueQuestionImageFileName);

            try
            {
                using var fs = new FileStream(uniqueQuestionImageFillNameFullpath, FileMode.Create);
                question.QuestionImage.CopyTo(fs);
            }
            catch (Exception)
            {
                // Console.WriteLine(ex.Message);
                return BadRequest(new { message = "Error while saving question image." });
            }

            var questionOptionEntities = new List<Option>();
            var questionEntity = new Question
            {
                Name = question.Name,
                ImagePath = Path.Combine(questionImagesFolderPath, uniqueQuestionImageFileName),
                Difficulty = question.Difficulty,
                Options = questionOptionEntities
            };

            // UPLOAD QUESTION OPTION IMAGES
            foreach (var questionOption in questionOptions)
            {
                var questionOptionImageExtension = GetExtensionFromBase64File(questionOption.Image);

                var uniqueQuestionOptionImageFileName = $"{Guid.NewGuid()}_option.{questionOptionImageExtension}";
                var uniqueQuestionOptionImageFileNameFullPath = Path.Combine(questionOptionsFolderFullPath, uniqueQuestionOptionImageFileName);

                try
                {
                    using var fs = new FileStream(uniqueQuestionOptionImageFileNameFullPath, FileMode.Create);
                    string imageAsBase64String = "";

                    if (questionOption.Image.Contains(","))
                    {
                        imageAsBase64String = questionOption.Image
                          .Substring(questionOption.Image.IndexOf(",") + 1);
                    }

                    var imageAsBase64ByteArray = Convert.FromBase64String(imageAsBase64String);

                    fs.Write(imageAsBase64ByteArray, 0, imageAsBase64ByteArray.Length);
                }
                catch (Exception)
                {
                    // Console.WriteLine(ex.Message);
                    return BadRequest(new { message = "Error while saving question option images." });
                }
                
                questionOptionEntities.Add(new Option
                {
                    ImagePath = Path.Combine(questionOptionsFolderPath, uniqueQuestionOptionImageFileName),
                    IsAnswer = !string.IsNullOrEmpty(questionOption.IsAnswer) && !questionOption.IsAnswer.Contains("false")
                });
            }

            _unitOfWork.Questions.Add(questionEntity);
            _unitOfWork.Complete();

            return Ok(questionEntity);
        }

        private string GetExtensionFromBase64File(string fileContents)
        {
            return new Regex(@"image\/(.*);").Match(fileContents).Groups[1].Value;
        }
    }
}
