using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipPRJ.Models
{
    public static class Barco
    {
        public static Jogo Jog { get; set; }
        public static int PortaAvioes { get; set; }
        public static int QuatroCanos { get; set; }

        public static bool AoFundo(int Barco, Jogo j, int opcaoY, int opcaoX)
        {
            Jog = j;

            if (Barco == 1)
            {
                Jog.Submanrinosrest--;
                return true;

            }
            if (Barco == 2)
            {
                if (opcaoY < 9)
                {
                    if (Jog.Grelha[opcaoY + 1, opcaoX] == 2)
                    {

                        Jog.Doiscanosrest--;
                        return true;
                    }
                }
                if (opcaoY > 0)
                {
                    if (Jog.Grelha[opcaoY - 1, opcaoX] == 2)
                    {

                        Jog.Doiscanosrest--;
                        return true;

                    }
                }
                if (opcaoX < 9)
                {
                    if (Jog.Grelha[opcaoY, opcaoX + 1] == 2)
                    {
                        Jog.Doiscanosrest--;
                        return true;
                    }
                }
                if (opcaoX > 0)
                {
                    if (Jog.Grelha[opcaoY, opcaoX - 1] == 2)
                    {
                        Jog.Doiscanosrest--;
                        return true;
                    }
                }
            }//2 canos
            if (Barco == 3)
            {
                if (opcaoY < 8)
                {
                    if (Jog.Grelha[opcaoY + 1, opcaoX] == 3 && Jog.Grelha[opcaoY + 2, opcaoX] == 3)
                    {
                        Jog.Trescanosrest--;
                        return true;
                    }
                }
                if (opcaoY < 9 && opcaoY > 0)
                {
                    if (Jog.Grelha[opcaoY + 1, opcaoX] == 3 && Jog.Grelha[opcaoY - 1, opcaoX] == 3)
                    {
                        Jog.Trescanosrest--;
                        return true;
                    }
                }
                if (opcaoY > 1)
                {
                    if (Jog.Grelha[opcaoY - 2, opcaoX] == 3 && Jog.Grelha[opcaoY - 1, opcaoX] == 3)
                    {
                        Jog.Trescanosrest--;
                        return true;
                    }
                }

                if (opcaoX < 8)
                {
                    if (Jog.Grelha[opcaoY, opcaoX + 1] == 3 && Jog.Grelha[opcaoY, opcaoX + 2] == 3)
                    {
                        Jog.Trescanosrest--;
                        return true;
                    }
                }
                if (opcaoX > 1)
                {
                    if (Jog.Grelha[opcaoY, opcaoX - 2] == 3 && Jog.Grelha[opcaoY, opcaoX - 1] == 3)
                    {
                        Jog.Trescanosrest--;
                        return true;
                    }
                }
                if (opcaoX < 9 && opcaoX > 0)
                {
                    if (Jog.Grelha[opcaoY, opcaoX - 1] == 3 && Jog.Grelha[opcaoY, opcaoX + 1] == 3)
                    {
                        Jog.Trescanosrest--;
                        return true;
                    }
                }
            }//3 canos
            if (Barco == 4)
            {
                QuatroCanos = QuatroCanos + 1;
                if (QuatroCanos == 4)
                {
                    Jog.Quatrocanosrest--;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //quatrocanos
            if (Barco == 5)
            {
                PortaAvioes = PortaAvioes + 1;
                if (PortaAvioes == 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }//portaavioes
            else
                return false;
        }
    }
}
