using System;

namespace stringTask1_2


{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ohjelma muuttaa käyttäjän syötteen merkkejä");

            string lause = "Hello World\t";
            string vaihto = lause.Replace('l', '1');
            
            Console.WriteLine($"{lause}{vaihto}");
            
        }
    }
}
