using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Ziga2 : Figure
    {
        int h = 1;
        public Ziga2(int x, int y, char c)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            plist = new List<Point>();
            for (int i = 0; i <= 1; i++)
            {
                Point p = new Point(x - i, y, c);
                plist.Add(p);
            }
            for (int i = 0; i <= 1; i++)
            {
                Point p = new Point(x - 1 - i, y + 1, c);
                plist.Add(p);
            }

        }
        public void Handle(ConsoleKey key, Ziga2 v)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
                foreach (var p in plist)
                {
                    p.clear();
                    p.c = '@';
                    v.Move1(p, direction);

                }
                foreach (var p in plist)
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
                    v.Move1(p, direction);
                }
                foreach (var p in plist)
                {
                    p.Draw();
                }
            }
            else if (key == ConsoleKey.UpArrow)
            {
                if (h % 2 == 1)
                {
                    Point z = plist.First();
                    foreach (var p in plist.ToArray())
                    {
                        p.clear();
                        plist.Remove(p);
                    }
                    Point q = new Point(z.x - 1, z.y - 1, z.c);
                    for (int i = 0; i <= 1; i++)
                    {
                        Point p = new Point(q.x, q.y + i, q.c);
                        plist.Add(p);
                    }
                    for (int i = 0; i <= 1; i++)
                    {
                        Point p = new Point(q.x + 1, q.y + 1 + i, q.c);
                        plist.Add(p);
                    }
                    foreach (var p in plist)
                    {
                        p.Draw();
                    }
                    h++;


                }
                else if (h % 2 == 0)
                {
                    Point z = plist.First();
                    foreach (var p in plist.ToArray())
                    {
                        p.clear();
                        plist.Remove(p);
                    }
                    Point q = new Point(z.x + 1, z.y + 1, z.c);
                    for (int i = 0; i <= 1; i++)
                    {
                        Point p = new Point(q.x - i, q.y, q.c);
                        plist.Add(p);
                    }
                    for (int i = 0; i <= 1; i++)
                    {
                        Point p = new Point(q.x - 1 - i, q.y + 1, q.c);
                        plist.Add(p);
                    }
                    foreach (var p in plist)
                    {
                        p.Draw();
                    }
                    h++;
                }
            }

        }
        internal bool Ramca()
        {
            Point p = plist.First();
            Point p1 = plist.Last();
            if ((p.x - 1 != 29) && (p.x + 1 != 50) && (p1.x - 1 != 29) && (p1.x + 1 != 50))
            {
                return true;
            }
            else return false;
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