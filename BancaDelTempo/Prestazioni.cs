using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancaDelTempo
{
    public class Prestazioni
    {
        private string nomePrestazione;
        private Categorie categoriaPrestazione;
        private Soci idEsecutore;
        private Soci idRicevente;
        private int totaleOre;
        private DateTime data;

        public Prestazioni(string nomePrestazione, Categorie categoriaPrestazione, Soci idEsecutore, Soci idRicevente, int totaleOre, DateTime data)
        {
            this.NomePrestazione = nomePrestazione;
            this.CategoriaPrestazione = categoriaPrestazione;
            this.IdEsecutore = idEsecutore;
            this.IdRicevente = idRicevente;
            this.TotaleOre = totaleOre;
            this.Data = data;
        }

        public string NomePrestazione { get => nomePrestazione; set { if (!string.IsNullOrWhiteSpace(value)) nomePrestazione = value; else throw new Exception("Inserire il Nome della prestazione");  } }
        public Categorie CategoriaPrestazione { get => categoriaPrestazione; set => categoriaPrestazione = value; }
        public Soci IdEsecutore { get => idEsecutore; set => idEsecutore = value; }
        public Soci IdRicevente { get => idRicevente; set => idRicevente = value;  }
        public int TotaleOre { get => totaleOre; set { if (value != 0) totaleOre = value; else throw new Exception("Inserire il Totale di Ore prestate"); } }
        public DateTime Data { get => data; set { if (!string.IsNullOrWhiteSpace(value.ToString())) if (value <= DateTime.Now) data = value; else throw new Exception("Inserire una Data di Esecuzione valida"); else throw new Exception("Inserire la Data di esecuzione prestazione");  } }
    }
}
