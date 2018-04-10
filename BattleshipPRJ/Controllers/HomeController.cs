using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BattleshipPRJ.Models;

namespace BattleshipPRJ.Controllers
{
    public class HomeController : Controller
    {
     
        public IActionResult Regras()
        {
            return View();
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Equipa()
        {
            return View();
        }

       public IActionResult Home()
        {
            return View();
        }

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

            ViewBag.Nome = player.Nome;

            ViewBag.Missao = player.Missao;

            ViewBag.Score = player.Score;


            return View();
        }

        public IActionResult HiScores()
        {
            return View();
        }
        
    }
}
