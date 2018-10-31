using System;

namespace arrayTask1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma alustaa kokonaisluku taulukon(10 alkiota) johon arvotaan lukuja 0....100");
            int[] numbers = new int[10];
            Random rnd = new Random();
            //set value to array numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(100);
            }
            // get values from array numbers

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }


            Console.WriteLine("ohjelma päättyy");

        }

    }
}
