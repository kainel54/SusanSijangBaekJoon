using System;
using System.Text;

namespace SusanSijangBaekJoon
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= t; i++)
            {
                sb.AppendLine(i.ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
