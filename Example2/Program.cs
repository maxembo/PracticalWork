using System;

namespace Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumScores = 256;
            int averageScore = sumScores / 3;
            
            Console.WriteLine($"Средний балл:{averageScore}");

            Console.ReadKey();
        }
    } 
}