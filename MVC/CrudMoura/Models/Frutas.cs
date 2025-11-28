using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using CrudMoura.Controllers;

namespace CrudMoura.Models
{
    public class Frutas
    {
        public int Id_Frutas {get; set;}
        public string Nome {get; set;}
        public float Preco {get; set;}
        public int Quantidade {get; set;}
        public string Categoria {get; set;}
    }
}