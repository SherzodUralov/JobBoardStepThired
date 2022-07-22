using Microsoft.AspNetCore.Mvc;

namespace JobBoardStep.Controllers
{
    public class ApplicationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
