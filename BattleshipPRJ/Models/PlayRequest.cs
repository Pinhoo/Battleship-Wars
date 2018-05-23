using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BattleshipPRJ.Models
{
    public enum PlayerAction { Fire, Quit }

    public class PlayRequest
    {

        public int ID { get; set; }

        public string Key { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public PlayerAction PlayerAction { get; set; }

        public PlayRequest(int id,  int x, int y, PlayerAction action)
        {
            ID = id;
            Key = Repository.TeamKey;
            X = x;
            Y = y;
            PlayerAction = action;
        }




    }


}

