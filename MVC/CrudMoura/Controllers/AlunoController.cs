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
    public class AlunoController : Controller
    {
        private readonly ILogger<AlunoController> _logger;
        private readonly CrudMouraContext _context; // representa o nosso banco de dados

        public AlunoController(ILogger<AlunoController> logger, CrudMouraContext context)
        {
            _logger = logger;
            _context = context;
        }

        public static List<Aluno> ListaDeAlunos = new List<Aluno>
        {
            new Aluno{Id_Aluno = 1, NomeAluno = "Rafael", Idade = 12, CPF = "716.611.610-33" },
            new Aluno{Id_Aluno = 2, NomeAluno = "Ariel", Idade = 11, CPF = "117.194.0505-34" },
            new Aluno{Id_Aluno = 3, NomeAluno = "Torolho", Idade = 12, CPF = "437.054.418-75" },
        };

        public AlunoController(ILogger<AlunoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListarAluno()
        {
            ViewBag.Aluno = ListaDeAlunos;
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SalvarAluno(Aluno AlunoCadastrado)
        {
            AlunoCadastrado.Id_Aluno = ListaDeAlunos.Max(f => f.Id_Aluno) + 1;
            ListaDeAlunos.Add(AlunoCadastrado);
            return RedirectToAction(nameof(ListarAluno));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}