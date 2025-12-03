using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CrudMoura.Models;

namespace CrudMoura.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // funcao padrão inicial
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult MinhaAcao()
    {
        return View(); // retorne a págia Minhacao.cshtml
    }

    public IActionResult ListarNomes()
    {
        string[] nomes = { "Eduardo", "Maria", "João", "Kauã", "Milena" };

        ViewBag.Teste = "Olá, eu vim da mochila";
        ViewBag.nomes = nomes; //Guarda os nomes na viewbag

        return View(); // chama a view
    }


    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Teste()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
