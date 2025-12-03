using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudMoura.Models
{
    public class Aluno
    {
        public int Id_Aluno {get; set;}

        public string NomeAluno {get; set;}

        public int Idade {get; set;}

        public double CPF {get; set;}
    }
}