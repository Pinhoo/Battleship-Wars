using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipPRJ.Models
{
    public class EspacoOcupado
    {
        private int[,] Barcos;

        public int[,] BarcosO
        {
            get
            {
                return Barcos;
            }
        }
        //criação dos barcos
        public EspacoOcupado()
        {
            Barcos = new int[10, 10];//tabela 10 por 10 para gravar os barcos

            //meter todos os valores a zero

            int a = 0;
            int i = 0;
            while (i <= 10)
            {
                Barcos[i, a] = 0;
                i++;
                a++;
                if (i == 9)
                {
                    Barcos[i + 1, a] = 0;
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
                int PortaAvioesX = rnr.Next(2, 10);//x e Y aleatórios
                int PortaAvioesY = rnr.Next(2, 10);//entre 2 e 9 porque vai ter bordas e se n fosse assim ficava de fora

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
                        Barcos[PortaAvioesX + 1, PortaAvioesY] = 5;
                        Barcos[PortaAvioesX - 1, PortaAvioesY] = 5;
                        Barcos[PortaAvioesX - 1, PortaAvioesY - 1] = 5;
                        Barcos[PortaAvioesX + 1, PortaAvioesY - 1] = 5;


                    }
                    else if (PosicaoPA == 2)
                    {
                        Barcos[PortaAvioesX, PortaAvioesY + 1] = 5;
                        Barcos[PortaAvioesX + 1, PortaAvioesY - 1] = 5;
                        Barcos[PortaAvioesX, PortaAvioesY + 1] = 5;
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
                        QuatroCanosX = rnr.Next(1, 11);// coord X
                        QuatroCanosY = rnr.Next(4, 11);// coord y

                        if (QuatroCanosX == 10 && QuatroCanosY == 10)
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
                        else if (QuatroCanosX == 1 && QuatroCanosY == 10)
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
                        else if (QuatroCanosX == 10 && QuatroCanosY == 4)
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
                        else if (QuatroCanosX == 1 && QuatroCanosY == 4)
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
                        else if (QuatroCanosY == 10)
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
                        else if (QuatroCanosY == 4)
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
                        else if (QuatroCanosX == 10)
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
                        else if (QuatroCanosX == 1)
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
                        QuatroCanosX = rnr.Next(4, 11);
                        QuatroCanosY = rnr.Next(1, 11);
                        if (QuatroCanosX == 10 && QuatroCanosY == 10)
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
                        else if (QuatroCanosX == 10 && QuatroCanosY == 1)
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
                        else if (QuatroCanosX == 4 && QuatroCanosY == 10)
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
                        else if (QuatroCanosX == 4 && QuatroCanosY == 1)
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
                        else if (QuatroCanosX == 10)
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
                        else if (QuatroCanosX == 4)
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
                        else if (QuatroCanosY == 1)
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
                        else if (QuatroCanosY == 10)
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
                        TresCanosX = rnr.Next(3, 11);// coord X
                        TresCanosY = rnr.Next(1, 11);// coord y

                        if (TresCanosX == 10 && TresCanosY == 10)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX - 3, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX - 2, TresCanosY - 1] == 0 && Barcos[TresCanosX - 3, TresCanosY - 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC = true;
                            }
                        }
                        else if (TresCanosX == 3 && TresCanosY == 10)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX - 2, TresCanosY - 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC = true;
                            }
                        }
                        else if (TresCanosX == 3 && TresCanosY == 1)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX - 2, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY + 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC = true;
                            }
                        }
                        else if (TresCanosX == 10 && TresCanosY == 1)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX - 3, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX - 2, TresCanosY + 1] == 0 && Barcos[TresCanosX - 3, TresCanosY + 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC = true;
                            }
                        }
                        else if (TresCanosX == 10)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX - 3, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX - 2, TresCanosY + 1] == 0 && Barcos[TresCanosX - 3, TresCanosY + 1] == 0 && Barcos[TresCanosX - 3, TresCanosY - 1] == 0 && Barcos[TresCanosX - 2, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC = true;
                            }
                        }
                        else if (TresCanosX == 3)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX - 2, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX - 2, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC = true;
                            }
                        }
                        else if (TresCanosY == 10)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX - 2, TresCanosY - 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX - 3, TresCanosY - 1] == 0 && Barcos[TresCanosX - 3, TresCanosY] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC = true;
                            }
                        }
                        else if (TresCanosY == 1)
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
                        TresCanosX = rnr.Next(1, 11);// coord X
                        TresCanosY = rnr.Next(3, 11);// coord y

                        if (TresCanosX == 10 && TresCanosY == 10)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX - 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY - 3] == 0 && Barcos[TresCanosX - 1, TresCanosY - 3] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC = true;
                            }
                        }
                        else if (TresCanosX == 1 && TresCanosY == 10)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX + 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY - 3] == 0 && Barcos[TresCanosX + 1, TresCanosY - 3] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC = true;
                            }
                        }
                        else if (TresCanosX == 10 && TresCanosY == 3)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX - 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC = true;
                            }
                        }
                        else if (TresCanosX == 1 && TresCanosY == 3)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX + 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY + 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC = true;
                            }
                        }
                        else if (TresCanosY == 10)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX - 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY - 3] == 0 && Barcos[TresCanosX - 1, TresCanosY - 3] == 0 && Barcos[TresCanosX + 1, TresCanosY - 3] == 0 && Barcos[TresCanosX + 1, TresCanosY - 2] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC = true;
                            }
                        }
                        else if (TresCanosY == 3)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX - 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 2] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC = true;
                            }
                        }
                        else if (TresCanosX == 10)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX - 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY - 3] == 0 && Barcos[TresCanosX - 1, TresCanosY - 3] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC = true;
                            }
                        }
                        else if (TresCanosX == 1)
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
                        TresCanosX = rnr.Next(3, 11);// coord X
                        TresCanosY = rnr.Next(1, 11);// coord y

                        if (TresCanosX == 10 && TresCanosY == 10)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX - 3, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX - 2, TresCanosY - 1] == 0 && Barcos[TresCanosX - 3, TresCanosY - 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC2 = true;
                            }
                        }
                        else if (TresCanosX == 3 && TresCanosY == 10)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX - 2, TresCanosY - 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC2 = true;
                            }
                        }
                        else if (TresCanosX == 3 && TresCanosY == 1)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX - 2, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY + 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC2 = true;
                            }
                        }
                        else if (TresCanosX == 10 && TresCanosY == 1)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX - 3, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX - 2, TresCanosY + 1] == 0 && Barcos[TresCanosX - 3, TresCanosY + 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC2 = true;
                            }
                        }
                        else if (TresCanosX == 10)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX - 3, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX - 2, TresCanosY + 1] == 0 && Barcos[TresCanosX - 3, TresCanosY + 1] == 0 && Barcos[TresCanosX - 3, TresCanosY - 1] == 0 && Barcos[TresCanosX - 2, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC2 = true;
                            }
                        }
                        else if (TresCanosX == 3)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX - 2, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX - 2, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC2 = true;
                            }
                        }
                        else if (TresCanosY == 10)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX - 2, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX - 2, TresCanosY - 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX - 3, TresCanosY - 1] == 0 && Barcos[TresCanosX - 3, TresCanosY] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX - 1, TresCanosY] = 3;
                                Barcos[TresCanosX - 2, TresCanosY] = 3;
                                iiiC2 = true;
                            }
                        }
                        else if (TresCanosY == 1)
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
                        TresCanosX = rnr.Next(1, 11);// coord X
                        TresCanosY = rnr.Next(3, 11);// coord y

                        if (TresCanosX == 10 && TresCanosY == 10)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX - 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY - 3] == 0 && Barcos[TresCanosX - 1, TresCanosY - 3] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC2 = true;
                            }
                        }
                        else if (TresCanosX == 1 && TresCanosY == 10)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX + 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY - 3] == 0 && Barcos[TresCanosX + 1, TresCanosY - 3] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC2 = true;
                            }
                        }
                        else if (TresCanosX == 10 && TresCanosY == 3)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX - 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC2 = true;
                            }
                        }
                        else if (TresCanosX == 1 && TresCanosY == 3)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX + 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY + 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC2 = true;
                            }
                        }
                        else if (TresCanosY == 10)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX - 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY - 3] == 0 && Barcos[TresCanosX - 1, TresCanosY - 3] == 0 && Barcos[TresCanosX + 1, TresCanosY - 3] == 0 && Barcos[TresCanosX + 1, TresCanosY - 2] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC2 = true;
                            }
                        }
                        else if (TresCanosY == 3)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX - 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY + 1] == 0 && Barcos[TresCanosX + 1, TresCanosY - 2] == 0 && Barcos[TresCanosX + 1, TresCanosY - 1] == 0 && Barcos[TresCanosX + 1, TresCanosY] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC2 = true;
                            }
                        }
                        else if (TresCanosX == 10)
                        {
                            if (Barcos[TresCanosX, TresCanosY] == 0 && Barcos[TresCanosX - 1, TresCanosY] == 0 && Barcos[TresCanosX, TresCanosY - 1] == 0 && Barcos[TresCanosX - 1, TresCanosY - 1] == 0 && Barcos[TresCanosX, TresCanosY - 2] == 0 && Barcos[TresCanosX - 1, TresCanosY - 2] == 0 && Barcos[TresCanosX, TresCanosY - 3] == 0 && Barcos[TresCanosX - 1, TresCanosY - 3] == 0 && Barcos[TresCanosX - 1, TresCanosY + 1] == 0 && Barcos[TresCanosX, TresCanosY + 1] == 0)
                            {
                                Barcos[TresCanosX, TresCanosY] = 3;
                                Barcos[TresCanosX, TresCanosY - 1] = 3;
                                Barcos[TresCanosX, TresCanosY - 2] = 3;
                                iiiC2 = true;
                            }
                        }
                        else if (TresCanosX == 1)
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
                    DoisCanosX = rnr.Next(2, 11);
                    DoisCanosY = rnr.Next(1, 11);

                    if (DoisCanosX == 10 && DoisCanosY == 10)
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY - 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                            iiC = true;
                        }
                    }
                    else if (DoisCanosX == 2 && DoisCanosY == 10)
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                            iiC = true;
                        }
                    }
                    else if (DoisCanosX == 10 && DoisCanosY == 1)
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY + 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                            iiC = true;
                        }
                    }
                    else if (DoisCanosX == 2 && DoisCanosY == 1)
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                            iiC = true;
                        }
                    }
                    else if (DoisCanosX == 10)
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                            iiC = true;
                        }
                    }
                    else if (DoisCanosX == 2)
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                            iiC = true;
                        }
                    }
                    else if (DoisCanosY == 1)
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                            iiC = true;
                        }
                    }
                    else if (DoisCanosY == 10)
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
                    DoisCanosX = rnr.Next(1, 11);
                    DoisCanosY = rnr.Next(2, 11);

                    if (DoisCanosX == 10 && DoisCanosY == 10) //1
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 2] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                            iiC = true;
                        }
                    }
                    else if (DoisCanosX == 1 && DoisCanosY == 10) //2
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 2] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                            iiC = true;
                        }
                    }
                    else if (DoisCanosX == 1 && DoisCanosY == 2) //3
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                            iiC = true;
                        }
                    }
                    else if (DoisCanosX == 10 && DoisCanosY == 2) //4
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                            iiC = true;
                        }
                    }
                    else if (DoisCanosX == 10) //5
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 2] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                            iiC = true;
                        }
                    }
                    else if (DoisCanosX == 1) //6
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                            iiC = true;
                        }
                    }
                    else if (DoisCanosY == 2) //7
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                            iiC = true;
                        }
                    }
                    else if (DoisCanosY == 10) //8
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
                    DoisCanosX = rnr.Next(2, 11);
                    DoisCanosY = rnr.Next(1, 11);

                    if (DoisCanosX == 10 && DoisCanosY == 10)
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY - 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                            iiC2 = true;
                        }
                    }
                    else if (DoisCanosX == 2 && DoisCanosY == 10)
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                            iiC2 = true;
                        }
                    }
                    else if (DoisCanosX == 10 && DoisCanosY == 1)
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY + 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                            iiC2 = true;
                        }
                    }
                    else if (DoisCanosX == 2 && DoisCanosY == 1)
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                            iiC2 = true;
                        }
                    }
                    else if (DoisCanosX == 10)
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                            iiC2 = true;
                        }
                    }
                    else if (DoisCanosX == 2)
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                            iiC2 = true;
                        }
                    }
                    else if (DoisCanosY == 1)
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                            iiC2 = true;
                        }
                    }
                    else if (DoisCanosY == 10)
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
                    DoisCanosX = rnr.Next(1, 11);
                    DoisCanosY = rnr.Next(2, 11);

                    if (DoisCanosX == 10 && DoisCanosY == 10) //1
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 2] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                            iiC2 = true;
                        }
                    }
                    else if (DoisCanosX == 1 && DoisCanosY == 10) //2
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 2] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                            iiC2 = true;
                        }
                    }
                    else if (DoisCanosX == 1 && DoisCanosY == 2) //3
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                            iiC2 = true;
                        }
                    }
                    else if (DoisCanosX == 10 && DoisCanosY == 2) //4
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                            iiC2 = true;
                        }
                    }
                    else if (DoisCanosX == 10) //5
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 2] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                            iiC2 = true;
                        }
                    }
                    else if (DoisCanosX == 1) //6
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                            iiC2 = true;
                        }
                    }
                    else if (DoisCanosY == 2) //7
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                            iiC2 = true;
                        }
                    }
                    else if (DoisCanosY == 10) //8
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
                    DoisCanosX = rnr.Next(2, 11);
                    DoisCanosY = rnr.Next(1, 11);

                    if (DoisCanosX == 10 && DoisCanosY == 10)
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY - 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                            iiC3 = true;
                        }
                    }
                    else if (DoisCanosX == 2 && DoisCanosY == 10)
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                            iiC3 = true;
                        }
                    }
                    else if (DoisCanosX == 10 && DoisCanosY == 1)
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY + 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                            iiC3 = true;
                        }
                    }
                    else if (DoisCanosX == 2 && DoisCanosY == 1)
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                            iiC3 = true;
                        }
                    }
                    else if (DoisCanosX == 10)
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                            iiC3 = true;
                        }
                    }
                    else if (DoisCanosX == 2)
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                            iiC3 = true;
                        }
                    }
                    else if (DoisCanosY == 1)
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 2, DoisCanosY] == 0 && Barcos[DoisCanosX - 2, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX - 1, DoisCanosY] = 2;
                            iiC3 = true;
                        }
                    }
                    else if (DoisCanosY == 10)
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
                    DoisCanosX = rnr.Next(1, 11);
                    DoisCanosY = rnr.Next(2, 11);

                    if (DoisCanosX == 10 && DoisCanosY == 10) //1
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 2] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                            iiC3 = true;
                        }
                    }
                    else if (DoisCanosX == 1 && DoisCanosY == 10) //2
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 2] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                            iiC3 = true;
                        }
                    }
                    else if (DoisCanosX == 1 && DoisCanosY == 2) //3
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                            iiC3 = true;
                        }
                    }
                    else if (DoisCanosX == 10 && DoisCanosY == 2) //4
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                            iiC3 = true;
                        }
                    }
                    else if (DoisCanosX == 10) //5
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 2] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                            iiC3 = true;
                        }
                    }
                    else if (DoisCanosX == 1) //6
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 2] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                            iiC3 = true;
                        }
                    }
                    else if (DoisCanosY == 2) //7
                    {
                        if (Barcos[DoisCanosX, DoisCanosY] == 0 && Barcos[DoisCanosX, DoisCanosY - 1] == 0 && Barcos[DoisCanosX, DoisCanosY + 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY] == 0 && Barcos[DoisCanosX - 1, DoisCanosY - 1] == 0 && Barcos[DoisCanosX - 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY + 1] == 0 && Barcos[DoisCanosX + 1, DoisCanosY] == 0 && Barcos[DoisCanosX + 1, DoisCanosY - 1] == 0)
                        {
                            Barcos[DoisCanosX, DoisCanosY] = 2;
                            Barcos[DoisCanosX, DoisCanosY - 1] = 2;
                            iiC3 = true;
                        }
                    }
                    else if (DoisCanosY == 10) //8
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

        }

    }
}
