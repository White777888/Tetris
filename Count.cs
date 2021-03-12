using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Count
    {
        int count;
        public Count()
        {


        }
        public void Cou(int m)
        {

            count = count + m;
            for (int i = 0; i <= 5; i++)
            {
                Console.SetCursorPosition(63 + i, 6);
                Console.Write(' ');
            }
            Console.SetCursorPosition(63, 6);
            Console.Write(count);
        }
        public void ram(int x, int y, int x1, int y1)
        {
            for (int i = x; i <= x1; i++)
            {
                Console.SetCursorPosition(i, y);
                Console.Write('#');
            }
            for (int i = y; i <= y1; i++)
            {
                Console.SetCursorPosition(x1, i);
                Console.Write('#');
            }
            for (int i = x1; i > x; i--)
            {
                Console.SetCursorPosition(i, y1);
                Console.Write('#');
            }
            for (int i = y1; i > y; i--)
            {
                Console.SetCursorPosition(x, i);
                Console.Write('#');
            }
        }
    }
}
