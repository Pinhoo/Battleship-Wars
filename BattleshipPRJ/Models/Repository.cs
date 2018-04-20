using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipPRJ.Models
{
    public static class Repository
    {
        private static List<Jogo> jogos = new List<Jogo>();

        //private static int [] = new 

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

        public static Jogo ObterJogo()
        {
            if(jogos.Count==0)
            {

                return null;
            }
            else
            {
                return jogos[0];

            }
            
        }

        
    }
}
