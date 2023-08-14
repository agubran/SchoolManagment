using Microsoft.AspNetCore.Mvc;
using SchoolManagment.Web.AdoDatabase;
using SchoolManagment.Web.Models;
using System.Diagnostics;

namespace SchoolManagment.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            StudentDatabase studentDatabase = new StudentDatabase();
            return View(studentDatabase.GetStudents());
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


        public ActionResult Details(int id)
        {
            StudentDatabase studentDatabase = new StudentDatabase();
            return View(studentDatabase.GetStudent(id));
        }
    }
}