using System;

namespace SusanSijangBaekJoon
{
    class MainClass
    {
        static void Main(string[] args)
        {
            string [] a = Console.ReadLine().Split();
            int b = 0;
            int c = 0;
            for(int i= 0;i<a.Length;i++)
            {
                b += int.Parse(a[i]) * int.Parse(a[i]);
                c = b % 10;
            }
            Console.WriteLine(c);

        }
    }
}