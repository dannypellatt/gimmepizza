using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using gimmepizza.Models;

namespace gimmepizza.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
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

    public IActionResult Index(pizzaModel cal)
    {
        int a = cal.Size;
        int b = cal.Quantity;
        //int c = cal.Price;

        int radius = a / 2;
        double pi = 3.14;

        //if (c != 0)
        //{
        //    cal.CostPerInch = c / (int)((pi * (radius * radius)) * b);
        //}

        cal.Result = (int)((pi * (radius * radius)) * b);
        
        ViewData["result"] = cal.Result;
        //ViewData["cost"] = cal.CostPerInch;
        return View();
    }
}

