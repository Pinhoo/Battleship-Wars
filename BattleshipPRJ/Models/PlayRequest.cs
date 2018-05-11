using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BattleshipPRJ.Models
{
    public class PlayerRequest
    {

        public int ID { get; set; }

        public string Key { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public enum PlayerAction { Fire, Quit } //0 e 1

        


    }


}

