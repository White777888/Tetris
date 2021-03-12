using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Vertical : Figure
    {

        int h = 1;


        public Vertical(int x, int y, char c)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            plist = new List<Point>();
            for (int i = 0; i < 4; i++)
            {
                y = y + 1;
                Point p = new Point(x, y, c);
                plist.Add(p);
            }

        }


        public Point getNextPoint()
        {
            Point head = plist.Last();
            Point nextpoint = new Point(head);
            nextpoint.y++;
            return nextpoint;
        }

        public void Handle(ConsoleKey key, Vertical v)
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


                int i = 4;
                if (h % 2 == 1)
                {
                    foreach (var p in plist)
                    {

                        p.clear();
                        p.c = '@';

                        p.x = p.x + i;
                        p.y = p.y + i; ;
                        p.Draw();
                        i--;

                    }
                    h++;
                }
                else
                {
                    int l = 3;
                    foreach (var p in plist)
                    {

                        p.clear();
                        p.c = '@';

                        p.x = p.x - l;
                        p.y = p.y - l; ;
                        p.Draw();
                        l--;

                    }
                    h++;


                }



            }

        }









        internal bool Ramca()
        {
            Point p = plist.First();
            if ((p.x + 1 != 31) && (p.x != 49))
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
