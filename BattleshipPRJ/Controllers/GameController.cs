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

        public IActionResult NovoJogoAutonomo()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NovoJogoAutonomo(Jogo jogo)
        {
            if (ModelState.IsValid)
            {
                Repository.CriarJogo(jogo);
                jogo.AlterarMissao();

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


                jogo.CalcularNumeroDisparos(jogo.Nome);

                while(jogo.NumeroDisparosAutonomo!=0)
                {

                    HttpClient client1 = MyHttpClient.Client;
                    string path1 = "api/Play";

                    jogo.ID = gs.GameID;

                    Random rnr = new Random();

                    int X = rnr.Next(0, 10);
                    int Y = rnr.Next(0, 10);

                    PlayRequest pr = new PlayRequest(jogo.ID, X, Y, 0);
                    string json1 = JsonConvert.SerializeObject(pr);

                    HttpRequestMessage request1 = new HttpRequestMessage(HttpMethod.Post, path1);
                    request1.Content = new StringContent(json1, System.Text.Encoding.UTF8,
                    "application/json");
                    HttpResponseMessage response1 = await client.SendAsync(request1);

                    if (!response1.IsSuccessStatusCode) { return Redirect("/"); }
                    string json_r1 = await response1.Content.ReadAsStringAsync();
                    GameState gs1 = JsonConvert.DeserializeObject<GameState>(json_r1);


                    jogo.Grelha[X, Y] = gs1.DamagedShipSize;
                    
                    jogo.NumeroDisparosAutonomo--;

                    if(gs1.Result==Resultado.SuccessVictory)
                    {
                        jogo.NumeroDisparosAutonomo = 0;
                    }


                }
                

                return View("ResultadosJogoAutonomo", jogo);
            }
            else
            {
                return View();
            }

        }

        [HttpPost]
        public async Task<IActionResult> NovoJogo(Jogo jogo)
        {
            if (ModelState.IsValid)
            {
                Repository.CriarJogo(jogo);
                jogo.AlterarMissao();

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

                jogue.AtualizarJogada(gs, opcaoY, opcaoX);


            }
            else if (submitButton == "Marcar")
            {
                jogue.Marcar(opcaoY, opcaoX);
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
                if (J.Gameover == true)
                {

                    if (J.Missao == "Antiaérea")
                    {

                        if (J.ModoLocal == false)
                        {
                            Anti.Add(J);
                            if (Anti.Count > 10)
                            {
                                Anti.Remove(J);
                            }
                        }
                    }
                    else
                    {

                        if (J.ModoLocal == false)
                        {
                            Dt.Add(J);
                            if (Dt.Count > 10)
                            {
                                Dt.Remove(J);
                            }
                        }
                    }
                }
            }
            List<List<Jogo>> Jogos = new List<List<Jogo>>();
            if (Anti.Count != 0)
            { Jogos.Add(Anti); }
            if (Dt.Count != 0)
            { Jogos.Add(Dt); }
            return View(Jogos);
        }

        //[HttpPost]
        //public async Task<IActionResult> Masterboard(int gameID)
        //{
        //    HttpClient client = MyHttpClient.Client;
        //    string path = "/api/Masterboard/" + Repository.TeamKey + "/" + gameID;

        //    HttpResponseMessage response = client.GetAsync(path).Result;
        //    string json = await response.Content.ReadAsStringAsync();
        //    int[,] board = JsonConvert.DeserializeObject<int[,]>(json);

        //    return View(board);
        //}


        //public IActionResult ModoAutonomo()
        //{
        //    List<Jogo> J = Repository.Jogos;
        //    Jogo j = J[J.Count - 1];
        //    return View(j);
        //}

        //[HttpPost]
        //public async Task<IActionResult> ModoAutonomo(int id, string Tipo)
        //{
        //    Jogo jogue = Repository.ObterJogo(id);

        //    int NrDisparos = 0;

        //    if (Tipo == "auto0")
        //    {
        //        NrDisparos = jogue.Misseis;
        //    }
        //    else if (Tipo == "auto3")
        //    {
        //        NrDisparos = 3;
        //    }
        //    else if (Tipo == "auto10")
        //    {
        //        NrDisparos = 10;
        //    }

        //    while (NrDisparos != 0)
        //    {
        //        ModoAutonomo1 m = new ModoAutonomo1();
        //        jogue.Coords = m.ReceberCoords(jogue.Grelha);

        //        HttpClient client = MyHttpClient.Client;
        //        string path = "api/Play";
        //        PlayRequest pr = new PlayRequest(id, jogue.Coords.X, jogue.Coords.Y, 0);
        //        string json = JsonConvert.SerializeObject(pr);

        //        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, path);
        //        request.Content = new StringContent(json, System.Text.Encoding.UTF8,
        //        "application/json");
        //        HttpResponseMessage response = await client.SendAsync(request);

        //        if (!response.IsSuccessStatusCode) { return Redirect("/"); }
        //        string json_r = await response.Content.ReadAsStringAsync();
        //        GameState gs = JsonConvert.DeserializeObject<GameState>(json_r);


        //        if (gs.Result == Resultado.SuccessHit)
        //        {

        //            jogue.Grelha[opcaoY, opcaoX] = gs.DamagedShipSize;
        //            jogue.Disparou(gs.DamagedShipSize, false, false);

        //        }
        //        else if (gs.Result == Resultado.SuccessMiss)
        //        {
        //            jogue.Grelha[opcaoY, opcaoX] = 0;
        //            jogue.Disparou(0, false, false);
        //        }
        //        else if (gs.Result == Resultado.SuccessSink)
        //        {
        //            jogue.Grelha[opcaoY, opcaoX] = gs.DamagedShipSize;

        //            jogue.Afundou(gs.DamagedShipSize);

        //            jogue.Disparou(gs.DamagedShipSize, false, true);
        //        }
        //        else if (gs.Result == Resultado.SuccessRepeat)
        //        {
        //            jogue.DisparouNasMesmasCoords();
        //        }
        //        else if (gs.Result == Resultado.SuccessVictory)
        //        {
        //            jogue.Grelha[opcaoY, opcaoX] = gs.DamagedShipSize;
        //            jogue.ResultadoJogada = jogue.ReceberResult(gs.Result);
        //            jogue.Disparou(gs.DamagedShipSize, true, true);
        //            jogue.FimdoJogo = "Ganhaste!";

        //            return View(jogue);
        //        }
        //        else if (gs.Result == Resultado.InvalidShot)
        //        {
        //            jogue.ResultadoJogada = jogue.ReceberResult(gs.Result);
        //        }
        //        else if (gs.Result == Resultado.GameHasEnded)
        //        {
        //            jogue.FimdoJogo = "Perdeste!";

        //            return View(jogue);
        //        }
        //        else if (gs.Result == Resultado.NoResult)
        //        {
        //            jogue.ResultadoJogada = jogue.ReceberResult(gs.Result);
        //        }

        //        NrDisparos--;

        //    }
        //    return View("Game", jogue);
        //}
    }
}