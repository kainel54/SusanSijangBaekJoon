using System;

namespace SusanSijangBaekJoon
{
    class MainClass
    {
        static void Main(string[] args)
        {
            string [] a = Console.ReadLine().Split();
            int b = int.Parse(a[0]) / int.Parse(a[1]);
            Console.WriteLine(b);
            int c = int.Parse(a[0]) % int.Parse(a[1]);
            Console.WriteLine(c);

        }
    }
}