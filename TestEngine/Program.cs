using System;
using Yatzee3000;

namespace TestEngine
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] kast = { 1, 2, 3, 6, 6 };
            int status = ScoreCounter.scoreSingleSum(6, kast);
            Console.WriteLine(status);


        }
    }
}
