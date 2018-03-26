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
            //1 Barco de 4 canos
            int iiiiC = 0;
            int QuatroCanosX;
            int QuatroCanosY;
            while (iiiiC == 0)
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
                            iiiiC = 1;
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
                            iiiiC = 1;
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
                            iiiiC = 1;
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
                            iiiiC = 1;
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
                            iiiiC = 1;
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
                            iiiiC = 1;
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
                            iiiiC = 1;
                        }
                    }
                    else if(QuatroCanosX == 1)
                    {
                        if(Barcos[QuatroCanosX, QuatroCanosY] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 2] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 3] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 2] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 3] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 4] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 4] == 0 && Barcos[QuatroCanosX, QuatroCanosY +1] == 0 && Barcos[QuatroCanosX +1, QuatroCanosY +1] == 0)
                        {
                            Barcos[QuatroCanosX, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX, QuatroCanosY - 1] = 4;
                            Barcos[QuatroCanosX, QuatroCanosY - 2] = 4;
                            Barcos[QuatroCanosX, QuatroCanosY - 3] = 4;
                            iiiiC = 1;
                        }
                    }
                    else
                    {
                        if(Barcos[QuatroCanosX, QuatroCanosY] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 2] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 3] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 2] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 3] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 3] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 2] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY -4] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 4] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 4] == 0)
                        {
                            Barcos[QuatroCanosX, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX, QuatroCanosY - 1] = 4;
                            Barcos[QuatroCanosX, QuatroCanosY - 2] = 4;
                            Barcos[QuatroCanosX, QuatroCanosY - 3] = 4;                            
                            iiiiC = 1;
                        }
                    }

                }
                if (PosicaoIIIIC == 1)//horizontal
                {
                    QuatroCanosX = rnr.Next(4, 11);
                    QuatroCanosY = rnr.Next(1, 11);
                    if (QuatroCanosX ==10 && QuatroCanosY == 10)
                    {
                        if (Barcos[QuatroCanosX -4, QuatroCanosY] ==0 && Barcos[QuatroCanosX - 4, QuatroCanosY -1] == 0 && Barcos[QuatroCanosX - 3, QuatroCanosY -1] == 0 && Barcos[QuatroCanosX - 2, QuatroCanosY-1] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY -1] == 0 && Barcos[QuatroCanosX, QuatroCanosY -1] == 0)
                        {
                            Barcos[QuatroCanosX, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX - 1, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX - 2, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX - 3, QuatroCanosY] = 4;
                            iiiiC = 1;
                        }
                    }
                    else if(QuatroCanosX == 10 && QuatroCanosY == 1)
                    {
                        if(Barcos[QuatroCanosX - 4, QuatroCanosY] == 0 && Barcos[QuatroCanosX - 4, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 3, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 2, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY + 1] == 0)
                        {
                            Barcos[QuatroCanosX, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX - 1, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX - 2, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX - 3, QuatroCanosY] = 4;
                            iiiiC = 1;
                        }
                    }
                    else if(QuatroCanosX == 4 && QuatroCanosY == 10)
                    {
                        if(Barcos[QuatroCanosX + 1, QuatroCanosY] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 3, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 2, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 1] == 0)
                        {
                            Barcos[QuatroCanosX, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX - 1, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX - 2, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX - 3, QuatroCanosY] = 4;
                            iiiiC = 1;
                        }
                    }
                    else if(QuatroCanosX == 4 && QuatroCanosY == 1)
                    {
                        if(Barcos[QuatroCanosX + 1, QuatroCanosY] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 3, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 2, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY + 1] == 0)
                        {
                            Barcos[QuatroCanosX, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX - 1, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX - 2, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX - 3, QuatroCanosY] = 4;
                            iiiiC = 1;
                        }
                    }
                    else if(QuatroCanosX == 10)
                    {
                        if(Barcos[QuatroCanosX - 4, QuatroCanosY] == 0 && Barcos[QuatroCanosX - 4, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 3, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 2, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 4, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 3, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 2, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY + 1] == 0)
                        {
                            Barcos[QuatroCanosX, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX - 1, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX - 2, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX - 3, QuatroCanosY] = 4;
                            iiiiC = 1;
                        }
                    }
                    else if(QuatroCanosX == 4)
                    {
                        if(Barcos[QuatroCanosX + 1, QuatroCanosY] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 3, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 2, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 3, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 2, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY + 1] == 0)
                        {
                            Barcos[QuatroCanosX, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX - 1, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX - 2, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX - 3, QuatroCanosY] = 4;
                            iiiiC = 1;
                        }
                    }
                    else if(QuatroCanosY == 1)
                    {
                        if(Barcos[QuatroCanosX - 4, QuatroCanosY] == 0 && Barcos[QuatroCanosX - 4, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 3, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 2, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX +1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX +1, QuatroCanosY] == 0)
                        {
                            Barcos[QuatroCanosX, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX - 1, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX - 2, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX - 3, QuatroCanosY] = 4;
                            iiiiC = 1;
                        }
                    }
                    else if(QuatroCanosY == 10)
                    {
                        if(Barcos[QuatroCanosX - 4, QuatroCanosY] == 0 && Barcos[QuatroCanosX - 4, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 3, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 2, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX -4, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 4, QuatroCanosY] == 0)
                        {
                            Barcos[QuatroCanosX, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX - 1, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX - 2, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX - 3, QuatroCanosY] = 4;
                            iiiiC = 1;
                        }
                    }
                    else
                    {
                        if(Barcos[QuatroCanosX + 1, QuatroCanosY] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 3, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 2, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX - 1, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY - 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 3, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 2, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX + 1, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX -4, QuatroCanosY + 1] == 0 && Barcos[QuatroCanosX - 4, QuatroCanosY] == 0 && Barcos[QuatroCanosX - 4, QuatroCanosY - 1] == 0)
                        {
                            Barcos[QuatroCanosX, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX - 1, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX - 2, QuatroCanosY] = 4;
                            Barcos[QuatroCanosX - 3, QuatroCanosY] = 4;
                            iiiiC = 1;
                        }
                    }
                }
            }

            //2 barcos de 3 canos
            int iiiC = 0;
            int TresCanosX;
            int TresCanosY;
            while(iiiC == 0)
            {
                int PosicaoTresCanos = rnr.Next(1);
                if (PosicaoTresCanos == 0)//horizontal
                {
                    TresCanosX = rnr.Next(1, 11);// coord X
                    TresCanosY = rnr.Next(1, 11);// coord y
                    
                    if(TresCanosX == && TresCanosY ==)
                    {
                        if()
                        {

                        }
                    }





                }

            }



            
        }

    }
}
