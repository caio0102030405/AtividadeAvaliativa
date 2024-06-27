using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeGit
{
    public class Partida
    {
        public Time Visitante { get; set; }
        public Time Casa { get; set; }
        public int GolsTimeCasa { get; set; }
        public int GolsTimeVisitante { get; set; }
        public List<Jogador> AutoresGols { get; set; }
        public string MensagemResultadoPartida { get; set; }

        public Partida(Time casa, Time visitante)
        {
            Casa = casa;
            Visitante = visitante;
            GolsTimeCasa = 0;
            GolsTimeVisitante = 0;
            AutoresGols = new List<Jogador>();
            MensagemResultadoPartida = "";
        }

        public Time DeterminarVencedor()
        {
            if (GolsTimeCasa > GolsTimeVisitante)
            {
                return Casa;
            }
            else if (GolsTimeVisitante > GolsTimeCasa)
            {
                return Visitante;
            }
            else
            {
                return null; 
            }
        }

        public void PreencherMensagemResultado()
        {
            if (GolsTimeCasa > GolsTimeVisitante)
            {
                MensagemResultadoPartida = $"{Casa.Nome} venceu por {GolsTimeCasa} a {GolsTimeVisitante} contra {Visitante.Nome}.";
            }
            else if (GolsTimeVisitante > GolsTimeCasa)
            {
                MensagemResultadoPartida = $"{Visitante.Nome} venceu por {GolsTimeVisitante} a {GolsTimeCasa} contra {Casa.Nome}.";
            }
            else
            {
                MensagemResultadoPartida = $"{Casa.Nome} e {Visitante.Nome} empataram em {GolsTimeCasa} a {GolsTimeVisitante}.";
            }
        }
    }
}
