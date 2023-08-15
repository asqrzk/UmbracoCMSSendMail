using System;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.Extensions.Logging;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;
namespace BananaMailer
{
	public class HomePageController: SurfaceController
    {
        public HomePageController(
            IUmbracoContextAccessor umbracoContextAccessor,
            IUmbracoDatabaseFactory databaseFactory,
            ServiceContext services,
            AppCaches appCaches,
            IProfilingLogger profilingLogger,
            IPublishedUrlProvider publishedUrlProvider)
            : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
        }

        public IActionResult Index()
        {
            return CurrentUmbracoPage();
        }

        [HttpPost]
        public IActionResult SendMail(string email)
        {
            using (var client = new SmtpClient())
            {
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("coldbananamailer@gmail.com", "mssetdmrnmdyjjaj");
                using (var message = new MailMessage(
                    from: new MailAddress("coldbananamailer@gmail.com", "Ashique K"),
                    to: new MailAddress(email, email.Split('@')[0])
                    ))
                {

                    message.Subject = "Hello from Cold Banana";
                    message.Body = "This is the test solution for a cold banana mailer.";

                    client.Send(message);
                }
            }
            return Ok("Successfully Sent Mail");
        }
    }
}

