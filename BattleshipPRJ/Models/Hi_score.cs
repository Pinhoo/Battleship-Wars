using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipPRJ.Models
{
    public static class Hi_score
    {
        //pontuação
        public static double Pontuacao { get; set; }
        public static double Bonus { get; set; }

        public static void AdicionarJogada(bool d_BarcoAtingido, bool d_BarcoAfundado, bool d_Penalizacao, bool d_Ganho, int d_Missseis)
        {

            if (d_BarcoAtingido == true)
            {

                if (Bonus < 1)
                {
                    Bonus = Bonus + 0.25;
                }
            }
            else
            {
                Bonus = -0.25;
            }

            if (d_BarcoAtingido == true)
            {
                Pontuacao = Pontuacao + (100 * (1 + Bonus));
            }
            if (d_BarcoAfundado == true)
            {
                Pontuacao = Pontuacao + 200;
            }
            if (d_Penalizacao == true)
            {
                Pontuacao = Pontuacao - 100;
            }
            if (d_Ganho == true)
            {
                Pontuacao = Pontuacao + 1000 + (d_Missseis * 250);
            }

        }


        public static double Receber()
        {
            return Pontuacao;
        }
        


        
    }
}
