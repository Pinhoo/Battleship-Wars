﻿using System;
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
        public IActionResult Game(Jogo jogo)
        {                      
            Jogo jogue = Repository.ObterJogo();

            jogue.Coordx = jogo.Coordx;

            jogue.Coordy = jogo.Coordy;

            jogue.Grelha[jogo.Coordy, jogo.Coordx] = 7;

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

            return View("JogosCriadosTeste" , jogues);

        }
    }
}