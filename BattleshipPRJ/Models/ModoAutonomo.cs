using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipPRJ.Models
{
    public class Coordenadas
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class ModoAutonomo1
    {

        //public Coordenadas ReceberCoords(int[,] CoordenadasJaSelecionadas)//"simples"
        //{
        //    Coordenadas c = new Models.Coordenadas();
        //    c.X = 0;
        //    c.Y = 0;
        //    int i = 0;

        //    Random rnr = new Random();

        //    while (i == 0)
        //    {
        //        c.X = rnr.Next(0, 10);
        //        c.Y = rnr.Next(0, 10);
        //        if (CoordenadasJaSelecionadas[c.X, c.Y] == -1)
        //        {

        //            i++;
        //        }
        //        else
        //        {
        //            i = 0;
        //        }
        //    }

        //    return c;
        //}
        //        public int[,] Marcar(int CoordX, int CoordY, int[,] GrelhaMarcada, bool Aofundo)
        //        {

        //            if (CoordX == 0 && CoordY == 0)
        //            {
        //                GrelhaMarcada[CoordX + 1, CoordY + 1] = 7;
        //                GrelhaMarcada[CoordX + 1, CoordY] = 7;
        //                GrelhaMarcada[CoordX, CoordY + 1] = 7;
        //            }
        //            else if (CoordX == 0 && CoordY == 9)
        //            {
        //                GrelhaMarcada[CoordX + 1, CoordY - 1] = 7;
        //                GrelhaMarcada[CoordX + 1, CoordY] = 7;
        //                GrelhaMarcada[CoordX, CoordY - 1] = 7;
        //            }
        //            else if (CoordX == 9 && CoordY == 0)
        //            {
        //                GrelhaMarcada[CoordX - 1, CoordY + 1] = 7;
        //                GrelhaMarcada[CoordX - 1, CoordY] = 7;
        //                GrelhaMarcada[CoordX, CoordY + 1] = 7;
        //            }
        //            else if (CoordX == 9 && CoordY == 9)
        //            {
        //                GrelhaMarcada[CoordX - 1, CoordY - 1] = 7;
        //                GrelhaMarcada[CoordX - 1, CoordY] = 7;
        //                GrelhaMarcada[CoordX, CoordY - 1] = 7;
        //            }
        //            else if()
        //                {

        //            }
        //        }

        //                return GrelhaMarcada;
        //            }
        //        public Coordenadas ReceberCoords(int[,] CoordenadasJaSelecionadas,int UltimaJogada,int XUJ,int YUJ,bool Afundou)//"simples"
        //        {
        //            int[,] g = CoordenadasJaSelecionadas;
        //            //Coordenadas c = new Models.Coordenadas();
        //            //c.X = 0;
        //            //c.Y = 0;




        //            if(UltimaJogada!=0)//marcar
        //            {
        //                g[XUJ, YUJ] = UltimaJogada;
        //                if(UltimaJogada==1)
        //                {

        //                    if(XUJ == 0 && YUJ == 0)
        //                    {
        //                        g[XUJ +1, YUJ] = 7;
        //                        g[XUJ +1, YUJ+1] = 7;
        //                        g[XUJ, YUJ+1] = 7;
        //                    }
        //                    else if(XUJ == 0 && YUJ == 9)
        //                    {
        //                        g[XUJ + 1, YUJ - 1] = 7;
        //                        g[XUJ + 1, YUJ] = 7;
        //                        g[XUJ, YUJ - 1] = 7;
        //                    }
        //                    else if(XUJ == 9 && YUJ == 0)
        //                    {
        //                        g[XUJ, YUJ + 1] = 7;
        //                        g[XUJ - 1, YUJ] = 7;
        //                        g[XUJ - 1, YUJ + 1] = 7;
        //                    }
        //                    else if(XUJ == 9 && YUJ == 9)
        //                    {
        //                        g[XUJ, YUJ - 1] = 7;
        //                        g[XUJ - 1, YUJ - 1] = 7;
        //                        g[XUJ - 1, YUJ] = 7;
        //                    }
        //                    else if(XUJ==0)
        //                    {
        //                        g[XUJ + 1, YUJ - 1] = 7;
        //                        g[XUJ + 1, YUJ] = 7;
        //                        g[XUJ + 1, YUJ + 1] = 7;
        //                        g[XUJ, YUJ + 1] = 7;
        //                        g[XUJ, YUJ - 1] = 7;
        //                    }
        //                    else if (XUJ == 9)
        //                    {
        //                        g[XUJ, YUJ + 1] = 7;
        //                        g[XUJ, YUJ - 1] = 7;
        //                        g[XUJ - 1, YUJ - 1] = 7;
        //                        g[XUJ - 1, YUJ] = 7;
        //                        g[XUJ - 1, YUJ + 1] = 7;
        //                    }
        //                    else if (YUJ == 0)
        //                    {
        //                        g[XUJ + 1, YUJ] = 7;
        //                        g[XUJ + 1, YUJ + 1] = 7;
        //                        g[XUJ, YUJ + 1] = 7;
        //                        g[XUJ - 1, YUJ] = 7;
        //                        g[XUJ - 1, YUJ + 1] = 7;
        //                    }
        //                    else if (YUJ == 9)
        //                    {
        //                        g[XUJ + 1, YUJ - 1] = 7;
        //                        g[XUJ + 1, YUJ] = 7;
        //                        g[XUJ, YUJ - 1] = 7;
        //                        g[XUJ - 1, YUJ - 1] = 7;
        //                        g[XUJ - 1, YUJ] = 7;
        //                    }
        //                    else
        //                    {
        //                        g[XUJ + 1, YUJ - 1] = 7;
        //                        g[XUJ + 1, YUJ] = 7;
        //                        g[XUJ + 1, YUJ + 1] = 7;
        //                        g[XUJ, YUJ + 1] = 7;
        //                        g[XUJ, YUJ - 1] = 7;
        //                        g[XUJ - 1, YUJ - 1] = 7;
        //                        g[XUJ - 1, YUJ] = 7;
        //                        g[XUJ - 1, YUJ + 1] = 7;
        //                    }
        //                }
        //                else if(UltimaJogada==2)
        //                {
        //                    if(Afundou == false)//se nao afundou apenas marca nos cantos
        //                    {
        //                        if (XUJ == 0 && YUJ == 0)
        //                        {
        //                            g[XUJ + 1, YUJ + 1] = 7;

        //                        }
        //                        else if (XUJ == 0 && YUJ == 9)
        //                        {
        //                            g[XUJ + 1, YUJ - 1] = 7;
        //                        }
        //                        else if (XUJ == 9 && YUJ == 0)
        //                        {
        //                            g[XUJ - 1, YUJ + 1] = 7;
        //                        }
        //                        else if (XUJ == 9 && YUJ == 9)
        //                        {
        //                            g[XUJ - 1, YUJ - 1] = 7;
        //                        }
        //                        else if (XUJ == 0)
        //                        {
        //                            g[XUJ + 1, YUJ - 1] = 7;
        //                            g[XUJ + 1, YUJ + 1] = 7;
        //                        }
        //                        else if (XUJ == 9)
        //                        {
        //                            g[XUJ - 1, YUJ - 1] = 7;
        //                            g[XUJ - 1, YUJ + 1] = 7;
        //                        }
        //                        else if (YUJ == 0)
        //                        {
        //                            g[XUJ + 1, YUJ + 1] = 7;
        //                            g[XUJ - 1, YUJ + 1] = 7;
        //                        }
        //                        else if (YUJ == 9)
        //                        {
        //                            g[XUJ + 1, YUJ - 1] = 7;
        //                            g[XUJ - 1, YUJ - 1] = 7;
        //                        }
        //                        else
        //                        {
        //                            g[XUJ + 1, YUJ - 1] = 7;
        //                            g[XUJ + 1, YUJ + 1] = 7;
        //                            g[XUJ - 1, YUJ - 1] = 7;
        //                            g[XUJ - 1, YUJ + 1] = 7;
        //                        }
        //                    }
        //                    else
        //                    {
        //                        if (XUJ!=9 && g[XUJ + 1, YUJ]==UltimaJogada)//marcar os pontos anteriores
        //                        {
        //                            if(XUJ > 1 && YUJ == 0)
        //                            {
        //                                g[XUJ + 2, YUJ] = 7;
        //                                g[XUJ + 2, YUJ + 1] = 7;
        //                            }
        //                            else if(XUJ > 1 && YUJ == 9)
        //                            {
        //                                g[XUJ + 2,YUJ] = 7;
        //                                g[XUJ + 2, YUJ - 1] = 7;
        //                            }
        //                            else
        //                            {
        //                                g[XUJ + 2, YUJ] = 7;
        //                                g[XUJ + 2, YUJ + 1] = 7;
        //                                g[XUJ + 2, YUJ - 1] = 7;
        //                            }
        //                        }
        //                        else if(XUJ != 0 && g[XUJ - 1, YUJ] == UltimaJogada)
        //                        {
        //                            if (XUJ > 1 && YUJ == 0)
        //                            {
        //                                g[XUJ - 2, YUJ] = 7;
        //                                g[XUJ - 2, YUJ + 1] = 7;
        //                            }
        //                            else if (XUJ > 1 && YUJ == 9)
        //                            {
        //                                g[XUJ - 2, YUJ] = 7;
        //                                g[XUJ - 2, YUJ - 1] = 7;
        //                            }
        //                            else
        //                            {
        //                                g[XUJ - 2, YUJ] = 7;
        //                                g[XUJ - 2, YUJ + 1] = 7;
        //                                g[XUJ - 2, YUJ - 1] = 7;
        //                            }
        //                        }
        //                        else if(YUJ != 0 && g[XUJ, YUJ -1] == UltimaJogada)
        //                        {
        //                            if (XUJ > 1 && YUJ == 0)
        //                            {
        //                                g[XUJ, YUJ - 2] = 7;
        //                                g[XUJ + 1, YUJ - 2] = 7;
        //                            }
        //                            else if (XUJ > 1 && YUJ == 9)
        //                            {
        //                                g[XUJ, YUJ - 2] = 7;
        //                                g[XUJ - 1, YUJ - 2] = 7;
        //                            }
        //                            else
        //                            {
        //                                g[XUJ - 1, YUJ - 2] = 7;
        //                                g[XUJ, YUJ - 2] = 7;
        //                                g[XUJ + 1, YUJ - 2] = 7;
        //                            }
        //                        }
        //                        else if(YUJ != 9 && g[XUJ, YUJ + 1] == UltimaJogada)
        //                        {
        //                            if (XUJ > 1 && YUJ == 0)
        //                            {
        //                                g[XUJ, YUJ + 2] = 7;
        //                                g[XUJ + 1, YUJ + 2] = 7;
        //                            }
        //                            else if (XUJ > 1 && YUJ == 9)
        //                            {
        //                                g[XUJ, YUJ + 2] = 7;
        //                                g[XUJ - 1, YUJ +2] = 7;
        //                            }
        //                            else
        //                            {
        //                                g[XUJ - 1, YUJ + 2] = 7;
        //                                g[XUJ, YUJ + 2] = 7;
        //                                g[XUJ + 1, YUJ + 2] = 7;
        //                            }
        //                        }
        //                        if (XUJ == 0 && YUJ == 0)//marcar á volta
        //                        {
        //                            g[XUJ + 1, YUJ] = 7;
        //                            g[XUJ + 1, YUJ + 1] = 7;
        //                            g[XUJ, YUJ + 1] = 7;
        //                        }
        //                        else if (XUJ == 0 && YUJ == 9)
        //                        {
        //                            g[XUJ + 1, YUJ - 1] = 7;
        //                            g[XUJ + 1, YUJ] = 7;
        //                            g[XUJ, YUJ - 1] = 7;
        //                        }
        //                        else if (XUJ == 9 && YUJ == 0)
        //                        {
        //                            g[XUJ, YUJ + 1] = 7;
        //                            g[XUJ - 1, YUJ] = 7;
        //                            g[XUJ - 1, YUJ + 1] = 7;
        //                        }
        //                        else if (XUJ == 9 && YUJ == 9)
        //                        {
        //                            g[XUJ, YUJ - 1] = 7;
        //                            g[XUJ - 1, YUJ - 1] = 7;
        //                            g[XUJ - 1, YUJ] = 7;
        //                        }
        //                        else if (XUJ == 0)
        //                        {
        //                            g[XUJ + 1, YUJ - 1] = 7;
        //                            g[XUJ + 1, YUJ] = 7;
        //                            g[XUJ + 1, YUJ + 1] = 7;
        //                            g[XUJ, YUJ + 1] = 7;
        //                            g[XUJ, YUJ - 1] = 7;
        //                        }
        //                        else if (XUJ == 9)
        //                        {
        //                            g[XUJ, YUJ + 1] = 7;
        //                            g[XUJ, YUJ - 1] = 7;
        //                            g[XUJ - 1, YUJ - 1] = 7;
        //                            g[XUJ - 1, YUJ] = 7;
        //                            g[XUJ - 1, YUJ + 1] = 7;
        //                        }
        //                        else if (YUJ == 0)
        //                        {
        //                            g[XUJ + 1, YUJ] = 7;
        //                            g[XUJ + 1, YUJ + 1] = 7;
        //                            g[XUJ, YUJ + 1] = 7;
        //                            g[XUJ - 1, YUJ] = 7;
        //                            g[XUJ - 1, YUJ + 1] = 7;
        //                        }
        //                        else if (YUJ == 9)
        //                        {
        //                            g[XUJ + 1, YUJ - 1] = 7;
        //                            g[XUJ + 1, YUJ] = 7;
        //                            g[XUJ, YUJ - 1] = 7;
        //                            g[XUJ - 1, YUJ - 1] = 7;
        //                            g[XUJ - 1, YUJ] = 7;
        //                        }
        //                        else
        //                        {
        //                            g[XUJ + 1, YUJ - 1] = 7;
        //                            g[XUJ + 1, YUJ] = 7;
        //                            g[XUJ + 1, YUJ + 1] = 7;
        //                            g[XUJ, YUJ + 1] = 7;
        //                            g[XUJ, YUJ - 1] = 7;
        //                            g[XUJ - 1, YUJ - 1] = 7;
        //                            g[XUJ - 1, YUJ] = 7;
        //                            g[XUJ - 1, YUJ + 1] = 7;
        //                        }
        //                    }
        //                }
        //                else if(UltimaJogada == 3)
        //                {

        //                }
        //                else if (UltimaJogada == 4)
        //                {

        //                }
        //                else if (UltimaJogada == 5)
        //                {

        //                }
        //            }
        //            int i = 0;

        //            Random rnr = new Random();

        //            //while (i == 0)
        //            //{
        //            //    c.X = rnr.Next(0, 10);
        //            //    c.Y = rnr.Next(0, 10);
        //            //    if (CoordenadasJaSelecionadas[c.X, c.Y] == -1)
        //            //    {

        //            //        i++;
        //            //    }
        //            //    else
        //            //    {
        //            //        i = 0;
        //            //    }
        //            //}


        //            //return c;
        //        }






    }
}
