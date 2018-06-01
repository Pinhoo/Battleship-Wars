using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BattleshipPRJ.Models
{
    public class RoundSummary
    {
        public int NRonda { get; set; }

        public int ScoreInicio { get; set; }

        public int CoordAlvoEscolhido { get; set; }

        public int ResultTiro { get; set; }

        public int BarcoAtingido { get; set; }

        public int TotalTiroAlvo { get; set; }

        public int TotalBarcosAfundados { get; set; }

        public int ScoreFimRonda { get; set; }

        private int[,] grelha;
        
        public int[,] Grelha
        {
            get
            {
                return grelha;
            }

        }

        public RoundSummary()
        {

            NRonda = 1;
            ScoreInicio = 0;

            grelha = new int[10, 10]
            {
                //valores reservados:
                //-1=desconhecido (jogador não atirou aqui)
                //0=água; 1,2,3,4,5=barco de n canos
                //outros valores: não usados (pode definir o que quiser caso necessite)


                //nesta grelha de teste mostramos alguns quadrados marcados com água e outros com barcos
                //esta disposição não apareceria no jogo pois não há barcos de 4 canos com este formato
                { -1,-1,-1,-1,-1,-1,-1,-1,-1, -1},
                {-1, -1,-1,-1,-1,-1,-1,-1, -1,-1},
                {-1,-1, -1, -1, -1, -1, -1, -1,-1,-1},
                {-1,-1, -1,-1,-1,-1,-1, -1,-1,-1},
                {-1,-1, -1,-1, -1, -1,-1, -1,-1,-1},
                {-1,-1, -1,-1, -1, -1,-1, -1,-1,-1},
                {-1,-1, -1,-1,-1,-1,-1, -1,-1,-1},
                {-1,-1, -1, -1, -1, -1, -1, -1,-1,-1},
                {-1, -1,-1,-1,-1,-1,-1,-1, -1,-1},
                { -1,-1,-1,-1,-1,-1,-1,-1,-1, -1}
            };


        }
        //public int NumTotRondas()
        //{

        //    int totalrondas = 1;

        //    while (NRonda > 1)
        //    {

        //        totalrondas = totalrondas + 1;
        //        break;

        //    }

        //    return totalrondas;




        }

       
    }




