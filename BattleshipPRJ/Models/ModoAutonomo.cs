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
    }

    public class ModoAutonomo1
    {

        public Coordenadas ReceberCoords(int[,] CoordenadasJaSelecionadas)//"simples"
        {
            Coordenadas c = new Models.Coordenadas();
            c.X = 0;
            c.Y = 0;
            int i = 0;

            Random rnr = new Random();

            while (i == 0)
            {
                c.X = rnr.Next(0, 10);
                c.Y = rnr.Next(0, 10);
                if (CoordenadasJaSelecionadas[c.X, c.Y] == -1)
                {

                    i++;
                }
                else
                {
                    i = 0;
                }
            }

            return c;
        }
    }
}
