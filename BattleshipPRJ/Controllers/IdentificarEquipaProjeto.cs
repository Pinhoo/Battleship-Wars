using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BattleshipPRJ.Models;



namespace BattleshipPRJ.Controllers
{
    [Route("api/[controller]")]
    public class IdentificarEquipaProjeto : Controller
    {
        //GET: api/<controller>
        [HttpGet]
        public List<TeamMember> Get()
        {

            List<TeamMember> teamMembers = Repository.TeamMembers;
            return teamMembers;
        }
    }
}