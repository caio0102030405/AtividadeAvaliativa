using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeGit
{
    public class Jogador
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }
        public int NumeroGols { get; set; }
        public int NumeroAssistencias { get; set; }
        public string Posicao { get; set; }

        public Jogador(string nome, int idade, double peso, string posicao)
        {
            Nome = nome;
            Idade = idade;
            Peso = peso;
            Posicao = posicao;
            NumeroGols = 0;
            NumeroAssistencias = 0;
        }
    }
}
