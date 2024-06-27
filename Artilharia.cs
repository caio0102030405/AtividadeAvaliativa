using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeGit
{
    public class Artilharia
    {
        public List<Jogador> TabelaArtilharia { get; set; }

        public Artilharia()
        {
            TabelaArtilharia = new List<Jogador>();
        }

        public void ImprimirArtilheiros()
        {
            Console.WriteLine("Lista de Artilheiros:");
            foreach (var jogador in TabelaArtilharia)
            {
                Console.WriteLine($"Nome: {jogador.Nome}, Gols: {jogador.NumeroGols}");
            }
        }
    }
}
