using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DotNetMeritoApp.Models;

namespace DotNetMeritoApp.Controllers;

public class CarController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public CarController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
