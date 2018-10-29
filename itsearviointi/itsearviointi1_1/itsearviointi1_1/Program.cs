using System;

namespace itsearviointi1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma toistaa käyttäjän kirjoittaman lauseen viisinkertaisesti");
            Console.WriteLine("Kirjoita ohjelmalle lause:");

            int number = 0;
            int i = 1;

            do
            {
                Console.WriteLine("Kirjoita ohjelmalle lause:");
                string userInput = Console.ReadLine();
                number = int.TryParse(userInput);

                if (number <= 5)
                {



                }


            }


        }
    }
}
