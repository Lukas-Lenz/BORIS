using BORIS.Models;
using BORIS.Services;
using Microsoft.AspNetCore.Mvc;

namespace BORIS.Controllers
{
    public class NaviController : Controller
    {

        private readonly IProgramService? _programService;

        public NaviController(IProgramService programService)
        {
            _programService = programService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoadProgramOverview(string programKeys)
        {
            List<ProgramInfo> programs = _programService.GetProgramList(programKeys);
            return View(programs);
        }

        public IActionResult LoadProgramDescription(string programKey)
        {
            ProgramInfo program = _programService.GetProgramDescription(programKey);
            return PartialView("_ProgramDescription", program);
        }

    }

    
}
