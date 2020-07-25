using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IQTest.Core.Entities
{
    public class Option
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        public string ImagePath { get; set; }

        [Required]
        public bool IsAnswer { get; set; }

        [Required]
        [ForeignKey("QuestionId")]
        public Question Question { get; set; }
        public int QuestionId { get; set; }
    }
}
