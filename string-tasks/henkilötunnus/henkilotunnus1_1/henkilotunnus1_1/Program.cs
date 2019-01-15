using System;

namespace henkilotunnus1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Id_number = real_form();
            string gender;
            var whole_id = Id_number;
            if (whole_id.Length == 11 || whole_id.Length == 10)
            {
                var numberINT = whole_id.Substring(0, 6) + whole_id.Substring(7, 10);
                var last_mark = whole_id.Substring(10, 11);
                var check_mark = calc_checkmark();
                int numberInt = int.Parse(numberINT);
                if (numberInt % 2 == 0)
                {
                    gender = "nainen";
                }
                else
                {
                    gender = "mies";
                }
                if (last_mark == "")
                {
                    Console.WriteLine("tarkistusmerkki on " + check_mark);
                    Console.WriteLine("tunnuksen haltija on " + gender);
                    Console.ReadLine();
                }
                else
                {
                    if (last_mark == check_mark)
                        Console.WriteLine("Tunnus on oikein ja sen haltija on  " + gender);
                    else
                        Console.WriteLine("Virheellinen tunnus!\nTämän tunnuksen haltija on " + gender);
                    Console.ReadLine();



                    static string real_form();
                    {
                        var Id_number = "";

                        Console.WriteLine("Anna henkilötunnus kokonaisena tai ilman viimeistä merkkiä (PPKKVV-ZZZQ): ");
                        Id_number = Console.ReadLine();

                        if ((Id_number.Length != 10) && (Id_number.Length != 11) ||
                        (Id_number.Substring(6, 7) != "-") && (Id_number.Substring(6, 7) != "+") && (Id_number.Substring(6, 7) != "A"))

                        {
                            Console.WriteLine("Tunnus ei ollut oikeassa muodossa!");
                            Console.ReadLine();
                        }
                        else

                            Console.WriteLine("Syöte on oikeassa muodossa, siirrytään laskemaan se");
                        {
                            return Id_number.ToUpper();
                        }
                        static string calc_checkmark();
                        {
                            string Id_number = real_form();
                            var numberInt = Id_number.Substring(0, 6) + Id_number.Substring(7, 10);
                            var check_mark = "0123456789ABCDEFHJKLMNPRSTUVWXY";
                            int numberInt = int.Parse(numberInt);
                            check_mark = check_mark.Substring(numberINT % 31, numberINT % 31 + 1);

                            return check_mark;
                        }
                    }
                }
            }
        }
    }
}