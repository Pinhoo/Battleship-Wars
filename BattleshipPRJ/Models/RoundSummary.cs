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

        public RoundSummary()
        {

            NRonda = 1;
            ScoreInicio = 0;
            
            
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




