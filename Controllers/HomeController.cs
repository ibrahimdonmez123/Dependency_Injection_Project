using Dependency_Injection_Project.Models;
using Dependency_Injection_Project.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dependency_Injection_Project.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        private readonly MyService _myService;

        public HomeController(MyService myService)
        {
            _myService = myService;
        }

        public IActionResult Index()
        {
            var message = _myService.GetMessage();
            return View("Index", message);
        }
    }
}
