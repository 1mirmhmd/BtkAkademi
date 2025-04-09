using BtkAkademi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BtkAkademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //bu action get için çalışır
        public IActionResult Apply()
        {
            return View();
        }
        //bu action post için çalışır
        [HttpPost]
        // Sahtekarlığa karşı
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm]Candidate model) // [FromForm] Verinin formdan geldiğini belirttik
        {
            return View();
        }
    }
}