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
                    missao = "DestroyCarrier";


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
                    if (gs.DamagedShipSize == 1)
                    {
                        jogue.ResultadoJogada = "Tiro num submarino!";

                    }
                    else if (gs.DamagedShipSize == 5)
                    {
                        jogue.ResultadoJogada = "Tiro no porta-aviões!";

                    }
                    else
                    {
                        jogue.ResultadoJogada = jogue.ReceberResult(gs.Result) + gs.DamagedShipSize + " canos!";
                    }


                    jogue.Disparou(gs.DamagedShipSize, false, false);

                    if (jogue.Misseis == 0)
                    {
                        jogue.FimdoJogo = "Derrota";
                        jogue.Gameover = true;
                    }



                }
                else if (gs.Result == Resultado.SuccessMiss)
                {

                    jogue.Grelha[opcaoY, opcaoX] = 0; //or gs.DamagedShipSize
                    jogue.ResultadoJogada = jogue.ReceberResult(gs.Result);
                    jogue.Disparou(0, false, false);

                    if (jogue.Misseis == 0)
                    {
                        jogue.FimdoJogo = "Derrota";
                        jogue.Gameover = true;
                    }

                }
                else if (gs.Result == Resultado.SuccessSink)
                {
                    jogue.Grelha[opcaoY, opcaoX] = gs.DamagedShipSize; //or gs.DamagedShipSize

                    jogue.Afundou(gs.DamagedShipSize);

                    if (gs.DamagedShipSize == 1)
                    {
                        if (jogue.Submanrinosrest == 0)
                        {
                            jogue.ResultadoJogada = "Afundaste o último submarino!";
                        }
                        jogue.ResultadoJogada = "Afundaste um submarino!";

                    }
                    else if (gs.DamagedShipSize == 5)
                    {
                        if (jogue.Portaavioesrest == 0)
                        {
                            jogue.ResultadoJogada = "Afundaste o último porta-aviões!";
                        }
                        jogue.ResultadoJogada = "Afundaste o porta-aviões!";
                    }
                    else
                    {
                        if (jogue.Doiscanosrest == 0 || jogue.Trescanosrest == 0 || jogue.Quatrocanosrest == 0)
                        {
                            jogue.ResultadoJogada = "Afundaste o último barco de" + gs.DamagedShipSize + " canos!";
                        }
                        jogue.ResultadoJogada = jogue.ReceberResult(gs.Result) + gs.DamagedShipSize + " canos!";
                    }

                    jogue.Disparou(gs.DamagedShipSize, false, true);


                }
                else if (gs.Result == Resultado.SuccessRepeat)
                {
                    jogue.ResultadoJogada = jogue.ReceberResult(gs.Result);
                    jogue.DisparouNasMesmasCoords();

                    if(jogue.Misseis==0)
                    {
                        jogue.FimdoJogo = "Derrota";
                        jogue.Gameover = true;
                    }

                }
                else if (gs.Result == Resultado.SuccessVictory)
                {
                    jogue.Grelha[opcaoY, opcaoX] = gs.DamagedShipSize;
                    jogue.ResultadoJogada = jogue.ReceberResult(gs.Result);
                    jogue.Disparou(gs.DamagedShipSize, true, true);
                    jogue.FimdoJogo = "Vitória";
                    jogue.Gameover = true;
                    
                }
                else if (gs.Result == Resultado.InvalidShot)
                {
                    jogue.ResultadoJogada = jogue.ReceberResult(gs.Result);
                }
                else if (gs.Result == Resultado.GameHasEnded)
                {

                    jogue.FimdoJogo = "Derrota";
                    jogue.Gameover = true;
                    
                }
                else if (gs.Result == Resultado.NoResult)
                {
                    jogue.ResultadoJogada = jogue.ReceberResult(gs.Result);
                }

                if (jogue.Misseis == 1 && jogue.Gameover != true)
                {
                    jogue.ResultadoJogada = jogue.ResultadoJogada + jogue.AvisarMisseisRestantes() + " míssil!";
                }

                if( jogue.Misseis < 6 && jogue.Misseis != 1 && jogue.Gameover != true)
                { 
                jogue.ResultadoJogada = jogue.ResultadoJogada + jogue.AvisarMisseisRestantes() + " mísseis!";
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
            if (submitButton == "Desistir")
            {
                if (jogue.ConfirmarDesistir(true) == true)
                {
                    HttpClient client = MyHttpClient.Client;
                    string path = "api/Play";
                    PlayRequest pr = new PlayRequest(id, opcaoX, opcaoY, PlayerAction.Quit);
                    string json = JsonConvert.SerializeObject(pr);

                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, path);
                    request.Content = new StringContent(json, System.Text.Encoding.UTF8,
                    "application/json");
                    HttpResponseMessage response = await client.SendAsync(request);

                    if (!response.IsSuccessStatusCode) { return Redirect("/"); }
                    string json_r = await response.Content.ReadAsStringAsync();
                    GameState gs = JsonConvert.DeserializeObject<GameState>(json_r);

                    jogue.FimdoJogo = "Derrota";
                    jogue.Gameover = true;
                }
                
            }
            else
            {
                jogue.ConfirmarDesistir(false);
            }


            return View(jogue);

        }



        public IActionResult HiScores()

        {
            List<Jogo> j = Repository.Jogos;
            j.Sort();
            List<Jogo> Anti = new List<Jogo>();
            List<Jogo> Dt = new List<Jogo>();
            foreach (Jogo J in j)
            {
                if (J.Missao == "Antiaérea")
                {
                    Anti.Add(J);
                    if(Anti.Count > 1)
                    {
                        Anti.Remove(J);
                    }
                }
                else
                {
                    Dt.Add(J);
                    if (Dt.Count > 1)
                    {
                        Dt.Remove(J);
                    }
                }
        }
            List<List<Jogo>> Jogos = new List<List<Jogo>>();
            if(Anti.Count!=0)
            { Jogos.Add(Anti);}
            if (Dt.Count != 0)
            { Jogos.Add(Dt); }        
            return View(Jogos);
        }

        public IActionResult ModoAutonomo()
        {
            List<Jogo> J = Repository.Jogos;
            Jogo j = J[J.Count - 1];
            return View(j);
        }

        [HttpPost]
        public async Task<IActionResult> ModoAutonomo(int id, string Tipo)
        {
            Jogo jogue = Repository.ObterJogo(id);

            int NrDisparos = 0;

            if (Tipo == "auto0")
            {
                NrDisparos = jogue.Misseis;
            }
            else if (Tipo == "auto3")
            {
                NrDisparos = 3;
            }
            else if (Tipo == "auto10")
            {
                NrDisparos = 10;
            }

            while (NrDisparos != 0)
            {
                ModoAutonomo1 m = new ModoAutonomo1();
                Coordenadas Coords = new Coordenadas();
                Coords = m.ReceberCoords(jogue.Grelha);

                HttpClient client = MyHttpClient.Client;
                string path = "api/Play";
                PlayRequest pr = new PlayRequest(id, Coords.X, Coords.Y, 0);
                string json = JsonConvert.SerializeObject(pr);

                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, path);
                request.Content = new StringContent(json, System.Text.Encoding.UTF8,
                "application/json");
                HttpResponseMessage response = await client.SendAsync(request);

                if (!response.IsSuccessStatusCode) { return Redirect("/"); }
                string json_r = await response.Content.ReadAsStringAsync();
                GameState gs = JsonConvert.DeserializeObject<GameState>(json_r);

                int opcaoX;
                int opcaoY;

                opcaoY = Coords.X;
                opcaoX = Coords.Y;

                if (gs.Result == Resultado.SuccessHit)
                {

                    jogue.Grelha[opcaoY, opcaoX] = gs.DamagedShipSize;
                    jogue.Disparou(gs.DamagedShipSize, false, false);

                }
                else if (gs.Result == Resultado.SuccessMiss)
                {
                    jogue.Grelha[opcaoY, opcaoX] = 0;
                    jogue.Disparou(0, false, false);
                }
                else if (gs.Result == Resultado.SuccessSink)
                {
                    jogue.Grelha[opcaoY, opcaoX] = gs.DamagedShipSize; //or gs.DamagedShipSize

                    jogue.Afundou(gs.DamagedShipSize);

                    jogue.Disparou(gs.DamagedShipSize, false, true);
                }
                else if (gs.Result == Resultado.SuccessRepeat)
                {
                    jogue.DisparouNasMesmasCoords();
                }
                else if (gs.Result == Resultado.SuccessVictory)
                {
                    jogue.Grelha[opcaoY, opcaoX] = gs.DamagedShipSize;
                    jogue.ResultadoJogada = jogue.ReceberResult(gs.Result);
                    jogue.Disparou(gs.DamagedShipSize, true, true);
                    jogue.FimdoJogo = "Ganhaste!";

                    return View(jogue);
                }
                else if (gs.Result == Resultado.InvalidShot)
                {
                    jogue.ResultadoJogada = jogue.ReceberResult(gs.Result);
                }
                else if (gs.Result == Resultado.GameHasEnded)
                {
                    jogue.FimdoJogo = "Perdeste!";

                    return View(jogue);
                }
                else if (gs.Result == Resultado.NoResult)
                {
                    jogue.ResultadoJogada = jogue.ReceberResult(gs.Result);
                }

                NrDisparos--;

            }
            return View("Game", jogue);
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