using System;
using Yatzee3000;

namespace TestEngine
{
    class TestEngine
    {        
        static void Main(string[] args)
        {
            int[] kast = { 1, 2, 3, 6, 6 };
            int status = ScoreCounter.ScoreSingleSum(6, kast);
            Console.WriteLine(status);
        }
    }
}
