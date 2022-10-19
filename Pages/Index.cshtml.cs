using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NET6RazorPagesSendEmailWithGmailAuth.Entities;
using NET6RazorPagesSendEmailWithGmailAuth.Helpers;

namespace NET6RazorPagesSendEmailWithGmailAuth.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        SendEmail sendMail = new SendEmail();

        [BindProperty]
        public Email Email { get; set; }

        public void OnPost()
        {
            sendMail.Send(Email.NameSurname,Email.EmailAddress,Email.Message);
        }
    }
}