using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipPRJ.Models
{
    public static class EspacoOcupado
    {
        private static int[,] Barcos;

        public static int[,] BarcosO
        {
            get
            {
                return Barcos;
            }
        }
        //criação dos barcos
        public static void CriarEspacoOcupado()
        {
            Barcos = new int[10, 10];//tabela 10 por 10 para gravar os barcos

            //meter todos os valores a zero

            int a = 0;
            int i = 0;
            while (i <= 9)
            {
                Barcos[i, a] = 0;
                i++;
                if (i == 8)
                {
                    Barcos[i + 1, a] = 0;
                    a++;
                    i = 0;
                    if (a == 10)
                    {
                        i = 10;
                        a = 0;
                    }

                }

            }

            //meter todos os valores a zero


            Random rnr = new Random();//para usar valores aleatórios usar rnr

            //1 porta avioes
            {
                int PortaAvioesX = rnr.Next(1, 9);//x e Y aleatórios
                int PortaAvioesY = rnr.Next(1, 9);//entre 2 e 9 porque vai ter bordas e se n fosse assim ficava de fora

                Barcos[PortaAvioesX, PortaAvioesY] = 5;//ponto inicial

                int PosicaoPA = rnr.Next(3);//para ter direção aleatoria
                {
                    if (PosicaoPA == 0)
                    {
                        Barcos[PortaAvioesX + 1, PortaAvioesY + 1] = 5;
                        Barcos[PortaAvioesX, PortaAvioesY + 1] = 5;
                        Barcos[PortaAvioesX - 1, PortaAvioesY + 1] = 5;
                        Barcos[PortaAvioesX, PortaAvioesY - 1] = 5;//isto é PA
                    }
                    else if (PosicaoPA == 1)
                    {
                        Barcos[PortaAvioesX - 1, PortaAvioesY + 1] = 5;
                        Barcos[PortaAvioesX - 1, PortaAvioesY] = 5;
                        Barcos[PortaAvioesX - 1, PortaAvioesY - 1] = 5;
                        Barcos[PortaAvioesX + 1, PortaAvioesY] = 5;


                    }
                    else if (PosicaoPA == 2)
                    {
                        Barcos[PortaAvioesX, PortaAvioesY + 1] = 5;
                        Barcos[PortaAvioesX + 1, PortaAvioesY - 1] = 5;
                        Barcos[PortaAvioesX, PortaAvioesY - 1] = 5;
                        Barcos[PortaAvioesX - 1, PortaAvioesY - 1] = 5;
                    }
                    else
                    {
                        Barcos[PortaAvioesX - 1, PortaAvioesY] = 5;
                        Barcos[PortaAvioesX + 1, PortaAvioesY - 1] = 5;
                        Barcos[PortaAvioesX + 1, PortaAvioesY] = 5;
                        Barcos[PortaAvioesX + 1, PortaAvioesY + 1] = 5;
                    }
                }
            }
            //1 Barco de 4 canos
            {
                bool iiiiC = false;
                int QuatroCanosX;
                int QuatroCanosY;
                while (iiiiC == false)
                {

                    int PosicaoIIIIC = rnr.Next(1);//IIIIC (barco 4 canos) vertical ou horizontal

                    if (PosicaoIIIIC == 0)//vertical
                    {
                        QuatroCanosX = rnr.Next(0, 10);// coord X
                        QuatroCanosY = rnr.Next(3, 10);// coord y

                        if (QuatroCanosX == 9 && QuatroCanosY == 9)
                        {
                            if (Barcos[QuatroCanosX, QuatroCanosY] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 2] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 3] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 2] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 3] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 4] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 4] == 0)
                            {
                                Barcos[QuatroCanosX, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX, QuatroCanosY - 1] = 4;
                                Barcos[QuatroCanosX, QuatroCanosY - 2] = 4;
                                Barcos[QuatroCanosX, QuatroCanosY - 3] = 4;
                                iiiiC = true;
                            }
                        }
                        else if (QuatroCanosX == 0 && QuatroCanosY == 9)
                        {
                            if (Barcos[QuatroCanosX, QuatroCanosY] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 2] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 3] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 2] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 3] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 4] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 4] == 0)
                            {
                                Barcos[QuatroCanosX, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX, QuatroCanosY - 1] = 4;
                                Barcos[QuatroCanosX, QuatroCanosY - 2] = 4;
                                Barcos[QuatroCanosX, QuatroCanosY - 3] = 4;
                                iiiiC = true;
                            }
                        }
                        else if (QuatroCanosX == 9 && QuatroCanosY == 3)
                        {
                            if (Barcos[QuatroCanosX, QuatroCanosY] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 2] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 3] == 0 && Barcos[QuatroCanosX, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 2] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 3] == 0)
                            {
                                Barcos[QuatroCanosX, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX, QuatroCanosY - 1] = 4;
                                Barcos[QuatroCanosX, QuatroCanosY - 2] = 4;
                                Barcos[QuatroCanosX, QuatroCanosY - 3] = 4;
                                iiiiC = true;
                            }
                        }
                        else if (QuatroCanosX == 0 && QuatroCanosY == 3)
                        {
                            if (Barcos[QuatroCanosX, QuatroCanosY] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 2] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 3] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 2] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 3] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY + 1] == 0)
                            {
                                Barcos[QuatroCanosX, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX, QuatroCanosY - 1] = 4;
                                Barcos[QuatroCanosX, QuatroCanosY - 2] = 4;
                                Barcos[QuatroCanosX, QuatroCanosY - 3] = 4;
                                iiiiC = true;
                            }
                        }
                        else if (QuatroCanosY == 9)
                        {
                            if (Barcos[QuatroCanosX, QuatroCanosY] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 2] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 3] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 2] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 3] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 4] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 4] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 4] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 3] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 2] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY] == 0)
                            {
                                Barcos[QuatroCanosX, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX, QuatroCanosY - 1] = 4;
                                Barcos[QuatroCanosX, QuatroCanosY - 2] = 4;
                                Barcos[QuatroCanosX, QuatroCanosY - 3] = 4;
                                iiiiC = true;
                            }
                        }
                        else if (QuatroCanosY == 3)
                        {
                            if (Barcos[QuatroCanosX, QuatroCanosY] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 2] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 3] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 2] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 3] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 3] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 2] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY] == 0)
                            {
                                Barcos[QuatroCanosX, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX, QuatroCanosY - 1] = 4;
                                Barcos[QuatroCanosX, QuatroCanosY - 2] = 4;
                                Barcos[QuatroCanosX, QuatroCanosY - 3] = 4;
                                iiiiC = true;
                            }
                        }
                        else if (QuatroCanosX == 9)
                        {
                            if (Barcos[QuatroCanosX, QuatroCanosY] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 2] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 3] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 2] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 3] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 4] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 4] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY + 1] == 0)
                            {
                                Barcos[QuatroCanosX, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX, QuatroCanosY - 1] = 4;
                                Barcos[QuatroCanosX, QuatroCanosY - 2] = 4;
                                Barcos[QuatroCanosX, QuatroCanosY - 3] = 4;
                                iiiiC = true;
                            }
                        }
                        else if (QuatroCanosX == 0)
                        {
                            if (Barcos[QuatroCanosX, QuatroCanosY] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 2] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 3] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 2] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 3] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 4] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 4] == 0 && Barcos[QuatroCanosX, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY + 1] == 0)
                            {
                                Barcos[QuatroCanosX, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX, QuatroCanosY - 1] = 4;
                                Barcos[QuatroCanosX, QuatroCanosY - 2] = 4;
                                Barcos[QuatroCanosX, QuatroCanosY - 3] = 4;
                                iiiiC = true;
                            }
                        }
                        else
                        {
                            if (Barcos[QuatroCanosX, QuatroCanosY] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 2] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 3] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 2] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 3] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 3] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 2] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 4] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 4] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 4] == 0)
                            {
                                Barcos[QuatroCanosX, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX, QuatroCanosY - 1] = 4;
                                Barcos[QuatroCanosX, QuatroCanosY - 2] = 4;
                                Barcos[QuatroCanosX, QuatroCanosY - 3] = 4;
                                iiiiC = true;
                            }
                        }

                    }
                    if (PosicaoIIIIC == 1)//horizontal
                    {
                        QuatroCanosX = rnr.Next(3, 10);
                        QuatroCanosY = rnr.Next(0, 10);
                        if (QuatroCanosX == 9 && QuatroCanosY == 9)
                        {
                            if (Barcos[QuatroCanosX, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 1, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 2, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 3, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 4, QuatroCanosY] == 0 && Barcos[QuatroCanosX - 4, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 3, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 2, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 1] == 0)
                            {
                                Barcos[QuatroCanosX, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX - 1, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX - 2, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX - 3, QuatroCanosY] = 4;
                                iiiiC = true;
                            }
                        }
                        else if (QuatroCanosX == 9 && QuatroCanosY == 0)
                        {
                            if (Barcos[QuatroCanosX, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 1, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 2, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 3, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 4, QuatroCanosY] == 0 && Barcos[QuatroCanosX - 4, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 3, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 2, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY + 1] == 0)
                            {
                                Barcos[QuatroCanosX, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX - 1, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX - 2, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX - 3, QuatroCanosY] = 4;
                                iiiiC = true;
                            }
                        }
                        else if (QuatroCanosX == 3 && QuatroCanosY == 9)
                        {
                            if (Barcos[QuatroCanosX, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 1, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 2, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 3, QuatroCanosY] == 4 && Barcos[QuatroCanosX + 1, QuatroCanosY] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 3, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 2, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 1] == 0)
                            {
                                Barcos[QuatroCanosX, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX - 1, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX - 2, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX - 3, QuatroCanosY] = 4;
                                iiiiC = true;
                            }
                        }
                        else if (QuatroCanosX == 3 && QuatroCanosY == 0)
                        {
                            if (Barcos[QuatroCanosX, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 1, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 2, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 3, QuatroCanosY] == 4 && Barcos[QuatroCanosX + 1, QuatroCanosY] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 3, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 2, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY + 1] == 0)
                            {
                                Barcos[QuatroCanosX, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX - 1, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX - 2, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX - 3, QuatroCanosY] = 4;
                                iiiiC = true;
                            }
                        }
                        else if (QuatroCanosX == 9)
                        {
                            if (Barcos[QuatroCanosX, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 1, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 2, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 3, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 4, QuatroCanosY] == 0 && Barcos[QuatroCanosX - 4, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 3, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 2, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 4, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 3, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 2, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY + 1] == 0)
                            {
                                Barcos[QuatroCanosX, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX - 1, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX - 2, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX - 3, QuatroCanosY] = 4;
                                iiiiC = true;
                            }
                        }
                        else if (QuatroCanosX == 3)
                        {
                            if (Barcos[QuatroCanosX, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 1, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 2, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 3, QuatroCanosY] == 4 && Barcos[QuatroCanosX + 1, QuatroCanosY] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 3, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 2, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 3, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 2, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY + 1] == 0)
                            {
                                Barcos[QuatroCanosX, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX - 1, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX - 2, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX - 3, QuatroCanosY] = 4;
                                iiiiC = true;
                            }
                        }
                        else if (QuatroCanosY == 0)
                        {
                            if (Barcos[QuatroCanosX, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 1, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 2, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 3, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 4, QuatroCanosY] == 0 && Barcos[QuatroCanosX - 4, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 3, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 2, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY] == 0)
                            {
                                Barcos[QuatroCanosX, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX - 1, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX - 2, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX - 3, QuatroCanosY] = 4;
                                iiiiC = true;
                            }
                        }
                        else if (QuatroCanosY == 9)
                        {
                            if (Barcos[QuatroCanosX, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 1, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 2, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 3, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 4, QuatroCanosY] == 0 && Barcos[QuatroCanosX - 4, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 3, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 2, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 4, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 4, QuatroCanosY] == 0)
                            {
                                Barcos[QuatroCanosX, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX - 1, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX - 2, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX - 3, QuatroCanosY] = 4;
                                iiiiC = true;
                            }
                        }
                        else
                        {
                            if (Barcos[QuatroCanosX, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 1, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 2, QuatroCanosY] == 4 && Barcos[QuatroCanosX - 3, QuatroCanosY] == 4 && Barcos[QuatroCanosX + 1, QuatroCanosY] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 3, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 2, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 3, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 2, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 4, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 4, QuatroCanosY] == 0 && Barcos[QuatroCanosX - 4, QuatroCanosY - 1] == 0)
                            {
                                Barcos[QuatroCanosX, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX - 1, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX - 2, QuatroCanosY] = 4;
                                Barcos[QuatroCanosX - 3, QuatroCanosY] = 4;
                                iiiiC = true;
                            }
                        }
                    }
                }
            }
            //2 barcos de 3 canos
            {
                bool iiiC = false;
                bool iiiC2 = false;
                int TresCanosX;
                int TresCanosY;
                //1º barco
                while (iiiC == false)
                {
                    int PosicaoTresCanos = rnr.Next(1);
                    if (PosicaoTresCanos == 0)//horizontal
                    {
                        TresCanosX = rnr.Next(2, 10);// coord X
                        TresCanosY = rnr.Next(0, 10);// coord y

                        if (TresCanosX == 9 && TresCanosY == 9)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX - 3, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX - 2, TresCanosY - 1] == 0 && Barcos[TresCanosX - 3, TresCanosY - 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC = true;
                            }
                        }
                        else if (TresCanosX == 2 && TresCanosY == 9)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX - 2, TresCanosY - 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC = true;
                            }
                        }
                        else if (TresCanosX == 2 && TresCanosY == 0)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX - 2, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY + 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC = true;
                            }
                        }
                        else if (TresCanosX == 9 && TresCanosY == 0)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX - 3, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX - 2, TresCanosY + 1] == 0 && Barcos[TresCanosX - 3, TresCanosY + 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC = true;
                            }
                        }
                        else if (TresCanosX == 9)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX - 3, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX - 2, TresCanosY + 1] == 0 && Barcos[TresCanosX - 3, TresCanosY + 1] == 0 && Barcos[TresCanosX - 3, TresCanosY - 1] == 0 && Barcos[TresCanosX - 2, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC = true;
                            }
                        }
                        else if (TresCanosX == 2)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX - 2, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX - 2, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC = true;
                            }
                        }
                        else if (TresCanosY == 9)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX - 2, TresCanosY - 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX - 3, TresCanosY - 1] == 0 && Barcos[TresCanosX - 3, TresCanosY] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC = true;
                            }
                        }
                        else if (TresCanosY == 0)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX - 2, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY + 1] == 0 && Barcos[TresCanosX - 3, TresCanosY + 1] == 0 && Barcos[TresCanosX - 3, TresCanosY] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC = true;
                            }
                        }
                        else
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX - 2, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX - 2, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 3, TresCanosY - 1] == 0 && Barcos[TresCanosX - 3, TresCanosY] == 0 && Barcos[TresCanosX - 3, TresCanosY + 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC = true;
                            }
                        }

                    }
                    if (PosicaoTresCanos == 1)//vertical
                    {
                        TresCanosX = rnr.Next(0, 10);// coord X
                        TresCanosY = rnr.Next(2, 10);// coord y

                        if (TresCanosX == 9 && TresCanosY == 9)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX - 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY - 3] == 0 && Barcos[TresCanosX - 1, TresCanosY - 3] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC = true;
                            }
                        }
                        else if (TresCanosX == 0 && TresCanosY == 9)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX + 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY - 3] == 0 && Barcos[TresCanosX + 1, TresCanosY - 3] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC = true;
                            }
                        }
                        else if (TresCanosX == 9 && TresCanosY == 2)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX - 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC = true;
                            }
                        }
                        else if (TresCanosX == 0 && TresCanosY == 2)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX + 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY + 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC = true;
                            }
                        }
                        else if (TresCanosY == 9)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX - 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY - 3] == 0 && Barcos[TresCanosX - 1, TresCanosY - 3] == 0 && Barcos[TresCanosX + 1, TresCanosY - 3] == 0 && Barcos[TresCanosX + 1, TresCanosY - 2] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC = true;
                            }
                        }
                        else if (TresCanosY == 2)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX - 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 2] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC = true;
                            }
                        }
                        else if (TresCanosX == 9)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX - 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY - 3] == 0 && Barcos[TresCanosX - 1, TresCanosY - 3] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC = true;
                            }
                        }
                        else if (TresCanosX == 0)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX + 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY - 3] == 0 && Barcos[TresCanosX + 1, TresCanosY - 3] == 0 && Barcos[TresCanosX + 1, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC = true;
                            }
                        }
                        else
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX - 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 2] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY - 3] == 0 && Barcos[TresCanosX, TresCanosY - 3] == 0 && Barcos[TresCanosX - 1, TresCanosY - 3] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC = true;
                            }
                        }

                    }

                }
                //2º barco
                while (iiiC2 == false)
                {
                    int PosicaoTresCanos = rnr.Next(1);
                    if (PosicaoTresCanos == 0)//horizontal
                    {
                        TresCanosX = rnr.Next(2, 10);// coord X
                        TresCanosY = rnr.Next(0, 10);// coord y

                        if (TresCanosX == 9 && TresCanosY == 9)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX - 3, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX - 2, TresCanosY - 1] == 0 && Barcos[TresCanosX - 3, TresCanosY - 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC2 = true;
                            }
                        }
                        else if (TresCanosX == 2 && TresCanosY == 9)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX - 2, TresCanosY - 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC2 = true;
                            }
                        }
                        else if (TresCanosX == 2 && TresCanosY == 0)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX - 2, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY + 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC2 = true;
                            }
                        }
                        else if (TresCanosX == 9 && TresCanosY == 0)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX - 3, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX - 2, TresCanosY + 1] == 0 && Barcos[TresCanosX - 3, TresCanosY + 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC2 = true;
                            }
                        }
                        else if (TresCanosX == 9)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX - 3, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX - 2, TresCanosY + 1] == 0 && Barcos[TresCanosX - 3, TresCanosY + 1] == 0 && Barcos[TresCanosX - 3, TresCanosY - 1] == 0 && Barcos[TresCanosX - 2, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC2 = true;
                            }
                        }
                        else if (TresCanosX == 2)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX - 2, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX - 2, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC2 = true;
                            }
                        }
                        else if (TresCanosY == 9)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX - 2, TresCanosY - 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX - 3, TresCanosY - 1] == 0 && Barcos[TresCanosX - 3, TresCanosY] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC2 = true;
                            }
                        }
                        else if (TresCanosY == 0)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX - 2, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY + 1] == 0 && Barcos[TresCanosX - 3, TresCanosY + 1] == 0 && Barcos[TresCanosX - 3, TresCanosY] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC2 = true;
                            }
                        }
                        else
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX - 2, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX - 2, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 3, TresCanosY - 1] == 0 && Barcos[TresCanosX - 3, TresCanosY] == 0 && Barcos[TresCanosX - 3, TresCanosY + 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC2 = true;
                            }
                        }

                    }
                    if (PosicaoTresCanos == 1)//vertical
                    {
                        TresCanosX = rnr.Next(0, 10);// coord X
                        TresCanosY = rnr.Next(2, 10);// coord y

                        if (TresCanosX == 9 && TresCanosY == 9)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX - 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY - 3] == 0 && Barcos[TresCanosX - 1, TresCanosY - 3] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC2 = true;
                            }
                        }
                        else if (TresCanosX == 0 && TresCanosY == 9)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX + 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY - 3] == 0 && Barcos[TresCanosX + 1, TresCanosY - 3] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC2 = true;
                            }
                        }
                        else if (TresCanosX == 9 && TresCanosY == 2)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX - 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC2 = true;
                            }
                        }
                        else if (TresCanosX == 0 && TresCanosY == 2)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX + 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY + 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC2 = true;
                            }
                        }
                        else if (TresCanosY == 9)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX - 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY - 3] == 0 && Barcos[TresCanosX - 1, TresCanosY - 3] == 0 && Barcos[TresCanosX + 1, TresCanosY - 3] == 0 && Barcos[TresCanosX + 1, TresCanosY - 2] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC2 = true;
                            }
                        }
                        else if (TresCanosY == 2)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX - 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 2] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC2 = true;
                            }
                        }
                        else if (TresCanosX == 9)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX - 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY - 3] == 0 && Barcos[TresCanosX - 1, TresCanosY - 3] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC2 = true;
                            }
                        }
                        else if (TresCanosX == 0)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX + 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY - 3] == 0 && Barcos[TresCanosX + 1, TresCanosY - 3] == 0 && Barcos[TresCanosX + 1, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC2 = true;
                            }
                        }
                        else
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX - 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 2] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY - 3] == 0 && Barcos[TresCanosX, TresCanosY - 3] == 0 && Barcos[TresCanosX - 1, TresCanosY - 3] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC2 = true;
                            }
                        }

                    }
                }
            }
            //3 barcos de 2 canos
            {
                bool iiC = false;
                bool iiC2 = false;
                bool iiC3 = false;
                int DoisCanosX;
                int DoisCanosY;
                while (iiC == false)
                {
                    int PosicaoDoisCanos = rnr.Next(1);
                    if (PosicaoDoisCanos == 0)//horizontal
                    {
                        DoisCanosX = rnr.Next(1, 10);
                        DoisCanosY = rnr.Next(0, 10);

                        if (DoisCanosX == 9 && DoisCanosY == 9)
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY - 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                                iiC = true;
                            }
                        }
                        else if (DoisCanosX == 1 && DoisCanosY == 9)
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                                iiC = true;
                            }
                        }
                        else if (DoisCanosX == 9 && DoisCanosY == 0)
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY + 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                                iiC = true;
                            }
                        }
                        else if (DoisCanosX == 1 && DoisCanosY == 0)
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                                iiC = true;
                            }
                        }
                        else if (DoisCanosX == 9)
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                                iiC = true;
                            }
                        }
                        else if (DoisCanosX == 1)
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                                iiC = true;
                            }
                        }
                        else if (DoisCanosY == 0)
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                                iiC = true;
                            }
                        }
                        else if (DoisCanosY == 9)
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                                iiC = true;
                            }
                        }
                        else
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY - 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                                iiC = true;
                            }
                        }
                    }
                    if (PosicaoDoisCanos == 1)//vertical
                    {
                        DoisCanosX = rnr.Next(0, 10);
                        DoisCanosY = rnr.Next(1, 10);

                        if (DoisCanosX == 9 && DoisCanosY == 9) //1
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 2] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                                iiC = true;
                            }
                        }
                        else if (DoisCanosX == 0 && DoisCanosY == 9) //2
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 2] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                                iiC = true;
                            }
                        }
                        else if (DoisCanosX == 0 && DoisCanosY == 1) //3
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                                iiC = true;
                            }
                        }
                        else if (DoisCanosX == 9 && DoisCanosY == 1) //4
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                                iiC = true;
                            }
                        }
                        else if (DoisCanosX == 9) //5
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 2] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                                iiC = true;
                            }
                        }
                        else if (DoisCanosX == 0) //6
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                                iiC = true;
                            }
                        }
                        else if (DoisCanosY == 1) //7
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                                iiC = true;
                            }
                        }
                        else if (DoisCanosY == 9) //8
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                                iiC = true;
                            }
                        }
                        else//9
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                                iiC = true;
                            }
                        }

                    }
                }
                while (iiC2 == false)
                {
                    int PosicaoDoisCanos = rnr.Next(1);
                    if (PosicaoDoisCanos == 0)//horizontal
                    {
                        DoisCanosX = rnr.Next(1, 10);
                        DoisCanosY = rnr.Next(0, 10);

                        if (DoisCanosX == 9 && DoisCanosY == 9)
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY - 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                                iiC2 = true;
                            }
                        }
                        else if (DoisCanosX == 1 && DoisCanosY == 9)
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                                iiC2 = true;
                            }
                        }
                        else if (DoisCanosX == 9 && DoisCanosY == 0)
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY + 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                                iiC2 = true;
                            }
                        }
                        else if (DoisCanosX == 1 && DoisCanosY == 0)
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                                iiC2 = true;
                            }
                        }
                        else if (DoisCanosX == 9)
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                                iiC2 = true;
                            }
                        }
                        else if (DoisCanosX == 1)
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                                iiC2 = true;
                            }
                        }
                        else if (DoisCanosY == 0)
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                                iiC2 = true;
                            }
                        }
                        else if (DoisCanosY == 9)
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                                iiC2 = true;
                            }
                        }
                        else
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY - 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                                iiC2 = true;
                            }
                        }
                    }
                    if (PosicaoDoisCanos == 1)//vertical
                    {
                        DoisCanosX = rnr.Next(0, 10);
                        DoisCanosY = rnr.Next(1, 10);

                        if (DoisCanosX == 9 && DoisCanosY == 9) //1
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 2] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                                iiC2 = true;
                            }
                        }
                        else if (DoisCanosX == 0 && DoisCanosY == 9) //2
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 2] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                                iiC2 = true;
                            }
                        }
                        else if (DoisCanosX == 0 && DoisCanosY == 1) //3
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                                iiC2 = true;
                            }
                        }
                        else if (DoisCanosX == 9 && DoisCanosY == 1) //4
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                                iiC2 = true;
                            }
                        }
                        else if (DoisCanosX == 9) //5
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 2] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                                iiC2 = true;
                            }
                        }
                        else if (DoisCanosX == 0) //6
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                                iiC2 = true;
                            }
                        }
                        else if (DoisCanosY == 1) //7
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                                iiC2 = true;
                            }
                        }
                        else if (DoisCanosY == 9) //8
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                                iiC2 = true;
                            }
                        }
                        else//9
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                                iiC2 = true;
                            }
                        }

                    }
                }
                while (iiC3 == false)
                {
                    int PosicaoDoisCanos = rnr.Next(1);
                    if (PosicaoDoisCanos == 0)//horizontal
                    {
                        DoisCanosX = rnr.Next(1, 10);
                        DoisCanosY = rnr.Next(0, 10);

                        if (DoisCanosX == 9 && DoisCanosY == 9)
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY - 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                                iiC3 = true;
                            }
                        }
                        else if (DoisCanosX == 1 && DoisCanosY == 9)
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                                iiC3 = true;
                            }
                        }
                        else if (DoisCanosX == 9 && DoisCanosY == 0)
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY + 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                                iiC3 = true;
                            }
                        }
                        else if (DoisCanosX == 1 && DoisCanosY == 0)
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                                iiC3 = true;
                            }
                        }
                        else if (DoisCanosX == 9)
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                                iiC3 = true;
                            }
                        }
                        else if (DoisCanosX == 1)
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                                iiC3 = true;
                            }
                        }
                        else if (DoisCanosY == 0)
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                                iiC3 = true;
                            }
                        }
                        else if (DoisCanosY == 9)
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                                iiC3 = true;
                            }
                        }
                        else
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY - 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                                iiC3 = true;
                            }
                        }
                    }
                    if (PosicaoDoisCanos == 1)//vertical
                    {
                        DoisCanosX = rnr.Next(0, 10);
                        DoisCanosY = rnr.Next(1, 10);

                        if (DoisCanosX == 9 && DoisCanosY == 9) //1
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 2] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                                iiC3 = true;
                            }
                        }
                        else if (DoisCanosX == 0 && DoisCanosY == 9) //2
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 2] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                                iiC3 = true;
                            }
                        }
                        else if (DoisCanosX == 0 && DoisCanosY == 1) //3
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                                iiC3 = true;
                            }
                        }
                        else if (DoisCanosX == 9 && DoisCanosY == 1) //4
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                                iiC3 = true;
                            }
                        }
                        else if (DoisCanosX == 9) //5
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 2] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                                iiC3 = true;
                            }
                        }
                        else if (DoisCanosX == 0) //6
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                                iiC3 = true;
                            }
                        }
                        else if (DoisCanosY == 1) //7
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                                iiC3 = true;
                            }
                        }
                        else if (DoisCanosY == 9) //8
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                                iiC3 = true;
                            }
                        }
                        else//9
                        {
                            if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0)
                            {
                                Barcos[DoisCanosX, DoisCanosY] = 2;
                                Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                                iiC = true;
                            }
                        }

                    }
                }
            }
            //4 submarinos
            {
                int Submarinos = 0;
                int SubX;
                int SubY;
                while (Submarinos < 4)
                {
                    SubX = rnr.Next(0, 10);
                    SubY = rnr.Next(0, 10);

                    if (SubX == 9 && SubY == 9)
                    {
                        if (Barcos[SubX, SubY] == 0 && Barcos[SubX - 1, SubY] == 0 && Barcos[SubX, SubY - 1] == 0 && Barcos[SubX - 1, SubY - 1] == 0)
                        {
                            Barcos[SubX, SubY] = 1;
                            Submarinos++;
                        }
                    }
                    else if (SubX == 0 && SubY == 9)
                    {
                        if (Barcos[SubX, SubY] == 0 && Barcos[SubX + 1, SubY] == 0 && Barcos[SubX, SubY - 1] == 0 && Barcos[SubX + 1, SubY - 1] == 0)
                        {
                            Barcos[SubX, SubY] = 1;
                            Submarinos++;
                        }

                    }
                    else if (SubX == 9 && SubY == 0)
                    {
                        if (Barcos[SubX, SubY] == 0 && Barcos[SubX - 1, SubY] == 0 && Barcos[SubX, SubY + 1] == 0 && Barcos[SubX - 1, SubY + 1] == 0)
                        {
                            Barcos[SubX, SubY] = 1;
                            Submarinos++;
                        }
                    }
                    else if (SubX == 0 && SubY == 0) //4
                    {
                        if (Barcos[SubX, SubY] == 0 && Barcos[SubX + 1, SubY] == 0 && Barcos[SubX, SubY + 1] == 0 && Barcos[SubX + 1, SubY + 1] == 0)
                        {
                            Barcos[SubX, SubY] = 1;
                            Submarinos++;
                        }
                    }
                    else if (SubX == 9) //5
                    {
                        if (Barcos[SubX, SubY] == 0 && Barcos[SubX - 1, SubY] == 0 && Barcos[SubX, SubY - 1] == 0 && Barcos[SubX - 1, SubY - 1] == 0 && Barcos[SubX - 1, SubY + 1] == 0 && Barcos[SubX, SubY + 1] == 0)
                        {
                            Barcos[SubX, SubY] = 1;
                            Submarinos++;
                        }
                    }
                    else if (SubX == 0) //6
                    {
                        if (Barcos[SubX, SubY] == 0 && Barcos[SubX + 1, SubY] == 0 && Barcos[SubX, SubY - 1] == 0 && Barcos[SubX + 1, SubY - 1] == 0 && Barcos[SubX + 1, SubY + 1] == 0 && Barcos[SubX, SubY + 1] == 0)
                        {
                            Barcos[SubX, SubY] = 1;
                            Submarinos++;
                        }
                    }
                    else if (SubY == 9) //7
                    {
                        if (Barcos[SubX, SubY] == 0 && Barcos[SubX - 1, SubY] == 0 && Barcos[SubX, SubY - 1] == 0 && Barcos[SubX - 1, SubY - 1] == 0 && Barcos[SubX + 1, SubY - 1] == 0 && Barcos[SubX + 1, SubY] == 0)
                        {
                            Barcos[SubX, SubY] = 1;
                            Submarinos++;
                        }
                    }
                    else if (SubY == 0)
                    {
                        if (Barcos[SubX, SubY] == 0 && Barcos[SubX - 1, SubY] == 0 && Barcos[SubX, SubY + 1] == 0 && Barcos[SubX - 1, SubY + 1] == 0 && Barcos[SubX + 1, SubY + 1] == 0 && Barcos[SubX + 1, SubY] == 0)
                        {
                            Barcos[SubX, SubY] = 1;
                            Submarinos++;
                        }
                    }
                    else
                    {
                        if (Barcos[SubX, SubY] == 0 && Barcos[SubX - 1, SubY] == 0 && Barcos[SubX, SubY - 1] == 0 && Barcos[SubX - 1, SubY - 1] == 0 && Barcos[SubX + 1, SubY - 1] == 0 && Barcos[SubX + 1, SubY] == 0 && Barcos[SubX + 1, SubY + 1] == 0 && Barcos[SubX, SubY + 1] == 0 && Barcos[SubX - 1, SubY + 1] == 0)
                        {
                            Barcos[SubX, SubY] = 1;
                            Submarinos++;
                        }
                    }
                }
            }
        }
    }
}
