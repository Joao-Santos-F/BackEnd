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

        public static List<Aluno> ListaDeAlunos = new List<Aluno>
        {
            new Aluno{Id_Aluno = 1, NomeAluno = "Rafael", Idade = 12, CPF = 716611610323 },
            new Aluno{Id_Aluno = 2, NomeAluno = "Ariel", Idade = 11, CPF = 1171940505534 },
            new Aluno{Id_Aluno = 3, NomeAluno = "Torolho", Idade = 12, CPF = 437054410875 },
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