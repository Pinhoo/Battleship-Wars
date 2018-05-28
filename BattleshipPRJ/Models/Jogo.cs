using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BattleshipPRJ.Models
{
    public class Jogo :IComparable
    {
        private static int heidi = 0;

        [Required(ErrorMessage = "Por favor preenche o campo Nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor seleciona a missão pretendida!")]
        public string Missao { get; set; }

        public int ID { get; set; }

        public bool Gameover { get; set; }

        public int Misseis { get; set; }

        public double Score { get; set; }

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

        public double Bonus { get; set; }

        public int Coordx { get; set; }

        public int Coordy { get; set; }

        public bool ModoLocal { get; set; }

        public int LocalPortaAvioes { get; set; }

        public int Local4Canos { get; set; }

        public int[,] GrelhaModoAuto { get; set; }

        public Coordenadas Coords { get; set; }



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
            else if(result == Resultado.GameHasEnded)
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

            ID = heidi;

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

        }

        public void Disparou(int Tiro, bool ganho, bool BarcoAoFundo)
        {
            TirosDados++;
            Misseis = Misseis - 1;
            UltimoTiroDisparado = Tiro;
            NumeroDeJogadas = NumeroDeJogadas + 1;
            if (Tiro == 1 || Tiro == 2 || Tiro == 3 || Tiro == 4 || Tiro == 5)
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
                        if (Tiro == 5)
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
            Score = Receber();
            Barcoaofundo = BarcoAoFundo;
            CalcularPercentagens();
        }

        public void DisparouNasMesmasCoords()
        {
            TirosRepetido++;
            Misseis = Misseis - 1;
            NumeroDeJogadas = NumeroDeJogadas + 1;
            AdicionarJogada(false, false, true, false, 0);
            Score = Receber();
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
            PercentagemAlvo = 100 * TirosAlvo / TirosDados;
            PercentagemAfundado = 100 - (100 * (Submarinosrestantes + Doiscanosrestantes + Trescanosrestantes + Quatrocanosrestantes + Portaavioesrestantes) / 11);
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

        public void Inicializar()
        {
            Bonus = -0.25;
            Score = 0;
        }

        public void AdicionarJogada(bool d_BarcoAtingido, bool d_BarcoAfundado, bool d_Penalizacao, bool d_Ganho, int d_Missseis)
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
                Score = Score + (100 * (1 + Bonus));
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


        public double Receber()
        {
            return Score;
        }

        public void AtualizarJogada(GameState gs,int opcaoY,int opcaoX)
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
    }
}
