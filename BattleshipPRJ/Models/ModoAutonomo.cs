using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipPRJ.Models
{
    public class ModoAutonomo
    {
        private Random rnr = new Random();

        public Coordenadas DevolverCoordsAleatorio(int[,] GrelhaMarcar)//metodo que devolve coordenadas aleatorias
        {
            Coordenadas NovasCoordenadas = new Models.Coordenadas();
            NovasCoordenadas.X = 0;
            NovasCoordenadas.Y = 0;

            Random rnr = new Random();

            while (true)
            {
                NovasCoordenadas.X = rnr.Next(0, 10);
                NovasCoordenadas.Y = rnr.Next(0, 10);
                if (GrelhaMarcar[NovasCoordenadas.X, NovasCoordenadas.Y] == -1)
                {
                    break;
                }
            }

            return NovasCoordenadas;
        }

        public int[,] Marcar(Coordenadas Coordenada, int[,] GrelhaMarcada)
        {
            int[,,,] NaoAceitoCoords = VerificarBordas(Coordenada,false);

            if (NaoAceitoCoords[1, 0, 1, 0] == 1)
            {
                if (GrelhaMarcada[Coordenada.X + 1, Coordenada.Y + 1] == -1)
                {
                    GrelhaMarcada[Coordenada.X + 1, Coordenada.Y + 1] = 7;
                }
                if (GrelhaMarcada[Coordenada.X + 1, Coordenada.Y] == -1)
                {
                    GrelhaMarcada[Coordenada.X + 1, Coordenada.Y] = 7;
                }
                if (GrelhaMarcada[Coordenada.X, Coordenada.Y + 1] == -1)
                {
                    GrelhaMarcada[Coordenada.X, Coordenada.Y + 1] = 7;
                }

            }
            else if (NaoAceitoCoords[1, 0, 0, 1] == 1)
            {
                if (GrelhaMarcada[Coordenada.X + 1, Coordenada.Y - 1] == -1)
                {
                    GrelhaMarcada[Coordenada.X + 1, Coordenada.Y - 1] = 7;
                }
                if (GrelhaMarcada[Coordenada.X + 1, Coordenada.Y] == -1)
                {
                    GrelhaMarcada[Coordenada.X + 1, Coordenada.Y] = 7;
                }
                if (GrelhaMarcada[Coordenada.X, Coordenada.Y - 1] == -1)
                {
                    GrelhaMarcada[Coordenada.X, Coordenada.Y - 1] = 7;
                }
            }
            else if (NaoAceitoCoords[0, 1, 1, 0] == 1)
            {
                if (GrelhaMarcada[Coordenada.X - 1, Coordenada.Y + 1] == -1)
                {
                    GrelhaMarcada[Coordenada.X - 1, Coordenada.Y + 1] = 7;
                }
                if (GrelhaMarcada[Coordenada.X - 1, Coordenada.Y] == -1)
                {
                    GrelhaMarcada[Coordenada.X - 1, Coordenada.Y] = 7;
                }
                if (GrelhaMarcada[Coordenada.X, Coordenada.Y + 1] == -1)
                {
                    GrelhaMarcada[Coordenada.X, Coordenada.Y + 1] = 7;
                }
            }
            else if (NaoAceitoCoords[0, 1, 0, 1] == 1)
            {
                if (GrelhaMarcada[Coordenada.X - 1, Coordenada.Y - 1] == -1)
                {
                    GrelhaMarcada[Coordenada.X - 1, Coordenada.Y - 1] = 7;
                }
                if (GrelhaMarcada[Coordenada.X, Coordenada.Y - 1] == -1)
                {
                    GrelhaMarcada[Coordenada.X, Coordenada.Y - 1] = 7;
                }
                if (GrelhaMarcada[Coordenada.X - 1, Coordenada.Y] == -1)
                {
                    GrelhaMarcada[Coordenada.X - 1, Coordenada.Y] = 7;
                }
            }
            else if (NaoAceitoCoords[1, 0, 0, 0] == 1)
            {
                if (GrelhaMarcada[Coordenada.X, Coordenada.Y - 1] == -1)
                {
                    GrelhaMarcada[Coordenada.X, Coordenada.Y - 1] = 7;
                }
                if (GrelhaMarcada[Coordenada.X + 1, Coordenada.Y - 1] == -1)
                {
                    GrelhaMarcada[Coordenada.X + 1, Coordenada.Y - 1] = 7;
                }
                if (GrelhaMarcada[Coordenada.X + 1, Coordenada.Y] == -1)
                {
                    GrelhaMarcada[Coordenada.X + 1, Coordenada.Y] = 7;
                }
                if (GrelhaMarcada[Coordenada.X, Coordenada.Y + 1] == -1)
                {
                    GrelhaMarcada[Coordenada.X, Coordenada.Y + 1] = 7;
                }
                if (GrelhaMarcada[Coordenada.X + 1, Coordenada.Y + 1] == -1)
                {
                    GrelhaMarcada[Coordenada.X + 1, Coordenada.Y + 1] = 7;
                }
            }
            else if (NaoAceitoCoords[0, 1, 0, 0] == 1)
            {
                if (GrelhaMarcada[Coordenada.X - 1, Coordenada.Y - 1] == -1)
                {
                    GrelhaMarcada[Coordenada.X - 1, Coordenada.Y - 1] = 7;
                }
                if (GrelhaMarcada[Coordenada.X, Coordenada.Y - 1] == -1)
                {
                    GrelhaMarcada[Coordenada.X, Coordenada.Y - 1] = 7;
                }
                if (GrelhaMarcada[Coordenada.X - 1, Coordenada.Y] == -1)
                {
                    GrelhaMarcada[Coordenada.X - 1, Coordenada.Y] = 7;
                }
                if (GrelhaMarcada[Coordenada.X - 1, Coordenada.Y + 1] == -1)
                {
                    GrelhaMarcada[Coordenada.X - 1, Coordenada.Y + 1] = 7;
                }
                if (GrelhaMarcada[Coordenada.X, Coordenada.Y + 1] == -1)
                {
                    GrelhaMarcada[Coordenada.X, Coordenada.Y + 1] = 7;
                }
            }
            else if (NaoAceitoCoords[0, 0, 1, 0] == 1)
            {
                if (GrelhaMarcada[Coordenada.X - 1, Coordenada.Y] == -1)
                {
                    GrelhaMarcada[Coordenada.X - 1, Coordenada.Y] = 7;
                }
                if (GrelhaMarcada[Coordenada.X + 1, Coordenada.Y] == -1)
                {
                    GrelhaMarcada[Coordenada.X + 1, Coordenada.Y] = 7;
                }
                if (GrelhaMarcada[Coordenada.X - 1, Coordenada.Y + 1] == -1)
                {
                    GrelhaMarcada[Coordenada.X - 1, Coordenada.Y + 1] = 7;
                }
                if (GrelhaMarcada[Coordenada.X, Coordenada.Y + 1] == -1)
                {
                    GrelhaMarcada[Coordenada.X, Coordenada.Y + 1] = 7;
                }
                if (GrelhaMarcada[Coordenada.X + 1, Coordenada.Y + 1] == -1)
                {
                    GrelhaMarcada[Coordenada.X + 1, Coordenada.Y + 1] = 7;
                }
            }
            else if (NaoAceitoCoords[0, 0, 0, 1] == 1)
            {
                if (GrelhaMarcada[Coordenada.X - 1, Coordenada.Y - 1] == -1)
                {
                    GrelhaMarcada[Coordenada.X - 1, Coordenada.Y - 1] = 7;
                }
                if (GrelhaMarcada[Coordenada.X, Coordenada.Y - 1] == -1)
                {
                    GrelhaMarcada[Coordenada.X, Coordenada.Y - 1] = 7;
                }
                if (GrelhaMarcada[Coordenada.X + 1, Coordenada.Y - 1] == -1)
                {
                    GrelhaMarcada[Coordenada.X + 1, Coordenada.Y - 1] = 7;
                }
                if (GrelhaMarcada[Coordenada.X - 1, Coordenada.Y] == -1)
                {
                    GrelhaMarcada[Coordenada.X - 1, Coordenada.Y] = 7;
                }
                if (GrelhaMarcada[Coordenada.X + 1, Coordenada.Y] == -1)
                {
                    GrelhaMarcada[Coordenada.X + 1, Coordenada.Y] = 7;
                }
            }
            else if (NaoAceitoCoords[0, 0, 0, 0] == 1)
            {
                if (GrelhaMarcada[Coordenada.X - 1, Coordenada.Y - 1] == -1)
                {
                    GrelhaMarcada[Coordenada.X - 1, Coordenada.Y - 1] = 7;
                }
                if (GrelhaMarcada[Coordenada.X, Coordenada.Y - 1] == -1)
                {
                    GrelhaMarcada[Coordenada.X, Coordenada.Y - 1] = 7;
                }
                if (GrelhaMarcada[Coordenada.X + 1, Coordenada.Y - 1] == -1)
                {
                    GrelhaMarcada[Coordenada.X + 1, Coordenada.Y - 1] = 7;
                }
                if (GrelhaMarcada[Coordenada.X - 1, Coordenada.Y] == -1)
                {
                    GrelhaMarcada[Coordenada.X - 1, Coordenada.Y] = 7;
                }
                if (GrelhaMarcada[Coordenada.X + 1, Coordenada.Y] == -1)
                {
                    GrelhaMarcada[Coordenada.X + 1, Coordenada.Y] = 7;
                }
                if (GrelhaMarcada[Coordenada.X - 1, Coordenada.Y + 1] == -1)
                {
                    GrelhaMarcada[Coordenada.X - 1, Coordenada.Y + 1] = 7;
                }
                if (GrelhaMarcada[Coordenada.X, Coordenada.Y + 1] == -1)
                {
                    GrelhaMarcada[Coordenada.X, Coordenada.Y + 1] = 7;
                }
                if (GrelhaMarcada[Coordenada.X + 1, Coordenada.Y + 1] == -1)
                {
                    GrelhaMarcada[Coordenada.X + 1, Coordenada.Y + 1] = 7;
                }

            }
            return GrelhaMarcada;
        }//marca todos os pontos á volta da coordenada

        public Coordenadas CoordenadasProximoTiro(int[,] GrelhaMarcar, int OQueAcertei, bool Afundou, Coordenadas TiroAFocar)
        {
            Coordenadas proximoTiro = new Coordenadas();

            if (Afundou == false)
            {
                switch (OQueAcertei)
                {
                    case 1:
                        proximoTiro = DevolverCoordsAleatorio(GrelhaMarcar);
                        break;
                    case 2:
                        proximoTiro = DisparoParaSegundoHit(TiroAFocar, GrelhaMarcar);
                        break;
                    case 3:
                        proximoTiro = Acertou3Canos(GrelhaMarcar, TiroAFocar);
                        break;
                    case 4:
                        proximoTiro = Acertou4Canos(GrelhaMarcar, TiroAFocar);
                        break;
                    case 5:
                        proximoTiro = PortaAvioes(GrelhaMarcar, TiroAFocar);
                        break;
                    default:
                        proximoTiro = DevolverCoordsAleatorio(GrelhaMarcar);
                        break;
                }
                
            }
            else
            {
                proximoTiro = DevolverCoordsAleatorio(GrelhaMarcar);
            }
            return proximoTiro;
        }//decide qual a coordenada em que se dispara o proximo missil

        public Coordenadas Acertou3Canos(int[,] Grelha, Coordenadas CoordAFocar)
        {
            Coordenadas NovaCoordenada = new Coordenadas();

            NovaCoordenada = VerificarEDecidirTerceiroTiro(Grelha, CoordAFocar, 3);

            if (NovaCoordenada == null)
            {
                NovaCoordenada = DisparoParaSegundoHit(CoordAFocar, Grelha);
            }

            return NovaCoordenada;
        }//o que faz se o ultimo tiro acertou num barco de 3 canos

        public Coordenadas Acertou4Canos(int[,] Grelha, Coordenadas CoordAFocar)//o que faz se o ultimo tiro acertou num barco de 4 canos
        {
            Coordenadas NovaCoordenada = null;

            NovaCoordenada = QuartoTiro4Canos(Grelha, CoordAFocar);

            if (NovaCoordenada == null)
            {
                NovaCoordenada = VerificarEDecidirTerceiroTiro(Grelha, CoordAFocar, 4);
            }

            if (NovaCoordenada == null)//2º tiro
            {
                NovaCoordenada = DisparoParaSegundoHit(CoordAFocar, Grelha);
            }

            return NovaCoordenada;
        }

        public int[,,,] VerificarBordas(Coordenadas coordenadas, bool RaioDois)
        {
            int[,,,] NaoAceitoCoords = new int[3,3,3,3];

            if (coordenadas.X == 0 && coordenadas.Y == 0)
            {
                NaoAceitoCoords[ 1, 0, 1, 0] = 1;
                return NaoAceitoCoords;
            }
            else if (coordenadas.X == 9 && coordenadas.Y == 0)
            {
                NaoAceitoCoords[1, 0, 0, 1] = 1;
                return NaoAceitoCoords;
            }
            else if (coordenadas.X == 0 && coordenadas.Y == 9)
            {
                NaoAceitoCoords[0, 1, 1, 0] = 1;
                return NaoAceitoCoords;
            }
            else if (coordenadas.X == 9 && coordenadas.Y == 9)
            {
                NaoAceitoCoords[0, 1, 0, 1] = 1;
                return NaoAceitoCoords;
            }
            else if (RaioDois == true)
            {
                if (coordenadas.X == 0 && coordenadas.Y == 1)
                {
                    NaoAceitoCoords[1, 0, 2, 0] = 1;
                    return NaoAceitoCoords;
                }
                else if (coordenadas.X == 0 && coordenadas.Y == 8)
                {
                    NaoAceitoCoords[1, 0, 0, 2] = 1;
                    return NaoAceitoCoords;
                }
                else if (coordenadas.X == 9 && coordenadas.Y == 1)
                {
                    NaoAceitoCoords[0, 1, 2, 0] = 1;
                    return NaoAceitoCoords;
                }
                else if (coordenadas.X == 9 && coordenadas.Y == 8)
                {
                    NaoAceitoCoords[0, 1, 0, 2] = 1;
                    return NaoAceitoCoords;
                }
                else if (coordenadas.X == 1 && coordenadas.Y == 0)
                {
                    NaoAceitoCoords[2, 0, 1, 0] = 1;
                    return NaoAceitoCoords;
                }
                else if (coordenadas.X == 8 && coordenadas.Y == 0)
                {
                    NaoAceitoCoords[0, 2, 1, 0] = 1;
                    return NaoAceitoCoords;
                }
                else if (coordenadas.X == 1 && coordenadas.Y == 9)
                {
                    NaoAceitoCoords[2, 0, 0, 1] = 1;
                    return NaoAceitoCoords;
                }
                else if (coordenadas.X == 8 && coordenadas.Y == 9)
                {
                    NaoAceitoCoords[0, 2, 0, 1] = 1;
                    return NaoAceitoCoords;
                }
                else if (coordenadas.X == 8 && coordenadas.Y == 8)
                {
                    NaoAceitoCoords[0, 2, 0, 2] = 1;
                    return NaoAceitoCoords;
                }
                else if (coordenadas.X == 1 && coordenadas.Y == 1)
                {
                    NaoAceitoCoords[2, 0, 2, 0] = 1;
                    return NaoAceitoCoords;
                }
                else if (coordenadas.X == 1 && coordenadas.Y == 8)
                {
                    NaoAceitoCoords[2, 0, 0, 2] = 1;
                    return NaoAceitoCoords;
                }
                else if (coordenadas.X == 8 && coordenadas.Y == 1)
                {
                    NaoAceitoCoords[0, 2, 2, 0] = 1;
                    return NaoAceitoCoords;
                }
            }
            else if (coordenadas.X == 0)
            {
                NaoAceitoCoords[1, 0, 0, 0] = 1;
                return NaoAceitoCoords;
            }
            else if (coordenadas.X == 9)
            {
                NaoAceitoCoords[0, 1, 0, 0] = 1;
                return NaoAceitoCoords;
            }
            else if (coordenadas.Y == 0)
            {
                NaoAceitoCoords[0, 0, 1, 0] = 1;
                return NaoAceitoCoords;
            }
            else if (coordenadas.Y == 9)
            {
                NaoAceitoCoords[0, 0, 0, 1] = 1;
                return NaoAceitoCoords;
            }
            else if (RaioDois == true)
            {
                if (coordenadas.X == 1)
                {
                    NaoAceitoCoords[2, 0, 0, 0] = 1;
                    return NaoAceitoCoords;
                }
                else if (coordenadas.X == 8)
                {
                    NaoAceitoCoords[0, 2, 0, 0] = 1;
                    return NaoAceitoCoords;
                }
                else if (coordenadas.Y == 1)
                {
                    NaoAceitoCoords[0, 0, 2, 0] = 1;
                    return NaoAceitoCoords;
                }
                else if (coordenadas.Y == 8)
                {
                    NaoAceitoCoords[0, 0, 0, 2] = 1;
                    return NaoAceitoCoords;
                }
            }
            NaoAceitoCoords[0, 0, 0, 0] = 1;
                return NaoAceitoCoords;//aceita tudo
        }//método para não deixar disparar para além das bordas da grelha
        
        public Coordenadas EscolherDirecao(int[,,,] NaoAceitoCoords)//aleatoriamente escolhe uma direção(norte sul este oeste) depende do que se acertou e se há possibilidade ou se já não está marcardo
        {
            Coordenadas C = new Coordenadas();

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
            else if (NaoAceitoCoords[1, 0, 0, 1] == 1)
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
            else if (NaoAceitoCoords[0, 1, 1, 0] == 1)
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
            else if (NaoAceitoCoords[0, 1, 0, 1] == 1)
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
            else if (NaoAceitoCoords[1, 0, 0, 0] == 1)
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
            else if (NaoAceitoCoords[0, 1, 0, 0] == 1)
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
            else if (NaoAceitoCoords[0, 0, 1, 0] == 1)
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
            else if (NaoAceitoCoords[0, 0, 0, 1] == 1)
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
            else if (NaoAceitoCoords[0, 0, 0, 0] == 1)
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

        public Coordenadas VerificarEDecidirTerceiroTiro(int[,] Grelha, Coordenadas CoordAFocar,int NrDeCanos)
        {
            bool CoordValida = false;

            int[,,,] NaoAceitoCoords = VerificarBordas(CoordAFocar, false);

            Coordenadas Coord = new Coordenadas();

            Coordenadas CoordFinal = new Coordenadas();

            if (NaoAceitoCoords[1, 0, 1, 0] == 1)
            {
                if (Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == NrDeCanos)
                {
                    Coord.X = Coord.X + 1;
                    CoordFinal = DirecaoTerceiroTiro(Coord.X - CoordAFocar.X, Coord.Y - CoordAFocar.Y, CoordAFocar, Grelha);
                    CoordValida = true;
                }
                if (Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == NrDeCanos)
                {
                    Coord.Y = Coord.Y + 1;
                    CoordFinal = DirecaoTerceiroTiro(Coord.X - CoordAFocar.X, Coord.Y - CoordAFocar.Y, CoordAFocar, Grelha);
                    CoordValida = true;
                }
            }
            else if (NaoAceitoCoords[1, 0, 0, 1] == 1)
            {
                if (Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == NrDeCanos)
                {
                    Coord.X = Coord.X + 1;
                    CoordFinal = DirecaoTerceiroTiro(Coord.X - CoordAFocar.X, Coord.Y - CoordAFocar.Y, CoordAFocar, Grelha);
                    CoordValida = true;
                }
                if (Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == NrDeCanos)
                {
                    Coord.Y = Coord.Y - 1;
                    CoordFinal = DirecaoTerceiroTiro(Coord.X - CoordAFocar.X, Coord.Y - CoordAFocar.Y, CoordAFocar, Grelha);
                    CoordValida = true;
                }
            }
            else if (NaoAceitoCoords[0, 1, 1, 0] == 1)
            {
                if (Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == NrDeCanos)
                {
                    Coord.X = Coord.X - 1;
                    CoordFinal = DirecaoTerceiroTiro(Coord.X - CoordAFocar.X, Coord.Y - CoordAFocar.Y, CoordAFocar, Grelha);
                    CoordValida = true;
                }
                if (Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == NrDeCanos)
                {
                    Coord.Y = Coord.Y + 1;
                    CoordFinal = DirecaoTerceiroTiro(Coord.X - CoordAFocar.X, Coord.Y - CoordAFocar.Y, CoordAFocar, Grelha);
                    CoordValida = true;
                }
            }
            else if (NaoAceitoCoords[0, 1, 0, 1] == 1)
            {
                if (Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == NrDeCanos)
                {
                    Coord.X = Coord.X - 1;
                    CoordFinal = DirecaoTerceiroTiro(Coord.X - CoordAFocar.X, Coord.Y - CoordAFocar.Y, CoordAFocar, Grelha);
                    CoordValida = true;
                }
                if (Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == NrDeCanos)
                {
                    Coord.Y = Coord.Y - 1;
                    CoordFinal = DirecaoTerceiroTiro(Coord.X - CoordAFocar.X, Coord.Y - CoordAFocar.Y, CoordAFocar, Grelha);
                    CoordValida = true;
                }
            }
            else if (NaoAceitoCoords[1, 0, 0, 0] == 1)
            {
                if (Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == NrDeCanos)
                {
                    Coord.X = Coord.X + 1;
                    CoordFinal = DirecaoTerceiroTiro(Coord.X - CoordAFocar.X, Coord.Y - CoordAFocar.Y, CoordAFocar, Grelha);
                    CoordValida = true;
                }
                if (Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == NrDeCanos)
                {
                    Coord.Y = Coord.Y + 1;
                    CoordFinal = DirecaoTerceiroTiro(Coord.X - CoordAFocar.X, Coord.Y - CoordAFocar.Y, CoordAFocar, Grelha);
                    CoordValida = true;
                }
                if (Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == NrDeCanos)
                {
                    Coord.Y = Coord.Y - 1;
                    CoordFinal = DirecaoTerceiroTiro(Coord.X - CoordAFocar.X, Coord.Y - CoordAFocar.Y, CoordAFocar, Grelha);
                    CoordValida = true;
                }
            }
            else if (NaoAceitoCoords[0, 1, 0, 0] == 1)
            {
                if (Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == NrDeCanos)
                {
                    Coord.X = Coord.X - 1;
                    CoordFinal = DirecaoTerceiroTiro(Coord.X - CoordAFocar.X, Coord.Y - CoordAFocar.Y, CoordAFocar, Grelha);
                    CoordValida = true;
                }
                if (Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == NrDeCanos)
                {
                    Coord.Y = Coord.Y + 1;
                    CoordFinal = DirecaoTerceiroTiro(Coord.X - CoordAFocar.X, Coord.Y - CoordAFocar.Y, CoordAFocar, Grelha);
                    CoordValida = true;
                }
                if (Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == NrDeCanos)
                {
                    Coord.Y = Coord.Y - 1;
                    CoordFinal = DirecaoTerceiroTiro(Coord.X - CoordAFocar.X, Coord.Y - CoordAFocar.Y, CoordAFocar, Grelha);
                    CoordValida = true;
                }
            }
            else if (NaoAceitoCoords[0, 0, 1, 0] == 1)
            {
                if (Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == NrDeCanos)
                {
                    Coord.X = Coord.X + 1;
                    CoordFinal = DirecaoTerceiroTiro(Coord.X - CoordAFocar.X, Coord.Y - CoordAFocar.Y, CoordAFocar, Grelha);
                    CoordValida = true;
                }
                if (Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == NrDeCanos)
                {
                    Coord.X = Coord.X - 1;
                    CoordFinal = DirecaoTerceiroTiro(Coord.X - CoordAFocar.X, Coord.Y - CoordAFocar.Y, CoordAFocar, Grelha);
                    CoordValida = true;
                }
                if (Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == NrDeCanos)
                {
                    Coord.Y = Coord.Y + 1;
                    CoordFinal = DirecaoTerceiroTiro(Coord.X - CoordAFocar.X, Coord.Y - CoordAFocar.Y, CoordAFocar, Grelha);
                    CoordValida = true;
                }
            }
            else if (NaoAceitoCoords[0, 0, 0, 1] == 1)
            {
                if (Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == NrDeCanos)
                {
                    Coord.X = Coord.X + 1;
                    CoordFinal = DirecaoTerceiroTiro(Coord.X - CoordAFocar.X, Coord.Y - CoordAFocar.Y, CoordAFocar, Grelha);
                    CoordValida = true;
                }
                if (Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == NrDeCanos)
                {
                    Coord.X = Coord.X - 1;
                    CoordFinal = DirecaoTerceiroTiro(Coord.X - CoordAFocar.X, Coord.Y - CoordAFocar.Y, CoordAFocar, Grelha);
                    CoordValida = true;
                }
                if (Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == NrDeCanos)
                {
                    Coord.Y = Coord.Y - 1;
                    CoordFinal = DirecaoTerceiroTiro(Coord.X - CoordAFocar.X, Coord.Y - CoordAFocar.Y, CoordAFocar, Grelha);
                    CoordValida = true;
                }
            }
            else if (NaoAceitoCoords[0, 0, 0, 0] == 1)
            {
                if (Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == NrDeCanos)
                {
                    Coord.X = Coord.X + 1;
                    CoordFinal = DirecaoTerceiroTiro(Coord.X - CoordAFocar.X, Coord.Y - CoordAFocar.Y, CoordAFocar, Grelha);
                    CoordValida = true;
                }
                if (Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == NrDeCanos)
                {
                    Coord.X = Coord.X - 1;
                    CoordFinal = DirecaoTerceiroTiro(Coord.X - CoordAFocar.X, Coord.Y - CoordAFocar.Y, CoordAFocar, Grelha);
                    CoordValida = true;
                }
                if (Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == NrDeCanos)
                {
                    Coord.Y = Coord.Y + 1;
                    CoordFinal = DirecaoTerceiroTiro(Coord.X - CoordAFocar.X, Coord.Y - CoordAFocar.Y, CoordAFocar, Grelha);
                    CoordValida = true;
                }
                if (Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == NrDeCanos)
                {
                    Coord.Y = Coord.Y - 1;
                    CoordFinal = DirecaoTerceiroTiro(Coord.X - CoordAFocar.X, Coord.Y - CoordAFocar.Y, CoordAFocar, Grelha);
                    CoordValida = true;
                }
            }
            if (CoordValida == true)
            {
                return CoordFinal;
            }
            else
            {
                return null;
            }
        }//o que faz se o ultimo tiro acertou num barco de 3 canos sabendo que já acertou 2 quadrados nesse barco
        
        public Coordenadas QuartoTiro4Canos(int[,] Grelha, Coordenadas CoordAFocar)//o que faz se o ultimo tiro acertou num barco de 4 canos sabendo que já acertou 3 quadrados nesse barco
        {
            bool Acertou = false;

            int[,,,] NaoAceitoCoords = VerificarBordas(CoordAFocar, true);

            Coordenadas C = new Coordenadas();
            C.CopiarValores(CoordAFocar);

            if (NaoAceitoCoords[1, 0, 1, 0] == 1)
            {
                if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 2, CoordAFocar.Y] == 4)//verifica se tem os 3 pontos do barco senao retorna null
                {
                    if (CoordAFocar.X == 0) //se for ao pé de uma das bordas apenas pode selecionar o outro lado
                    {
                        C.X = CoordAFocar.X + 3;
                    }
                    else if (CoordAFocar.X == 7)// por isso meto este codigo
                    {
                        C.X = CoordAFocar.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);// senao seleciona aleatoriamento neste caso esquerda ou direita
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 3;
                            if (Grelha[C.X, C.Y] != -1)// mas verifica se a cordenada que selecionou nao está marcada ou se já se disparou lá
                            {
                                C.X = CoordAFocar.X - 1;//faz isto
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 3;
                            }
                        }

                    }
                    Acertou = true;
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 2] == 4)
                {
                    if (CoordAFocar.Y == 0)
                    {
                        C.Y = CoordAFocar.Y + 3;
                    }
                    else if (CoordAFocar.Y == 7)
                    {
                        C.Y = CoordAFocar.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 3;
                            }
                        }

                    }
                    Acertou = true;
                }
            }
            else if (NaoAceitoCoords[1, 0, 0, 1] == 1)
            {
                if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 2, CoordAFocar.Y] == 4)
                {
                    if (CoordAFocar.X == 2)
                    {
                        C.X = CoordAFocar.X + 1;
                    }
                    else if (CoordAFocar.X == 9)
                    {
                        C.X = CoordAFocar.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 3;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 1;
                            }
                        }

                    }
                    Acertou = true;
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 2] == 4)
                {
                    if (CoordAFocar.Y == 0)
                    {
                        C.Y = CoordAFocar.Y + 3;
                    }
                    else if (CoordAFocar.Y == 7)
                    {
                        C.Y = CoordAFocar.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 3;
                            }
                        }

                    }
                    Acertou = true;
                }
            }
            else if (NaoAceitoCoords[0, 1, 1, 0] == 1)
            {
                if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 2, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 0)
                    {
                        C.X = CoordAFocar.X + 3;
                    }
                    else if (CoordAFocar.X == 7)
                    {
                        C.X = CoordAFocar.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 1;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 3;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 2] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 2)
                    {
                        C.Y = CoordAFocar.Y + 1;
                    }
                    else if (CoordAFocar.Y == 9)
                    {
                        C.Y = CoordAFocar.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 1;
                            }
                        }

                    }
                }
            }
            else if (NaoAceitoCoords[0, 1, 0, 1] == 1)
            {
                if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 2, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 2)
                    {
                        C.X = CoordAFocar.X + 1;
                    }
                    else if (CoordAFocar.X == 9)
                    {
                        C.X = CoordAFocar.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 3;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 1;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 2] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 2)
                    {
                        C.Y = CoordAFocar.Y + 1;
                    }
                    else if (CoordAFocar.Y == 9)
                    {
                        C.Y = CoordAFocar.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 1;
                            }
                        }

                    }
                }
            }
            //2 radius inicio
            else if (NaoAceitoCoords[1, 0, 2, 0] == 1)
            {
                if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 2, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 0)
                    {
                        C.X = CoordAFocar.X + 3;
                    }
                    else if (CoordAFocar.X == 7)
                    {
                        C.X = CoordAFocar.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 1;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 3;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 2] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 0)
                    {
                        C.Y = CoordAFocar.Y + 3;
                    }
                    else if (CoordAFocar.Y == 7)
                    {
                        C.Y = CoordAFocar.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 3;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 1)
                    {
                        C.Y = CoordAFocar.Y + 2;
                    }
                    else if (CoordAFocar.Y == 8)
                    {
                        C.Y = CoordAFocar.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 2;
                            }
                        }

                    }
                }
            }
            else if (NaoAceitoCoords[1, 0, 0, 2] == 1)
            {
                if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 2, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 0)
                    {
                        C.X = CoordAFocar.X + 3;
                    }
                    else if (CoordAFocar.X == 7)
                    {
                        C.X = CoordAFocar.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 1;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 3;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 1)
                    {
                        C.Y = CoordAFocar.Y + 2;
                    }
                    else if (CoordAFocar.Y == 8)
                    {
                        C.Y = CoordAFocar.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 2;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 2] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 2)
                    {
                        C.Y = CoordAFocar.Y + 1;
                    }
                    else if (CoordAFocar.Y == 9)
                    {
                        C.Y = CoordAFocar.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 1;
                            }
                        }

                    }
                }
            }
            else if (NaoAceitoCoords[0, 1, 2, 0] == 1)
            {
                if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 2, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 2)
                    {
                        C.X = CoordAFocar.X + 1;
                    }
                    else if (CoordAFocar.X == 9)
                    {
                        C.X = CoordAFocar.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 3;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 1;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 2] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 0)
                    {
                        C.Y = CoordAFocar.Y + 3;
                    }
                    else if (CoordAFocar.Y == 7)
                    {
                        C.Y = CoordAFocar.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 3;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 1)
                    {
                        C.Y = CoordAFocar.Y + 2;
                    }
                    else if (CoordAFocar.Y == 8)
                    {
                        C.Y = CoordAFocar.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 2;
                            }
                        }

                    }
                }
            }
            else if (NaoAceitoCoords[0, 1, 0, 2] == 1)
            {
                if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 2, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 2)
                    {
                        C.X = CoordAFocar.X + 1;
                    }
                    else if (CoordAFocar.X == 9)
                    {
                        C.X = CoordAFocar.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 3;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 1;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 1)
                    {
                        C.Y = CoordAFocar.Y + 2;
                    }
                    else if (CoordAFocar.Y == 8)
                    {
                        C.Y = CoordAFocar.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 2;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 2] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 2)
                    {
                        C.Y = CoordAFocar.Y + 1;
                    }
                    else if (CoordAFocar.Y == 9)
                    {
                        C.Y = CoordAFocar.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 1;
                            }
                        }

                    }
                }
            }
            else if (NaoAceitoCoords[2, 0, 1, 0] == 1)
            {
                if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 2, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 0)
                    {
                        C.X = CoordAFocar.X + 3;
                    }
                    else if (CoordAFocar.X == 7)
                    {
                        C.X = CoordAFocar.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 1;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 3;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 1)
                    {
                        C.X = CoordAFocar.X + 2;
                    }
                    else if (CoordAFocar.X == 8)
                    {
                        C.X = CoordAFocar.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 2;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 2] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 0)
                    {
                        C.Y = CoordAFocar.Y + 3;
                    }
                    else if (CoordAFocar.Y == 7)
                    {
                        C.Y = CoordAFocar.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 3;
                            }
                        }

                    }
                }
            }
            else if (NaoAceitoCoords[0, 2, 1, 0] == 1)
            {
                if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 1)
                    {
                        C.X = CoordAFocar.X + 2;
                    }
                    else if (CoordAFocar.X == 8)
                    {
                        C.X = CoordAFocar.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 2;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 2, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 2)
                    {
                        C.X = CoordAFocar.X + 1;
                    }
                    else if (CoordAFocar.X == 9)
                    {
                        C.X = CoordAFocar.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 3;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 1;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 2] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 0)
                    {
                        C.Y = CoordAFocar.Y + 3;
                    }
                    else if (CoordAFocar.Y == 7)
                    {
                        C.Y = CoordAFocar.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 3;
                            }
                        }

                    }
                }
            }
            else if (NaoAceitoCoords[2, 0, 0, 1] == 1)
            {
                if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 2, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 0)
                    {
                        C.X = CoordAFocar.X + 3;
                    }
                    else if (CoordAFocar.X == 7)
                    {
                        C.X = CoordAFocar.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 1;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 3;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 1)
                    {
                        C.X = CoordAFocar.X + 2;
                    }
                    else if (CoordAFocar.X == 8)
                    {
                        C.X = CoordAFocar.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 2;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 2] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 2)
                    {
                        C.Y = CoordAFocar.Y + 1;
                    }
                    else if (CoordAFocar.Y == 9)
                    {
                        C.Y = CoordAFocar.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 1;
                            }
                        }

                    }
                }
            }
            else if (NaoAceitoCoords[0, 2, 0, 1] == 1)
            {
                Acertou = true;
                if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4)
                {
                    if (CoordAFocar.X == 1)
                    {
                        C.X = CoordAFocar.X + 2;
                    }
                    else if (CoordAFocar.X == 8)
                    {
                        C.X = CoordAFocar.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 2;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 2, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 2)
                    {
                        C.X = CoordAFocar.X + 1;
                    }
                    else if (CoordAFocar.X == 9)
                    {
                        C.X = CoordAFocar.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 3;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 1;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 2] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 2)
                    {
                        C.Y = CoordAFocar.Y + 1;
                    }
                    else if (CoordAFocar.Y == 9)
                    {
                        C.Y = CoordAFocar.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 1;
                            }
                        }

                    }
                }
            }
            else if (NaoAceitoCoords[0, 2, 0, 2] == 1)
            {
                Acertou = true;
                if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4)
                {
                    if (CoordAFocar.X == 1)
                    {
                        C.X = CoordAFocar.X + 2;
                    }
                    else if (CoordAFocar.X == 8)
                    {
                        C.X = CoordAFocar.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 2;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 2, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 2)
                    {
                        C.X = CoordAFocar.X + 1;
                    }
                    else if (CoordAFocar.X == 9)
                    {
                        C.X = CoordAFocar.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 3;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 1;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 1)
                    {
                        C.Y = CoordAFocar.Y + 2;
                    }
                    else if (CoordAFocar.Y == 8)
                    {
                        C.Y = CoordAFocar.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 2;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 2] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 2)
                    {
                        C.Y = CoordAFocar.Y + 1;
                    }
                    else if (CoordAFocar.Y == 9)
                    {
                        C.Y = CoordAFocar.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 1;
                            }
                        }

                    }
                }
            }
            else if (NaoAceitoCoords[2, 0, 2, 0] == 1)
            {
                if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 2, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 0)
                    {
                        C.X = CoordAFocar.X + 3;
                    }
                    else if (CoordAFocar.X == 7)
                    {
                        C.X = CoordAFocar.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 1;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 3;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 1)
                    {
                        C.X = CoordAFocar.X + 2;
                    }
                    else if (CoordAFocar.X == 8)
                    {
                        C.X = CoordAFocar.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 2;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 2] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 0)
                    {
                        C.Y = CoordAFocar.Y + 3;
                    }
                    else if (CoordAFocar.Y == 7)
                    {
                        C.Y = CoordAFocar.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 3;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 1)
                    {
                        C.Y = CoordAFocar.Y + 2;
                    }
                    else if (CoordAFocar.Y == 8)
                    {
                        C.Y = CoordAFocar.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 2;
                            }
                        }

                    }
                }
            }
            else if (NaoAceitoCoords[2, 0, 0, 2] == 1)
            {
                Acertou = true;
                if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 2, CoordAFocar.Y] == 4)
                {
                    if (CoordAFocar.X == 0)
                    {
                        C.X = CoordAFocar.X + 3;
                    }
                    else if (CoordAFocar.X == 7)
                    {
                        C.X = CoordAFocar.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 1;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 3;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 1)
                    {
                        C.X = CoordAFocar.X + 2;
                    }
                    else if (CoordAFocar.X == 8)
                    {
                        C.X = CoordAFocar.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 2;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 1)
                    {
                        C.Y = CoordAFocar.Y + 2;
                    }
                    else if (CoordAFocar.Y == 8)
                    {
                        C.Y = CoordAFocar.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 2;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 2] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 2)
                    {
                        C.Y = CoordAFocar.Y + 1;
                    }
                    else if (CoordAFocar.Y == 9)
                    {
                        C.Y = CoordAFocar.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 1;
                            }
                        }

                    }
                }
            }
            else if (NaoAceitoCoords[0, 2, 2, 0] == 1)
            {
                if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 1)
                    {
                        C.X = CoordAFocar.X + 2;
                    }
                    else if (CoordAFocar.X == 8)
                    {
                        C.X = CoordAFocar.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 2;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 2, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 2)
                    {
                        C.X = CoordAFocar.X + 1;
                    }
                    else if (CoordAFocar.X == 9)
                    {
                        C.X = CoordAFocar.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 3;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 1;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 2] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 0)
                    {
                        C.Y = CoordAFocar.Y + 3;
                    }
                    else if (CoordAFocar.Y == 7)
                    {
                        C.Y = CoordAFocar.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 3;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 1)
                    {
                        C.Y = CoordAFocar.Y + 2;
                    }
                    else if (CoordAFocar.Y == 8)
                    {
                        C.Y = CoordAFocar.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 2;
                            }
                        }

                    }
                }
            }
            //2 radius fim
            else if (NaoAceitoCoords[1, 0, 0, 0] == 1)
            {
                if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 2, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 0)
                    {
                        C.X = CoordAFocar.X + 3;
                    }
                    else if (CoordAFocar.X == 7)
                    {
                        C.X = CoordAFocar.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 1;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 3;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 2] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 0)
                    {
                        C.Y = CoordAFocar.Y + 3;
                    }
                    else if (CoordAFocar.Y == 7)
                    {
                        C.Y = CoordAFocar.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 3;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 1)
                    {
                        C.Y = CoordAFocar.Y + 2;
                    }
                    else if (CoordAFocar.Y == 8)
                    {
                        C.Y = CoordAFocar.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 2;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 2] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 2)
                    {
                        C.Y = CoordAFocar.Y + 1;
                    }
                    else if (CoordAFocar.Y == 9)
                    {
                        C.Y = CoordAFocar.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 1;
                            }
                        }

                    }
                }
            }
            else if (NaoAceitoCoords[0, 1, 0, 0] == 1)
            {
                Acertou = true;
                if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 2, CoordAFocar.Y] == 4)
                {
                    if (CoordAFocar.X == 2)
                    {
                        C.X = CoordAFocar.X + 1;
                    }
                    else if (CoordAFocar.X == 9)
                    {
                        C.X = CoordAFocar.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 3;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 1;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 2] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 0)
                    {
                        C.Y = CoordAFocar.Y + 3;
                    }
                    else if (CoordAFocar.Y == 7)
                    {
                        C.Y = CoordAFocar.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 3;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 1)
                    {
                        C.Y = CoordAFocar.Y + 2;
                    }
                    else if (CoordAFocar.Y == 8)
                    {
                        C.Y = CoordAFocar.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 2;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 2] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 2)
                    {
                        C.Y = CoordAFocar.Y + 1;
                    }
                    else if (CoordAFocar.Y == 9)
                    {
                        C.Y = CoordAFocar.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 1;
                            }
                        }

                    }
                }
            }
            else if (NaoAceitoCoords[0, 0, 1, 0] == 1)
            {
                if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 2, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 0)
                    {
                        C.X = CoordAFocar.X + 3;
                    }
                    else if (CoordAFocar.X == 7)
                    {
                        C.X = CoordAFocar.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 1;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 3;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 1)
                    {
                        C.X = CoordAFocar.X + 2;
                    }
                    else if (CoordAFocar.X == 8)
                    {
                        C.X = CoordAFocar.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 2;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 2, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 2)
                    {
                        C.X = CoordAFocar.X + 1;
                    }
                    else if (CoordAFocar.X == 9)
                    {
                        C.X = CoordAFocar.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 3;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 1;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 2] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 0)
                    {
                        C.Y = CoordAFocar.Y + 3;
                    }
                    else if (CoordAFocar.Y == 7)
                    {
                        C.Y = CoordAFocar.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 3;
                            }
                        }

                    }
                }
            }
            else if (NaoAceitoCoords[0, 0, 0, 1] == 1)
            {
                if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 2, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 0)
                    {
                        C.X = CoordAFocar.X + 3;
                    }
                    else if (CoordAFocar.X == 7)
                    {
                        C.X = CoordAFocar.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 1;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 3;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 1)
                    {
                        C.X = CoordAFocar.X + 2;
                    }
                    else if (CoordAFocar.X == 8)
                    {
                        C.X = CoordAFocar.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 2;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 2, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 2)
                    {
                        C.X = CoordAFocar.X + 1;
                    }
                    else if (CoordAFocar.X == 9)
                    {
                        C.X = CoordAFocar.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 3;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 1;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 2] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 2)
                    {
                        C.Y = CoordAFocar.Y + 1;
                    }
                    else if (CoordAFocar.Y == 9)
                    {
                        C.Y = CoordAFocar.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 1;
                            }
                        }

                    }
                }
            }
            //2 radius inicio
            else if (NaoAceitoCoords[2, 0, 0, 0] == 1)
            {
                if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 2, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 0)
                    {
                        C.X = CoordAFocar.X + 3;
                    }
                    else if (CoordAFocar.X == 7)
                    {
                        C.X = CoordAFocar.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 1;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 3;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 1)
                    {
                        C.X = CoordAFocar.X + 2;
                    }
                    else if (CoordAFocar.X == 8)
                    {
                        C.X = CoordAFocar.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 2;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 2] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 0)
                    {
                        C.Y = CoordAFocar.Y + 3;
                    }
                    else if (CoordAFocar.Y == 7)
                    {
                        C.Y = CoordAFocar.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 3;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 1)
                    {
                        C.Y = CoordAFocar.Y + 2;
                    }
                    else if (CoordAFocar.Y == 8)
                    {
                        C.Y = CoordAFocar.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 2;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 2] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 2)
                    {
                        C.Y = CoordAFocar.Y + 1;
                    }
                    else if (CoordAFocar.Y == 9)
                    {
                        C.Y = CoordAFocar.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 1;
                            }
                        }

                    }
                }
            }
            else if (NaoAceitoCoords[0, 2, 0, 0] == 1)
            {
                if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 1)
                    {
                        C.X = CoordAFocar.X + 2;
                    }
                    else if (CoordAFocar.X == 8)
                    {
                        C.X = CoordAFocar.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 2;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 2, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 2)
                    {
                        C.X = CoordAFocar.X + 1;
                    }
                    else if (CoordAFocar.X == 9)
                    {
                        C.X = CoordAFocar.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 3;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 1;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 2] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 0)
                    {
                        C.Y = CoordAFocar.Y + 3;
                    }
                    else if (CoordAFocar.Y == 7)
                    {
                        C.Y = CoordAFocar.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 3;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 1)
                    {
                        C.Y = CoordAFocar.Y + 2;
                    }
                    else if (CoordAFocar.Y == 8)
                    {
                        C.Y = CoordAFocar.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 2;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 2] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 2)
                    {
                        C.Y = CoordAFocar.Y + 1;
                    }
                    else if (CoordAFocar.Y == 9)
                    {
                        C.Y = CoordAFocar.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 1;
                            }
                        }

                    }
                }
            }
            else if (NaoAceitoCoords[0, 0, 2, 0] == 1)
            {
                if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 2, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 0)
                    {
                        C.X = CoordAFocar.X + 3;
                    }
                    else if (CoordAFocar.X == 7)
                    {
                        C.X = CoordAFocar.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 1;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 3;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 1)
                    {
                        C.X = CoordAFocar.X + 2;
                    }
                    else if (CoordAFocar.X == 8)
                    {
                        C.X = CoordAFocar.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 2;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 2, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 2)
                    {
                        C.X = CoordAFocar.X + 1;
                    }
                    else if (CoordAFocar.X == 9)
                    {
                        C.X = CoordAFocar.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 3;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 1;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 2] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 0)
                    {
                        C.Y = CoordAFocar.Y + 3;
                    }
                    else if (CoordAFocar.Y == 7)
                    {
                        C.Y = CoordAFocar.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 3;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 1)
                    {
                        C.Y = CoordAFocar.Y + 2;
                    }
                    else if (CoordAFocar.Y == 8)
                    {
                        C.Y = CoordAFocar.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 2;
                            }
                        }

                    }
                }
            }
            else if (NaoAceitoCoords[0, 0, 0, 2] == 1)
            {
                if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 2, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 0)
                    {
                        C.X = CoordAFocar.X + 3;
                    }
                    else if (CoordAFocar.X == 7)
                    {
                        C.X = CoordAFocar.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 1;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 3;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 1)
                    {
                        C.X = CoordAFocar.X + 2;
                    }
                    else if (CoordAFocar.X == 8)
                    {
                        C.X = CoordAFocar.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 2;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 2, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 2)
                    {
                        C.X = CoordAFocar.X + 1;
                    }
                    else if (CoordAFocar.X == 9)
                    {
                        C.X = CoordAFocar.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 3;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 1;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 1)
                    {
                        C.Y = CoordAFocar.Y + 2;
                    }
                    else if (CoordAFocar.Y == 8)
                    {
                        C.Y = CoordAFocar.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 2;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 2] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 2)
                    {
                        C.Y = CoordAFocar.Y + 1;
                    }
                    else if (CoordAFocar.Y == 9)
                    {
                        C.Y = CoordAFocar.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 1;
                            }
                        }

                    }
                }
            }
            //2 radius fim
            else if (NaoAceitoCoords[0, 0, 0, 0] == 1)
            {
                if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 2, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 0)
                    {
                        C.X = CoordAFocar.X + 3;
                    }
                    else if (CoordAFocar.X == 7)
                    {
                        C.X = CoordAFocar.X - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 1;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 3;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X + 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 1)
                    {
                        C.X = CoordAFocar.X + 2;
                    }
                    else if (CoordAFocar.X == 8)
                    {
                        C.X = CoordAFocar.X - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 2;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 2;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 1, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X - 2, CoordAFocar.Y] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.X == 2)
                    {
                        C.X = CoordAFocar.X + 1;
                    }
                    else if (CoordAFocar.X == 9)
                    {
                        C.X = CoordAFocar.X - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.X = CoordAFocar.X + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X - 3;
                            }
                        }
                        else
                        {
                            C.X = CoordAFocar.X - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.X = CoordAFocar.X + 1;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 2] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 0)
                    {
                        C.Y = CoordAFocar.Y + 3;
                    }
                    else if (CoordAFocar.Y == 7)
                    {
                        C.Y = CoordAFocar.Y - 1;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 1;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 3;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y + 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 1)
                    {
                        C.Y = CoordAFocar.Y + 2;
                    }
                    else if (CoordAFocar.Y == 8)
                    {
                        C.Y = CoordAFocar.Y - 2;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 2;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 2;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 2;
                            }
                        }

                    }
                }
                else if (Grelha[CoordAFocar.X, CoordAFocar.Y] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 1] == 4 && Grelha[CoordAFocar.X, CoordAFocar.Y - 2] == 4)
                {
                    Acertou = true;
                    if (CoordAFocar.Y == 2)
                    {
                        C.Y = CoordAFocar.Y + 1;
                    }
                    else if (CoordAFocar.Y == 9)
                    {
                        C.Y = CoordAFocar.Y - 3;
                    }
                    else
                    {
                        int aleatorio = rnr.Next(0, 2);
                        if (aleatorio == 0)
                        {
                            C.Y = CoordAFocar.Y + 1;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y - 3;
                            }
                        }
                        else
                        {
                            C.Y = CoordAFocar.Y - 3;
                            if (Grelha[C.X, C.Y] != -1)
                            {
                                C.Y = CoordAFocar.Y + 1;
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

        public Coordenadas PortaAvioes(int[,] Grelha, Coordenadas CoordAFocar)//1º verifica se já disparou a todas as coords nseo se já disparou em todas passa para um dos vizinhos que seja porta avioes senao dispara onde nao disparou
        {
            Coordenadas CoordFinal = new Coordenadas();
            CoordFinal.CopiarValores(CoordAFocar);
            int i = 0;
            while (i == 0)
            {

                int[,,,] NaoAceitoCoords = VerificarBordas(CoordFinal, false);

                if (NaoAceitoCoords[1, 0, 1, 0] == 1)
                {
                    if (Grelha[CoordFinal.X + 1, CoordFinal.Y] == -1)
                    {
                        CoordFinal.X++;
                        i++;
                    }
                    else if (Grelha[CoordFinal.X, CoordFinal.Y + 1] == -1)
                    {
                        CoordFinal.Y++;
                        i++;
                    }
                    else
                    {
                        int aleatorio;
                        int j = 0;
                        while (j == 0)
                        {
                            aleatorio = rnr.Next(0, 2);
                            if (aleatorio == 0 && Grelha[CoordFinal.X + 1, CoordFinal.Y] == 5)
                            {
                                CoordFinal.X++;
                                j++;
                            }
                            else if (aleatorio == 1 && Grelha[CoordFinal.X, CoordFinal.Y + 1] == 5)
                            {
                                CoordFinal.Y++;
                                j++;
                            }
                        }
                    }
                }
                else if (NaoAceitoCoords[1, 0, 0, 1] == 1)
                {
                    if (Grelha[CoordFinal.X + 1, CoordFinal.Y] == -1)
                    {
                        CoordFinal.X++;
                        i++;
                    }
                    else if (Grelha[CoordFinal.X, CoordFinal.Y - 1] == -1)
                    {
                        CoordFinal.Y--;
                        i++;
                    }
                    else
                    {
                        int aleatorio;
                        int j = 0;
                        while (j == 0)
                        {
                            aleatorio = rnr.Next(0, 2);
                            if (aleatorio == 0 && Grelha[CoordFinal.X + 1, CoordFinal.Y] == 5)
                            {
                                CoordFinal.X++;
                                j++;
                            }
                            else if (aleatorio == 1 && Grelha[CoordFinal.X, CoordFinal.Y - 1] == 5)
                            {
                                CoordFinal.Y--;
                                j++;
                            }
                        }
                    }
                }
                else if (NaoAceitoCoords[0, 1, 1, 0] == 1)
                {
                    if (Grelha[CoordFinal.X - 1, CoordFinal.Y] == -1)
                    {
                        CoordFinal.X--;
                        i++;
                    }
                    else if (Grelha[CoordFinal.X, CoordFinal.Y + 1] == -1)
                    {
                        CoordFinal.Y++;
                        i++;
                    }
                    else
                    {
                        int aleatorio;
                        int j = 0;
                        while (j == 0)
                        {
                            aleatorio = rnr.Next(0, 2);
                            if (aleatorio == 0 && Grelha[CoordFinal.X - 1, CoordFinal.Y] == 5)
                            {
                                CoordFinal.X--;
                                j++;
                            }
                            else if (aleatorio == 1 && Grelha[CoordFinal.X, CoordFinal.Y + 1] == 5)
                            {
                                CoordFinal.Y++;
                                j++;
                            }
                        }
                    }
                }
                else if (NaoAceitoCoords[0, 1, 0, 1] == 1)
                {
                    if (Grelha[CoordFinal.X - 1, CoordFinal.Y] == -1)
                    {
                        CoordFinal.X--;
                        i++;
                    }
                    else if (Grelha[CoordFinal.X, CoordFinal.Y - 1] == -1)
                    {
                        CoordFinal.Y--;
                        i++;
                    }
                    else
                    {
                        int aleatorio;
                        int j = 0;
                        while (j == 0)
                        {
                            aleatorio = rnr.Next(0, 4);
                            if (aleatorio == 0 && Grelha[CoordFinal.X - 1, CoordFinal.Y] == 5)
                            {
                                CoordFinal.X--;
                                j++;
                            }
                            else if (aleatorio == 1 && Grelha[CoordFinal.X, CoordFinal.Y - 1] == 5)
                            {
                                CoordFinal.Y--;
                                j++;
                            }
                        }
                    }
                }
                else if (NaoAceitoCoords[1, 0, 0, 0] == 1)
                {
                    if (Grelha[CoordFinal.X + 1, CoordFinal.Y] == -1)
                    {
                        CoordFinal.X++;
                        i++;
                    }
                    else if (Grelha[CoordFinal.X, CoordFinal.Y + 1] == -1)
                    {
                        CoordFinal.Y++;
                        i++;
                    }
                    else if (Grelha[CoordFinal.X, CoordFinal.Y - 1] == -1)
                    {
                        CoordFinal.Y--;
                        i++;
                    }
                    else
                    {
                        int aleatorio;
                        int j = 0;
                        while (j == 0)
                        {
                            aleatorio = rnr.Next(0, 3);
                            if (aleatorio == 0 && Grelha[CoordFinal.X + 1, CoordFinal.Y] == 5)
                            {
                                CoordFinal.X++;
                                j++;
                            }
                            else if (aleatorio == 1 && Grelha[CoordFinal.X, CoordFinal.Y + 1] == 5)
                            {
                                CoordFinal.Y++;
                                j++;
                            }
                            else if (aleatorio == 2 && Grelha[CoordFinal.X, CoordFinal.Y - 1] == 5)
                            {
                                CoordFinal.Y--;
                                j++;
                            }
                        }
                    }
                }
                else if (NaoAceitoCoords[0, 1, 0, 0] == 1)
                {
                    if (Grelha[CoordFinal.X - 1, CoordFinal.Y] == -1)
                    {
                        CoordFinal.X--;
                        i++;
                    }
                    else if (Grelha[CoordFinal.X, CoordFinal.Y + 1] == -1)
                    {
                        CoordFinal.Y++;
                        i++;
                    }
                    else if (Grelha[CoordFinal.X, CoordFinal.Y - 1] == -1)
                    {
                        CoordFinal.Y--;
                        i++;
                    }
                    else
                    {
                        int aleatorio;
                        int j = 0;
                        while (j == 0)
                        {
                            aleatorio = rnr.Next(0, 3);
                            if (aleatorio == 0 && Grelha[CoordFinal.X - 1, CoordFinal.Y] == 5)
                            {
                                CoordFinal.X--;
                                j++;
                            }
                            else if (aleatorio == 1 && Grelha[CoordFinal.X, CoordFinal.Y + 1] == 5)
                            {
                                CoordFinal.Y++;
                                j++;
                            }
                            else if (aleatorio == 2 && Grelha[CoordFinal.X, CoordFinal.Y - 1] == 5)
                            {
                                CoordFinal.Y--;
                                j++;
                            }
                        }
                    }
                }
                else if (NaoAceitoCoords[0, 0, 1, 0] == 1)
                {
                    if (Grelha[CoordFinal.X + 1, CoordFinal.Y] == -1)
                    {
                        CoordFinal.X++;
                        i++;
                    }
                    else if (Grelha[CoordFinal.X - 1, CoordFinal.Y] == -1)
                    {
                        CoordFinal.X--;
                        i++;
                    }
                    else if (Grelha[CoordFinal.X, CoordFinal.Y + 1] == -1)
                    {
                        CoordFinal.Y++;
                        i++;
                    }
                    else
                    {
                        int aleatorio;
                        int j = 0;
                        while (j == 0)
                        {
                            aleatorio = rnr.Next(0, 3);
                            if (aleatorio == 0 && Grelha[CoordFinal.X + 1, CoordFinal.Y] == 5)
                            {
                                CoordFinal.X++;
                                j++;
                            }
                            else if (aleatorio == 1 && Grelha[CoordFinal.X - 1, CoordFinal.Y] == 5)
                            {
                                CoordFinal.X--;
                                j++;
                            }
                            else if (aleatorio == 2 && Grelha[CoordFinal.X, CoordFinal.Y + 1] == 5)
                            {
                                CoordFinal.Y++;
                                j++;
                            }
                        }
                    }
                }
                else if (NaoAceitoCoords[0, 0, 0, 1] == 1)
                {
                    if (Grelha[CoordFinal.X + 1, CoordFinal.Y] == -1)
                    {
                        CoordFinal.X++;
                        i++;
                    }
                    else if (Grelha[CoordFinal.X - 1, CoordFinal.Y] == -1)
                    {
                        CoordFinal.X--;
                        i++;
                    }
                    else if (Grelha[CoordFinal.X, CoordFinal.Y - 1] == -1)
                    {
                        CoordFinal.Y--;
                        i++;
                    }
                    else
                    {
                        int aleatorio;
                        int j = 0;
                        while (j == 0)
                        {
                            aleatorio = rnr.Next(0, 3);
                            if (aleatorio == 0 && Grelha[CoordFinal.X + 1, CoordFinal.Y] == 5)
                            {
                                CoordFinal.X++;
                                j++;
                            }
                            else if (aleatorio == 1 && Grelha[CoordFinal.X - 1, CoordFinal.Y] == 5)
                            {
                                CoordFinal.X--;
                                j++;
                            }
                            else if (aleatorio == 2 && Grelha[CoordFinal.X, CoordFinal.Y - 1] == 5)
                            {
                                CoordFinal.Y--;
                                j++;
                            }
                        }
                    }
                }
                else if (NaoAceitoCoords[0, 0, 0, 0] == 1)
                {
                    if (Grelha[CoordFinal.X + 1, CoordFinal.Y] == -1)
                    {
                        CoordFinal.X++;
                        i++;
                    }
                    else if (Grelha[CoordFinal.X - 1, CoordFinal.Y] == -1)
                    {
                        CoordFinal.X--;
                        i++;
                    }
                    else if (Grelha[CoordFinal.X, CoordFinal.Y + 1] == -1)
                    {
                        CoordFinal.Y++;
                        i++;
                    }
                    else if (Grelha[CoordFinal.X, CoordFinal.Y - 1] == -1)
                    {
                        CoordFinal.Y--;
                        i++;
                    }
                    else
                    {
                        int aleatorio;
                        int j = 0;
                        while (j == 0)
                        {
                            aleatorio = rnr.Next(0, 4);
                            if (aleatorio == 0 && Grelha[CoordFinal.X + 1, CoordFinal.Y] == 5)
                            {
                                CoordFinal.X++;
                                j++;
                            }
                            else if (aleatorio == 1 && Grelha[CoordFinal.X - 1, CoordFinal.Y] == 5)
                            {
                                CoordFinal.X--;
                                j++;
                            }
                            else if (aleatorio == 2 && Grelha[CoordFinal.X, CoordFinal.Y + 1] == 5)
                            {
                                CoordFinal.Y++;
                                j++;
                            }
                            else if (aleatorio == 3 && Grelha[CoordFinal.X, CoordFinal.Y - 1] == 5)
                            {
                                CoordFinal.Y--;
                                j++;
                            }
                        }
                    }
                }
            }
            return CoordFinal;
        }

        public Coordenadas DirecaoTerceiroTiro(int X, int Y, Coordenadas Coordenadas, int[,] Grelha)
        {
            Coordenadas Coord = new Coordenadas();
            Coord.CopiarValores(Coordenadas);

            int Aleatorio = rnr.Next(0, 2);
            while (true)
            {
                if (X == -1)
                {
                    if (Aleatorio == 0)
                    {
                        if(Coord.X > 1)
                            Coord.X = Coord.X - 2;
                        else
                            Coord.X = Coord.X + 1;
                    }
                    else if (Aleatorio == 1)
                    {
                        Coord.X = Coord.X + 1;
                    }
                }
                else if (X == 1)
                {
                    if (Aleatorio == 0)
                    {
                        if (Coord.X < 8)
                            Coord.X = Coord.X + 2;
                        else
                            Coord.X = Coord.X - 1;
                    }
                    else if (Aleatorio == 1)
                    {
                        Coord.X = Coord.X - 1;
                    }
                }
                else if (Y == -1)
                {
                    if (Aleatorio == 0)
                    {
                        if(Coord.Y > 1)
                            Coord.Y = Coord.Y - 2;
                        else
                            Coord.Y = Coord.Y + 1;
                    }
                    else if (Aleatorio == 1)
                    {
                        Coord.Y = Coord.Y + 1;
                    }
                }
                else
                {
                    if (Aleatorio == 0)
                    {
                        if(Coord.Y < 8)
                            Coord.Y = Coord.Y + 2;
                        else
                            Coord.Y = Coord.Y - 1;
                    }
                    else if (Aleatorio == 1)
                    {
                        Coord.Y = Coord.Y - 1;
                    }
                }
                if (Coord.Y < 0 || Coord.Y > 9 || Coord.X < 0 || Coord.X > 9 || Grelha[Coord.X, Coord.Y] != -1)
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
                    break;
                }
            }
            return Coord;
        }//método para 3º tiro dos barcos de 3 e 4 canos(criei um metodo apenas para não haver repetição do codigo do mesmo)

        public int[,] MarcarAdjacentes(int[,] GrelhaMarcar, int Barco)
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

        public Coordenadas DisparoParaSegundoHit(Coordenadas CoordAFocar, int[,] Grelha)
        {
            Coordenadas NovaCoordenada = new Coordenadas();
            while (true)
            {
                int[,,,] NaoAceitoCoords = VerificarBordas(CoordAFocar, false);

                NovaCoordenada.CopiarValores(CoordAFocar);

                Coordenadas AdicionarValor = EscolherDirecao(NaoAceitoCoords);

                NovaCoordenada.X = NovaCoordenada.X + AdicionarValor.X;
                NovaCoordenada.Y = NovaCoordenada.Y + AdicionarValor.Y;

                if (Grelha[NovaCoordenada.X, NovaCoordenada.Y] == -1)
                {
                    return NovaCoordenada;
                }
            }
        }
    }
}
