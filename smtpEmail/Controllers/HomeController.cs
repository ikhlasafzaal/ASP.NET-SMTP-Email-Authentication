using Microsoft.AspNetCore.Mvc;
using smtpEmail.Models;
using System.Diagnostics;

using MailKit.Security;
using MimeKit;
using MailKit.Net;
using MailKit.Net.Smtp;


namespace smtpEmail.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult SendEmail(string email, string body, string subject)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("ikhlas", "ikhlasafzaal13@gmail.com"));
            message.To.Add(new MailboxAddress("", email));
            message.Subject = subject;
            message.Body = new TextPart("plain text")
            {
                Text = body
            };

            using var client = new MailKit.Net.Smtp.SmtpClient();
            client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTlsWhenAvailable);
            client.Authenticate("ikhlasafzaal13@gmail.com", "otgr purx zlhk qsxg");
            client.Send(message);

            return RedirectToAction("Index");

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult register()
        {
            return View("register");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}