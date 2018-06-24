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
                jogo.ModoLocal = true;
                EspacoOcupado.CriarEspacoOcupado();

                Repository.CriarJogo(jogo);
                jogo.AlterarMissao();
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
                        jogue.FimdoJogo = "Derrota";
                        jogue.Gameover = true;
                    }
                }
                else
                {

                    if (jogue.Misseis != 0)//EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx]=1,2,3,4,5
                    {
                        bool jogoganho = false;

                        jogue.LocalAoFundo(ResultTiro, opcaoY, opcaoX);

                        jogue.Grelha[opcaoY, opcaoX] = ResultTiro;
                        

                        if (ResultTiro != 0)//tem de se utilizar isto para permitir o funcionamento da app online
                        {
                            if (jogue.Missao == "Antiaérea")
                            {
                                if (ResultTiro == 5)
                                {
                                    jogue.Quadradosabater--;
                                }
                            }
                            else
                            {
                                jogue.Quadradosabater--;
                            }
                        }

                        if (jogue.Quadradosabater == 0)
                        {
                            jogoganho = true;
                        }

                        jogue.Disparou(ResultTiro, jogoganho, jogue.Barcoaofundo);

                        if (ResultTiro != 0)
                        {
                            if (jogue.Missao == "Antiaérea")
                            {
                                if (ResultTiro == 5)
                                {
                                    jogue.Quadradosabater++;
                                }
                            }
                            else
                            {
                                jogue.Quadradosabater++;
                            }
                        }

                        jogue.TiroNaMesmaCoord = false;

                        if (jogoganho == true)
                        {
                            jogue.FimdoJogo = "Vitória";
                            jogue.Gameover = true;
                        }
                    }
                    else
                    {
                        jogue.FimdoJogo = "Derrota";
                        jogue.Gameover = true;
                    }
                }
            }
            else if (submitButton == "Marcar")
            {
                jogue.Marcar(opcaoY, opcaoX);
            }
            if (submitButton == "Desistir")
            {
                if (jogue.ConfirmarDesistir(true) == true)
                {
                    jogue.FimdoJogo = "Derrota";
                    jogue.Gameover = true;
                }
            }
            else
            {
                jogue.ConfirmarDesistir(false);
            }

            jogue.AtualizarJogoLocal();

            return View(jogue);

        }

        public IActionResult LocalHiScores()
        {
            List<Jogo> j = Repository.Jogos;
            j.Sort();
            List<Jogo> AntiLocal = new List<Jogo>();
            List<Jogo> DtLocal = new List<Jogo>();
            foreach (Jogo J in j)
            {
                if (J.Gameover == true)
                {

                    if (J.Missao == "Antiaérea")
                    {

                        if (J.ModoLocal == true)
                        {
                            AntiLocal.Add(J);
                            if (AntiLocal.Count > 10)
                            {
                                AntiLocal.Remove(J);
                            }
                        }
                    }
                    else
                    {

                        if (J.ModoLocal == true)
                        {
                            DtLocal.Add(J);
                            if (DtLocal.Count > 10)
                            {
                                DtLocal.Remove(J);
                            }
                        }
                    }
                }
            }
            List<List<Jogo>> Jogos = new List<List<Jogo>>();
            if (AntiLocal.Count != 0)
            { Jogos.Add(AntiLocal); }
            if (DtLocal.Count != 0)
            { Jogos.Add(DtLocal); }
            return View(Jogos);
        }


    }
}