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

            int ResultTiro = EspacoOcupado.BarcosO[opcaoY, opcaoX];

            if (submitButton == "Disparar")
            {

                
                if (jogue.Grelha[opcaoY, opcaoX] == ResultTiro)
                {
                    if (jogue.Misseis != 0)
                    {
                        jogue.DisparouNasMesmasCoords();
                        jogue.TiroNaMesmaCoord = true;
                    }
                    else
                    {
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

                        BarcoAoFundo = Barco.AoFundo(ResultTiro, jogue,opcaoY,opcaoX);
                        jogue = Barco.Jog;

                        jogue.Grelha[opcaoY, opcaoX] = ResultTiro;

                        if (jogue.Quadradosabater == 0)
                        {
                            jogoganho = true;
                        }

                        jogue.Disparou(ResultTiro, jogoganho, BarcoAoFundo);

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