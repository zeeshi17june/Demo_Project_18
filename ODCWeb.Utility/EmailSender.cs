using Microsoft.AspNetCore.Identity.UI.Services;
namespace Bulky.Utility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            ////////write logic here to send email if requried, for now we are doing this to remove error
            return Task.CompletedTask;
        }
    }
}