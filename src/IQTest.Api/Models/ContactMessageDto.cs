using System;

namespace IQTest.Api.Models
{
    public class ContactMessageDto
    {
        public string FullName { get; set; }

        public string EmailAddress { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        public DateTime DateReceived { get; set; }
    }
}
