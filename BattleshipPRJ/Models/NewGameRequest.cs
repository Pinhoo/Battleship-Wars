using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BattleshipPRJ.Models
{
    public class NewGameRequest
    {

        public string PlayerName { get; set; }
        public string GameMode { get; set; }
        public string Teamkey { get; set; }

        public NewGameRequest(string playername, string gamemode)
        {
            PlayerName = playername;
            GameMode = gamemode;
            Teamkey = Repository.TeamKey;
        }

    }


}

