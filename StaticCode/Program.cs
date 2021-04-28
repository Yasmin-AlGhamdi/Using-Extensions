using System;

namespace StaticCode
{
    public static class CodeHelpers
    {
        public static string trim(string code)
        {
            return null;
        }
        public static int doAction(string code)
        {
            return 0;
        }
    }
    public static class MyHelper
    {
        public static bool isCapitalized(this string s) // Extension: this string s
        {
            return char.IsUpper(s[0]);
        }
        public static bool isOdd(this int a)
        {
            return a % 2 != 0;        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Welcome to C#";
            if(message.isCapitalized()) // message is string so no need to put it inside isCapitalized
            {
                Console.WriteLine("Capitalized");
            }
            else
            {
                Console.WriteLine("Not Capitalized");
            }
            // StringHelper.isCapitalized(message);

            /*
            int age = 21;
            if(age.isOdd())
            {
                Console.WriteLine(age);
            }
            */

            //xxutil (in java)
            string s = CodeHelpers.trim(" Welcome to C#  ");
            //Console.WriteLine(s);
            Math.Floor(4.5);
            Math.Ceiling(4.5);

            Console.ReadKey();
        }
    }
}
