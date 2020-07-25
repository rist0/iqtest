using System.ComponentModel.DataAnnotations;

namespace IQTest.Core.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [MinLength(3)]
        [MaxLength(100)]
        public string EmailAddress { get; set; }

        [Required]
        public byte[] PasswordHash { get; set; }

        [Required]
        public byte[] PasswordSalt { get; set; }
    }
}
