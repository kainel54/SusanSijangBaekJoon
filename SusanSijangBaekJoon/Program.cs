using System;

namespace SusanSijangBaekJoon
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = 1;
            for (int i = 0; i < a; i++)
            {
                b *= (a - i);                
            }
            Console.WriteLine(b);
            
            

        }
    }
}