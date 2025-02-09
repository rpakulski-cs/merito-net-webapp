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
        var carsList = new List<CarViewModel>
        {
            new CarViewModel { Name = "Toyota", Type = "Sedan", Color = "Red" },
            new CarViewModel { Name = "Honda", Type = "SUV", Color = "Blue" },
            new CarViewModel { Name = "Ford", Type = "Truck", Color = "Black" }
        };
        return View(carsList);
    }
}
