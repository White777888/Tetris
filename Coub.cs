using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Coub : Figure
    {
        public Coub(int x, int y, char c)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            plist = new List<Point>();
            Point p = new Point(x,y,c);
            plist.Add(p);
            Point p1 = new Point(x + 1, y, c);
            plist.Add(p1);
            Point p2 = new Point(x + 1,y+1,c);
            plist.Add(p2);
            Point p3 = new Point(x, y + 1, c);
            plist.Add(p3);
        }
        public void Handle(ConsoleKey key,  Coub c)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
                foreach (var p in plist)
                {
                    p.clear();
                    p.c = '@';
                    c.Move1(p, direction);
                    
                }
                foreach(var p in plist)
                {
                    p.Draw();
                }

            }
            else if (key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
                foreach (var p in plist)
                {
                    p.clear();
                    p.c = '@';

                    c.Move1(p, direction);
                    
                }
                foreach (var p in plist)
                {
                    p.Draw();
                }
            }
        }

     
        internal bool Ramca()
        {
            int i = 1;
            foreach (var p in plist)
            {
                if ((p.x - 1 == 29) || (p.x+1 == 50))
                {
                    i = 0;
                    break;
                }
            }
            if (i == 0)
            {
                return false;
            }
            else return true;
        }
        internal bool cucha(List<Point> blist)
        {
            int q = 1;
            foreach (var s in plist)
            {
                foreach (var p in blist)
                {
                    if ((s.x + 1 == p.x) && (s.y == p.y) || (s.x - 1 == p.x) && (s.y == p.y))
                    {
                        q = 0;
                        break;
                    }
                }
            }
            if (q == 0)
            {
                return false;
            }
            else return true;
        }

    }
}
