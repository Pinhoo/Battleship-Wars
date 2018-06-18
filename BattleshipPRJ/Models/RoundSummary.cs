using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BattleshipPRJ.Models
{
    public class RoundSummary
    {
        public int NRonda { get; set; }

        public int ScoreInicio { get; set; }

        public string CoordAlvoEscolhido { get; set; }

        public string ResultTiro { get; set; }  

        public string BarcoAtingido { get; set; }  

        public int TotalTiroAlvo { get; set; }

        public int TotalBarcosAfundados { get; set; }

        public int ScoreFimRonda { get; set; }
        

        public RoundSummary()
        {

            NRonda = 1;
            ScoreInicio = 0;

            

        }
        
        public void AtualizarRonda(Resultado res, int x, int y, int shipsize, int nronda)
        {

            NRonda = nronda;
            
            switch (res)
            {
                case Resultado.NoResult:
                    break;
                case Resultado.SuccessHit:
                    ResultTiro = "Alvo";
                    TotalTiroAlvo++;
                    break;
                case Resultado.SuccessMiss:
                    ResultTiro = "Água";
                    break;
                case Resultado.SuccessSink:
                    ResultTiro = "Afundado";
                    TotalTiroAlvo++;
                    TotalBarcosAfundados++;
                    break;
                case Resultado.SuccessRepeat:
                    ResultTiro = "Repetido";
                    break;
                case Resultado.SuccessVictory:
                    ResultTiro = "Afundado";
                    TotalTiroAlvo++;
                    break;
                case Resultado.InvalidShot:
                    break;
                case Resultado.GameHasEnded:
                    break;
                default:
                    break;
            }

            string coordx = x.ToString();
            string coordy = (y + 1).ToString();

            switch (coordx)
            {
                case "0":
                    coordx = "A";
                    break;
                case "1":
                    coordx = "B";
                    break;
                case "2":
                    coordx = "C";
                    break;
                case "3":
                    coordx = "D";
                    break;
                case "4":
                    coordx = "E";
                    break;
                case "5":
                    coordx = "F";
                    break;
                case "6":
                    coordx = "G";
                    break;
                case "7":
                    coordx = "H";
                    break;
                case "8":
                    coordx = "I";
                    break;
                case "9":
                    coordx = "J";
                    break;
                default:
                    break;
            }

            CoordAlvoEscolhido = coordx + ", " + coordy;



            switch (shipsize)
            {
                case 0:
                    BarcoAtingido = "-";
                    break;
                case 1:
                    BarcoAtingido = "Submarino";
                    break;
                case 2:
                    BarcoAtingido = "2 canos";
                    break;
                case 3:
                    BarcoAtingido = "3 canos";
                    break;
                case 4:
                    BarcoAtingido = "4 canos";
                    break;
                case 5:
                    BarcoAtingido = "Porta-aviões";
                    break;
                default:
                    break;
            }


        }

        public void AtualizarRonda(Resultado res, int x, int y, int shipsize, int nronda, RoundSummary ronda)
        {
            ScoreInicio = ronda.ScoreFimRonda;

            TotalTiroAlvo = ronda.TotalTiroAlvo;
            TotalBarcosAfundados = ronda.TotalBarcosAfundados;
            AtualizarRonda(res, x, y, shipsize, nronda);
            

        }

    }

       
    }




