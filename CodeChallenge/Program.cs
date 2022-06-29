using System;

namespace CodeChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sprint Sprint1 = new Sprint();
            Console.WriteLine("\nBest developer in Sprint1:\n"
                    + Sprint1.GetBestDeveloper().Name + "\n"
                    + "Score: " + Sprint1.GetBestDeveloper().Fitness() + "\n"
            );
            Sprint1.PrintDevelopers();
        }
    }
}
