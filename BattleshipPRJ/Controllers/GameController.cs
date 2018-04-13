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
        public IActionResult Game(Player player)
        {
            GrelhaTeste grelhaTeste = new GrelhaTeste();

            ViewBag.Grelha = grelhaTeste.Grelha;

            EspacoOcupado espacoOcupado = new EspacoOcupado();

            ViewBag.Barcos = espacoOcupado.BarcosO;

            if(player.Missao == "Antiaérea")
            {
                ViewBag.Misseis = 20;
            }
            else
            {
                ViewBag.Misseis = 50;
            }

            if(ModelState.IsValid)
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

       [HttpPost]
       public IActionResult SelectedCords(int CoordX, int CoordY)
       {
           SelectCoords selectcoords = new SelectCoords(CoordX, CoordY);
           ViewBag.Grelha[selectcoords.CoordX , selectcoords.CoordY] = ViewBag.Barcos[selectcoords.CoordX, selectcoords.CoordY];
           return View(selectcoords);
       }



      
    }
}