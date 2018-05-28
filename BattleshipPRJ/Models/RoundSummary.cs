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






    }


}

