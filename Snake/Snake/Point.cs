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

        public Point() { }

        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
            this.sum = p.sum;
        }

        public Point(int x, int y, char sum)
        {
            this.x = x;
            this.y = y;
            this.sum = sum;  
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
                x = x + offset;
            else
                if (direction == Direction.LEFT)
                    x = x - offset;
                else
                    if (direction == Direction.UP)
                        y = y + offset;
                    else
                        if (direction == Direction.DOWN)
                            y = y - offset;
        }

        public void pointDraw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sum);
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sum;
        }
    }
}
