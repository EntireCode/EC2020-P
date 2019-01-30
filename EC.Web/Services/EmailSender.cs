using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace EC.Web.Services
{
    public class EmailSender : IEmailSender
    {
        public AuthMessageSenderOptions Options { get; }

        public EmailSender(IOptions<AuthMessageSenderOptions> options)
        {
            Options = options.Value;
        }

        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Execute(Options.SendGridKey, subject, message, email);
        }

        public async Task Execute(string apiKey, string subject, string message, string email)
        {
            //var client = new SendGridClient(apiKey);
            //var msg = new SendGridMessage()
            //{
            //    From = new EmailAddress("admin@advantech.com", "Admin"),
            //    Subject = subject,
            //    PlainTextContent = message,
            //    HtmlContent = message
            //};
            //msg.AddTo(new EmailAddress(email));
            //msg.SetClickTracking(false, false);

            //var response = client.SendEmailAsync(msg);
            //return response;
            using (var client = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "paps.dataupload@hotmail.com",
                    Password = "P@ps.dataupload"
                };

                client.Credentials = credential;
                client.Host = "smtp.live.com";
                client.Port = 587;
                client.EnableSsl = true;

                using (var emailMessage = new MailMessage())
                {
                    emailMessage.To.Add(new MailAddress(email));
                    emailMessage.From = new MailAddress("paps.dataupload@hotmail.com");
                    emailMessage.Subject = subject;
                    emailMessage.Body = message;
                    client.Send(emailMessage);
                }
            }
            await Task.CompletedTask;
        }
    }
}
