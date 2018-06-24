using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BattleshipPRJ.Models
{
    public class Jogo : IComparable
    {
        private static int heidi = 0;

        [Required(ErrorMessage = "Por favor preenche o campo Nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor seleciona a missão pretendida!")]
        public string Missao { get; set; }

        public int ID { get; set; }

        public bool Gameover { get; set; }

        public int Misseis { get; set; }

        public int Score { get; set; }

        public int Portaavioesrestantes { get; set; }

        public int Quatrocanosrestantes { get; set; }

        public int Trescanosrestantes { get; set; }

        public int Doiscanosrestantes { get; set; }

        public int Submarinosrestantes { get; set; }

        public int Quadradosabater { get; set; }

        public int UltimoTiroDisparado { get; set; }

        public int NumeroDeJogadas { get; set; }

        public bool Barcoaofundo { get; set; }

        public bool TiroNaMesmaCoord { get; set; }

        public string ResultadoJogada { get; set; }

        public string FimdoJogo { get; set; }

        public int TirosDados { get; set; }

        public int TirosAgua { get; set; }

        public int TirosAlvo { get; set; }

        public int TirosRepetido { get; set; }

        public double PercentagemAlvo { get; set; }

        public double PercentagemAfundado { get; set; }

        public bool Desistir { get; set; }

        public int Bonus { get; set; }

        public int Coordx { get; set; }

        public int Coordy { get; set; }

        public bool ModoLocal { get; set; }

        public int LocalPortaAvioes { get; set; }

        public int Local4Canos { get; set; }

        public string MensagemJogoLocal { get; set; }

        //modo auto

        public int[,] GrelhaModoAuto { get; set; }

        public Coordenadas CoordsUltimoTiro { get; set; }

        public int UltimoBarcoAcertado { get; set; }

        public bool Afundou { get; set; }

        //modo auto

        public int NumeroDisparosAutonomo { get; set; }

        private List<RoundSummary> rss = new List<RoundSummary>();

        public List<RoundSummary> Rss
        {

            get
            {
                return rss;

            }
        }

        public void AddRoundSummary(RoundSummary rs)
        {
            Rss.Add(rs);
        }


        private int[,] grelha;



        public int[,] Grelha
        {
            get
            {
                return grelha;
            }

        }


        public string ReceberResult(Resultado result)
        {

            if (result == Resultado.SuccessHit)
            {
                return "Tiro num barco de ";
            }
            else if (result == Resultado.SuccessMiss)
            {
                return "O teu míssil foi perdido no mar!";
            }
            else if (result == Resultado.SuccessSink)
            {
                return "Afundaste um barco de ";
            }
            else if (result == Resultado.SuccessRepeat)
            {
                return "Foste penalizado em 100 pontos por disparar no mesmo quadrado.";
            }
            else if (result == Resultado.SuccessVictory)
            {
                return "Cumpriste a missão escolhida!";
            }
            else if (result == Resultado.InvalidShot)
            {
                return "Tiro Inválido!";
            }
            else if (result == Resultado.GameHasEnded)
            {
                return "Jogo acabou!";

            }
            else
            {
                return "Começa por disparar num quadrado!";
            }
        }

        public string AvisarMisseisRestantes()
        {
            if (Misseis < 6)
            {
                return " Restam-te " + Misseis;
            }
            else return null;
        }

        public void AlterarMissao()
        {
            if (Missao == "Antiaérea")
            {
                Misseis = 20;
                Quadradosabater = 5;

            }
            else
            {

                Misseis = 50;
                Quadradosabater = 25;

            }

        }

        public Jogo()
        {
            ModoLocal = false;

            heidi++;
            Score = 0;
            Bonus = -25;
            FimdoJogo = "Derrota";

            ID = heidi;
            MensagemJogoLocal = "Comece por disparar um míssil!";
            Gameover = false;

            Portaavioesrestantes = 1;
            Quatrocanosrestantes = 1;
            Trescanosrestantes = 2;
            Doiscanosrestantes = 3;
            Submarinosrestantes = 4;


            grelha = new int[10, 10]
            {
                //valores reservados:
                //-1=desconhecido (jogador não atirou aqui)
                //0=água; 1,2,3,4,5=barco de n canos
                //outros valores: não usados (pode definir o que quiser caso necessite)


                //nesta grelha de teste mostramos alguns quadrados marcados com água e outros com barcos
                //esta disposição não apareceria no jogo pois não há barcos de 4 canos com este formato
                { -1,-1,-1,-1,-1,-1,-1,-1,-1, -1},
                {-1, -1,-1,-1,-1,-1,-1,-1, -1,-1},
                {-1,-1, -1, -1, -1, -1, -1, -1,-1,-1},
                {-1,-1, -1,-1,-1,-1,-1, -1,-1,-1},
                {-1,-1, -1,-1, -1, -1,-1, -1,-1,-1},
                {-1,-1, -1,-1, -1, -1,-1, -1,-1,-1},
                {-1,-1, -1,-1,-1,-1,-1, -1,-1,-1},
                {-1,-1, -1, -1, -1, -1, -1, -1,-1,-1},
                {-1, -1,-1,-1,-1,-1,-1,-1, -1,-1},
                { -1,-1,-1,-1,-1,-1,-1,-1,-1, -1}
            };

            GrelhaModoAuto = new int[10, 10]
            {
                { -1,-1,-1,-1,-1,-1,-1,-1,-1, -1},
                {-1, -1,-1,-1,-1,-1,-1,-1, -1,-1},
                {-1,-1, -1, -1, -1, -1, -1, -1,-1,-1},
                {-1,-1, -1,-1,-1,-1,-1, -1,-1,-1},
                {-1,-1, -1,-1, -1, -1,-1, -1,-1,-1},
                {-1,-1, -1,-1, -1, -1,-1, -1,-1,-1},
                {-1,-1, -1,-1,-1,-1,-1, -1,-1,-1},
                {-1,-1, -1, -1, -1, -1, -1, -1,-1,-1},
                {-1, -1,-1,-1,-1,-1,-1,-1, -1,-1},
                { -1,-1,-1,-1,-1,-1,-1,-1,-1, -1}
            };

            UltimoBarcoAcertado = 0;
            Afundou = false;
            CoordsUltimoTiro = new Coordenadas();
        }

        public void Disparou(int BarcoAtingidoSize, bool ganho, bool BarcoAoFundo)
        {
            TirosDados++;
            Misseis = Misseis - 1;
            UltimoTiroDisparado = BarcoAtingidoSize;
            NumeroDeJogadas = NumeroDeJogadas + 1;
            if (BarcoAtingidoSize != 0)
            {
                TirosAlvo++;
                if (ganho == false)
                {
                    AdicionarJogada(true, BarcoAoFundo, false, false, 0);


                }
                else
                {
                    AdicionarJogada(true, BarcoAoFundo, false, true, Misseis);
                    if (Missao == "Antiaérea")
                    {
                        if (BarcoAtingidoSize == 5)
                        {
                            Quadradosabater = Quadradosabater - 1;
                        }
                    }
                    else
                    {
                        Quadradosabater = Quadradosabater - 1;
                    }
                }
            }
            else
            {
                TirosAgua++;
                AdicionarJogada(false, false, false, false, 0);
            }

            Barcoaofundo = BarcoAoFundo;
            CalcularPercentagens();
        }

        public void DisparouNasMesmasCoords()
        {
            TirosRepetido++;
            Misseis = Misseis - 1;
            NumeroDeJogadas = NumeroDeJogadas + 1;
            AdicionarJogada(false, false, true, false, 0);

            Barcoaofundo = false;
            CalcularPercentagens();
        }

        public void AtualizarArmadaInimiga(int shipsize)
        {
            if (shipsize == 1)
            {
                Submarinosrestantes--;
            }
            else if (shipsize == 2)
            {
                Doiscanosrestantes--;
            }
            else if (shipsize == 3)
            {
                Trescanosrestantes--;
            }
            else if (shipsize == 4)
            {
                Quatrocanosrestantes--;
            }
            else if (shipsize == 5)
            {
                Portaavioesrestantes--;
            }



        }

        public void CalcularPercentagens()
        {
            PercentagemAlvo = 100 * TirosAlvo / (double)TirosDados;

            PercentagemAlvo = Math.Round(PercentagemAlvo, 2);

            PercentagemAfundado = 100 - (100 * (Submarinosrestantes + Doiscanosrestantes + Trescanosrestantes + Quatrocanosrestantes + Portaavioesrestantes) / 11.0);

            PercentagemAfundado = Math.Round(PercentagemAfundado, 2);
        }

        public int CompareTo(object obj)
        {
            Jogo j2 = (Jogo)obj;

            if (j2.Score > Score)
                return 1;
            if (j2.Score == Score)
                return 0;
            return -1;


        }

        public bool ConfirmarDesistir(bool Confirmado)
        {
            if (Confirmado == true)
            {
                if (Desistir == true)
                {
                    return true;
                }
                else
                {
                    Desistir = true;
                    return false;
                }
            }
            else
            {
                Desistir = false;
                return false;
            }
        }


        public void AdicionarJogada(bool d_BarcoAtingido, bool d_BarcoAfundado, bool d_Penalizacao, bool d_Ganho, int d_Missseis)
        {

            if (d_BarcoAtingido == true)
            {

                if (Bonus < 100)
                {
                    Bonus = Bonus + 25;
                }
            }
            else
            {
                Bonus = -25;
            }

            if (d_BarcoAtingido == true)
            {
                Score = Score + 100 + Bonus;
            }
            if (d_BarcoAfundado == true)
            {
                Score = Score + 200;
            }
            if (d_Penalizacao == true)
            {
                Score = Score - 100;
            }
            if (d_Ganho == true)
            {
                Score = Score + 1000 + (d_Missseis * 250);
            }

        }




        public void AtualizarJogada(GameState gs, int opcaoY, int opcaoX)
        {
            if (gs.Result == Resultado.SuccessHit)
            {

                Grelha[opcaoY, opcaoX] = gs.DamagedShipSize;
                if (gs.DamagedShipSize == 1)
                {
                    ResultadoJogada = "Tiro num submarino!";

                }
                else if (gs.DamagedShipSize == 5)
                {
                    ResultadoJogada = "Tiro no porta-aviões!";

                }
                else
                {
                    ResultadoJogada = ReceberResult(gs.Result) + gs.DamagedShipSize + " canos!";
                }


                Disparou(gs.DamagedShipSize, false, false);

                if (Misseis == 0)
                {
                    FimdoJogo = "Derrota";
                    Gameover = true;
                }



            }
            else if (gs.Result == Resultado.SuccessMiss)
            {

                Grelha[opcaoY, opcaoX] = 0; //or gs.DamagedShipSize
                ResultadoJogada = ReceberResult(gs.Result);
                Disparou(0, false, false);

                if (Misseis == 0)
                {
                    FimdoJogo = "Derrota";
                    Gameover = true;
                }

            }
            else if (gs.Result == Resultado.SuccessSink)
            {
                Grelha[opcaoY, opcaoX] = gs.DamagedShipSize; //or gs.DamagedShipSize

                AtualizarArmadaInimiga(gs.DamagedShipSize);

                if (gs.DamagedShipSize == 1)
                {
                    if (Submarinosrestantes == 0)
                    {
                        ResultadoJogada = "Afundaste o último submarino!";
                    }
                    ResultadoJogada = "Afundaste um submarino!";

                }
                else if (gs.DamagedShipSize == 5)
                {
                    if (Portaavioesrestantes == 0)
                    {
                        ResultadoJogada = "Afundaste o último porta-aviões!";
                    }
                    ResultadoJogada = "Afundaste o porta-aviões!";
                }
                else
                {
                    if (Doiscanosrestantes == 0 || Trescanosrestantes == 0 || Quatrocanosrestantes == 0)
                    {
                        ResultadoJogada = "Afundaste o último barco de" + gs.DamagedShipSize + " canos!";
                    }
                    ResultadoJogada = ReceberResult(gs.Result) + gs.DamagedShipSize + " canos!";
                }

                Disparou(gs.DamagedShipSize, false, true);


            }
            else if (gs.Result == Resultado.SuccessRepeat)
            {
                ResultadoJogada = ReceberResult(gs.Result);
                DisparouNasMesmasCoords();

                if (Misseis == 0)
                {
                    FimdoJogo = "Derrota";
                    Gameover = true;
                }

            }
            else if (gs.Result == Resultado.SuccessVictory)
            {

                AtualizarArmadaInimiga(gs.DamagedShipSize);

                Grelha[opcaoY, opcaoX] = gs.DamagedShipSize;
                ResultadoJogada = ReceberResult(gs.Result);
                Disparou(gs.DamagedShipSize, true, true);
                FimdoJogo = "Vitória";
                Gameover = true;

            }
            else if (gs.Result == Resultado.InvalidShot)
            {
                ResultadoJogada = ReceberResult(gs.Result);
            }
            else if (gs.Result == Resultado.GameHasEnded)
            {

                FimdoJogo = "Derrota";
                Gameover = true;

            }
            else if (gs.Result == Resultado.NoResult)
            {
                ResultadoJogada = ReceberResult(gs.Result);
            }

            if (Misseis == 1 && Gameover != true)
            {
                ResultadoJogada = ResultadoJogada + AvisarMisseisRestantes() + " míssil!";
            }

            if (Misseis < 6 && Misseis != 1 && Gameover != true)
            {
                ResultadoJogada = ResultadoJogada + AvisarMisseisRestantes() + " mísseis!";
            }


        }

        public void Marcar(int opcaoY, int opcaoX)
        {
            if (Grelha[opcaoY, opcaoX] == -1)
            {
                Grelha[opcaoY, opcaoX] = 7;
            }
            else if (Grelha[opcaoY, opcaoX] == 7)
            {
                Grelha[opcaoY, opcaoX] = -1;
            }

        }

        public void CalcularNumeroDisparos(string numrondas)
        {
            if (numrondas == "auto0")
            {
                NumeroDisparosAutonomo = Misseis;
            }
            else if (numrondas == "auto3")
            {
                NumeroDisparosAutonomo = 3;
            }
            else if (numrondas == "auto10")
            {
                NumeroDisparosAutonomo = 10;
            }
        }

        public void CoordenadasUltimoTiroAcertado(Coordenadas Coordenada, int DamagedShipSize)
        {
            CoordsUltimoTiro.X = Coordenada.X;
            CoordsUltimoTiro.Y = Coordenada.Y;
            UltimoBarcoAcertado = DamagedShipSize;
        }

        public void MarcarGrelhas(int x, int y, int dmgshipsize)
        {

            Grelha[x, y] = dmgshipsize;

            GrelhaModoAuto[x, y] = dmgshipsize;

        }

        public void FinalizarRonda(RoundSummary rs)
        {
            CalcularPercentagens();

            AddRoundSummary(rs);

            NumeroDisparosAutonomo--;
        }

        public void LocalAoFundo(int Barco, int opcaoY, int opcaoX)
        {
            if (Barco == 1)
            {
                Submarinosrestantes--;
                Barcoaofundo = true;

            }
            if (Barco == 2)
            {
                if (opcaoY < 9)
                {
                    if (Grelha[opcaoY + 1, opcaoX] == 2)
                    {

                        Doiscanosrestantes--;
                        Barcoaofundo = true;
                    }
                }
                if (opcaoY > 0)
                {
                    if (Grelha[opcaoY - 1, opcaoX] == 2)
                    {

                        Doiscanosrestantes--;
                        Barcoaofundo = true;

                    }
                }
                if (opcaoX < 9)
                {
                    if (Grelha[opcaoY, opcaoX + 1] == 2)
                    {
                        Doiscanosrestantes--;
                        Barcoaofundo = true;
                    }
                }
                if (opcaoX > 0)
                {
                    if (Grelha[opcaoY, opcaoX - 1] == 2)
                    {
                        Doiscanosrestantes--;
                        Barcoaofundo = true;
                    }
                }
            }//2 canos
            if (Barco == 3)
            {
                if (opcaoY < 8)
                {
                    if (Grelha[opcaoY + 1, opcaoX] == 3 && Grelha[opcaoY + 2, opcaoX] == 3)
                    {
                        Trescanosrestantes--;
                        Barcoaofundo = true;
                    }
                }
                if (opcaoY < 9 && opcaoY > 0)
                {
                    if (Grelha[opcaoY + 1, opcaoX] == 3 && Grelha[opcaoY - 1, opcaoX] == 3)
                    {
                        Trescanosrestantes--;
                        Barcoaofundo = true;
                    }
                }
                if (opcaoY > 1)
                {
                    if (Grelha[opcaoY - 2, opcaoX] == 3 && Grelha[opcaoY - 1, opcaoX] == 3)
                    {
                        Trescanosrestantes--;
                        Barcoaofundo = true;
                    }
                }

                if (opcaoX < 8)
                {
                    if (Grelha[opcaoY, opcaoX + 1] == 3 && Grelha[opcaoY, opcaoX + 2] == 3)
                    {
                        Trescanosrestantes--;
                        Barcoaofundo = true;
                    }
                }
                if (opcaoX > 1)
                {
                    if (Grelha[opcaoY, opcaoX - 2] == 3 && Grelha[opcaoY, opcaoX - 1] == 3)
                    {
                        Trescanosrestantes--;
                        Barcoaofundo = true;
                    }
                }
                if (opcaoX < 9 && opcaoX > 0)
                {
                    if (Grelha[opcaoY, opcaoX - 1] == 3 && Grelha[opcaoY, opcaoX + 1] == 3)
                    {
                        Trescanosrestantes--;
                        Barcoaofundo = true;
                    }
                }
            }//3 canos
            if (Barco == 4)
            {
                Local4Canos++;
                if (Local4Canos == 4)
                {
                    Quatrocanosrestantes--;
                    Barcoaofundo = true;
                }
                else
                {
                    Barcoaofundo = false;
                }
            }
            //quatrocanos
            if (Barco == 5)
            {
                LocalPortaAvioes--;
                if (LocalPortaAvioes == 5)
                {
                    Barcoaofundo = true;
                }
                else
                {
                    Barcoaofundo = false;
                }
            }//portaavioes
            else
                Barcoaofundo = false;
        }

        public void AtualizarJogoLocal()
        {
            if (NumeroDeJogadas == 0)
            {
                MensagemJogoLocal = "Começa por disparar um missíl.";
            }
            else if (TiroNaMesmaCoord == true)
            {
                MensagemJogoLocal = "Foste penalizado em 100 pontos por disparar no mesmo quadrado!";
            }
            else if (UltimoTiroDisparado == 5)
            {
                if (Barcoaofundo == true)
                {
                    MensagemJogoLocal = "Afundaste o porta-aviões!";
                }
                else
                {
                    MensagemJogoLocal = "Acertaste no porta-aviões!";
                }
            }
            else if (UltimoTiroDisparado == 4)
            {
                if (Barcoaofundo == true)
                {
                    MensagemJogoLocal = "Afundaste o barco de quatro canos!";
                }
                else
                {
                    MensagemJogoLocal = " Acertaste num barco de quatro canos!";
                }
            }
            else if (UltimoTiroDisparado == 3)
            {
                if (Barcoaofundo == true)
                {
                    if (Trescanosrestantes == 0)
                    {
                        MensagemJogoLocal = "Afundaste o<b> último</ b > barco de três canos!";
                    }
                    else
                    {
                        MensagemJogoLocal = "Afundaste um barco de três canos!";
                    }
                }
                else
                {
                    MensagemJogoLocal = "Acertaste num barco de três canos!";
                }
            }
            else if (UltimoTiroDisparado == 2)
            {
                if (Barcoaofundo == true)
                {
                    if (Doiscanosrestantes == 0)
                    {
                        MensagemJogoLocal = "Afundaste o último barco de dois canos";
                    }
                    else
                    {
                        MensagemJogoLocal = "Afundaste um barco de dois canos!";
                    }
                }
                else
                {
                    MensagemJogoLocal = "Acertaste num barco de dois canos!";
                }
            }
            else if (UltimoTiroDisparado == 1)
            {
                if (Submarinosrestantes == 0)
                {
                    MensagemJogoLocal = "Afundaste o último submarino!";

                }
                else
                {

                    MensagemJogoLocal = "Afundaste um submarino!";
                }
            }
            else if (UltimoTiroDisparado == 0)
            {
                MensagemJogoLocal = " O teu missíl foi perdido no mar.";
            }





        }
    }
}
