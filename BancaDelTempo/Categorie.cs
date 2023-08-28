using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancaDelTempo
{
    public class Categorie
    {
        private int idCategoria;
        private string nomeCategoria;

        public Categorie(int idCategoria, string nomeCategoria)
        {
            IdCategoria = idCategoria;
            NomeCategoria = nomeCategoria;
        }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string NomeCategoria { get => nomeCategoria; set { if (!string.IsNullOrWhiteSpace(value)) if (value.Length > 2) nomeCategoria = value; else throw new Exception("Inserire una Categoria corretta"); else throw new Exception("Inserire il Nome della Categoria");  } }
    }
}
