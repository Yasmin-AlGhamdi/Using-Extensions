using System;
namespace test4
{
    public static class MyHelper
    {
        public static int isdoble(this int val)
        {
            return val * 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int v = 2;
            int v1 = v.isdoble();
            int v2 = v1.isdoble();
            Console.WriteLine(v.isdoble());
            Console.WriteLine(v1.isdoble());
            Console.WriteLine(v2.isdoble());
        }
    }
}