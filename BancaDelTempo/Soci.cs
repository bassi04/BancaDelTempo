using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancaDelTempo
{
    public class Soci
    {
        private int idSocio;
        private string cognome;
        private string nome;
        private string telefono;
        private int orePrestate;
        private int oreRicevute;

        public Soci(int idSocio, string cognome, string nome, string telefono, int orePrestate, int oreRicevute)
        {
            IdSocio = idSocio;
            Cognome = cognome;
            Nome = nome;
            Telefono = telefono;
            OrePrestate = orePrestate;
            OreRicevute = oreRicevute;
        }

        public int IdSocio { get => idSocio; set => idSocio = value; }
        public string Cognome { get => cognome; set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (value.Length > 2)
                    {
                        cognome = value;
                    }
                    else
                    {
                        throw new Exception("Inserire un Cognome valido");
                    }
                }
                else
                {
                    throw new Exception("Inserire il Cognome");
                }
            }
         }
        public string Nome { get => nome; set { if (!string.IsNullOrWhiteSpace(value)) if (value.Length > 2) nome = value; else throw new Exception("Inserire un Nome valido"); else throw new Exception("inserire il Nome"); } }    
        public string Telefono { get => telefono; set { if (!string.IsNullOrWhiteSpace(value)) if (value.Length == 10 || value.ToString().Length == 9) telefono = value; else throw new Exception("Inserire un Cellulare valido"); else throw new Exception("Inserire il cellulare"); } }
        public int OrePrestate { get => orePrestate; set => orePrestate = value; }
        public int OreRicevute { get => oreRicevute; set => oreRicevute = value; }
    }
}
