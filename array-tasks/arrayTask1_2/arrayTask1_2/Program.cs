using System;
using System.Globalization;
namespace arrayTask1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //CultureInfo culture = new CultureInfo("sv-SV");
            CultureInfo.CurrentCulture = new CultureInfo("fi-FI");
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("ohjelma alustaa kokonaisluku taulukon(10 alkiota) johon arvotaan lukuja 0....50");
            int[] iT = new int[100];
            Random rnd = new Random();
            

            //set value to array numbers
            for (int i = 0; i < iT.Length; i++)
            {
                iT[i] = rnd.Next(50);
            }
            // get values from array numbers

            for (int i = 0; i < iT.Length; i++)
            {
                
                Console.WriteLine(iT[i]);
               int iT = iT.Average(i => i.Length);
                Console.WriteLine([iT]);
            }


            Console.WriteLine("ohjelma päättyy");
        }
        }
}
