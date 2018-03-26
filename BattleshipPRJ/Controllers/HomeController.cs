﻿using System;
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
        public IActionResult Index()
        {
            GrelhaTeste grelhaTeste = new GrelhaTeste();
           
            ViewBag.Grelha = grelhaTeste.Grelha;
           
            EspacoOcupado espacoOcupado = new EspacoOcupado();
           
            ViewBag.Barcos = espacoOcupado.BarcosO;

            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
