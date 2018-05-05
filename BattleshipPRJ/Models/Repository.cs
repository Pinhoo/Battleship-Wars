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
    public static class Hi_score
    {
        //pontuação
        public static double Pontuacao { get; set; }
        public static double Bonus { get; set; }

        public static void AdicionarJogada(bool d_BarcoAtingido, bool d_BarcoAfundado, bool Acertou, bool d_Penalizacao, bool d_Ganho, int d_Missseis)
        {
            if(Acertou == true)
            {

                if(Bonus <2)
                { 
                Bonus = Bonus + 0.25;
                }
            }
            else
            {
                Bonus = 1;
            }
            
            if(d_BarcoAtingido==true)
            {
                Pontuacao = Pontuacao + (100*Bonus);
            }
            if(d_BarcoAfundado==true)
            {
                Pontuacao = Pontuacao + (200*Bonus);
            }
            if(d_Penalizacao==true)
            {
                Pontuacao = Pontuacao - 100;
            }
            if(d_Ganho==true)
            {
                Pontuacao = Pontuacao + (1000 * Bonus) + (d_Missseis * Bonus);
            }
        }

        public static double Receber()
        {
            return Pontuacao;
        }
    }
}
