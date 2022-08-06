using EmpRegistration.Web.Areas.Employees;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace EmpRegistration.Web.Areas.Employees.Controllers
{
    [Area("Employees")]
    public class EmpController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(string input, IFormCollection collection)
        {
            return View("Confirmation");
            
        }
        


    }
}
