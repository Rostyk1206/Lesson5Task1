using System;

namespace Lesson5Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        for (int f = 0; f < 5; f++)
                        {
                            for (int q = 0; q < 5; q++)
                            {
                                result++;
                                
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"{result}");
            Console.ReadLine();
        }
    }
}
