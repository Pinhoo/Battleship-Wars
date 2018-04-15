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

        public IActionResult Game()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Game(Player player)
        {
            //isto permite ter botao funcional
            //EspacoOcupado espacoOcupado = new EspacoOcupado();
            //GrelhaTeste grelhaTeste = new GrelhaTeste();     
            
            //ViewBag.Grelha = grelhaTeste.Grelha;
            //ViewBag.Barcos = espacoOcupado.BarcosO;

            //grelhaTeste.Grelha[player.CoordY, player.CoordX] = espacoOcupado.BarcosO[player.CoordY, player.CoordX];



            if (player.Missao == "Antiaérea")
            {
                ViewBag.Misseis = 20;
            }
            else
            {
                ViewBag.Misseis = 50;
            }

            if (ModelState.IsValid)
            {
                return View(player);
            }
            else
            {
                return View("NovoJogo");
            }





        }

        public IActionResult HiScores()
        {
            return View();
        }
    }
}