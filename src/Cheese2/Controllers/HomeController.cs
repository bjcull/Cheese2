using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cheese2.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Framework.OptionsModel;

namespace Cheese2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<AppSettings> _appSettings;

        public HomeController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings;
        }

        public IActionResult Index()
        {
            ViewBag.Key = _appSettings.Options.ConsumerKey;

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }

        public TestObject Test()
        {
            return new TestObject()
            {
                Id = new Random().Next(),
                Name = "Ben"
            };
        }
    }

    public class TestObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
