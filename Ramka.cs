using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Ramka
    {
        int i;
        public Ramka(int x, int y, char c)
        {
            for (i = 0; i < 24; i++)
            {
                Point p = new Point(x, y - i, c);
                p.Draw();

            }
            y = y - i;
            for (i = 0; i < 21; i++)
            {
                Point p = new Point(x + i, y, c);
                p.Draw();
            }
            x = x + i;
            for (i = 0; i < 24; i++)
            {
                Point p = new Point(x, y + i, c);
                p.Draw();

            }
            y = y + i;
            for (i = 0; i < 21; i++)
            {
                Point p = new Point(x - i, y, c);
                p.Draw();

            }
            x = x - i;

        }
    }
}
