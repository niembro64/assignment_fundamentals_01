using System;

namespace assignment_fundamentals_01
{
    class Program
    {

        static int p(string s)
        {
            Console.Write(s);
            return 0;
        }
        static void Main(string[] args)
        {
            int x, i;

            x = 255;
            for (i = 1; i <= x; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("Ciao");


            x = 100;
            for (i = 0; i <= x; i++)
            {

                if (i % 3 == 0)
                {

                    Console.Write("Fizz");
                }
                if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine($" | {i}");
                }

            }



            x = 100;
            i = 0;
            while (i <= x)
            {

                if (i % 3 == 0)
                {

                    Console.Write("Fizz");
                }
                if (i % 5 == 0)
                {

                    Console.Write("Buzz");
                }
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine($" | {i}");
                }
                i++;

            }


        }
    }
}
