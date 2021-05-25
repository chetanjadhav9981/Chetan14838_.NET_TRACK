using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using MVCDemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemoApp.Controllers
{
    public class AssignmentController : Controller
    {
        private readonly ILogger<AssignmentController> _logger;

        public AssignmentController(ILogger<AssignmentController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult RegistrationForm()
        {
            return View(new Registration());
        }

        [HttpPost]
        public ActionResult DisplayRegistrationData(Registration registration)

        {
            if(registration != null)
            {
                ViewBag.DefaultMessage = "Thank You" + registration.Name;
                if (registration.MeetingStatus == "yes")
                {
                    ViewBag.Message = "thankyou for coming ,Please be 10 min prior to start of meeting.";
                }
                else if (registration.MeetingStatus == "Maybe")
                {
                    ViewBag.Message = "We'll Expecting You.";
                }
                else if(registration.MeetingStatus == "No")
                {
                    ViewBag.Message = "Sorry to hear tha you can't make it,but thanks for letting ud know";
                }
            }

            return View();
        }


    }
}
