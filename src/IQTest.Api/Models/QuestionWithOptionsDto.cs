using System.Collections.Generic;

namespace IQTest.Api.Models
{
    public class QuestionWithOptionsDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImagePath { get; set; }

        public List<OptionDto> Options { get; set; }

        public int Difficulty { get; set; }
    }
}
