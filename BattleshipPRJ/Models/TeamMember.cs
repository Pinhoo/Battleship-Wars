using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipPRJ.Models
{
    public class TeamMember
    {

        public string NomeEquipa { get; set; }
        public string NomeMembro { get; set; }
        public string NumeroAluno { get; set; }

        public TeamMember(string nomeequipa, string nomemembro, string numero)
        {
            NomeEquipa = nomeequipa;
            NomeMembro = nomemembro;
            NumeroAluno = numero;

        }
            

    }
}
