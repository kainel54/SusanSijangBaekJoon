using System;

namespace SusanSijangBaekJoon
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            int[] divisors = new int[n];
            for (int i = 0; i < n; i++)
            {
                divisors[i] = int.Parse(input[i]);
            }
            Array.Sort(divisors);
            int result = divisors[0] * divisors[n - 1];
            Console.WriteLine(result);
        }
    }
}