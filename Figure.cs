using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Figure
    {

        protected List<Point> plist;
        protected Direction direction;

        public virtual void Drow()
        {
            foreach (Point p in plist)
            {
                p.Draw();
            }
        }

        internal void Move()
        {
            foreach (var p in plist)
            {
                p.clear();
                p.c = '@';

                p.y = p.y + 1;

            }
            foreach (var p in plist)
            {
                p.Draw();

            }

        }

        public void splicing(List<Point> blist)
        {
            foreach (var p in plist)
            {
                blist.Add(p);

            }
        }
        internal bool Board(List<Point> blist)
        {
            int m = 0;
            foreach (var b in plist)
            {
                foreach (var p in blist)
                {

                    if ((b.y + 1 == p.y) && (b.x == p.x))
                    {
                        m = 1;
                        break;
                    }
                }
                if (m == 1)
                {
                    break;
                }
            }

            if (m == 1)
            {
                return true;
            }
            else return false;

        }
        public void wash(List<Point> blist)
        {

            foreach (var p in blist)
            {
                if ((p.y == 22) && (p.c == '@'))
                {
                    p.clear();
                    blist.Remove(p);
                }
            }

        }
        internal bool wash1(List<Point> blist, int i)
        {
            int f = 0;


            foreach (var p in blist)
            {
                if (p.y == i)
                {
                    f++;
                }


            }


            if (f == 20)
            {
                return true;

            }
            else return false;

        }
        internal bool correct(List<Point> blist, Point p)
        {
            int q = 1;
            foreach (var z in blist)
            {
                if ((p.y + 1 == z.y) & (p.x == z.x))
                {
                    q = 0;

                    break;

                }



            }
            if (q == 0)
            {
                return false;
            }
            else return true;

        }
        public void Move1(Point p, Direction direction)
        {
            if (direction == Direction.LEFT)
            {
                int k = -1;
                p.change(k);

            }
            else if (direction == Direction.RIGHT)
            {
                int k = 1;
                p.change(k);


            }
        }
        internal bool stop()
        {

            Point n = plist.Last();

            if (n.y + 1 == 24)
            {
                return true;
            }
            else return false;


        }

    }
}
