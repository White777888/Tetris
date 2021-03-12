using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Tete : Figure
    {
        int h = 1;
        public Tete(int x, int y, char c)
        {
            Console.ForegroundColor = ConsoleColor.White;
            plist = new List<Point>();
            Point p = new Point(x, y, c);
            plist.Add(p);
            for (int i = 0; i <= 2; i++)
            {
                Point n = new Point(p.x + 1 - i, p.y + 1, p.c);
                plist.Add(n);
            }
        }
        public void Handle(ConsoleKey key, Tete v)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
                foreach (var p in plist)
                {
                    p.clear();
                    p.c = '@';
                    v.Move1(p, direction);
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
                    p.Draw();
                }

            }
            else if (key == ConsoleKey.UpArrow)
            {
                if (h == 1)
                {
                    Point z = plist.First();
                    foreach (var p in plist.ToArray())
                    {
                        p.clear();
                        plist.Remove(p);
                    }
                    Point q = new Point(z.x, z.y, z.c);
                    plist.Add(q);
                    for (int i = 0; i <= 2; i++)
                    {
                        Point p = new Point(q.x - 1, q.y - 1 + i, q.c);
                        plist.Add(p);
                    }
                    foreach (var p in plist)
                    {
                        p.Draw();
                    }
                    h++;
                }
                else if (h == 2)
                {
                    Point z = plist.First();
                    foreach (var p in plist.ToArray())
                    {
                        p.clear();
                        plist.Remove(p);
                    }
                    Point q = new Point(z.x, z.y, z.c);
                    plist.Add(q);
                    for (int i = 0; i <= 2; i++)
                    {
                        plist.Add(new Point(q.x - 1 + i, q.y - 1, q.c));
                    }
                    foreach (var p in plist)
                    {
                        p.Draw();
                    }
                    h = h - 3;
                }
                else if (h == -1)
                {
                    Point z = plist.First();
                    foreach (var p in plist.ToArray())
                    {
                        p.clear();
                        plist.Remove(p);
                    }
                    Point q = new Point(z.x, z.y, z.c);
                    plist.Add(q);
                    for (int i = 0; i <= 2; i++)
                    {
                        plist.Add(new Point(q.x + 1, q.y - 1 + i, q.c));
                    }
                    v.Drow();
                    h++;



                }
                else if (h == 0)
                {
                    Point z = plist.First();
                    foreach (var p in plist.ToArray())
                    {
                        p.clear();
                        plist.Remove(p);
                    }
                    Point q = new Point(z.x, z.y, z.c);
                    plist.Add(q);
                    for (int i = 0; i <= 2; i++)
                    {
                        plist.Add(new Point(q.x + 1 - i, q.y + 1, q.c));
                    }
                    v.Drow();
                    h++;

                }
            }

        }
        internal bool Ramca()
        {
            int q = 1;
            foreach (var p in plist)
            {
                if ((p.x - 1 == 29) || (p.x + 1 == 50))
                {
                    q = 0;
                    break;

                }


            }
            if (q == 1)
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
        internal bool stop()
        {
            int q = 0;
            foreach (var p in plist)
            {
                if (p.y + 1 == 24)
                {
                    q = 1;
                    break;
                }

            }
            if (q == 1)
            {
                return true;
            }
            else return false;
        }
    }
}
