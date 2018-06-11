using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipPRJ.Models
{
    public class HiScoresModel : IComparable
    {
        public string ID { get; set; }

        public string NomeJogador { get; set; }

        public int Score { get; set; }

        public double PercentagemAlvo { get; set; }

        public double PercentagemAfundado { get; set; }

        public int TirosAgua { get; set; }

        public int TirosAlvo { get; set; }

        public int TirosRepetido { get; set; }

        public string Resultado { get; set; }

        public string Missao { get; set; }

        public HiScoresModel(string nome, int score, double percalvo, double percafundado, int agua, int alvo, int repetido, string fimdojogo, string missao)
        {
            NomeJogador = nome;
            Score = score;
            PercentagemAlvo = percalvo;
            PercentagemAfundado = percafundado;
            TirosAgua = agua;
            TirosAlvo = alvo;
            TirosRepetido = repetido;
            Resultado = fimdojogo;
            Missao = missao;
            
        }

        public HiScoresModel()
        {

        }

        public int CompareTo(object obj)
        {
            HiScoresModel hs2 = (HiScoresModel)obj;

            if (hs2.Score > Score)
                return 1;
            if (hs2.Score == Score)
                return 0;
            return -1;


        }

    }
}
