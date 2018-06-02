using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipPRJ.Models
{
    public class ModoAutonomo
    {
        public Coordenadas DevolverCoordsAleatorio(int[,] GrelhaMarcar)//metodo que devolve coordenadas aleatorias
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
        }//marca todos os pontos á volta da coordenada

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
                    proximoTiro = Acertou4Canos(GrelhaMarcar, TiroDisparado);
                }
                else if (OQueAcertei == 5)
                {
                    proximoTiro = DevolverCoordsAleatorio(GrelhaMarcar);
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
        }//decide qual a coordenada em que se dispara o proximo missil

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
        }//o que faz se o ultimo tiro acertou num barco de 2 canos

        public Coordenadas Acertou3Canos(int[,] Grelha, Coordenadas TD)
        {
            Coordenadas C = new Coordenadas();
            string Borda = VerificarBordas(TD);

            C = TerceiroTiro3Canos(Borda, Grelha, TD);

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

                    if (Grelha[C.X, C.Y] == -1)
                    {
                        i++;
                    }
                }
            }

            return C;
        }//o que faz se o ultimo tiro acertou num barco de 3 canos

        public Coordenadas Acertou4Canos(int[,] Grelha, Coordenadas TD)//o que faz se o ultimo tiro acertou num barco de 4 canos
        {
            Coordenadas C = new Coordenadas();

            string Borda = VerificarBordas(TD);

            C = QuartoTiro4Canos(Grelha, TD);

            if (C == null)
            {
                C = TerceiroTiro4Canos(Borda, Grelha, TD);
            }

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

                    if (Grelha[C.X, C.Y] == -1)
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
            else if (c.Y == 9)
            {
                return "Nao aceito Y + 1";
            }
            else
            {
                return "Aceito tudo";
            }
        }//método para não deixar disparar para além das bordas da grelha

        public string VerificarBordasRadius2(Coordenadas c)
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
            //2 radius
            else if (c.X == 0 && c.Y == 1)
            {
                return "Nao aceito X - 1 ou Y - 2";
            }
            else if (c.X == 0 && c.Y == 8)
            {
                return "Nao aceito X - 1 ou Y + 2";
            }
            else if (c.X == 9 && c.Y == 1)
            {
                return "Nao aceito X + 1 ou Y - 2";
            }
            else if (c.X == 9 && c.Y == 8)
            {
                return "Nao aceito X + 1 ou Y + 2";
            }
            else if (c.X == 1 && c.Y == 0)
            {
                return "Nao aceito X - 2 ou Y - 1";
            }
            else if (c.X == 8 && c.Y == 0)
            {
                return "Nao aceito X + 2 ou Y - 1";
            }
            else if (c.X == 1 && c.Y == 9)
            {
                return "Nao aceito X - 2 ou Y + 1";
            }
            else if (c.X == 8 && c.Y == 9)
            {
                return "Nao aceito X + 2 ou Y + 1";
            }
            else if (c.X == 8 && c.Y == 8)
            {
                return "Nao aceito + 2";
            }
            else if (c.X == 1 && c.Y == 1)
            {
                return "Nao aceito - 2";
            }
            else if (c.X == 1 && c.Y == 8)
            {
                return "Nao aceito X - 2 ou Y + 2";
            }
            else if (c.X == 8 && c.Y == 1)
            {
                return "Nao aceito X + 2 ou Y - 2";
            }
            //2 radius
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
            else if (c.Y == 9)
            {
                return "Nao aceito Y + 1";
            }
            //2 radius
            else if (c.X == 1)
            {
                return "Nao aceito X - 2";
            }
            else if (c.X == 8)
            {
                return "Nao aceito X + 2";
            }
            else if (c.Y == 1)
            {
                return "Nao aceito Y - 2";
            }
            else if (c.Y == 8)
            {
                return "Nao aceito Y + 2";
            }
            //2 radius
            else
            {
                return "Aceito tudo";
            }
        }//método para não deixar disparar para além das bordas da grelha

        public Coordenadas EscolherNSEO(string Borda)//aleatoriamente escolhe uma direção(norte sul este oeste) depende do que se acertou e se há possibilidade ou se já não está marcardo
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

        public Coordenadas TerceiroTiro3Canos(string Borda, int[,] Grelha, Coordenadas TD)
        {
            bool Acertou = false;

            Coordenadas C = new Coordenadas();

            Coordenadas R = new Coordenadas();

            if (Borda == "Nao aceito -1")
            {
                if (Grelha[TD.X + 1, TD.Y] == 3)
                {
                    C.X = C.X + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y + 1] == 3)
                {
                    C.Y = C.Y + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
            }
            else if (Borda == "Nao aceito X - 1 ou Y + 1")
            {
                if (Grelha[TD.X + 1, TD.Y] == 3)
                {
                    C.X = C.X + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y - 1] == 3)
                {
                    C.Y = C.Y - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
            }
            else if (Borda == "Nao aceito X + 1 ou Y - 1")
            {
                if (Grelha[TD.X - 1, TD.Y] == 3)
                {
                    C.X = C.X - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y + 1] == 3)
                {
                    C.Y = C.Y + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
            }
            else if (Borda == "Nao aceito + 1")
            {
                if (Grelha[TD.X - 1, TD.Y] == 3)
                {
                    C.X = C.X - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y - 1] == 3)
                {
                    C.Y = C.Y - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
            }
            else if (Borda == "Nao aceito X - 1")
            {
                if (Grelha[TD.X + 1, TD.Y] == 3)
                {
                    C.X = C.X + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y + 1] == 3)
                {
                    C.Y = C.Y + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y - 1] == 3)
                {
                    C.Y = C.Y - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
            }
            else if (Borda == "Nao aceito X + 1")
            {
                if (Grelha[TD.X - 1, TD.Y] == 3)
                {
                    C.X = C.X - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y + 1] == 3)
                {
                    C.Y = C.Y + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y - 1] == 3)
                {
                    C.Y = C.Y - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
            }
            else if (Borda == "Nao aceito Y - 1")
            {
                if (Grelha[TD.X + 1, TD.Y] == 3)
                {
                    C.X = C.X + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X - 1, TD.Y] == 3)
                {
                    C.X = C.X - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y + 1] == 3)
                {
                    C.Y = C.Y + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
            }
            else if (Borda == "Nao aceito Y + 1")
            {
                if (Grelha[TD.X + 1, TD.Y] == 3)
                {
                    C.X = C.X + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X - 1, TD.Y] == 3)
                {
                    C.X = C.X - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y - 1] == 3)
                {
                    C.Y = C.Y - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
            }
            else if (Borda == "Aceito tudo")
            {
                if (Grelha[TD.X + 1, TD.Y] == 3)
                {
                    C.X = C.X + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X - 1, TD.Y] == 3)
                {
                    C.X = C.X - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y + 1] == 3)
                {
                    C.Y = C.Y + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y - 1] == 3)
                {
                    C.Y = C.Y - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
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
        }//o que faz se o ultimo tiro acertou num barco de 3 canos sabendo que já acertou 2 quadrados nesse barco

        public Coordenadas TerceiroTiro4Canos(string Borda, int[,] Grelha, Coordenadas TD)
        {
            bool Acertou = false;

            Coordenadas C = new Coordenadas();//coords

            Coordenadas R = new Coordenadas();//resultado final

            if (Borda == "Nao aceito -1")
            {
                if (Grelha[TD.X + 1, TD.Y] == 4)
                {
                    C.X = C.X + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y + 1] == 4)
                {
                    C.Y = C.Y + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
            }
            else if (Borda == "Nao aceito X - 1 ou Y + 1")
            {
                if (Grelha[TD.X + 1, TD.Y] == 4)
                {
                    C.X = C.X + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y - 1] == 4)
                {
                    C.Y = C.Y - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
            }
            else if (Borda == "Nao aceito X + 1 ou Y - 1")
            {
                if (Grelha[TD.X - 1, TD.Y] == 4)
                {
                    C.X = C.X - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y + 1] == 4)
                {
                    C.Y = C.Y + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
            }
            else if (Borda == "Nao aceito + 1")
            {
                if (Grelha[TD.X - 1, TD.Y] == 4)
                {
                    C.X = C.X - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y - 1] == 4)
                {
                    C.Y = C.Y - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
            }
            else if (Borda == "Nao aceito X - 1")
            {
                if (Grelha[TD.X + 1, TD.Y] == 4)
                {
                    C.X = C.X + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y + 1] == 4)
                {
                    C.Y = C.Y + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y - 1] == 4)
                {
                    C.Y = C.Y - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
            }
            else if (Borda == "Nao aceito X + 1")
            {
                if (Grelha[TD.X - 1, TD.Y] == 4)
                {
                    C.X = C.X - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y + 1] == 4)
                {
                    C.Y = C.Y + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y - 1] == 4)
                {
                    C.Y = C.Y - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
            }
            else if (Borda == "Nao aceito Y - 1")
            {
                if (Grelha[TD.X + 1, TD.Y] == 4)
                {
                    C.X = C.X + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X - 1, TD.Y] == 4)
                {
                    C.X = C.X - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y + 1] == 4)
                {
                    C.Y = C.Y + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
            }
            else if (Borda == "Nao aceito Y + 1")
            {
                if (Grelha[TD.X + 1, TD.Y] == 4)
                {
                    C.X = C.X + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X - 1, TD.Y] == 4)
                {
                    C.X = C.X - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y - 1] == 4)
                {
                    C.Y = C.Y - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
            }
            else if (Borda == "Aceito tudo")
            {
                if (Grelha[TD.X + 1, TD.Y] == 4)
                {
                    C.X = C.X + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X - 1, TD.Y] == 4)
                {
                    C.X = C.X - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y + 1] == 4)
                {
                    C.Y = C.Y + 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
                    Acertou = true;
                }
                if (Grelha[TD.X, TD.Y - 1] == 4)
                {
                    C.Y = C.Y - 1;
                    R = TerceiroTiro(C.X - TD.X, C.Y - TD.Y, TD, Grelha);
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
        }//o que faz se o ultimo tiro acertou num barco de 4 canos sabendo que já acertou 2 quadrados nesse barco

        public Coordenadas QuartoTiro4Canos(int[,] Grelha, Coordenadas TD)//o que faz se o ultimo tiro acertou num barco de 4 canos sabendo que já acertou 3 quadrados nesse barco
        {
            bool Acertou = false;

            string Borda = VerificarBordasRadius2(TD);

            Coordenadas C = TD;

            Random rnr = new Random();

            if (Borda == "Nao aceito -1")
            {
                if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X + 2, TD.Y] == 4)//explicação disto no ultimo if(borda == aceito tudo)
                {
                    if (TD.X == 0)
                    {
                        C.X = TD.X + 3;
                    }
                    else if (TD.X == 7)
                    {
                        C.X = TD.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 1;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 3;
                            }
                        }

                    }
                    Acertou = true;
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y + 2] == 4)
                {
                    if (TD.Y == 0)
                    {
                        C.Y = TD.Y + 3;
                    }
                    else if (TD.Y == 7)
                    {
                        C.Y = TD.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 3;
                            }
                        }

                    }
                    Acertou = true;
                }
            }
            else if (Borda == "Nao aceito X + 1 ou Y - 1")
            {
                if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4 && Grelha[TD.X - 2, TD.Y] == 4)
                {
                    if (TD.X == 2)
                    {
                        C.X = TD.X + 1;
                    }
                    else if (TD.X == 9)
                    {
                        C.X = TD.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 3;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 1;
                            }
                        }
                        
                    }
                    Acertou = true;
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y + 2] == 4)
                {
                    if (TD.Y == 0)
                    {
                        C.Y = TD.Y + 3;
                    }
                    else if (TD.Y == 7)
                    {
                        C.Y = TD.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 3;
                            }
                        }

                    }
                    Acertou = true;
                }
            }
            else if (Borda == "Nao aceito X - 1 ou Y + 1")
            {
                if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X + 2, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 0)
                    {
                        C.X = TD.X + 3;
                    }
                    else if (TD.X == 7)
                    {
                        C.X = TD.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 1;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 3;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y - 1] == 4 && Grelha[TD.X, TD.Y - 2] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 2)
                    {
                        C.Y = TD.Y + 1;
                    }
                    else if (TD.Y == 9)
                    {
                        C.Y = TD.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 1;
                            }
                        }

                    }
                }
            }
            else if (Borda == "Nao aceito + 1")
            {
                if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4 && Grelha[TD.X - 2, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 2)
                    {
                        C.X = TD.X + 1;
                    }
                    else if (TD.X == 9)
                    {
                        C.X = TD.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 3;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 1;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y - 1] == 4 && Grelha[TD.X, TD.Y - 2] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 2)
                    {
                        C.Y = TD.Y + 1;
                    }
                    else if (TD.Y == 9)
                    {
                        C.Y = TD.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 1;
                            }
                        }

                    }
                }
            }
            //2 radius inicio
            else if (Borda == "Nao aceito X - 1 ou Y - 2")
            {
                if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X + 2, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 0)
                    {
                        C.X = TD.X + 3;
                    }
                    else if (TD.X == 7)
                    {
                        C.X = TD.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 1;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 3;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y + 2] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 0)
                    {
                        C.Y = TD.Y + 3;
                    }
                    else if (TD.Y == 7)
                    {
                        C.Y = TD.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 3;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y - 1] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 1)
                    {
                        C.Y = TD.Y + 2;
                    }
                    else if (TD.Y == 8)
                    {
                        C.Y = TD.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 2;
                            }
                        }

                    }
                }
            }
            else if (Borda == "Nao aceito X - 1 ou Y + 2")
            {
                if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X + 2, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 0)
                    {
                        C.X = TD.X + 3;
                    }
                    else if (TD.X == 7)
                    {
                        C.X = TD.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 1;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 3;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y - 1] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 1)
                    {
                        C.Y = TD.Y + 2;
                    }
                    else if (TD.Y == 8)
                    {
                        C.Y = TD.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 2;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y - 1] == 4 && Grelha[TD.X, TD.Y - 2] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 2)
                    {
                        C.Y = TD.Y + 1;
                    }
                    else if (TD.Y == 9)
                    {
                        C.Y = TD.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 1;
                            }
                        }

                    }
                }
            }
            else if (Borda == "Nao aceito X + 1 ou Y - 2")
            {
                if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4 && Grelha[TD.X - 2, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 2)
                    {
                        C.X = TD.X + 1;
                    }
                    else if (TD.X == 9)
                    {
                        C.X = TD.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 3;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 1;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y + 2] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 0)
                    {
                        C.Y = TD.Y + 3;
                    }
                    else if (TD.Y == 7)
                    {
                        C.Y = TD.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 3;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y - 1] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 1)
                    {
                        C.Y = TD.Y + 2;
                    }
                    else if (TD.Y == 8)
                    {
                        C.Y = TD.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 2;
                            }
                        }

                    }
                }
            }
            else if (Borda == "Nao aceito X + 1 ou Y + 2")
            { 
                if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4 && Grelha[TD.X - 2, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 2)
                    {
                        C.X = TD.X + 1;
                    }
                    else if (TD.X == 9)
                    {
                        C.X = TD.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 3;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 1;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y - 1] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 1)
                    {
                        C.Y = TD.Y + 2;
                    }
                    else if (TD.Y == 8)
                    {
                        C.Y = TD.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 2;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y - 1] == 4 && Grelha[TD.X, TD.Y - 2] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 2)
                    {
                        C.Y = TD.Y + 1;
                    }
                    else if (TD.Y == 9)
                    {
                        C.Y = TD.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 1;
                            }
                        }

                    }
                }
            }
            else if (Borda == "Nao aceito X - 2 ou Y - 1")
            {
                if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X + 2, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 0)
                    {
                        C.X = TD.X + 3;
                    }
                    else if (TD.X == 7)
                    {
                        C.X = TD.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 1;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 3;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 1)
                    {
                        C.X = TD.X + 2;
                    }
                    else if (TD.X == 8)
                    {
                        C.X = TD.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 2;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y + 2] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 0)
                    {
                        C.Y = TD.Y + 3;
                    }
                    else if (TD.Y == 7)
                    {
                        C.Y = TD.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 3;
                            }
                        }

                    }
                }
            }
            else if (Borda == "Nao aceito X + 2 ou Y - 1")
            {
                if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 1)
                    {
                        C.X = TD.X + 2;
                    }
                    else if (TD.X == 8)
                    {
                        C.X = TD.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 2;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4 && Grelha[TD.X - 2, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 2)
                    {
                        C.X = TD.X + 1;
                    }
                    else if (TD.X == 9)
                    {
                        C.X = TD.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 3;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 1;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y + 2] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 0)
                    {
                        C.Y = TD.Y + 3;
                    }
                    else if (TD.Y == 7)
                    {
                        C.Y = TD.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 3;
                            }
                        }

                    }
                }
            }
            else if (Borda == "Nao aceito X - 2 ou Y + 1")
            {
                if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X + 2, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 0)
                    {
                        C.X = TD.X + 3;
                    }
                    else if (TD.X == 7)
                    {
                        C.X = TD.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 1;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 3;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 1)
                    {
                        C.X = TD.X + 2;
                    }
                    else if (TD.X == 8)
                    {
                        C.X = TD.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 2;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y - 1] == 4 && Grelha[TD.X, TD.Y - 2] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 2)
                    {
                        C.Y = TD.Y + 1;
                    }
                    else if (TD.Y == 9)
                    {
                        C.Y = TD.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 1;
                            }
                        }

                    }
                }
            }
            else if (Borda == "Nao aceito X + 2 ou Y + 1")
            {
                Acertou = true;
                if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4)
                {
                    if (TD.X == 1)
                    {
                        C.X = TD.X + 2;
                    }
                    else if (TD.X == 8)
                    {
                        C.X = TD.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 2;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4 && Grelha[TD.X - 2, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 2)
                    {
                        C.X = TD.X + 1;
                    }
                    else if (TD.X == 9)
                    {
                        C.X = TD.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 3;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 1;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y - 1] == 4 && Grelha[TD.X, TD.Y - 2] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 2)
                    {
                        C.Y = TD.Y + 1;
                    }
                    else if (TD.Y == 9)
                    {
                        C.Y = TD.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 1;
                            }
                        }

                    }
                }
            }
            else if (Borda == "Nao aceito + 2")
            {
                Acertou = true;
                if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4)
                {
                    if (TD.X == 1)
                    {
                        C.X = TD.X + 2;
                    }
                    else if (TD.X == 8)
                    {
                        C.X = TD.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 2;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4 && Grelha[TD.X - 2, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 2)
                    {
                        C.X = TD.X + 1;
                    }
                    else if (TD.X == 9)
                    {
                        C.X = TD.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 3;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 1;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y - 1] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 1)
                    {
                        C.Y = TD.Y + 2;
                    }
                    else if (TD.Y == 8)
                    {
                        C.Y = TD.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 2;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y - 1] == 4 && Grelha[TD.X, TD.Y - 2] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 2)
                    {
                        C.Y = TD.Y + 1;
                    }
                    else if (TD.Y == 9)
                    {
                        C.Y = TD.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 1;
                            }
                        }

                    }
                }
            }
            else if (Borda == "Nao aceito - 2")
            {
                if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X + 2, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 0)
                    {
                        C.X = TD.X + 3;
                    }
                    else if (TD.X == 7)
                    {
                        C.X = TD.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 1;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 3;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 1)
                    {
                        C.X = TD.X + 2;
                    }
                    else if (TD.X == 8)
                    {
                        C.X = TD.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 2;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y + 2] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 0)
                    {
                        C.Y = TD.Y + 3;
                    }
                    else if (TD.Y == 7)
                    {
                        C.Y = TD.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 3;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y - 1] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 1)
                    {
                        C.Y = TD.Y + 2;
                    }
                    else if (TD.Y == 8)
                    {
                        C.Y = TD.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 2;
                            }
                        }

                    }
                }
            }
            else if (Borda == "Nao aceito X - 2 ou Y + 2")
            {
                Acertou = true;
                if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X + 2, TD.Y] == 4)
                {
                    if (TD.X == 0)
                    {
                        C.X = TD.X + 3;
                    }
                    else if (TD.X == 7)
                    {
                        C.X = TD.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 1;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 3;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 1)
                    {
                        C.X = TD.X + 2;
                    }
                    else if (TD.X == 8)
                    {
                        C.X = TD.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 2;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y - 1] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 1)
                    {
                        C.Y = TD.Y + 2;
                    }
                    else if (TD.Y == 8)
                    {
                        C.Y = TD.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 2;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y - 1] == 4 && Grelha[TD.X, TD.Y - 2] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 2)
                    {
                        C.Y = TD.Y + 1;
                    }
                    else if (TD.Y == 9)
                    {
                        C.Y = TD.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 1;
                            }
                        }

                    }
                }
            }
            else if (Borda == "Nao aceito X + 2 ou Y - 2")
            {
                if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 1)
                    {
                        C.X = TD.X + 2;
                    }
                    else if (TD.X == 8)
                    {
                        C.X = TD.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 2;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4 && Grelha[TD.X - 2, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 2)
                    {
                        C.X = TD.X + 1;
                    }
                    else if (TD.X == 9)
                    {
                        C.X = TD.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 3;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 1;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y + 2] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 0)
                    {
                        C.Y = TD.Y + 3;
                    }
                    else if (TD.Y == 7)
                    {
                        C.Y = TD.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 3;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y - 1] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 1)
                    {
                        C.Y = TD.Y + 2;
                    }
                    else if (TD.Y == 8)
                    {
                        C.Y = TD.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 2;
                            }
                        }

                    }
                }
            }
            //2 radius fim
            else if (Borda == "Nao aceito X - 1")
            {
                if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X + 2, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 0)
                    {
                        C.X = TD.X + 3;
                    }
                    else if (TD.X == 7)
                    {
                        C.X = TD.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 1;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 3;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y + 2] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 0)
                    {
                        C.Y = TD.Y + 3;
                    }
                    else if (TD.Y == 7)
                    {
                        C.Y = TD.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 3;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y - 1] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 1)
                    {
                        C.Y = TD.Y + 2;
                    }
                    else if (TD.Y == 8)
                    {
                        C.Y = TD.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 2;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y - 1] == 4 && Grelha[TD.X, TD.Y - 2] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 2)
                    {
                        C.Y = TD.Y + 1;
                    }
                    else if (TD.Y == 9)
                    {
                        C.Y = TD.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 1;
                            }
                        }

                    }
                }
            }
            else if (Borda == "Nao aceito X + 1")
            {
                Acertou = true;
                if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4 && Grelha[TD.X - 2, TD.Y] == 4)
                {
                    if (TD.X == 2)
                    {
                        C.X = TD.X + 1;
                    }
                    else if (TD.X == 9)
                    {
                        C.X = TD.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 3;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 1;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y + 2] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 0)
                    {
                        C.Y = TD.Y + 3;
                    }
                    else if (TD.Y == 7)
                    {
                        C.Y = TD.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 3;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y - 1] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 1)
                    {
                        C.Y = TD.Y + 2;
                    }
                    else if (TD.Y == 8)
                    {
                        C.Y = TD.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 2;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y - 1] == 4 && Grelha[TD.X, TD.Y - 2] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 2)
                    {
                        C.Y = TD.Y + 1;
                    }
                    else if (TD.Y == 9)
                    {
                        C.Y = TD.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 1;
                            }
                        }

                    }
                }
            }
            else if (Borda == "Nao aceito Y - 1")
            {
                if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X + 2, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 0)
                    {
                        C.X = TD.X + 3;
                    }
                    else if (TD.X == 7)
                    {
                        C.X = TD.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 1;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 3;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 1)
                    {
                        C.X = TD.X + 2;
                    }
                    else if (TD.X == 8)
                    {
                        C.X = TD.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 2;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4 && Grelha[TD.X - 2, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 2)
                    {
                        C.X = TD.X + 1;
                    }
                    else if (TD.X == 9)
                    {
                        C.X = TD.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 3;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 1;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y + 2] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 0)
                    {
                        C.Y = TD.Y + 3;
                    }
                    else if (TD.Y == 7)
                    {
                        C.Y = TD.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 3;
                            }
                        }

                    }
                }
            }
            else if (Borda == "Nao aceito Y + 1")
            {
                if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X + 2, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 0)
                    {
                        C.X = TD.X + 3;
                    }
                    else if (TD.X == 7)
                    {
                        C.X = TD.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 1;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 3;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 1)
                    {
                        C.X = TD.X + 2;
                    }
                    else if (TD.X == 8)
                    {
                        C.X = TD.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 2;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4 && Grelha[TD.X - 2, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 2)
                    {
                        C.X = TD.X + 1;
                    }
                    else if (TD.X == 9)
                    {
                        C.X = TD.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 3;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 1;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y - 1] == 4 && Grelha[TD.X, TD.Y - 2] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 2)
                    {
                        C.Y = TD.Y + 1;
                    }
                    else if (TD.Y == 9)
                    {
                        C.Y = TD.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 1;
                            }
                        }

                    }
                }
            }
            //2 radius inicio
            else if (Borda == "Nao aceito X - 2")
            {
                if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X + 2, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 0)
                    {
                        C.X = TD.X + 3;
                    }
                    else if (TD.X == 7)
                    {
                        C.X = TD.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 1;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 3;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 1)
                    {
                        C.X = TD.X + 2;
                    }
                    else if (TD.X == 8)
                    {
                        C.X = TD.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 2;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y + 2] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 0)
                    {
                        C.Y = TD.Y + 3;
                    }
                    else if (TD.Y == 7)
                    {
                        C.Y = TD.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 3;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y - 1] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 1)
                    {
                        C.Y = TD.Y + 2;
                    }
                    else if (TD.Y == 8)
                    {
                        C.Y = TD.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 2;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y - 1] == 4 && Grelha[TD.X, TD.Y - 2] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 2)
                    {
                        C.Y = TD.Y + 1;
                    }
                    else if (TD.Y == 9)
                    {
                        C.Y = TD.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 1;
                            }
                        }

                    }
                }
            }
            else if (Borda == "Nao aceito X + 2")
            {
                if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 1)
                    {
                        C.X = TD.X + 2;
                    }
                    else if (TD.X == 8)
                    {
                        C.X = TD.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 2;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4 && Grelha[TD.X - 2, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 2)
                    {
                        C.X = TD.X + 1;
                    }
                    else if (TD.X == 9)
                    {
                        C.X = TD.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 3;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 1;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y + 2] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 0)
                    {
                        C.Y = TD.Y + 3;
                    }
                    else if (TD.Y == 7)
                    {
                        C.Y = TD.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 3;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y - 1] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 1)
                    {
                        C.Y = TD.Y + 2;
                    }
                    else if (TD.Y == 8)
                    {
                        C.Y = TD.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 2;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y - 1] == 4 && Grelha[TD.X, TD.Y - 2] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 2)
                    {
                        C.Y = TD.Y + 1;
                    }
                    else if (TD.Y == 9)
                    {
                        C.Y = TD.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 1;
                            }
                        }

                    }
                }
            }
            else if (Borda == "Nao aceito Y - 2")
            {
                if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X + 2, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 0)
                    {
                        C.X = TD.X + 3;
                    }
                    else if (TD.X == 7)
                    {
                        C.X = TD.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 1;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 3;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 1)
                    {
                        C.X = TD.X + 2;
                    }
                    else if (TD.X == 8)
                    {
                        C.X = TD.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 2;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4 && Grelha[TD.X - 2, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 2)
                    {
                        C.X = TD.X + 1;
                    }
                    else if (TD.X == 9)
                    {
                        C.X = TD.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 3;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 1;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y + 2] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 0)
                    {
                        C.Y = TD.Y + 3;
                    }
                    else if (TD.Y == 7)
                    {
                        C.Y = TD.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 3;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y - 1] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 1)
                    {
                        C.Y = TD.Y + 2;
                    }
                    else if (TD.Y == 8)
                    {
                        C.Y = TD.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 2;
                            }
                        }

                    }
                }
            }
            else if (Borda == "Nao aceito Y + 2")
            {
                if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X + 2, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 0)
                    {
                        C.X = TD.X + 3;
                    }
                    else if (TD.X == 7)
                    {
                        C.X = TD.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 1;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 3;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 1)
                    {
                        C.X = TD.X + 2;
                    }
                    else if (TD.X == 8)
                    {
                        C.X = TD.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 2;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4 && Grelha[TD.X - 2, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 2)
                    {
                        C.X = TD.X + 1;
                    }
                    else if (TD.X == 9)
                    {
                        C.X = TD.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 3;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 1;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y - 1] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 1)
                    {
                        C.Y = TD.Y + 2;
                    }
                    else if (TD.Y == 8)
                    {
                        C.Y = TD.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 2;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y - 1] == 4 && Grelha[TD.X, TD.Y - 2] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 2)
                    {
                        C.Y = TD.Y + 1;
                    }
                    else if (TD.Y == 9)
                    {
                        C.Y = TD.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 1;
                            }
                        }

                    }
                }
            }
            //2 radius fim
            else if (Borda == "Aceito tudo")
            {
                if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X + 2, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 0)
                    {
                        C.X = TD.X + 3;
                    }
                    else if (TD.X == 7)
                    {
                        C.X = TD.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 1;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 3;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X + 1, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 1)
                    {
                        C.X = TD.X + 2;
                    }
                    else if (TD.X == 8)
                    {
                        C.X = TD.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 2;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X - 1, TD.Y] == 4 && Grelha[TD.X - 2, TD.Y] == 4)
                {
                    Acertou = true;
                    if (TD.X == 2)
                    {
                        C.X = TD.X + 1;
                    }
                    else if (TD.X == 9)
                    {
                        C.X = TD.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = TD.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X - 3;
                            }
                        }
                        else
                        {
                            C.X = TD.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = TD.X + 1;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y + 2] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 0)
                    {
                        C.Y = TD.Y + 3;
                    }
                    else if (TD.Y == 7)
                    {
                        C.Y = TD.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 3;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y + 1] == 4 && Grelha[TD.X, TD.Y - 1] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 1)
                    {
                        C.Y = TD.Y + 2;
                    }
                    else if (TD.Y == 8)
                    {
                        C.Y = TD.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 2;
                            }
                        }

                    }
                }
                else if (Grelha[TD.X, TD.Y] == 4 && Grelha[TD.X, TD.Y - 1] == 4 && Grelha[TD.X, TD.Y - 2] == 4)
                {
                    Acertou = true;
                    if (TD.Y == 2)
                    {
                        C.Y = TD.Y + 1;
                    }
                    else if (TD.Y == 9)
                    {
                        C.Y = TD.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = TD.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = TD.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = TD.Y + 1;
                            }
                        }

                    }
                }
            }
            if (Acertou == true)
            {
                return C;
            }
            else
            {
                return null;
            }
        }

        public Coordenadas TerceiroTiro(int X, int Y, Coordenadas Tiro, int[,] Grelha)
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
                if (Tiro.Y < 0 || Tiro.Y > 9 || Tiro.X < 0 || Tiro.X > 9 || Grelha[Tiro.X, Tiro.Y] == 7)
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
        }//método para 3º tiro dos barcos de 3 e 4 canos(criei um metodo apenas para não haver repetição do codigo do mesmo)

        public int[,] AfundouMarcar(int[,] GrelhaMarcar, int Barco)
        {
            for (int X = 0; X < 10; X++)
            {
                for (int Y = 0; Y < 10; Y++)
                {
                    if (GrelhaMarcar[X, Y] == Barco)
                    {
                        Coordenadas C = new Coordenadas();
                        C.X = X;
                        C.Y = Y;
                        Marcar(C, GrelhaMarcar);
                    }
                }
            }
            return GrelhaMarcar;
        }//marca todos os pontos á volta do tipo de barco selecionado(para não disparar em coordenadas em que seja impossivel estar um barco)
    }
}
