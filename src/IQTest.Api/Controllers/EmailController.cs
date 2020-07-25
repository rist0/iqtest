using IQTest.Api.Models;
using IQTest.Api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IQTest.Api.Controllers
{
    [ApiController]
    [Route("api/email")]
    public class EmailController : ControllerBase
    {
        private readonly IEmailSender _emailSender;

        public EmailController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        [HttpPost]
        public async Task<IActionResult> SendEmail(EmailModel emailModel)
        {
            var sendEmail = await _emailSender.SendEmailAsync(emailModel.Email, emailModel.Subject, emailModel.Message);

            if ((int) sendEmail.StatusCode >= 200 && (int) sendEmail.StatusCode < 300)
            {
                return Ok();
            }

            return StatusCode(500, "Failed to send e-mail. Contact the administrators for more information.");
        }
    }
}
