using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipPRJ.Models
{
    public class Player
    {

        private string m_nome;
        private string m_missao;
        private int m_misseis;
        private bool m_ganhou;
        private int m_score;


        public string Nome {
            get { return m_nome; }
            set { m_nome = value; }
        }
        public string Missao {
            get { return m_missao; }
            set { m_missao = value; }
        }
        public int Misseis {
            get { return m_misseis; }
            set { m_misseis = value; }
        }
        public bool Ganhou {
            get { return m_ganhou; }
            set { m_ganhou = value; }
        }
        public int Score {
            get { return m_score; }
            set { m_score = value; }
        }

        public Player(string Nome, string Missao, int Misseis, bool Ganhou, int Score)
        {
            m_nome = Nome;
            m_missao = Missao;
            m_misseis = 0;
            m_ganhou = false;
            m_score = 0;
            

        }

        public Player()
        { }







    }
}
