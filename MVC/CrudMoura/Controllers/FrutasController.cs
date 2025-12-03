using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CrudMoura.Models;
namespace CrudMoura.Controllers
{
    // [Route("[controller]")]
    public class FrutasController : Controller
    {
        private readonly ILogger<FrutasController> _logger;

        public static List<Frutas> ListaDeFrutas = new List<Frutas>
        {
            new Frutas{Id_Frutas = 1, Nome = "Morango", Preco = 5.99f, Quantidade = 10, Categoria = "Tropical"},
            new Frutas{Id_Frutas = 2, Nome = "Abacate", Preco = 4.99f, Quantidade = 12, Categoria = "Tropical"},
            new Frutas{Id_Frutas = 3, Nome = "Limão", Preco = 6.99f, Quantidade = 17, Categoria = "Cítrica"},
        };

        public FrutasController(ILogger<FrutasController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListarFrutas()
        {

            ViewBag.Frutas = ListaDeFrutas;

            return View();
        }

        //Cria a tela de cadastro das frutas
        public IActionResult Create()
        {
            return View();
        }

        //salvar a frutana ListaDeFrutas
        //Em seguida, redireciona para a lista/tabela de ListaFrutas
        [HttpPost]
        public IActionResult SalvarFruta(Frutas FrutaCadastrada)
        {
            FrutaCadastrada.Id_Frutas = ListaDeFrutas.Max(f => f.Id_Frutas) + 1;
            ListaDeFrutas.Add(FrutaCadastrada);
            return RedirectToAction(nameof (ListarFrutas));

        }

        public IActionResult TesteController()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}