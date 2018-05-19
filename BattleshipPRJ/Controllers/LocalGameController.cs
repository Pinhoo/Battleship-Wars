using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BattleshipPRJ.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace BattleshipPRJ.Controllers
{

    public class LocalGameController : Controller
    {


        [HttpGet]
        public IActionResult NewLocalGame()
        {

            return View();

        }

        [HttpPost]
        public IActionResult NewLocalGame(Jogo jogo)
        {

            if (ModelState.IsValid)
            {
                EspacoOcupado.CriarEspacoOcupado();

                Repository.CriarJogo(jogo);
                jogo.AltMissao();
                return View("LocalGame", jogo);
            }
            else
            {
                return View();
            }

        }

        

        [HttpPost]
        public IActionResult LocalGame(int id, int opcaoX, int opcaoY, string submitButton)
        {
            Jogo jogue = Repository.ObterJogo(id);


            jogue.Coordx = opcaoX;

            jogue.Coordy = opcaoY;


            if (submitButton == "Disparar")
            {


                if (jogue.Grelha[opcaoY, opcaoX] == EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx])
                {
                    if (jogue.Misseis != 0)
                    {
                        jogue.DisparouNasMesmasCoords();
                        jogue.TiroNaMesmaCoord = true;
                    }
                    else
                    {
                        //return View("HiScores");//gameover screen
                        jogue.FimdoJogo = "Perdeste!";
                        return View("LocalGameOver", jogue);
                    }
                }
                else
                {

                    if (jogue.Misseis != 0)//EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx]=1,2,3,4,5
                    {
                        bool BarcoAoFundo = false;
                        bool jogoganho = false;
                        if (EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx] == 2)
                        {
                            if (opcaoY < 9)
                            {
                                if (jogue.Grelha[opcaoY + 1, opcaoX] == 2)
                                {
                                    BarcoAoFundo = true;
                                    jogue.Doiscanosrest--;
                                }
                            }
                            if (opcaoY > 0)
                            {
                                if (jogue.Grelha[opcaoY - 1, opcaoX] == 2)
                                {
                                    BarcoAoFundo = true;
                                    jogue.Doiscanosrest--;
                                }
                            }
                            if (opcaoX < 9)
                            {
                                if (jogue.Grelha[opcaoY, opcaoX + 1] == 2)
                                {
                                    BarcoAoFundo = true;
                                    jogue.Doiscanosrest--;
                                }
                            }
                            if (opcaoX > 0)
                            {
                                if (jogue.Grelha[opcaoY, opcaoX - 1] == 2)
                                {
                                    BarcoAoFundo = true;
                                    jogue.Doiscanosrest--;
                                }
                            }
                        }//2 canos
                        else if (EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx] == 3)
                        {
                            if (opcaoY < 8)
                            {
                                if (jogue.Grelha[opcaoY + 1, opcaoX] == 3 && jogue.Grelha[opcaoY + 2, opcaoX] == 3)
                                {
                                    jogue.Trescanosrest--;
                                    BarcoAoFundo = true;
                                }
                            }
                            if (opcaoY < 9 && opcaoY > 0)
                            {
                                if (jogue.Grelha[opcaoY + 1, opcaoX] == 3 && jogue.Grelha[opcaoY - 1, opcaoX] == 3)
                                {
                                    jogue.Trescanosrest--;
                                    BarcoAoFundo = true;
                                }
                            }
                            if (opcaoY > 1)
                            {
                                if (jogue.Grelha[opcaoY - 2, opcaoX] == 3 && jogue.Grelha[opcaoY - 1, opcaoX] == 3)
                                {
                                    jogue.Trescanosrest--;
                                    BarcoAoFundo = true;
                                }
                            }

                            if (opcaoX < 8)
                            {
                                if (jogue.Grelha[opcaoY, opcaoX + 1] == 3 && jogue.Grelha[opcaoY, opcaoX + 2] == 3)
                                {
                                    jogue.Trescanosrest--;
                                    BarcoAoFundo = true;
                                }
                            }
                            if (opcaoX > 1)
                            {
                                if (jogue.Grelha[opcaoY, opcaoX - 2] == 3 && jogue.Grelha[opcaoY, opcaoX - 1] == 3)
                                {
                                    jogue.Trescanosrest--;
                                    BarcoAoFundo = true;
                                }
                            }
                            if (opcaoX < 9 && opcaoX > 0)
                            {
                                if (jogue.Grelha[opcaoY, opcaoX - 1] == 3 && jogue.Grelha[opcaoY, opcaoX + 1] == 3)
                                {
                                    jogue.Trescanosrest--;
                                    BarcoAoFundo = true;
                                }
                            }
                        }//3 canos
                        else if (EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx] == 1)
                        {
                            BarcoAoFundo = Barco.AoFundo(EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx]);
                            jogue.Submanrinosrest--;
                        }//Subs
                        else if (EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx] == 4)
                        {
                            BarcoAoFundo = Barco.AoFundo(EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx]);
                            if (BarcoAoFundo == true)
                            {
                                jogue.Quatrocanosrest--;
                            }
                        }//quatrocanos
                        else if (EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx] == 5)
                        {
                            BarcoAoFundo = Barco.AoFundo(EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx]);
                            if (BarcoAoFundo == true)
                            {
                                jogue.Portaavioesrest--;

                                if (jogue.Missao != "Antiaérea")
                                {
                                    if (jogue.Quadradosabater == 0)
                                    {
                                        jogoganho = true;
                                    }
                                }
                            }
                        }//portaavioes

                        if (jogue.Quadradosabater == 0)
                        {
                            jogoganho = true;
                            //grelha=espocupado
                        }
                        jogue.Grelha[opcaoY, opcaoX] = EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx];
                        //disparou
                        jogue.Disparou(EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx], jogoganho, BarcoAoFundo);
                        jogue.TiroNaMesmaCoord = false;
                        if (jogoganho == true)
                        {
                            jogue.FimdoJogo = "Ganhaste!";
                            return View("LocalGameOver", jogue);
                            //gameover screen ganhou
                        }
                    }
                    else
                    {
                        //gameover screen
                        jogue.FimdoJogo = "Perdeste!";
                        return View("LocalGameOver", jogue);
                    }
                }
            }
            else if (submitButton == "Marcar")
            {
                if (jogue.Grelha[opcaoY, opcaoX] == -1)
                {
                    jogue.Grelha[opcaoY, opcaoX] = 7;
                }
                else if (jogue.Grelha[opcaoY, opcaoX] == 7)
                {
                    jogue.Grelha[opcaoY, opcaoX] = -1;
                }
            }
            
            return View(jogue);

        }
        

        //public IActionResult JogosCriadosTeste()
        //{
        //    List<Jogo> jogos = Repository.Jogos;

        //    return View(jogos);

        //}

        //public IActionResult Teste(List<Jogo> jogues)
        //{
        //    Repository.ApagarJogos();

        //    return View("JogosCriadosTeste", jogues);

        //}
    }
}