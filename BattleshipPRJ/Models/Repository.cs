using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipPRJ.Models
{
    public static class Repository
    {
        private static List<Jogo> jogos = new List<Jogo>();

        private static string teamkey;

        public static string TeamKey
        {
            get { return teamkey; }
        }

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
            j.inicializar();
            teamkey = "90dff7381b604603b5145be5f610da0d";
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



    }

    public class ListasJogos
    {
        private List<Jogo> anti = new List<Jogo>(1);
        private List<Jogo> dt = new List<Jogo>(1);

        public List<Jogo> Anti
        {
            get { return anti; }
            set { anti = value; }
        }
        public List<Jogo> Dt
        {
            get { return dt; }
            set { dt = value; }
        }
    }
    
}
