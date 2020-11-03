using System;

namespace Lesson5Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("First number:");
                int number1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Second number:");
                int number2 = int.Parse(Console.ReadLine());

                if (number1 < number2)
                {
                    for (int i = number1 + 1; i < number2; i++)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Write correct number");
                    continue;
                }
            }
        }
    }
}
