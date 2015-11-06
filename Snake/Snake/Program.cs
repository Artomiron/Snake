using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            //
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0,'+');
            VerticalLine rightLine = new VerticalLine(0,24,78,'+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            // отрисовка точек
            Point p = new Point(4, 5, '*');
            Shake mySnake = new Shake(p, 5, Direction.RIGHT);
            mySnake.Draw();
            mySnake.Move();
            Thread.Sleep(300);
            mySnake.Move();
            Thread.Sleep(300);
            mySnake.Move();
            Thread.Sleep(300);
            mySnake.Move();
            Thread.Sleep(300);
            mySnake.Move();
            Thread.Sleep(300);
            mySnake.Move();
            Thread.Sleep(300);
            mySnake.Move();



            Console.ReadLine();
        }
    }
}
