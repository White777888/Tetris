using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Point
    {
        public int x;
        public int y;
        public char c;
        public Point(int _x, int _y, char _c)
        {
            x = _x;
            y = _y;
            c = _c;

        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            c = p.c;

        }



        public void clear()
        {
            c = ' ';
            Draw();
        }

        public void change(int k)
        {
            x = x + k;

        }





    }

}
