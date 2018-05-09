using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BattleshipPRJ.Models;



namespace BattleshipPRJ.Controllers
{

    public class GameController : Controller
    {


        [HttpGet]
        public IActionResult NovoJogo()
        {
            return View();
        }


        [HttpPost]
        public IActionResult NovoJogo(Jogo jogo)
        {



            //jogo.Grelha[5,5] = 0;


            if (ModelState.IsValid)
            {
                EspacoOcupado.CriarEspacoOcupado();

                Repository.CriarJogo(jogo);
                jogo.AltMissao();
                return View("Game", jogo);
            }
            else
            {
                return View();
            }



        }




        [HttpPost]
        public IActionResult Game(int id, int opcaoX, int opcaoY, string submitButton)
        {
            Jogo jogue = Repository.ObterJogo(id);

            if (jogue.NumeroDeJogadas == 0)
            {
                jogue.InicializarBarcos();
            }


            jogue.Coordx = opcaoX;

            jogue.Coordy = opcaoY;


            if (submitButton == "Disparar")
            {


                if (jogue.Grelha[opcaoY, opcaoX] == EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx])
                {
                    if (jogue.Misseis != 0)
                    {
                        jogue.DisparouNasMesmasCoords(EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx]);
                    }
                    else
                    {
                        return View("HiScores");
                    }
                }
                else
                {
                    if (jogue.Misseis != 0)//EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx]=1,2,3,4,5
                    {
                        bool BarcoAoFundo = false;
                        if (EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx] == 2)
                        {
                            if (jogue.Grelha[opcaoY + 1, opcaoX] == 2 || jogue.Grelha[opcaoY - 1, opcaoX] == 2 || jogue.Grelha[opcaoY, opcaoX + 1] == 2 || jogue.Grelha[opcaoY, opcaoX - 1] == 2)
                            {
                                BarcoAoFundo = true;
                                jogue.Doiscanosrest--;
                            }
                        }//2 canos
                        else if (EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx] == 3)
                        {
                            //Falta o de 3 canos
                        }
                        else if (EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx] == 1)
                        {
                            BarcoAoFundo = Barco.AoFundo(EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx]);
                            jogue.Submanrinosrest--;
                        }//Subs, PortaAvioes e quatrocanos
                        else if (EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx] == 4)
                        {
                            BarcoAoFundo = Barco.AoFundo(EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx]);
                            if (BarcoAoFundo == true)
                            {
                                jogue.Quatrocanosrest--;
                            }
                        }
                        else if (EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx] == 5)
                        {
                            BarcoAoFundo = Barco.AoFundo(EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx]);
                            if (BarcoAoFundo == true)
                            {
                                jogue.Portaavioesrest--;
                            }
                        }
                        //grelha=espocupado
                        jogue.Grelha[opcaoY, opcaoX] = EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx];
                        //disparou
                        jogue.Disparou(EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx], false, BarcoAoFundo);
                    }
                    else
                    {
                        return View("HiScores");
                    }
                }
            }
            else if (submitButton == "Marcar")
            {
                if (jogue.Grelha[opcaoY, opcaoX] == -1)
                {
                    jogue.Grelha[opcaoY, opcaoX] = 7;
                }
            }



            //jogue.Grelha[jogo.coordy, jogo.coordx] = EspacoOcupado.BarcosO[jogo.coordy, jogo.coordx] ;




            return View(jogue);

        }



        public IActionResult HiScores()
        {
            return View();
        }

        public IActionResult JogosCriadosTeste()
        {
            List<Jogo> jogos = Repository.Jogos;

            return View(jogos);

        }

        public IActionResult Teste(List<Jogo> jogues)
        {
            Repository.ApagarJogos();

            return View("JogosCriadosTeste", jogues);

        }
    }
}