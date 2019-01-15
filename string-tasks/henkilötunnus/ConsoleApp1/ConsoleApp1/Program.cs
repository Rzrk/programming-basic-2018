using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace henktunlasku
{
    class Program
    {
        static void Main(string[] args)
        {
            var henkilötunnus = oikeaMuoto();
            string sukupuoli;
            var kokotunnus = henkilötunnus;

            if (kokotunnus.Length == 11 || kokotunnus.Length == 10)
            {
                var lukuarvo = kokotunnus.Substring(0, 6) + kokotunnus.Substring(7, 10);
                var vikamerkki = kokotunnus.Substring(10, 11);
                var tarkistusmerkki = laskeTarkistusMerkki();
                int lukuarvoInt = int.Parse(lukuarvo);
                if (lukuarvoInt % 2 == 0)
                {
                    sukupuoli = "nainen";
                }
                else
                {
                    sukupuoli = "mies";
                }
                if (vikamerkki == "")
                {
                    Console.WriteLine("Tunnukseen tuleva tarkistusmerkki on " + tarkistusmerkki);
                    Console.WriteLine("ja tunnuksen haltija on " + sukupuoli);
                    Console.ReadLine();
                }
                else
                {
                    if (vikamerkki == tarkistusmerkki)
                        Console.WriteLine("Tunnus on oikein ja sen haltija on  " + sukupuoli);
                    else
                        Console.WriteLine("Virheellinen tunnus!\nTämän tunnuksen haltija on " + sukupuoli);
                    Console.ReadLine();
                }
            }
        }
        static string oikeaMuoto() 
        {
            var henkilötunnus = "";

            Console.WriteLine("Anna henkilötunnus kokonaisena tai ilman viimeistä merkkiä (PPKKVV-ZZZQ): ");
            henkilötunnus = Console.ReadLine();

            if ((henkilötunnus.Length != 10) && (henkilötunnus.Length != 11) ||
               (henkilötunnus.Substring(6, 7) != "-") && (henkilötunnus.Substring(6, 7) != "+") && (henkilötunnus.Substring(6, 7) != "A"))
            {
                Console.WriteLine("Tunnus ei ollut oikeassa muodossa!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Syöte on oikeassa muodossa, siirrytään laskemaan se");
            }

            return henkilötunnus.ToUpper(); 
        }
        static string laskeTarkistusMerkki() 
        {
            string henkilötunnus = oikeaMuoto();
            var luku = henkilötunnus.Substring(0, 6) + henkilötunnus.Substring(7, 10); 
            var tarkistusMerkki = "0123456789ABCDEFHJKLMNPRSTUVWXY";
            int lukuInt = int.Parse(luku);      
            tarkistusMerkki = tarkistusMerkki.Substring(lukuInt % 31, lukuInt % 31 + 1); 

            return tarkistusMerkki; 
        }
    }
}