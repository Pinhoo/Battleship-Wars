﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipPRJ.Models
{
    public class ModoAutonomo1
    {
        public Coordenadas DevolverCoordsAleatorio(int[,] GrelhaMarcar)//"simples"
        {
            Coordenadas c = new Models.Coordenadas();
            c.X = 0;
            c.Y = 0;
            int i = 0;

            Random rnr = new Random();

            while (i == 0)
            {
                c.X = rnr.Next(0, 10);
                c.Y = rnr.Next(0, 10);
                if (GrelhaMarcar[c.X, c.Y] == -1)
                {

                    i++;
                }
                else
                {
                    i = 0;
                }
            }

            return c;
        }

        public int[,] Marcar(Coordenadas C, int[,] GrelhaMarcada)
        {
            string Borda = VerificarBordas(C);

            if (Borda == "Nao aceito -1")
            {
                if (GrelhaMarcada[C.X + 1, C.Y + 1] == -1)
                {
                    GrelhaMarcada[C.X + 1, C.Y + 1] = 7;
                }
                if (GrelhaMarcada[C.X + 1, C.Y] == -1)
                {
                    GrelhaMarcada[C.X + 1, C.Y] = 7;
                }
                if (GrelhaMarcada[C.X, C.Y + 1] == -1)
                {
                    GrelhaMarcada[C.X, C.Y + 1] = 7;
                }

            }
            else if (Borda == "Nao aceito X - 1 ou Y + 1")
            {
                if (GrelhaMarcada[C.X + 1, C.Y - 1] == -1)
                {
                    GrelhaMarcada[C.X + 1, C.Y - 1] = 7;
                }
                if (GrelhaMarcada[C.X + 1, C.Y] == -1)
                {
                    GrelhaMarcada[C.X + 1, C.Y] = 7;
                }
                if (GrelhaMarcada[C.X, C.Y - 1] == -1)
                {
                    GrelhaMarcada[C.X, C.Y - 1] = 7;
                }
            }
            else if (Borda == "Nao aceito X + 1 ou Y - 1")
            {
                if (GrelhaMarcada[C.X - 1, C.Y + 1] == -1)
                {
                    GrelhaMarcada[C.X - 1, C.Y + 1] = 7;
                }
                if (GrelhaMarcada[C.X - 1, C.Y] == -1)
                {
                    GrelhaMarcada[C.X - 1, C.Y] = 7;
                }
                if (GrelhaMarcada[C.X, C.Y + 1] == -1)
                {
                    GrelhaMarcada[C.X, C.Y + 1] = 7;
                }
            }
            else if (Borda == "Nao aceito + 1")
            {
                if (GrelhaMarcada[C.X - 1, C.Y - 1] == -1)
                {
                    GrelhaMarcada[C.X - 1, C.Y - 1] = 7;
                }
                if (GrelhaMarcada[C.X, C.Y - 1] == -1)
                {
                    GrelhaMarcada[C.X, C.Y - 1] = 7;
                }
                if (GrelhaMarcada[C.X - 1, C.Y] == -1)
                {
                    GrelhaMarcada[C.X - 1, C.Y] = 7;
                }
            }
            else if (Borda == "Nao aceito X - 1")
            {
                if (GrelhaMarcada[C.X, C.Y - 1] == -1)
                {
                    GrelhaMarcada[C.X, C.Y - 1] = 7;
                }
                if (GrelhaMarcada[C.X + 1, C.Y - 1] == -1)
                {
                    GrelhaMarcada[C.X + 1, C.Y - 1] = 7;
                }
                if (GrelhaMarcada[C.X + 1, C.Y] == -1)
                {
                    GrelhaMarcada[C.X + 1, C.Y] = 7;
                }
                if (GrelhaMarcada[C.X, C.Y + 1] == -1)
                {
                    GrelhaMarcada[C.X, C.Y + 1] = 7;
                }
                if (GrelhaMarcada[C.X + 1, C.Y + 1] == -1)
                {
                    GrelhaMarcada[C.X + 1, C.Y + 1] = 7;
                }
            }
            else if (Borda == "Nao aceito X + 1")
            {
                if (GrelhaMarcada[C.X - 1, C.Y - 1] == -1)
                {
                    GrelhaMarcada[C.X - 1, C.Y - 1] = 7;
                }
                if (GrelhaMarcada[C.X, C.Y - 1] == -1)
                {
                    GrelhaMarcada[C.X, C.Y - 1] = 7;
                }
                if (GrelhaMarcada[C.X - 1, C.Y] == -1)
                {
                    GrelhaMarcada[C.X - 1, C.Y] = 7;
                }
                if (GrelhaMarcada[C.X - 1, C.Y + 1] == -1)
                {
                    GrelhaMarcada[C.X - 1, C.Y + 1] = 7;
                }
                if (GrelhaMarcada[C.X, C.Y + 1] == -1)
                {
                    GrelhaMarcada[C.X, C.Y + 1] = 7;
                }
            }
            else if (Borda == "Nao aceito Y - 1")
            {
                if (GrelhaMarcada[C.X - 1, C.Y] == -1)
                {
                    GrelhaMarcada[C.X - 1, C.Y] = 7;
                }
                if (GrelhaMarcada[C.X + 1, C.Y] == -1)
                {
                    GrelhaMarcada[C.X + 1, C.Y] = 7;
                }
                if (GrelhaMarcada[C.X - 1, C.Y + 1] == -1)
                {
                    GrelhaMarcada[C.X - 1, C.Y + 1] = 7;
                }
                if (GrelhaMarcada[C.X, C.Y + 1] == -1)
                {
                    GrelhaMarcada[C.X, C.Y + 1] = 7;
                }
                if (GrelhaMarcada[C.X + 1, C.Y + 1] == -1)
                {
                    GrelhaMarcada[C.X + 1, C.Y + 1] = 7;
                }
            }
            else if (Borda == "Nao aceito Y + 1")
            {
                if (GrelhaMarcada[C.X - 1, C.Y - 1] == -1)
                {
                    GrelhaMarcada[C.X - 1, C.Y - 1] = 7;
                }
                if (GrelhaMarcada[C.X, C.Y - 1] == -1)
                {
                    GrelhaMarcada[C.X, C.Y - 1] = 7;
                }
                if (GrelhaMarcada[C.X + 1, C.Y - 1] == -1)
                {
                    GrelhaMarcada[C.X + 1, C.Y - 1] = 7;
                }
                if (GrelhaMarcada[C.X - 1, C.Y] == -1)
                {
                    GrelhaMarcada[C.X - 1, C.Y] = 7;
                }
                if (GrelhaMarcada[C.X + 1, C.Y] == -1)
                {
                    GrelhaMarcada[C.X + 1, C.Y] = 7;
                }
            }
            else if (Borda == "Aceito tudo")
            {
                if (GrelhaMarcada[C.X - 1, C.Y - 1] == -1)
                {
                    GrelhaMarcada[C.X - 1, C.Y - 1] = 7;
                }
                if (GrelhaMarcada[C.X, C.Y - 1] == -1)
                {
                    GrelhaMarcada[C.X, C.Y - 1] = 7;
                }
                if (GrelhaMarcada[C.X + 1, C.Y - 1] == -1)
                {
                    GrelhaMarcada[C.X + 1, C.Y - 1] = 7;
                }
                if (GrelhaMarcada[C.X - 1, C.Y] == -1)
                {
                    GrelhaMarcada[C.X - 1, C.Y] = 7;
                }
                if (GrelhaMarcada[C.X + 1, C.Y] == -1)
                {
                    GrelhaMarcada[C.X + 1, C.Y] = 7;
                }
                if (GrelhaMarcada[C.X - 1, C.Y + 1] == -1)
                {
                    GrelhaMarcada[C.X - 1, C.Y + 1] = 7;
                }
                if (GrelhaMarcada[C.X, C.Y + 1] == -1)
                {
                    GrelhaMarcada[C.X, C.Y + 1] = 7;
                }
                if (GrelhaMarcada[C.X + 1, C.Y + 1] == -1)
                {
                    GrelhaMarcada[C.X + 1, C.Y + 1] = 7;
                }

            }
            return GrelhaMarcada;
        }

        public Coordenadas ProximoTiro(int[,] GrelhaMarcar, int OQueAcertei, bool Afundou, Coordenadas TiroDisparado)
        {
            Coordenadas proximoTiro = new Coordenadas();
            if (Afundou == false)
            {
                if (OQueAcertei == 1)
                {
                    proximoTiro = DevolverCoordsAleatorio(GrelhaMarcar);
                }
                else if (OQueAcertei == 2)
                {
                    proximoTiro = Acertou2Canos(GrelhaMarcar, TiroDisparado);
                }
                else if (OQueAcertei == 3)
                {
                    proximoTiro = Acertou3Canos(GrelhaMarcar, TiroDisparado);
                }
                else if (OQueAcertei == 4)
                {

                }
                else if (OQueAcertei == 5)
                {

                }
                else
                {
                    proximoTiro = DevolverCoordsAleatorio(GrelhaMarcar);
                }
            }
            else
            {
                proximoTiro = DevolverCoordsAleatorio(GrelhaMarcar);
            }
            return proximoTiro;
        }

        public Coordenadas Acertou2Canos(int[,] Grelha, Coordenadas TD)
        {
            int i = 0;
            Coordenadas C = new Coordenadas();
            while (i == 0)
            {
                C = TD;

                string Borda = VerificarBordas(C);

                Coordenadas Add = EscolherNSEO(Borda);

                C.X = C.X + Add.X;
                C.Y = C.Y + Add.Y;

                if (Grelha[C.X, C.Y] == -1)
                {
                    i++;
                }
            }
            return C;
        }

        public Coordenadas Acertou3Canos(int[,] Grelha, Coordenadas TD)
        {
            Coordenadas C = new Coordenadas();
            string Borda = VerificarBordas(TD);

            C = TerceiroTiro34Canos(Borda, Grelha, TD);

            if (C == null)
            {
                int i = 0;

                while (i == 0)
                {
                    C = TD;

                    string borda = VerificarBordas(C);

                    Coordenadas Add = EscolherNSEO(borda);

                    C.X = C.X + Add.X;
                    C.Y = C.Y + Add.Y;

                    if (Grelha[C.X, C.Y] != -1)
                    {
                        i++;
                    }
                }
            }

            return C;
        }

        public string VerificarBordas(Coordenadas c)
        {
            if (c.X == 0 && c.Y == 0)
            {
                return "Nao aceito -1";
            }
            else if (c.X == 9 && c.Y == 0)
            {
                return "Nao aceito X + 1 ou Y - 1";
            }
            else if (c.X == 0 && c.Y == 9)
            {
                return "Nao aceito X - 1 ou Y + 1";
            }
            else if (c.X == 9 && c.Y == 9)
            {
                return "Nao aceito + 1";
            }
            else if (c.X == 0)
            {
                return "Nao aceito X - 1";
            }
            else if (c.X == 9)
            {
                return "Nao aceito X + 1";
            }
            else if (c.Y == 0)
            {
                return "Nao aceito Y - 1";
            }
            else if (c.Y == 0)
            {
                return "Nao aceito Y + 1";
            }
            else
            {
                return "Aceito tudo";
            }
        }

        public Coordenadas EscolherNSEO(string Borda)//norte sul este oeste
        {
            Coordenadas C = new Coordenadas();
            Random rnr = new Random();

            if (Borda == "Nao aceito -1")
            {
                int Direcao = rnr.Next(0, 2);
                if (Direcao == 0)
                {
                    C.X = 1;
                    C.Y = 0;
                }
                else if (Direcao == 1)
                {
                    C.X = 0;
                    C.Y = 1;
                }
            }
            else if (Borda == "Nao aceito X - 1 ou Y + 1")
            {
                int Direcao = rnr.Next(0, 2);
                if (Direcao == 0)
                {
                    C.X = 1;
                    C.Y = 0;
                }
                else if (Direcao == 1)
                {
                    C.X = 0;
                    C.Y = -1;
                }
            }
            else if (Borda == "Nao aceito X + 1 ou Y - 1")
            {
                int Direcao = rnr.Next(0, 2);
                if (Direcao == 0)
                {
                    C.X = -1;
                    C.Y = 0;
                }
                else if (Direcao == 1)
                {
                    C.X = 0;
                    C.Y = 1;
                }
            }
            else if (Borda == "Nao aceito + 1")
            {
                int Direcao = rnr.Next(0, 2);
                if (Direcao == 0)
                {
                    C.X = -1;
                    C.Y = 0;
                }
                else if (Direcao == 1)
                {
                    C.X = 0;
                    C.Y = -1;
                }
            }
            else if (Borda == "Nao aceito X - 1")
            {
                int Direcao = rnr.Next(0, 3);
                if (Direcao == 0)
                {
                    C.X = 1;
                    C.Y = 0;
                }
                else if (Direcao == 1)
                {
                    C.X = 0;
                    C.Y = -1;
                }
                else if (Direcao == 2)
                {
                    C.X = 0;
                    C.Y = 1;
                }
            }
            else if (Borda == "Nao aceito X + 1")
            {
                int Direcao = rnr.Next(0, 3);
                if (Direcao == 0)
                {
                    C.X = -1;
                    C.Y = 0;
                }
                else if (Direcao == 1)
                {
                    C.X = 0;
                    C.Y = -1;
                }
                else if (Direcao == 2)
                {
                    C.X = 0;
                    C.Y = 1;
                }
            }
            else if (Borda == "Nao aceito Y - 1")
            {
                int Direcao = rnr.Next(0, 3);
                if (Direcao == 0)
                {
                    C.X = 1;
                    C.Y = 0;
                }
                else if (Direcao == 1)
                {
                    C.X = -1;
                    C.Y = 0;
                }
                else if (Direcao == 2)
                {
                    C.X = 0;
                    C.Y = 1;
                }
            }
            else if (Borda == "Nao aceito Y + 1")
            {
                int Direcao = rnr.Next(0, 3);
                if (Direcao == 0)
                {
                    C.X = 1;
                    C.Y = 0;
                }
                else if (Direcao == 1)
                {
                    C.X = -1;
                    C.Y = 0;
                }
                else if (Direcao == 2)
                {
                    C.X = 0;
                    C.Y = -1;
                }
            }
            else if (Borda == "Aceito tudo")
            {
                int Direcao = rnr.Next(0, 4);
                if (Direcao == 0)
                {
                    C.X = 1;
                    C.Y = 0;
                }
                else if (Direcao == 1)
                {
                    C.X = -1;
                    C.Y = 0;
                }
                else if (Direcao == 2)
                {
                    C.X = 0;
                    C.Y = 1;
                }
                else if (Direcao == 3)
                {
                    C.X = 0;
                    C.Y = -1;
                }
            }

            return C;
        }

        public Coordenadas TerceiroTiro34Canos(string Borda, int[,] Grelha, Coordenadas TD)
        {
            bool Acertou = false;

            Coordenadas C = new Coordenadas();

            Coordenadas R = new Coordenadas();

            if (Borda == "Nao aceito -1")
            {
                if (Grelha[TD.X + 1, TD.Y] == 3)
                {
                    C.X = C.X + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y + 1] == 3)
                {
                    C.Y = C.Y + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD);
                    Acertou = true;
                }
            }
            else if (Borda == "Nao aceito X - 1 ou Y + 1")
            {
                if (Grelha[TD.X + 1, TD.Y] == 3)
                {
                    C.X = C.X + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y - 1] == 3)
                {
                    C.Y = C.Y - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD);
                    Acertou = true;
                }
            }
            else if (Borda == "Nao aceito X + 1 ou Y - 1")
            {
                if (Grelha[TD.X - 1, TD.Y] == 3)
                {
                    C.X = C.X - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y + 1] == 3)
                {
                    C.Y = C.Y + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD);
                    Acertou = true;
                }
            }
            else if (Borda == "Nao aceito + 1")
            {
                if (Grelha[TD.X - 1, TD.Y] == 3)
                {
                    C.X = C.X - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y - 1] == 3)
                {
                    C.Y = C.Y - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD);
                    Acertou = true;
                }
            }
            else if (Borda == "Nao aceito X - 1")
            {
                if (Grelha[TD.X + 1, TD.Y] == 3)
                {
                    C.X = C.X + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y + 1] == 3)
                {
                    C.Y = C.Y + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y - 1] == 3)
                {
                    C.Y = C.Y - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD);
                    Acertou = true;
                }
            }
            else if (Borda == "Nao aceito X + 1")
            {
                if (Grelha[TD.X - 1, TD.Y] == 3)
                {
                    C.X = C.X - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y + 1] == 3)
                {
                    C.Y = C.Y + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y - 1] == 3)
                {
                    C.Y = C.Y - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD);
                    Acertou = true;
                }
            }
            else if (Borda == "Nao aceito Y - 1")
            {
                if (Grelha[TD.X + 1, TD.Y] == 3)
                {
                    C.X = C.X + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD);
                    Acertou = true;
                }
                if (Grelha[TD.X - 1, TD.Y] == 3)
                {
                    C.X = C.X - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y + 1] == 3)
                {
                    C.Y = C.Y + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD);
                    Acertou = true;
                }
            }
            else if (Borda == "Nao aceito Y + 1")
            {
                if (Grelha[TD.X + 1, TD.Y] == 3)
                {
                    C.X = C.X + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD);
                    Acertou = true;
                }
                if (Grelha[TD.X - 1, TD.Y] == 3)
                {
                    C.X = C.X - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y - 1] == 3)
                {
                    C.Y = C.Y - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD);
                    Acertou = true;
                }
            }
            else if (Borda == "Aceito tudo")
            {
                if (Grelha[TD.X + 1, TD.Y] == 3)
                {
                    C.X = C.X + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD);
                    Acertou = true;
                }
                if (Grelha[TD.X - 1, TD.Y] == 3)
                {
                    C.X = C.X - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y + 1] == 3)
                {
                    C.Y = C.Y + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y - 1] == 3)
                {
                    C.Y = C.Y - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD);
                    Acertou = true;
                }
            }
            if (Acertou == true)
            {
                return R;
            }
            else
            {
                return null;
            }
        }

        public Coordenadas TerceiroTiro(int X, int Y, Coordenadas Tiro)
        {
            Random rnr = new Random();
            int i = 0;
            int Aleatorio = rnr.Next(0, 2);
            while (i == 0)
            {
                if (X == -1)
                {
                    if (Aleatorio == 0)
                    {
                        Tiro.X = Tiro.X + 2;
                    }
                    else if (Aleatorio == 1)
                    {
                        Tiro.X = Tiro.X - 1;
                    }
                }
                else if (X == 1)
                {
                    if (Aleatorio == 0)
                    {
                        Tiro.X = Tiro.X - 2;
                    }
                    else if (Aleatorio == 1)
                    {
                        Tiro.X = Tiro.X + 1;
                    }
                }
                else if (Y == -1)
                {
                    if (Aleatorio == 0)
                    {
                        Tiro.Y = Tiro.Y + 2;
                    }
                    else if (Aleatorio == 1)
                    {
                        Tiro.Y = Tiro.Y - 1;
                    }
                }
                else
                {
                    if (Aleatorio == 0)
                    {
                        Tiro.Y = Tiro.Y - 2;
                    }
                    else if (Aleatorio == 1)
                    {
                        Tiro.Y = Tiro.Y + 1;
                    }
                }
                if (Tiro.Y < 0 || Tiro.Y > 9 || Tiro.X < 0 || Tiro.X > 9)
                {
                    if (Aleatorio == 0)
                    {
                        Aleatorio = 1;
                    }
                    else if (Aleatorio == 1)
                    {
                        Aleatorio = 0;
                    }
                }
                else
                {
                    i++;
                }
            }
            return Tiro;
        }

        public int[,] AfundouMarcar(int[,] GrelhaMarcar, int Barco)
        {
            int X = 0;
            while (X < 10)
            {
                int Y = 0;
                while (Y < 10)
                {
                    if (GrelhaMarcar[X, Y] == Barco)
                    {
                        Coordenadas C = new Coordenadas();
                        C.X = X;
                        C.Y = Y;
                        Marcar(C, GrelhaMarcar);
                    }
                    Y++;
                }
                X++;
            }
            return GrelhaMarcar;
        }
    }
}
