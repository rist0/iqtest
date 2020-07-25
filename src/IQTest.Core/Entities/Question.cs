using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IQTest.Core.Entities
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string ImagePath { get; set; }

        [Required]
        public ICollection<Option> Options { get; set; }

        [Required]
        public int Difficulty { get; set; }
    }
}
