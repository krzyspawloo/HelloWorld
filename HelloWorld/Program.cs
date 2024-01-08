using System;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    //PascalCase
    public class Program
    {
        //camelCase
        public static void Main(string[] args)
        {
            string firstAndLastName = "Krzysztof";

            //UPPERCASE
            const double PI_NUMBER = 3.14;
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Nazywam się Krzysztof Pawłowski");
            Console.WriteLine("Witam");
            if (PI_NUMBER > 2)
            {
                WritePiNumber(PI_NUMBER);
            }
        }

        private static string WritePiNumber(double pi)
        {
            return ("3.14");
        }


    }
}
