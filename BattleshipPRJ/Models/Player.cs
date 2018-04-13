using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BattleshipPRJ.Models
{
    public class Player
    {
        [Required( ErrorMessage ="Por favor preencha o campo Nome!")]
        public string Nome { get; set; }

        public string Missao { get; set; }
        public int Misseis { get; set; }
        public bool Ganhou { get; set; }
        public int Score { get; set; }
        public int CoordX { get; set; }
        public int CoordY { get; set; }

        

        public Player()
        { }

        







    }
}
