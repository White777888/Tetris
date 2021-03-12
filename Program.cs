using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Media;

namespace Tetris
{
    class Program
    {

        static void Main(string[] args)

        {
            
                SoundPlayer sp = new SoundPlayer("Raise The Flag - Killrude.wav");
                sp.Play();
            int olay = 0;
            int end = 1;
            string c;
            int h = 1;
            string hard;
            int value;
            int a = 0;
            List<Point> blist = new List<Point>();
            Console.SetBufferSize(200, 200);
            Console.SetCursorPosition(20,8);
            Console.Write("Выберите уровень сложости(введите число)");
            Console.SetCursorPosition(38,10);
            Console.Write("1)Лёгкий");
            Console.SetCursorPosition(38, 12);
            Console.Write("2)Средний");
            Console.SetCursorPosition(38, 14);
            Console.Write("3)Тяжёлый");
            Console.SetCursorPosition(45, 16);
            
            hard = Console.ReadLine();
            if (hard =="1")
            {
                h = 300;
            }else if (hard =="2")
            {
                h = 230;
            }else if (hard == "3")
            {
                h = 195;
            }
            Console.Clear();
            Ramka r = new Ramka(29, 24, '*');

            int an = 1;
            Random rnd = new Random();
            Count cou = new Count();
            cou.ram(61, 3, 71, 9);
            
            
            do {
                while (true)
                {

                    if (an == 0)
                    {
                        break;
                    }
                    value = rnd.Next(1, 14);
                    if ((value > 0) && (value < 3))
                    {
                        Vertical v = new Vertical(39, 1, '@');
                        v.Drow();
                        while (true)
                        {

                            if (Console.KeyAvailable)
                            {
                                if (v.Ramca() && v.cucha(blist))
                                {
                                    ConsoleKeyInfo key = Console.ReadKey();
                                    v.Handle(key.Key, v);
                                    
                                }
                            }

                            if (v.stop() || v.Board(blist))
                            {
                                v.splicing(blist);
                                for (int i = 1; i <= 23; i++)
                                {
                                    if (v.wash1(blist, i))
                                    {
                                        a = 1;
                                        cou.Cou(100);
                                        foreach (var p in blist.ToArray())
                                        {
                                            if ((p.y == i))
                                            {
                                                p.clear();
                                                blist.Remove(p);
                                            }
                                        }

                                    }
                                }

                                if (a == 1)
                                {
                                    for (int z = 1; z < 24; z++)
                                    {

                                        for (int m = 24; m >= 1; m--)
                                        {




                                            foreach (var p in blist)
                                            {
                                                if ((p.y + 1 != 24) & (v.correct(blist, p)) & (p.y == m))
                                                {
                                                    p.clear();
                                                    p.c = '@';
                                                    p.y++;
                                                    p.Draw();
                                                }

                                            }

                                        }
                                    }
                                    a = 0;

                                }
                                olay = olay + 100;
                                if (olay >2000)
                                {
                                    olay = 0;
                                    sp.Play();
                                }


                                break;
                            }
                            v.Move();
                            Thread.Sleep(h);


                        }
                    }
                    else if ((value > 2) && (value < 5))
                    {
                        Tete v = new Tete(39, 1, '@');
                        v.Drow();
                        while (true)
                        {

                            if (Console.KeyAvailable)
                            {
                                if (v.Ramca() && v.cucha(blist))
                                {
                                    ConsoleKeyInfo key = Console.ReadKey();
                                    v.Handle(key.Key, v);
                                }
                            }

                            if (v.stop() || v.Board(blist))
                            {
                                v.splicing(blist);
                                for (int i = 1; i <= 23; i++)
                                {
                                    if (v.wash1(blist, i))
                                    {
                                        a = 1;
                                        cou.Cou(100);
                                        foreach (var p in blist.ToArray())
                                        {
                                            if ((p.y == i))
                                            {
                                                p.clear();
                                                blist.Remove(p);
                                            }
                                        }

                                    }
                                }

                                if (a == 1)
                                {
                                    for (int z = 1; z < 24; z++)
                                    {

                                        for (int m = 24; m >= 1; m--)
                                        {




                                            foreach (var p in blist)
                                            {
                                                if ((p.y + 1 != 24) & (v.correct(blist, p)) & (p.y == m))
                                                {
                                                    p.clear();
                                                    p.c = '@';
                                                    p.y++;
                                                    p.Draw();
                                                }

                                            }

                                        }
                                    }
                                    a = 0;

                                }
                                olay = olay + 100;
                                if (olay > 2000)
                                {
                                    olay = 0;
                                    sp.Play();
                                }


                                break;
                            }
                            v.Move();
                            Thread.Sleep(h);


                        }
                    }
                    else if ((value > 4) && (value < 7))
                    {
                        Gege2 v = new Gege2(39, 1, '@');
                        v.Drow();
                        while (true)
                        {

                            if (Console.KeyAvailable)
                            {
                                if (v.Ramca() && v.cucha(blist))
                                {
                                    ConsoleKeyInfo key = Console.ReadKey();
                                    v.Handle(key.Key, v);
                                }
                            }

                            if (v.stop() || v.Board(blist))
                            {
                                v.splicing(blist);
                                for (int i = 1; i <= 23; i++)
                                {
                                    if (v.wash1(blist, i))
                                    {
                                        a = 1;
                                        cou.Cou(100);
                                        foreach (var p in blist.ToArray())
                                        {
                                            if ((p.y == i))
                                            {
                                                p.clear();
                                                blist.Remove(p);
                                            }
                                        }

                                    }
                                }

                                if (a == 1)
                                {
                                    for (int z = 1; z < 24; z++)
                                    {

                                        for (int m = 24; m >= 1; m--)
                                        {




                                            foreach (var p in blist)
                                            {
                                                if ((p.y + 1 != 24) & (v.correct(blist, p)) & (p.y == m))
                                                {
                                                    p.clear();
                                                    p.c = '@';
                                                    p.y++;
                                                    p.Draw();
                                                }

                                            }

                                        }
                                    }
                                    a = 0;

                                }
                                olay = olay + 100;
                                if (olay > 2000)
                                {
                                    olay = 0;
                                    sp.Play();
                                }


                                break;
                            }
                            v.Move();
                            Thread.Sleep(h);


                        }
                    }
                    else if ((value > 6) && (value < 9))
                    {
                        Gege1 v = new Gege1(39, 1, '@');
                        v.Drow();
                        while (true)
                        {

                            if (Console.KeyAvailable)
                            {
                                if (v.Ramca() && v.cucha(blist))
                                {
                                    ConsoleKeyInfo key = Console.ReadKey();
                                    v.Handle(key.Key, v);
                                }
                            }

                            if (v.stop() || v.Board(blist))
                            {
                                v.splicing(blist);
                                for (int i = 1; i <= 23; i++)
                                {
                                    if (v.wash1(blist, i))
                                    {
                                        a = 1;
                                        cou.Cou(100);
                                        foreach (var p in blist.ToArray())
                                        {
                                            if ((p.y == i))
                                            {
                                                p.clear();
                                                blist.Remove(p);
                                            }
                                        }

                                    }
                                }

                                if (a == 1)
                                {
                                    for (int z = 1; z < 24; z++)
                                    {

                                        for (int m = 24; m >= 1; m--)
                                        {




                                            foreach (var p in blist)
                                            {
                                                if ((p.y + 1 != 24) & (v.correct(blist, p)) & (p.y == m))
                                                {
                                                    p.clear();
                                                    p.c = '@';
                                                    p.y++;
                                                    p.Draw();
                                                }

                                            }

                                        }
                                    }
                                    a = 0;

                                }
                                olay = olay + 100;
                                if (olay > 2000)
                                {
                                    olay = 0;
                                    sp.Play();
                                }


                                break;
                            }
                            v.Move();
                            Thread.Sleep(h);


                        }
                    }
                    else if ((value > 8) && (value < 11))
                    {
                        Ziga2 v = new Ziga2(39, 1, '@');
                        v.Drow();
                        while (true)
                        {

                            if (Console.KeyAvailable)
                            {
                                if (v.Ramca() && v.cucha(blist))
                                {
                                    ConsoleKeyInfo key = Console.ReadKey();
                                    v.Handle(key.Key, v);
                                }
                            }

                            if (v.stop() || v.Board(blist))
                            {
                                v.splicing(blist);
                                for (int i = 1; i <= 23; i++)
                                {
                                    if (v.wash1(blist, i))
                                    {
                                        a = 1;
                                        cou.Cou(100);
                                        foreach (var p in blist.ToArray())
                                        {
                                            if ((p.y == i))
                                            {
                                                p.clear();
                                                blist.Remove(p);
                                            }
                                        }

                                    }
                                }

                                if (a == 1)
                                {
                                    for (int z = 1; z < 24; z++)
                                    {

                                        for (int m = 24; m >= 1; m--)
                                        {




                                            foreach (var p in blist)
                                            {
                                                if ((p.y + 1 != 24) & (v.correct(blist, p)) & (p.y == m))
                                                {
                                                    p.clear();
                                                    p.c = '@';
                                                    p.y++;
                                                    p.Draw();
                                                }

                                            }

                                        }
                                    }
                                    a = 0;

                                }
                                olay = olay + 100;
                                if (olay > 2000)
                                {
                                    olay = 0;
                                    sp.Play();
                                }


                                break;
                            }
                            v.Move();
                            Thread.Sleep(h);


                        }
                    }
                    else if ((value > 10) && (value < 13))
                    {
                        Ziga1 v = new Ziga1(39, 1, '@');
                        v.Drow();
                        while (true)
                        {

                            if (Console.KeyAvailable)
                            {
                                if (v.Ramca() && v.cucha(blist))
                                {
                                    ConsoleKeyInfo key = Console.ReadKey();
                                    v.Handle(key.Key, v);
                                }
                            }

                            if (v.stop() || v.Board(blist))
                            {
                                v.splicing(blist);
                                for (int i = 1; i <= 23; i++)
                                {
                                    if (v.wash1(blist, i))
                                    {
                                        a = 1;
                                        cou.Cou(100);
                                        foreach (var p in blist.ToArray())
                                        {
                                            if ((p.y == i))
                                            {
                                                p.clear();
                                                blist.Remove(p);
                                            }
                                        }

                                    }
                                }

                                if (a == 1)
                                {
                                    for (int z = 1; z < 24; z++)
                                    {

                                        for (int m = 24; m >= 1; m--)
                                        {




                                            foreach (var p in blist)
                                            {
                                                if ((p.y + 1 != 24) & (v.correct(blist, p)) & (p.y == m))
                                                {
                                                    p.clear();
                                                    p.c = '@';
                                                    p.y++;
                                                    p.Draw();
                                                }

                                            }

                                        }
                                    }
                                    a = 0;

                                }
                                olay = olay + 100;
                                if (olay > 2000)
                                {
                                    olay = 0;
                                    sp.Play();
                                }


                                break;
                            }
                            v.Move();
                            Thread.Sleep(h);


                        }
                    }
                    else if ((value > 12) && (value < 15))
                    {
                        Coub v = new Coub(39, 1, '@');
                        v.Drow();
                        while (true)
                        {

                            if (Console.KeyAvailable)
                            {
                                if (v.Ramca() && v.cucha(blist))
                                {
                                    ConsoleKeyInfo key = Console.ReadKey();
                                    v.Handle(key.Key, v);
                                }
                            }

                            if (v.stop() || v.Board(blist))
                            {
                                v.splicing(blist);
                                for (int i = 1; i <= 23; i++)
                                {
                                    if (v.wash1(blist, i))
                                    {
                                        a = 1;
                                        cou.Cou(100);
                                        foreach (var p in blist.ToArray())
                                        {
                                            if ((p.y == i))
                                            {
                                                p.clear();
                                                blist.Remove(p);
                                            }
                                        }

                                    }
                                }

                                if (a == 1)
                                {
                                    for (int z = 1; z < 24; z++)
                                    {

                                        for (int m = 24; m >= 1; m--)
                                        {




                                            foreach (var p in blist)
                                            {
                                                if ((p.y + 1 != 24) & (v.correct(blist, p)) & (p.y == m))
                                                {
                                                    p.clear();
                                                    p.c = '@';
                                                    p.y++;
                                                    p.Draw();
                                                }

                                            }

                                        }
                                    }
                                    a = 0;

                                }
                                olay = olay + 100;
                                if (olay > 2000)
                                {
                                    olay = 0;
                                    sp.Play();
                                }


                                break;
                            }
                            v.Move();
                            Thread.Sleep(h);


                        }
                    }

                    foreach (var p in blist)
                    {

                        if ((p.y < 6) & (p.x == 39))
                        {
                            an = 0;
                            break;
                        }

                    }

                }
                Console.SetCursorPosition(10,10);
                Console.WriteLine("Продолжить игру?");
                Console.SetCursorPosition(15, 11);
                Console.Write("Да,Нет ");
                
                c = Console.ReadLine();
                if ((c=="нет")||(c=="Нет"))
                {
                    end = 0;
                }else
                {
                    an = 1;
                    foreach (var p in blist.ToArray())
                    {
                        p.clear();
                        blist.Remove(p);
                    }
                    for (int i = 0;i<16;i++)
                    {
                        Console.SetCursorPosition(10+i,10);
                        Console.Write(' ');
                        Console.SetCursorPosition(10 + i, 11);
                        Console.Write(' ');
                    }

                }
            } while (end == 1);

            

        }

        
           
    }
}

