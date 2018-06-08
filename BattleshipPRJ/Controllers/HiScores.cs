using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BattleshipPRJ.Models;



namespace BattleshipPRJ.Controllers
{
    [Route("api/[controller]")]
    public class HiScores : Controller
    {
        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]ApiHiScores api)
        {
            //Criei um model ApiHiScores, n sei se é assim

        }


    }
}
