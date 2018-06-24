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
                NewGameRequest ngreq = new NewGameRequest(jogo.Nome, missao);//ngreq new game request
                string json = JsonConvert.SerializeObject(ngreq);

                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, path);
                request.Content = new StringContent(json, System.Text.Encoding.UTF8,
                "application/json");
                HttpResponseMessage response = await client.SendAsync(request);

                if (!response.IsSuccessStatusCode) { return Redirect("/"); }
                string json_r = await response.Content.ReadAsStringAsync();
                GameState gs = JsonConvert.DeserializeObject<GameState>(json_r);

                jogo.CalcularNumeroDisparos(jogo.Nome);

                int i = 1; //para ronda anterior

                Coordenadas Coordenada;

                ModoAutonomo ModoAuto = new ModoAutonomo();

                while (true)
                {
                    HttpClient client1 = MyHttpClient.Client;
                    string path1 = "api/Play";

                    jogo.ID = gs.GameID;

                    Coordenada = ModoAuto.CoordenadasProximoTiro(jogo.GrelhaModoAuto, jogo.UltimoBarcoAcertado, jogo.Afundou, jogo.CoordsUltimoTiro);
                    
                    PlayRequest pr = new PlayRequest(jogo.ID, Coordenada.X, Coordenada.Y, 0);
                    string json1 = JsonConvert.SerializeObject(pr);

                    HttpRequestMessage request1 = new HttpRequestMessage(HttpMethod.Post, path1);
                    request1.Content = new StringContent(json1, System.Text.Encoding.UTF8,
                    "application/json");
                    HttpResponseMessage response1 = await client.SendAsync(request1);

                    if (!response1.IsSuccessStatusCode) { return Redirect("/"); }
                    string json_r1 = await response1.Content.ReadAsStringAsync();
                    GameState gs1 = JsonConvert.DeserializeObject<GameState>(json_r1);
                    

                    RoundSummary rs = new RoundSummary();

                    if (jogo.Rss.Count != 0)
                    {
                        RoundSummary rondaanterior = jogo.Rss[i - 1];
                        i++;
                        rs.AtualizarRonda(gs1.Result, Coordenada.Y, Coordenada.X, gs1.DamagedShipSize, gs1.RoundNumber, rondaanterior);
                    }
                    else
                    {
                        rs.AtualizarRonda(gs1.Result, Coordenada.Y, Coordenada.X, gs1.DamagedShipSize, gs1.RoundNumber);
                    }


                    //modo auto metodos de ajuda

                    jogo.MarcarGrelhas(Coordenada.X, Coordenada.Y, gs1.DamagedShipSize);
                    
                    if (gs1.Result == Resultado.SuccessVictory)
                    {
                        jogo.FimdoJogo = "Vitória";
                    }
                    else if (gs1.Result == Resultado.SuccessSink)
                    {
                        jogo.GrelhaModoAuto = ModoAuto.MarcarAdjacentes(jogo.GrelhaModoAuto, gs1.DamagedShipSize);
                        jogo.Afundou = true;
                    }
                    else
                    {
                        if(gs1.Result == Resultado.SuccessHit)
                        {
                        jogo.Afundou = false;
                        }
                    }



                    if (gs1.DamagedShipSize != 0)//no caso de ser hit
                    {
                        jogo.CoordenadasUltimoTiroAcertado(Coordenada, gs1.DamagedShipSize);
                    }

                    //modo auto fim

                    jogo.AtualizarJogada(gs1, Coordenada.X, Coordenada.Y);

                    rs.ScoreFimRonda = jogo.Score;

                    jogo.FinalizarRonda(rs);

                    if (gs1.Result == Resultado.SuccessVictory)
                    {
                        jogo.NumeroDisparosAutonomo = 0;
                    }

                    if (jogo.NumeroDisparosAutonomo == 0)
                    {
                        break;
                    }

                }


                HttpClient client2 = MyHttpClient.Client;
                string path2 = "api/Play";
                PlayRequest pr2 = new PlayRequest(jogo.ID, 1, 1, PlayerAction.Quit);
                string json2 = JsonConvert.SerializeObject(pr2);

                HttpRequestMessage request2 = new HttpRequestMessage(HttpMethod.Post, path2);
                request2.Content = new StringContent(json2, System.Text.Encoding.UTF8,
                "application/json");
                HttpResponseMessage response2 = await client.SendAsync(request2);

                if (!response2.IsSuccessStatusCode) { return Redirect("/"); }
                string json_r2 = await response2.Content.ReadAsStringAsync();
                GameState gs2 = JsonConvert.DeserializeObject<GameState>(json_r2);


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

                if (gs.Result == Resultado.SuccessVictory || jogue.Misseis == 0)
                {
                    HiScoresModel hiscore = new HiScoresModel(jogue.Nome, jogue.Score, jogue.PercentagemAlvo, jogue.PercentagemAfundado, jogue.TirosAgua, jogue.TirosAlvo, jogue.TirosRepetido, jogue.FimdoJogo, jogue.Missao);

                    Repository.AddHighScore(hiscore);

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

                    HiScoresModel hiscore = new HiScoresModel(jogue.Nome, jogue.Score, jogue.PercentagemAlvo, jogue.PercentagemAfundado, jogue.TirosAgua, jogue.TirosAlvo, jogue.TirosRepetido, jogue.FimdoJogo, jogue.Missao);

                    Repository.AddHighScore(hiscore);
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

    }
}