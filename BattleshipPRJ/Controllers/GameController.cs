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
                    if (jogue.Misseis != 0)
                    {
                        jogue.Grelha[opcaoY, opcaoX] = EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx];
                        jogue.Disparou(EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx], false);
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