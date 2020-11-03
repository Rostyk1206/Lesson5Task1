using System;

namespace Lesson5Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //квадрат
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("______________________________________");

            //прямокутна трапеція
            int a = 10;
            int b = 20;
            for (int i = 0; i < 10; i++)
            {
                for (int j =0 ; j > 1; j--)
                {
                    Console.Write(" ");
                }
                for(int j=0;j<b;j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                a--;
                b=b + 4;
            }
            Console.WriteLine("_________________________________________");
            
            //рівнобедрена трапеція
            int q = 10;
            int w = 20;
            for (int i = 0; i < 10; i++)
            {
                for (int j = q; j > 1; j--)
                {
                    Console.Write(" ");
                }
                for (int j = q; j < w; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                q--;
                w = w + 1;
            }
            Console.WriteLine("_________________________________________");
            Console.ReadKey();
        }
    }
}
