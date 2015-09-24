using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitP
{
    class Program
    {
        public static void HelloGit ()
        {
            Console.WriteLine("Hello Github");
        }

        public static void FizzBuzz()
        {
            Console.WriteLine("Kérek egy számot: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; ++i)
            {
                //if (Ketto(i) && Harom(i))
                //{
                //    Console.WriteLine("FizzBuzz");
                //}
                //else
                //{
                //    switch (Ketto(i) || Harom(i))
                //    {
                //        case true:
                //            Eldont(i);
                //            break;

                //        default:
                //            {
                //                Console.WriteLine(i);
                //            }
                //            break;
                //    }
                //}

                //Ketto(i) && Harom(i) ? FB() : Eldont(y) ;

                if (Ketto(i) && Harom(i) == true)
                {
                    FB();
                }
                else
                {
                    Eldont(i);
                }

            }
        }

        public static bool Ketto(int y)
        {
            if (y % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool Harom(int y)
        {
            if (y % 3 == 0)
            {
                return true;
            }
            return false;
        }

        public static void FB()
        {
            Console.WriteLine("fizzbuzz");
        }

        public static void Eldont(int y)
        {
            switch (Ketto(y))
            {
                case true:
                    Console.WriteLine("Fizz");
                    break;
                default:
                    if (Harom(y))
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(y);
                    }
                    break;
            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello Github");
            //Console.ReadLine();

            HelloGit();

            FizzBuzz();

            Console.ReadLine();
        }
    }
}
