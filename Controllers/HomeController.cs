using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tp4.Models;

namespace Tp4.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

[HttpPost]
public IActionResult ComenzarJuego (string Modo)
{
Juego.InicializarJuego(Modo);
return View();
}
    }
