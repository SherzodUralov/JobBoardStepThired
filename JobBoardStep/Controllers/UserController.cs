using JobBoardStep.Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace JobBoardStep.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository repository;

        public UserController(IUserRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            var model = repository.GetAll();
            return View(model);
        }
    }
}
