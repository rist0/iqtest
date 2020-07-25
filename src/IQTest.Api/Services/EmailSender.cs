using IQTest.Api.Helpers;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace IQTest.Api.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly SendGridOptions _sendGridSettings;

        public EmailSender(IOptions<SendGridOptions> sendGridOptions)
        {
            _sendGridSettings = sendGridOptions.Value;
        }

        public async Task<Response> SendEmailAsync(string email, string subject, string message)
        {
            var client = new SendGridClient(_sendGridSettings.ApiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("noreply@iqtest.com", "IQ Test Results"),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };

            msg.AddTo(email);

            return await client.SendEmailAsync(msg);
        }
    }
}
