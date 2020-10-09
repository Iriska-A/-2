using System;

namespace ConsoleApp4
{
    class Program
    {
        public static int Main(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] agres)
        {
            int c = Main(55, 10);
            Console.WriteLine(c);
            Console.ReadLine();
        }
         
        }
}
    
}
