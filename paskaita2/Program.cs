using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace paskaita2
{
    public class Program
    {
        static void Main(string[] args)
        {
            TreciosUzduotiesPIrmaDalis(2);

            /*
             * PIRMA DALIS
             */

            //int counter = 0;
            //string text = "Hello, World!";
            //Console.WriteLine(text[7]);
            //foreach (char o in text)
            //{
            //    if (o == 'o')
            //    counter++;
            //}

            //Console.WriteLine($"Raidė kartojasi {counter} kartu.");

            //string tekstas = "Mano vardas Nerijus";
            //Console.WriteLine(tekstas.Substring(12));
            //Console.WriteLine(tekstas.Substring(0, 4));

            //string tekstas2 = " LABAS mano vardas Nerijus   ";
            //Console.WriteLine(tekstas2.Substring(19));
            //Console.WriteLine(tekstas2.Trim());
            //Console.WriteLine(tekstas2.ToLower());
            //Console.WriteLine(tekstas2.ToUpper());
            //Console.WriteLine(tekstas2.Replace('B', 'P'));
            //Console.WriteLine(tekstas2.IndexOf('a'));


            /*
             *  
             *  ANTRA DALIS
             */

            //    int skaicius = 0;
            //    // PIRMA UZDUOTIS
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("Pirmos užduoties I dalis\t(skaicius 100)\n");
            //    skaicius = int.Parse(Console.ReadLine());
            //    if (skaicius > 100)
            //    {
            //        Console.WriteLine("Skaicius yra didesnis, nei 100.");
            //    }
            //    else if (skaicius == 100)
            //    {
            //        Console.WriteLine("Skaicius yra lygus 100.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Skaicius yra mazesnis, nei 100.");
            //    }
            //    Console.WriteLine("Pirmos užduoties II dalis\t(savaites dienos)\n");
            //    skaicius = int.Parse(Console.ReadLine());
            //    if (skaicius >= 1 && skaicius <= 7)
            //    {
            //        if (skaicius == 1)
            //        {
            //            Console.WriteLine("Pirmadienis");
            //        }
            //        else if (skaicius == 2)
            //        {
            //            Console.WriteLine("Antradienis");
            //        }
            //        else if (skaicius == 3)
            //        {
            //            Console.WriteLine("Treciadienis");
            //        }
            //        else if (skaicius == 4)
            //        {
            //            Console.WriteLine("Ketvirtadienis");
            //        }
            //        else if (skaicius == 5)
            //        {
            //            Console.WriteLine("Penktadienis");
            //        }
            //        else if (skaicius == 6)
            //        {
            //            Console.WriteLine("Sestadienis");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Sekmadienis");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Neteisingas dienos skaicus.");
            //    }
            //    Console.ReadLine();
            //    // ANTRA UZDUOTIS
            //    Console.Clear();
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Antros uzduoties I dalis\t(lyginis/nelyginis ir dalyba is 5)\n");
            //    skaicius = int.Parse(Console.ReadLine());
            //    if ((skaicius%2) == 0)
            //    {
            //        Console.WriteLine("Skaičius yra lyginis.");
            //    }
            //    if ((skaicius % 5) == 0)
            //    {
            //        Console.WriteLine("Skaičius dalinasi iš 5.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Skaičius neatitinka jokių sąlygų.");
            //    }
            //    Console.WriteLine("Antros uzduoties II dalis\t (temperatura)\n");
            //    skaicius = int.Parse(Console.ReadLine());
            //    if (skaicius < 0) 
            //    {
            //        Console.WriteLine("Šalta");
            //    }
            //    else if (skaicius >= 0 && skaicius <= 20)
            //    {
            //        Console.WriteLine("Vėsu");
            //    }
            //    else if (skaicius > 20)
            //    {
            //        Console.WriteLine("Karšta");
            //    }
            //Console.ReadLine();
            //Console.Clear();
            // TRECIA UZDUOTIS
            //Console.ForegroundColor = ConsoleColor.DarkBlue;
            //Console.WriteLine("Trecios uzduoties I dalis\n");
            //Console.WriteLine("Kuria valanda keletes ryte?\n");
            //int skaicius;
            //skaicius = int.Parse(Console.ReadLine());
            //if (skaicius > 1 && skaicius <= 11)
            //{
            //    Console.WriteLine("Geros dienos!");
            //}
            //else if (skaicius >= 12 && skaicius <= 18)
            //{
            //    Console.WriteLine("Geros popietės!");
            //}
            //else if (skaicius > 18 && skaicius <= 24)
            //{
            //    Console.WriteLine("Gero vakaro!");
            //}
            // Console.WriteLine("Trecios uzduoties II dalis\t(slaptazodis)\n");
            //string slaptazodis = "slaptas";
            //string skaicius2 = Console.ReadLine();
            //if (skaicius2 == slaptazodis)
            //    {
            //        Console.WriteLine("Sėkmingai prisijungėte");
            //    }
            //else if (skaicius2 == "Mellon")
            //    {
            //        Console.WriteLine("Sėkmingai prisijungėte");
            //    }
            //else if (skaicius2 == "01101001 01101110")
            //    {
            //        Console.WriteLine("Nulaužta...");
            //    }
            //else
            //    {
            //        Console.WriteLine("Slaptažodis neteisingas, prašome bandyti dar kartą...");
            //    }
            //Console.ReadLine();
        }
        public static string TreciosUzduotiesPIrmaDalis(int number)
        {
            int skaicius = number;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Trecios uzduoties I dalis\n");
            Console.WriteLine("Kuria valanda keletes ryte?\n");
            skaicius = int.Parse(Console.ReadLine());
            if (skaicius > 1 && skaicius <= 11)
            {
                return "Geros dienos!";
            }
            else if (skaicius >= 12 && skaicius <= 18)
            {
                return "Geros popietės!";
            }
            else if (skaicius > 18 && skaicius <= 24)
            {
                return "Gero vakaro!";
            }
            return "Kazkas ne taip...";
        }

        }
}
