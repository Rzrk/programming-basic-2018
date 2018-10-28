
using System;

namespace functionTask1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä ohjelmalle sana tai lause ohjelma tulostaa lauseesi.");


            System.out.print("Anna viesti: ");
            String viesti = input.nextLine();
            System.out.print("Anna toistokerrat: ");
            int kerrat = Integer.parseInt(input.nextLine());

            for (int i = 0; i < kerrat; i++)
            {
                System.out.println(viesti);
            }

        }
    }

}





