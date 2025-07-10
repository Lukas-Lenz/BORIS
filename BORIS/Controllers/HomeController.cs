using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BORIS.Models;

namespace BORIS.Controllers;

public class HomeController : Controller
{
    List<ProgramInfo> programSelection;

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;

    }

    public IActionResult Index()
    {
        return View();
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
    public IActionResult LoadProgramDescription(List<ProgramInfo> program)
    {
        return PartialView("_ProgramDescription", program);
    }
}
