using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sum;

        public Point(int x, int y, char sum)
        {
            this.x = x;
            this.y = y;
            this.sum = sum;  
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sum);
        }
    }
}
