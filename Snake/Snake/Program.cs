﻿using System;
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
            Point p1 = new Point(1, 3, '*');
            p1.pointDraw();

            Point p2 = new Point(4, 5, '#');
            p2.pointDraw();

            Point p3 = new Point(9, 2, '@');
            p3.pointDraw();

            HorizontalLine line = new HorizontalLine(12, 17, 6, '+');
            line.Draw();

            VerticalLine firstVline = new VerticalLine(7, 19, 12, '@');
            firstVline.Draw();

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
