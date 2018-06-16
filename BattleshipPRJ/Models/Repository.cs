using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipPRJ.Models
{
    public static class Repository
    {
        private static List<Jogo> jogos = new List<Jogo>();

        private static List<TeamMember> teamMembers = new List<TeamMember>();

        private static List<HiScoresModel> Hiscores = new List<HiScoresModel>();

        private static string teamkey;

        public static TeamMember pinho = new TeamMember("Ti Delian", "André Pinho", "160323023");

        public static TeamMember myke = new TeamMember("Ti Delian", "Myke Palma", "160323028");

        public static TeamMember beja = new TeamMember("Ti Delian", "Ricardo Carvalho", "160323001");

        public static List<TeamMember> TeamMembers
        {

            get
            {
                return teamMembers;

            }
        }

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



        public static List<HiScoresModel> HiScores
        {

            get
            {
                BattleshipDbContext context = new BattleshipDbContext();
                List<HiScoresModel> hiscores = context.HiScoresDb.ToList();
                return hiscores;

            }


        }


        public static void AddHighScore(HiScoresModel hs)
        {

            BattleshipDbContext context = new BattleshipDbContext();
            context.HiScoresDb.Add(hs);
            context.SaveChanges();


        }
        


        public static List<TeamMember> ReceberTeamMembers()
        {
            teamMembers.Add(pinho);
            teamMembers.Add(myke);
            teamMembers.Add(beja);

            return teamMembers;
        }

        public static List<HiScoresModel> Listahiscores(ApiHiScores apiHiScores)
        {
            List<HiScoresModel> hiScores = new List<HiScoresModel>();


            //FIX DESTA CENA

            foreach (HiScoresModel hi in HiScores)
            {

                if (apiHiScores.IgnorarNome == true)
                {
                    for (int i = 0; i < apiHiScores.NumMelhoresResultados; i++)
                    {

                        hiScores.Add(hi);


                    }
                }
                else
                {
                    for (int i = 0; i < apiHiScores.NumMelhoresResultados; i++)
                    {

                        if (hi.NomeJogador == apiHiScores.NomeJogador)
                        {
                            hiScores.Add(hi);

                        }

                    }


                }



            }

            return hiScores;

        }



    }

}
