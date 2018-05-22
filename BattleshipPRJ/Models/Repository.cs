using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipPRJ.Models
{
    public static class Repository
    {
        private static List<Jogo> jogos = new List<Jogo>();

        private static ListasJogos lista;


        public static List<Jogo> Jogos
        {

            get
            {
                return jogos;

            }
        }
        public static ListasJogos Lista
        {

            get
            {
                return lista;

            }
        }
        public static void CriarJogo(Jogo j)
        {
            Jogos.Add(j);
            Hi_score.inicializar();
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
