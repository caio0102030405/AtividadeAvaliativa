using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeGit
{
    public class Campeonato
    {
        public string Nome { get; set; }
        public List<Time> Times { get; set; }

        public Campeonato(string nome)
        {
            Nome = nome;
            Times = new List<Time>();
        }
    }
}
