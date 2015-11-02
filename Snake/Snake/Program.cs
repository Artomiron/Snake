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


            Point p1 = new Point(1, 3, '*');
            //p1.Draw();

            Point p2 = new Point(4, 5, '#');
           // p2.Draw();

            Point p3 = new Point(9, 2, '@');
           // p3.Draw();

            #region    работа со списками
           /* List<int> myList = new List<int>();
            myList.Add(2);
            myList.Add(4);
            myList.Add(7);

            int x = myList[0];
            int y = myList[1];
            int z = myList[2];

            foreach(int i in myList)
            {
                Console.WriteLine("Element of the list " + i);
            }

            List<Point> myPointList = new List<Point>();
            myPointList.Add(p1);
            myPointList.Add(p2);


            foreach (Point yy in myPointList)
            {
                yy.Draw();
                //Console.WriteLine(yy);
            }*/
            #endregion
            List<char> sympolList = new List<char>();
            sympolList.Add('!');
            sympolList.Add('@');
            sympolList.Add('$');
            sympolList.Add('^');
            sympolList.Add('%');

            foreach(char Y in sympolList)
            {
                Console.WriteLine("Oll symbols " + Y);
            }

            sympolList.RemoveAt(3);
            foreach (char Y in sympolList)
            {
                Console.WriteLine("Symbols after deleted " + Y);
            }


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
