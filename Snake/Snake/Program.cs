using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



            #region представление точек без ООП
            //Console.WriteLine("Let's start programing Snake!!!");
            /*int x1 = 1;
            int y1 = 3;
            char sym1 = '*';
            Draw(x1, y1, sym1);
            int x2 = 4;
            int y2 = 5;
            char sym2 = '*';
            Draw(x2, y2, sym2);*/
            #endregion

            Console.ReadLine();
        }
    }
}
