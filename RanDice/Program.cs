using System;

namespace RanDice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(args[0]);
            int s = int.Parse(args[1]);
            int[] sequence = new int[n];
            int result = 0;
            
            Random dice = new Random(s);
            for(int i = 0; i<n ; i++)
            {
                int diceInt = dice.Next(1, 6);

                sequence[i] = diceInt;
            }

            foreach(int num in sequence)
            {
                result += num;
            }
            Console.WriteLine(result);
        }
    }
}
