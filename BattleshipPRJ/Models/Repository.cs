using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipPRJ.Models
{
    public static class Repository
    {
        private static List<Jogo> jogos = new List<Jogo>();

        public static List<Jogo> Jogos
        {

            get
            {
                return jogos;

            }
        }

        public static void CriarJogo(Jogo j)
        {

            Jogos.Add(j);

        }

        public static Jogo ObterJogo(int id)
        {

            foreach (Jogo j in jogos)
            {

                if (j.ID == id)
                {

                    return j;

                }


            }

            return null;

        }

        public static void ApagarJogos()
        {

            jogos.Clear();

        }

    }
}
