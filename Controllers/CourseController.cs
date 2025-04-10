using BtkAkademi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BtkAkademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);
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
        public IActionResult Apply([FromForm] Candidate model) // [FromForm] Verinin formdan geldiğini belirttik
        {
            if (Repository.Applications.Any(c => c.Email.Equals(model.Email)))
            {
                ModelState.AddModelError("", "There is already an application for you");
            }
            if (ModelState.IsValid)
            {
                Repository.Add(model);
                return View("Feedback", model);
            }
            return View();
        }
    }
}