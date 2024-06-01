using System.ComponentModel.Design;

namespace paskaita3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("Pirma uzduotis\t(amzius)\n");
            //int skaicius = int.Parse(Console.ReadLine());
            //if (skaicius < 18)
            //{
            //    Console.WriteLine("Jums priklauso nepilnamecio akcija.");
            //}
            //else if (skaicius >= 18 && skaicius < 65)
            //{
            //    Console.WriteLine("Jus esate suauges.");
            //}
            //else if (skaicius >= 65)
            //{
            //    Console.WriteLine("Jums priklauso senjoro akcija");
            //}
            //Console.ReadLine();
            //Console.Clear();
            //Console.ForegroundColor= ConsoleColor.Blue;
            //Console.WriteLine("Antra uzduotis \t(keliamieji metai)\n");
            //skaicius = int.Parse(Console.ReadLine());
            //if (skaicius % 4 == 0 && (skaicius % 100 != 0 || skaicius % 400 == 0))
            //{
            //    Console.WriteLine("Tai yra keliamieji metai");
            //}
            //else
            //{
            //    Console.WriteLine("Tai nera keliamieji metai");
            //}
            //Console.ReadLine();
            //Console.Clear();
            //Console.ForegroundColor= ConsoleColor.DarkRed;
            //Console.WriteLine("Trecia uzduotis\t(dalinasi is 3 ir 5)\n");
            //skaicius = int.Parse (Console.ReadLine());
            //if (skaicius % 3 == 0 && skaicius % 5 == 0)
            //{
            //    Console.WriteLine("BazingaPop");
            //}
            //else if (skaicius % 3 == 0 && skaicius % 5 != 0)
            //{
            //    Console.WriteLine("Bazinga");
            //}
            //else if (skaicius % 3 != 0 && skaicius % 5 == 0)
            //{
            //    Console.WriteLine("Pop");
            //}
            //else
            //{
            //    Console.WriteLine(skaicius);
            //}
            //Console.ReadLine();
            //Console.Clear();
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Ketvirtos uzduoties I dalis\t(Teigiami/Neigiami skaiciai)\n");
            //Console.WriteLine("Iveskite pirmaji skaiciu: ");
            //skaicius = int.Parse(Console.ReadLine());
            //Console.WriteLine("Iveskite antraji skaiciu: ");
            //int skaicius2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("");
            //if (skaicius > 0 && skaicius2 > 0)
            //{
            //    Console.WriteLine("Abu skaiciai yra teigiami");
            //}
            //else if (skaicius > 0 || skaicius2 > 0)
            //{
            //    Console.WriteLine("Tik vienas skaicius yra teigiamas");
            //}
            //else
            //{
            //    Console.WriteLine("Ne vienas skaicius nera teigiamas");
            //}
            //Console.ReadLine();
            //Console.Clear();
            //Console.ForegroundColor= ConsoleColor.Magenta;
            //Console.WriteLine("Ketvirtos uzduoties II dalis\t(trys lygus skaiciai)\n");
            //Console.WriteLine("Iveskite pirmaji skaiciu: ");
            //skaicius = int.Parse(Console.ReadLine());
            //Console.WriteLine("Iveskite antraji skaiciu: ");
            //skaicius2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Iveskite treciaji skaiciu: ");
            //int skaicius3 = int.Parse(Console.ReadLine());
            //if (skaicius == skaicius2 && skaicius == skaicius3)
            //{
            //    Console.WriteLine("Visi skaiciai yra lygus");
            //}
            //else if (skaicius == skaicius2 || skaicius == skaicius3 || skaicius2 == skaicius3)
            //{
            //    Console.WriteLine("Du skaiciai yra lygus");
            //}
            //else
            //{
            //    Console.WriteLine("Nei vienas skaicius nera lygus");
            //}
            //Console.ReadLine();
            //Console.Clear();
            //Console.ForegroundColor = ConsoleColor.DarkCyan;
            //Console.WriteLine("Penktos uzduoties I dalis\t(teigiamu skaiciu suma)\n");
            //Console.WriteLine("A: ");
            //skaicius = int.Parse(Console.ReadLine());
            //Console.WriteLine("B: ");
            //skaicius2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("C: ");
            //skaicius3 = int.Parse(Console.ReadLine());
            //Console.WriteLine("");
            //if (skaicius == skaicius2)
            //{
            //    Console.WriteLine($"Skaiciu suma lygi {skaicius+skaicius}");
            //}
            //else if (skaicius == skaicius3)
            //{
            //    Console.WriteLine($"Skaiciu suma lygi {skaicius + skaicius}");
            //}
            //else if (skaicius2 == skaicius3)
            //{
            //    Console.WriteLine($"Skaicius suma lygi {skaicius2 + skaicius2}");
            //}
            //else
            //{
            //    Console.WriteLine("Neimanoma suskaiciuoti sumos");
            //}
            //Console.ReadLine();
            //Console.Clear();
            //Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //Console.WriteLine("Penktos uzduoties II dalis\t(silti/salti laikotarpiai)\n");
            //Console.WriteLine("Iveskite metus ir menesi (su tarpu): ");
            //string kalendorius = Console.ReadLine();
            //kalendorius = kalendorius.Substring(5);
            //skaicius = int.Parse(kalendorius);
            //if (skaicius >= 1 && skaicius <= 3)
            //{
            //    Console.WriteLine("Saltas laikotarpis");
            //}
            //else if (skaicius >= 6 && skaicius <= 9)
            //{
            //    Console.WriteLine("Karstas laikotarpis");
            //}
            //else
            //{
            //    Console.WriteLine("Vidutinio laikotarpio menuo");
            //}
            //Console.ReadLine();
            //Console.Clear();
            //Console.ForegroundColor= ConsoleColor.White;
            //Console.WriteLine("Penkta uzduotis\t(trikampis)\n");
            //Console.WriteLine("Iveskite 3 krastiniu ilgius: ");
            //skaicius = int.Parse(Console.ReadLine());
            //skaicius2 = int.Parse(Console.ReadLine());
            //skaicius3 = int.Parse(Console.ReadLine());
            //Console.WriteLine("");
            //if ((skaicius > skaicius3 && skaicius2 > skaicius3) ||
            //    (skaicius2 > skaicius && skaicius3 > skaicius) ||
            //    (skaicius3 > skaicius && skaicius3 > skaicius2))
            //{
            //    Console.WriteLine("Galima sudaryti trikampi");
            //}
            //else
            //{
            //    Console.WriteLine("Negalima sudaryti trikampio");
            //}
            //Console.ReadLine();
            //Console.Clear();
            //Console.ForegroundColor= ConsoleColor.DarkYellow;
            //Console.WriteLine("Sesta uzduotis\t(cekis)\n");

            //// Nusikopijuoti € , nes neveikia ALT kodai ^^

            //string preke1 = "Piestukas";
            //string preke2 = "Papke kietu virseliu";
            //string preke3 = "Spalvotu piestuku rinkinys";
            //skaicius = 1; skaicius2 = 2; skaicius3 = 7;
            //Console.WriteLine("PREKIU KATALOGAS: ");
            //Console.WriteLine($"1. {preke1}\t{skaicius}€");
            //Console.WriteLine($"2. {preke2}\t{skaicius2}€");
            //Console.WriteLine($"3. {preke3}\t{skaicius3}€");
            //Console.WriteLine("");
            //Console.WriteLine("Pasirinkite ka pirksite (2 prekes): ");
            //int pasirinkimas1 = int.Parse(Console.ReadLine());
            //int pasirinkimas2 = int.Parse(Console.ReadLine());
            //if (pasirinkimas1 == pasirinkimas2)
            //{

            //}
            /*
             * SWITCH
             */

            //    Console.WriteLine("Pirma uzduotis\n");
            //    string pavadinimas = Console.ReadLine().ToLower();
            //    switch (pavadinimas)
            //    {
            //        case "kvadratas":
            //            Console.WriteLine("Iveskite krastines ilgi: ");
            //            int krastine = int.Parse(Console.ReadLine());
            //            Console.WriteLine("Kvadrato plotas: " + krastine * krastine);
            //            break;
            //        case "apskritimas":
            //            Console.WriteLine("Iveskite spinduli: ");
            //            krastine = int.Parse(Console.ReadLine());
            //            Console.WriteLine("Skritulio plotas: " + 3.14 * (krastine * krastine));
            //            break;
            //        case "trikampis":
            //            Console.WriteLine("Iveskite trikampio aukstine: ");
            //            krastine = int.Parse(Console.ReadLine());
            //            Console.WriteLine("Iveskite trikampio pagrinda: ");
            //            int krastine2 = int.Parse(Console.ReadLine());
            //            Console.WriteLine("Trikampio plotas: " + (krastine * krastine2)/2);
            //            break;
            //        case "staciakampis":
            //            Console.WriteLine("Iveskite abi krastines: ");
            //            krastine = int.Parse(Console.ReadLine());
            //            krastine2 = int.Parse(Console.ReadLine());
            //            Console.WriteLine("Staciakampio plotas: " + krastine * krastine2);
            //            break;
            //        default:
            //            Console.WriteLine("Kazkas ne taip...");
            //            break;
            //    }
            //    Console.ReadLine();
            //    Console.Clear();
            //    Console.WriteLine("Antra uzduotis\n");
            //    Console.WriteLine("Pasirinkite elementa");
            //    string elementas = Console.ReadLine().ToLower();
            //    switch (elementas)
            //    {
            //        case "ugnis":
            //            Console.WriteLine("Saule.");
            //            break;
            //        case "vanduo":
            //            Console.WriteLine("Vandenynas.");
            //            break;
            //        case "zeme":
            //            Console.WriteLine("Kalnas.");
            //            break;
            //        case "oras":
            //            Console.WriteLine("Viesulas");
            //            break;
            //        case "eteris":
            //            Console.WriteLine("Kosmosas.");
            //            break;
            //        default:
            //            Console.WriteLine("Kazkas ne taip...");
            //            break;
            //    }

            /* 
             * CHAR ARRAY
             */
            Console.WriteLine("Pirmos uzduoties I dalis\n");
            Console.WriteLine("Iveskite teksta (minimum 10 simboliu): ");
            string tekstas = Console.ReadLine();
            if (tekstas.Length > 9)
            {
                char[] masyvas = tekstas.ToCharArray();
                var raide = masyvas[0].ToString();
                raide = raide.ToUpper();
                masyvas[0] = Char.Parse(raide);
                var pakeistasMasyvas = new string(masyvas);
                Console.WriteLine(pakeistasMasyvas);
                char[] naujasZodis = pakeistasMasyvas.ToCharArray();
                naujasZodis[1] = 'g';
                naujasZodis[3] = 'b';
                naujasZodis[5] = '*';
                naujasZodis[7] = 'x';
                naujasZodis[9] = 'w';
                var atverstasZodis = new string(naujasZodis);
                Console.WriteLine(atverstasZodis);
                Console.WriteLine("");
            }
            Console.WriteLine("Pirmos uzduoties II dalis\n");
            Console.WriteLine("Iveskite 5 skaitmenu simbolius");
            var simboliai = Console.ReadLine();
            if (simboliai.Length > 5 || simboliai.Length < 5)
            {
                Console.WriteLine("Netinkamas zodis.");
            }
            Console.WriteLine("Kaip norite koduoti? (-/+ <skaicius>)");
            int kintamasis = int.Parse(Console.ReadLine());
            char[] naujiSimboliai = simboliai.ToCharArray();
            naujiSimboliai[0] = (char)(naujiSimboliai[0] + kintamasis);
            naujiSimboliai[1] = (char)(naujiSimboliai[1] + kintamasis);
            naujiSimboliai[2] = (char)(naujiSimboliai[2] + kintamasis);
            naujiSimboliai[3] = (char)(naujiSimboliai[3] + kintamasis);
            naujiSimboliai[4] = (char)(naujiSimboliai[4] + kintamasis);
            var gautasZodis = new string(naujiSimboliai);
            Console.WriteLine(gautasZodis);
        }
    }
}
