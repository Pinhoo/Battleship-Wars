using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BattleshipPRJ.Models
{
    public class GameState
    {

        public int GameID { get; set; }

        public int RoundNumber { get; set; }

        public int FiredX { get; set; }

        public int FiredY { get; set; }

        public enum Result { NoResult, SuccessHit, SuccessMiss, SuccessSink, SuccessRepeat, SuccessVictory, InvalidShot, GameHasEnded }

        public int DamagedShipSize { get; set; }

    }


}

