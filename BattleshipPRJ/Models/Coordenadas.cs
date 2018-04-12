using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipPRJ.Models
{
    public class Coordenadas
    {

        private int m_selectedcoordx;
        private int m_selectedcoordy;


        public int SelectedCoordX
        {

            get
            {
                return m_selectedcoordx;
            }

            set
            {
                m_selectedcoordx = value;

            }
        }


        public int SelectedCoordY
        {

            get
            {
                return m_selectedcoordy;
            }

            set
            {
                m_selectedcoordy = value;

            }
        }




        public Coordenadas(int coordx, int coordy)
        {
            m_selectedcoordx = coordx;

            m_selectedcoordy = coordy;


        }

    }
}
