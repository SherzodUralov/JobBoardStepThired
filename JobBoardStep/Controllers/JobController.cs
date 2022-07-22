using JobBoardStep.Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace JobBoardStep.Controllers
{
    public class JobController : Controller
    {
        private readonly IJobRepository _repository;

        public JobController(IJobRepository repository)
        {
            _repository = repository;
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
