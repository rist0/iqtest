using System;
using System.ComponentModel.DataAnnotations;

namespace IQTest.Core.Entities
{
    public class ContactMessage
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [MinLength(5)]
        public string Subject { get; set; }

        [Required]
        [MinLength(20)]
        [MaxLength(200)]
        public string Message { get; set; }

        public DateTime DateReceived { get; set; }
    }
}
