using Microsoft.AspNetCore.Mvc;

namespace JobBoardStep.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
