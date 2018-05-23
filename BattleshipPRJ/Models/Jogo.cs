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

        public int Portaavioesrest { get; set; }

        public int Quatrocanosrest { get; set; }

        public int Trescanosrest { get; set; }

        public int Doiscanosrest { get; set; }

        public int Submanrinosrest { get; set; }

        public int Quadradosabater { get; set; }

        public int UltimoTiroDisparado { get; set; }

        public int NumeroDeJogadas { get; set; }

        public bool Barcoaofundo { get; set; }

        public bool TiroNaMesmaCoord { get; set; }

        public string ResultadoJogada { get; set; }

        public string FimdoJogo { get; set; }

        public int Tiros { get; set; }

        public int TiroAgua { get; set; }

        public int TiroAlvo { get; set; }

        public int TiroRepetido { get; set; }

        public double PercentagemAlvo { get; set; }

        public double PercentagemAfundado { get; set; }

        public bool Desistir { get; set; }

        public double Bonus { get; set; }

        public int Coordx { get; set; }

        public int Coordy { get; set; }

        public bool ModoLocal { get; set; }



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
                return "Ganhaste!";
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

        public void AltMissao()
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

            Portaavioesrest = 1;
            Quatrocanosrest = 1;
            Trescanosrest = 2;
            Doiscanosrest = 3;
            Submanrinosrest = 4;


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
            Tiros++;
            Misseis = Misseis - 1;
            UltimoTiroDisparado = Tiro;
            NumeroDeJogadas = NumeroDeJogadas + 1;
            if (Tiro == 1 || Tiro == 2 || Tiro == 3 || Tiro == 4 || Tiro == 5)
            {
                TiroAlvo++;
                if (ganho == false)
                {
                    AdicionarJogada(true, BarcoAoFundo, false, false, 0);
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
                TiroAgua++;
                AdicionarJogada(false, false, false, false, 0);
            }
            Score = Receber();
            Barcoaofundo = BarcoAoFundo;
            CalcularPercentagens();
        }

        public void DisparouNasMesmasCoords()
        {
            TiroRepetido++;
            Misseis = Misseis - 1;
            NumeroDeJogadas = NumeroDeJogadas + 1;
            AdicionarJogada(false, false, true, false, 0);
            Score = Receber();
            Barcoaofundo = false;
            CalcularPercentagens();
        }

        public void Afundou(int shipsize)
        {
            if (shipsize == 1)
            {
                Submanrinosrest--;
            }
            else if (shipsize == 2)
            {
                Doiscanosrest--;
            }
            else if (shipsize == 3)
            {
                Trescanosrest--;
            }
            else if (shipsize == 4)
            {
                Quatrocanosrest--;
            }
            else if (shipsize == 5)
            {
                Portaavioesrest--;
            }



        }

        public void CalcularPercentagens()
        {
            PercentagemAlvo = 100 * TiroAlvo / Tiros;
            PercentagemAfundado = 100 - (100 * (Submanrinosrest + Doiscanosrest + Trescanosrest + Quatrocanosrest + Portaavioesrest) / 11);
        }

        public int CompareTo(object obj)
        {
            Jogo j2 = (Jogo)obj;

            if (j2.Score > Score)
                return 1;
            if (j2.Score == Score)
                return 0;
            if (j2.Score < Score)
                return -1;
            return Score.CompareTo(j2.Score);


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

        public void inicializar()
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

        public void Atualizar(GameState gs,int opcaoY,int opcaoX)
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

                Afundou(gs.DamagedShipSize);

                if (gs.DamagedShipSize == 1)
                {
                    if (Submanrinosrest == 0)
                    {
                        ResultadoJogada = "Afundaste o último submarino!";
                    }
                    ResultadoJogada = "Afundaste um submarino!";

                }
                else if (gs.DamagedShipSize == 5)
                {
                    if (Portaavioesrest == 0)
                    {
                        ResultadoJogada = "Afundaste o último porta-aviões!";
                    }
                    ResultadoJogada = "Afundaste o porta-aviões!";
                }
                else
                {
                    if (Doiscanosrest == 0 || Trescanosrest == 0 || Quatrocanosrest == 0)
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
    }
}
