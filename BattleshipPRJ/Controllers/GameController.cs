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

    public class GameController : Controller
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





        public IActionResult NovoJogo()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> NovoJogo(Jogo jogo)
        {

            if (ModelState.IsValid)
            {
                Repository.CriarJogo(jogo);
                jogo.AltMissao();

                string missao;

                if (jogo.Missao == "Destruição Total")
                    missao = "TotalDestruction";
                else
                    missao = "DestroyCarrier"; //perguntar o nome que está na API


                HttpClient client = MyHttpClient.Client;
                string path = "api/NewGame";
                NewGameRequest ngreq = new NewGameRequest(jogo.Nome, missao);
                string json = JsonConvert.SerializeObject(ngreq);

                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, path);
                request.Content = new StringContent(json, System.Text.Encoding.UTF8,
                "application/json");
                HttpResponseMessage response = await client.SendAsync(request);

                if (!response.IsSuccessStatusCode) { return Redirect("/"); }
                string json_r = await response.Content.ReadAsStringAsync();
                GameState gs = JsonConvert.DeserializeObject<GameState>(json_r);


                jogo.ID = gs.GameID;
                jogo.Coordx = gs.FiredX;
                jogo.Coordy = gs.FiredY;
                

                jogo.ResultadoJogada = jogo.ReceberResult(gs.Result);
                

                return View("Game", jogo); 
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
                        return View("GameOverScore");
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
                            //grelha=espocupado
                        }
                        jogue.Grelha[opcaoY, opcaoX] = EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx];
                        //disparou
                        jogue.Disparou(EspacoOcupado.BarcosO[jogue.Coordy, jogue.Coordx], jogoganho, BarcoAoFundo);
                        jogue.TiroNaMesmaCoord = false;
                        if (jogoganho == true)
                        {
                            //gameover screen ganhou
                        }
                    }
                    else
                    {
                        //return View("HiScores");//gameover screen
                        return View("GameOverScore");
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



            //jogue.Grelha[jogo.coordy, jogo.coordx] = EspacoOcupado.BarcosO[jogo.coordy, jogo.coordx] ;




            return View(jogue);

        }


        [HttpPost]
        public async Task<IActionResult> Game(int id, int opcaoX, int opcaoY, string submitButton)
        {

            Jogo jogue = Repository.ObterJogo(id);



            jogue.Coordx = opcaoX;

            jogue.Coordy = opcaoY;


            if (submitButton == "Disparar")
            {
              
                HttpClient client = MyHttpClient.Client;
                string path = "api/Play";
                PlayRequest pr = new PlayRequest(id, opcaoX, opcaoY, 0);
                string json = JsonConvert.SerializeObject(pr);

                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, path);
                request.Content = new StringContent(json, System.Text.Encoding.UTF8,
                "application/json");
                HttpResponseMessage response = await client.SendAsync(request);

                if (!response.IsSuccessStatusCode) { return Redirect("/"); } 
                string json_r = await response.Content.ReadAsStringAsync();
                GameState gs = JsonConvert.DeserializeObject<GameState>(json_r);

                gs.FiredX = jogue.Coordx;
                gs.FiredY = jogue.Coordy;

                if (gs.Result == Resultado.SuccessHit)
                {
                    
                    jogue.Grelha[opcaoY, opcaoX] = gs.DamagedShipSize;
                    if(gs.DamagedShipSize==1)
                    {
                        jogue.ResultadoJogada = "Tiro num submarino!";

                    }
                    else if (gs.DamagedShipSize == 5)
                    {
                        jogue.ResultadoJogada = "Tiro no porta-aviões!";
                    }
                    else
                    { jogue.ResultadoJogada = jogue.ReceberResult(gs.Result) + gs.DamagedShipSize + " canos!";
                    }
                    
                    jogue.Disparou(gs.DamagedShipSize, false, false);

                }
                else if (gs.Result == Resultado.SuccessMiss)
                {
                    jogue.Grelha[opcaoY, opcaoX] = 0; //or gs.DamagedShipSize
                    jogue.ResultadoJogada = jogue.ReceberResult(gs.Result);
                    jogue.Disparou(0, false, false);
                }
                else if (gs.Result == Resultado.SuccessSink)
                {
                    jogue.Grelha[opcaoY, opcaoX] = gs.DamagedShipSize; //or gs.DamagedShipSize

                    if (gs.DamagedShipSize == 1)
                    {
                        jogue.ResultadoJogada = "Afundaste um submarino!";

                    }
                    else if(gs.DamagedShipSize == 5)
                    {
                        jogue.ResultadoJogada = "Afundaste o porta-aviões!";
                    }
                    else
                    {
                        jogue.ResultadoJogada = jogue.ReceberResult(gs.Result) + gs.DamagedShipSize + " canos!";
                    }
                    
                    jogue.Disparou(gs.DamagedShipSize, false, true);
                }
                else if (gs.Result == Resultado.SuccessRepeat)
                {
                    jogue.ResultadoJogada = jogue.ReceberResult(gs.Result);
                    jogue.DisparouNasMesmasCoords();
                }
                else if (gs.Result == Resultado.SuccessVictory)
                {
                    jogue.Grelha[opcaoY, opcaoX] = gs.DamagedShipSize;
                    jogue.ResultadoJogada = jogue.ReceberResult(gs.Result);
                    jogue.Disparou(gs.DamagedShipSize, true, true);
                    jogue.FimdoJogo = "Ganhaste!";

                    return View("GameOver", jogue);
                }
                else if (gs.Result == Resultado.InvalidShot)
                {
                    jogue.ResultadoJogada = jogue.ReceberResult(gs.Result);
                }
                else if (gs.Result == Resultado.GameHasEnded)
                {
                    jogue.FimdoJogo = "Perdeste!"; //PROBLEMA

                    return View("GameOver", jogue);
                }
                else if (gs.Result == Resultado.NoResult)
                {
                    jogue.ResultadoJogada = jogue.ReceberResult(gs.Result);
                }

                return View(jogue);

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



        public IActionResult HiScores()
        {
            return View();
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