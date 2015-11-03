using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> pList;

        public HorizontalLine(int xLeft, int xRight, int y, char sum)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sum);
                pList.Add(p);
            }
        }

        public void lineDraw()
        { 
            foreach(Point z in pList)
            {
                z.pointDraw();
            }
        }
    }
}
