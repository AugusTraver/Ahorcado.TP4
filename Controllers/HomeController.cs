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
    public IActionResult ComenzarJuego(string Modo)
    {
        Juego.InicializarJuego(Modo);
        ViewBag.adivinanza = Juego.Adivinanza;
        ViewBag.IntentosLetras = Juego.IntentosLetras;
        return View("Juego");
    }
    public IActionResult CompararLetra(char Letra)
    {
        Juego.CompararLetra(Letra);
    string adivinanzaA = new string(Juego.Adivinanza);
    string palabraElegidaA = new string(Juego.PalabraElegida);

    if (adivinanzaA == palabraElegidaA)
    {
        return RedirectToAction("CompararPalabra", new { Palabra = adivinanzaA });
    }
        ViewBag.adivinanza = Juego.Adivinanza;
        ViewBag.IntentosLetras = Juego.IntentosLetras;
        ViewBag.Intentos = Juego.ContadorIntentos;
        return View("Juego");

    }
    public IActionResult CompararPalabra(string Palabra)
    {
        ViewBag.Gano = Juego.CompararPalabra(Palabra);
        ViewBag.adivinanza = Juego.Adivinanza;
        ViewBag.Intentos= Juego.ContadorIntentos;
        ViewBag.IntentosLetras = Juego.IntentosLetras;
        return View("MostrarResultado");
    }
}
