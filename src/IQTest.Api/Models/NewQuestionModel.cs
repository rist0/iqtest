using Microsoft.AspNetCore.Http;

namespace IQTest.Api.Models
{
    public class NewQuestionModel
    {
        public string Name { get; set; }
        public int Difficulty { get; set; }
        public IFormFile QuestionImage { get; set; }
        //public List<NewOptionModel> Options { get; set; }
    }
}
