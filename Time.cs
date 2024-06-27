using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeGit
{
    public class Time
    {
        public string Nome { get; set; }
        public int AnoCriacao { get; set; }
        public int Pontuacao { get; set; }

        public Time(string nome, int anoCriacao)
        {
            Nome = nome;
            AnoCriacao = anoCriacao;
            Pontuacao = 0; 
        }
    }
}
