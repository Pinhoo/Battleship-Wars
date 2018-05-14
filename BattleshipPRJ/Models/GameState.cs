using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BattleshipPRJ.Models
{
    public enum Resultado { NoResult, SuccessHit, SuccessMiss, SuccessSink, SuccessRepeat, SuccessVictory, InvalidShot, GameHasEnded }

    public class GameState
    {

        public int GameID { get; set; }

        public int RoundNumber { get; set; }

        public int FiredX { get; set; }

        public int FiredY { get; set; }

        public Resultado Result { get; set; }

        public int DamagedShipSize { get; set; }



    }



}







