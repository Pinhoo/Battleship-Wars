using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipPRJ.Models
{
    public class Coordenadas
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void CopiarValores(Coordenadas CoordenadasACopiar)
        {
            Y = CoordenadasACopiar.Y;
            X = CoordenadasACopiar.X;
        }
    }
}
