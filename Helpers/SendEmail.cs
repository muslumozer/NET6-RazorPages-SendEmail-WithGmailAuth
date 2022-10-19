using MimeKit;
using NET6RazorPagesSendEmailWithGmailAuth.Entities;
using System.Net.Mail;

namespace NET6RazorPagesSendEmailWithGmailAuth.Helpers
{
    public class SendEmail
    {
        public void Send(string namesurname,string emailaddress,string message)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(MailboxAddress.Parse("yourmail@gmail.com"));
            emailMessage.To.Add(MailboxAddress.Parse("yourmail@gmail.com"));
            emailMessage.Subject = "Email Subject";
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = string.Format("Name and Surname: {0}<br/>E-Mail Address: {1}<br/>Message: {2}", namesurname,emailaddress, message) };

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                try
                {
                    client.Connect("smtp.gmail.com", 465, true);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Authenticate("yourmail@gmail.com", "password");
                    client.Send(emailMessage);
                }
                catch
                {
                    throw;
                }
                finally
                {
                    client.Disconnect(true);
                    client.Dispose();
                }
            }
        }
    }
}
