using System;

namespace ConsoleApp
{
    public static class Adder
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }

    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("2 + 3 = " + Adder.Add(2, 3));
        }
    }
}