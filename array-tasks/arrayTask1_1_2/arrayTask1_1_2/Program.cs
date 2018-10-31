using System;

namespace arrayTask1_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // tällä käskyllä saadaan UTF8 merkit
            int[] productAmount = new int[] { 1, 2, 3 };
            Decimal[] productPrice = new Decimal[3] { 7.96m, 72.0m, 99.90m };
            Decimal[] productTotalPrice = new Decimal[3];
            Console.WriteLine("Hinnasto");

            for (int i = 0; i < productTotalPrice.Length; i++)
            {
                productTotalPrice[i] = productAmount[i] * productPrice[i];
                Console.WriteLine($"tuote 1 + {i + 1}.{productTotalPrice[i]:c}");
            }
        }
    }
}
