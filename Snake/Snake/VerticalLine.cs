using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> vLine;

        public VerticalLine(){ }

        public VerticalLine(int yUp, int yDown, int x, char symbol)
        {
            vLine = new List<Point>();
            for(int y = yUp; y < yDown; y++)
            {
                Point p = new Point(x, y, symbol);
                vLine.Add(p);
            }
        }

        public void Draw()
        {
            foreach (Point t in vLine)
            {
                t.pointDraw();
 
            }
        }

    }
}
