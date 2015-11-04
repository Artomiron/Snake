﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> line;

        public void Draw()
        {
            foreach (Point t in line)
            {
                t.pointDraw();

            }
        }
    }
}
