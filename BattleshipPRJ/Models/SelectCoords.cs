using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipPRJ.Models
{
    public class SelectCoords
    {
        //campos
        private int m_CoordX;
        private int m_CoordY;

        //propriedades
        public int CoordX
        {
            get { return m_CoordX; }
            set { m_CoordX = value; }
        }
        public int CoordY
        {
            get { return m_CoordY; }
            set { m_CoordY = value; }
        }

        //CONSTRUTOR
        public SelectCoords(int sCoordsX, int sCoordsY)
        {
            m_CoordX = sCoordsX;
            m_CoordX = sCoordsX;
        }
    }
}
