using AspLesson7.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspLesson7.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Sample sample)
        {
            Debug.WriteLine(sample.First);
            Debug.WriteLine(sample.Second);
            Debug.WriteLine(sample.Count);
            return View();
        }

    }
}
