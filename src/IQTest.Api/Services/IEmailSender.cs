using SendGrid;
using System.Threading.Tasks;

namespace IQTest.Api.Services
{
    public interface IEmailSender
    {
        Task<Response> SendEmailAsync(string email, string subject, string message);
    }
}
