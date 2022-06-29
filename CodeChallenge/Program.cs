using System;

namespace CodeChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sprint Sprint1 = Sprint.GetInstance();
            Console.WriteLine("\nBest developer this Sprint:\n"
                    + Sprint1.GetBestDeveloper().Name + "\n"
                    + "Score: " + Sprint1.GetBestDeveloper().Fitness() + "\n"
            );
            Sprint1.PrintDevelopers();
        }
    }
}
