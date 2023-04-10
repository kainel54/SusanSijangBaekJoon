using System;

namespace SusanSijangBaekJoon
{
    class MainClass
    {
        static void Main(string[] args)
        {
            string[] colors = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
            string color1 = Console.ReadLine();
            string color2 = Console.ReadLine();
            string color3 = Console.ReadLine();
            long value = (Array.IndexOf(colors, color1) * 10 + Array.IndexOf(colors, color2)) * (long)Math.Pow(10, Array.IndexOf(colors, color3));
            Console.WriteLine(value);
        }
    }

}
