using System;

namespace Lesson5Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("я йду він залишається:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Your answer:");
                string answer = Console.ReadLine();


                if (answer == "footprint" || answer == "Footprint" || answer == "FOOTPRINT" || answer == "footPrint")
                {
                    Console.WriteLine("Correct answer");
                    //return;
                    break;
                }

                else if (answer == "")
                {
                    Console.WriteLine("Empty line,please enter answer");
                    
                }
                else
                {
                    Console.WriteLine("Your answer:");
                   
                }
                if (i == 4)
                {
                    Console.WriteLine("You lose");
                }
            }
            //Console.WriteLine("You lose");
        }
    }
}
