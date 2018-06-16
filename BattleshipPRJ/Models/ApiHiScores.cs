using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipPRJ.Models
{
    public class ApiHiScores
    {
        public int NumMelhoresResultados { get; set; }
        public string NomeJogador { get; set; }
        public bool IgnorarNome { get; set; }
    }
}
