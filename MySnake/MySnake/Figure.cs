﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    class Figure
    {
        protected List<Point> pList;
        public void drw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

    }
}