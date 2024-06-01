namespace paskaita4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///*
            // * TRYPARSE
            // */

            //Console.WriteLine("Pirma uzduotis\n");
            //Console.WriteLine("Iveskite savo gimimo data YYYY-MM-DD formatu: ");
            //string writtenYearMonthDay = Console.ReadLine();
            //DateTime yearMonthDay = DateTime.Parse(writtenYearMonthDay);
            //DateTime now = DateTime.Now;
            //DateTime oldAge = yearMonthDay.AddYears(90);
            //TimeSpan requiredAge = oldAge - now;
            //Console.WriteLine($"Jums liko metu iki kol sukaks 90: {requiredAge.TotalDays / 30 / 12}");
            //Console.WriteLine($"Jums liko menesiu iki kol sukaks 90: {requiredAge.TotalDays / 30}");
            //Console.WriteLine($"Jums liko dienu iki kol sukaks 90: {requiredAge.TotalDays}");
            //Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine("Antra uzduotis\n");
            //Console.WriteLine("Iveskite zodi: ");
            //string word = Console.ReadLine();
            //char[] symbols = word.ToCharArray();
            //if (char.IsUpper(symbols[0]))
            //{
            //    var upperLetters = new string(symbols);
            //    upperLetters = upperLetters.ToUpper();
            //    Console.WriteLine(upperLetters);
            //}
            //else
            //{
            //    symbols[0] = Char.ToUpper(symbols[0]);
            //    var upperLetters = new string(symbols);
            //    Console.WriteLine(upperLetters);
            //}
            //Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine("Trecia uzduotis\n");
            //Console.WriteLine("Iveskite zodi: ");
            //word = Console.ReadLine();
            //if (word == "labas")
            //{
            //    char[] letters = word.ToCharArray();
            //    //letters = word.Reverse(letters).ToArray();
            //}

            /*
             * WHILE CIKLAS
             */
            char pasirinkimas = 'A';
            int meniu = 99;
            do
            {
                pasirinkimas = 'A';
                meniu = 99;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("MENIU: \n");
                Console.WriteLine("1. Pirmas uzduociu lapas.");
                Console.WriteLine("2. Antras uzduociu lapas.");
                Console.WriteLine("3. Trecias uzduociu lapas.");
                Console.WriteLine("4. Ketvirtas uzduociu lapas.");
                Console.WriteLine("\n\n\n\n\n");
                Console.WriteLine("0. Iseiti.\n");
                while (!int.TryParse(Console.ReadLine(), out meniu) || (meniu < 1 && meniu > 9))
                {
                    Console.WriteLine("Neteisingas pasirinkimas. Bandykite dar kartą.");
                }
                switch (meniu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("1. Pirmos uzduoties I dalis.");
                        Console.WriteLine("2. Pirmos uzduoties II dalis.");
                        Console.WriteLine("3. Antros uzduoties I dalis.");
                        Console.WriteLine("4. Antros uzduoties II dalis.");
                        Console.WriteLine("5. Trecios uzduoties I dalis.");
                        Console.WriteLine("6. Trecios uzduoties II dalis.");

                        while (!int.TryParse(Console.ReadLine(), out meniu) || (meniu < 1 && meniu > 9))
                        {
                            Console.WriteLine("Neteisingas pasirinkimas. Bandykite dar kartą.");
                        }
                        int i = 0;
                        int j = 5;

                        switch (meniu)
                        {
                            case 1:
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("1. Pirmos uzduoties I dalis.\n");
                                Console.ForegroundColor = ConsoleColor.Green;
                                while (i < 5)
                                {
                                    Console.WriteLine(i);
                                    i++;
                                }
                                i = 0;
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Uzduotis baigta. Grizti i MENIU? (T/N)");
                                pasirinkimas = char.Parse(Console.ReadLine());
                                Console.Clear();
                                break;
                            case 2:
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("2. Pirmos dalis II dalis.\n");
                                Console.ForegroundColor = ConsoleColor.Green;
                                i = 0;
                                while (i < 5)
                                {
                                    i++;
                                    Console.WriteLine(i);
                                }
                                while (i > 0)
                                {
                                    Console.WriteLine(i);
                                    i--;
                                }
                                Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Uzduotis baigta. Grizti i MENIU? (T/N)");
                                pasirinkimas = char.Parse(Console.ReadLine());
                                Console.Clear();
                                break;
                            case 3:
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("2. Antros uzduoties I dalis.\n");
                                Console.ForegroundColor = ConsoleColor.Green;
                                i = 0;
                                while (i <= 10)
                                {
                                    if (i % 2 == 0)
                                    {
                                        Console.WriteLine(i);
                                    }
                                    i++;
                                }
                                Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Uzduotis baigta. Grizti i MENIU? (T/N)");
                                pasirinkimas = char.Parse(Console.ReadLine());
                                Console.Clear();
                                break;
                            case 4:
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("4. Antros uzduoties dalis II dalis.");
                                Console.ForegroundColor = ConsoleColor.Green;
                                i = 0;
                                j = 1;
                                while (i <= 10)
                                {
                                    if (i % 2 == 0)
                                    {
                                        Console.WriteLine(i);
                                    }
                                    i++;
                                    while (j <= 10)
                                    {
                                        if (j % 2 != 0)
                                        {
                                            Console.WriteLine(j);
                                        }
                                        j++;
                                    }
                                }
                                Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Uzduotis baigta. Grizti i MENIU? (T/N)");
                                pasirinkimas = char.Parse(Console.ReadLine());
                                Console.Clear();
                                break;
                            case 5:
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("5. Trecios uzduoties I dalis.");
                                Console.ForegroundColor = ConsoleColor.Green;
                                i = 0;
                                while (i < 101)
                                {
                                    Console.Write("Iveskite skaiciu (>100 jei norite, kad ciklas nutruktu): ");
                                    i = int.Parse(Console.ReadLine());
                                }
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Ivestas salyga tenkintantis skaicus.");
                                Console.ReadLine();
                                Console.WriteLine("Uzduotis baigta. Grizti i MENIU? (T/N)");
                                pasirinkimas = char.Parse(Console.ReadLine());
                                Console.Clear();
                                break;
                            case 6:
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("5. Trecios uzduoties I dalis.");
                                Console.ForegroundColor = ConsoleColor.Green;
                                i = 0;
                                while (i < 101)
                                {
                                    Console.Write("Iveskite skaiciu (>100 jei norite, kad  isorinis ciklas nutruktu): ");
                                    i = int.Parse(Console.ReadLine());
                                    while (i < 0)
                                    {
                                        Console.Write("Iveskite teigiama skaiciu noredami nutraukti vidini cikla: ");
                                        i = int.Parse(Console.ReadLine());
                                    }
                                }
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Ivestas salyga tenkintantis skaicus.");
                                Console.ReadLine();
                                Console.WriteLine("Uzduotis baigta. Grizti i MENIU? (T/N)");
                                pasirinkimas = char.Parse(Console.ReadLine());
                                Console.Clear();
                                break;
                            default:
                                break;
                        }
                        meniu = 99;
                        break;
                    case 2:
                        Console.Clear();
                        Console.ForegroundColor= ConsoleColor.Yellow;
                        Console.WriteLine("1. Pirmos uzduoties I dalis.");
                        Console.WriteLine("2. Pirmos uzduoties II dalis.");
                        Console.WriteLine("3. Antra uzduotis.");
                        Console.WriteLine("4. Trecia uzduotis");
                        while (!int.TryParse(Console.ReadLine(), out meniu) || (meniu < 1 && meniu > 9))
                        {
                            Console.WriteLine("Neteisingas pasirinkimas. Bandykite dar kartą.");
                        }
                        switch (meniu)
                        {
                            case 1:
                                Console.ForegroundColor= ConsoleColor.Yellow;
                                Console.WriteLine("1. Pirmos uzduoties I dalis.\n");
                                Console.Write("Iveskite skaiciu, kurio faktoriala norite suzinoti: ");
                                i = int.Parse(Console.ReadLine());
                                int skaicius = i;
                                int atsakymas = 1;
                                Console.ForegroundColor = ConsoleColor.Green;
                                while (i > 1)
                                {
                                    atsakymas *= i;
                                    i--;
                                    Console.WriteLine($"Tarpinis atsakymas: {atsakymas}");
                                }
                                Console.WriteLine("");
                                Console.WriteLine($"Skaiciaus {skaicius} faktorialas: {atsakymas}");
                                Console.ReadLine();
                                Console.WriteLine("Uzduotis baigta. Grizti i MENIU? (T/N)");
                                pasirinkimas = char.Parse(Console.ReadLine());
                                Console.Clear();
                                break;
                            case 2:
                                Console.Write("Iveskite skaiciu, kurio faktoriala norite suzinoti: ");
                                i = int.Parse(Console.ReadLine());
                                skaicius = i;
                                atsakymas = 1;
                                int atsakymas2 = 1;
                                Console.ForegroundColor = ConsoleColor.Green;
                                while (i > 1)
                                {
                                    atsakymas *= i;
                                    i--;
                                    Console.WriteLine($"Tarpinis isorinio ciklo atsakymas: {atsakymas}");
                                    while (i >= 0)
                                    {
                                        atsakymas2 += i;
                                        i--;
                                        Console.WriteLine($"Tarpinis vidinio ciklo atsakymas: {atsakymas2}");
                                    }
                                }
                                Console.WriteLine("");
                                Console.WriteLine($"Skaiciaus {skaicius} faktorialas: {atsakymas}");
                                Console.ReadLine();
                                Console.WriteLine("Uzduotis baigta. Grizti i MENIU? (T/N)");
                                pasirinkimas = char.Parse(Console.ReadLine());
                                Console.Clear();
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("3. Antra uzduotis.");
                                Console.Write("Iveskite skaiciu: ");
                                Console.ForegroundColor= ConsoleColor.Green;
                             //   char[] trimming = { ',', ' ' };
                                while (!int.TryParse(Console.ReadLine(), out skaicius))
                                {
                                    Console.Write("Neteisingas ivestas skaicius. Kartokite: ");
                                }
                                string arrayOfNumbers = skaicius.ToString();
                                char[] chars = arrayOfNumbers.ToCharArray();
                                i = 0;

                                while (i < chars.Length)
                                {
                                    Console.Write(chars[i]);
                                    if (i < chars.Length - 1)
                                    {
                                        Console.Write(", ");
                                    }
                                    i++;
                                }
                                Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Uzduotis baigta. Grizti i MENIU? (T/N)");
                                pasirinkimas = char.Parse(Console.ReadLine());
                                Console.Clear();
                                break;
                            case 4:
                                Console.WriteLine("4. Trecia uzduotis\n");
                                Console.Write("Iveskite skaiciu: ");
                                int n; i = 0; j = 0;
                                while (!int.TryParse(Console.ReadLine(), out n))
                                {
                                    Console.Write("Neteisingas ivestas skaicius. Kartokite: ");
                                }
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                while (n > i)
                                {
                                    do
                                    {
                                        Console.Write($"{new string('*', i + 1)}");
                                        i++;
                                    } while (i > n);
                                    Console.WriteLine("");
                                }
                                Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Uzduotis baigta. Grizti i MENIU? (T/N)");
                                pasirinkimas = char.Parse(Console.ReadLine());
                                Console.Clear();
                                break;
                            default:
                                break;
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Trecias uzduociu lapas.");
                        Console.WriteLine("1. Pirma uzduotis.");
                        Console.WriteLine("2. Antra uzduotis.\n");
                        while (!int.TryParse(Console.ReadLine(), out meniu) || (meniu < 1 && meniu > 9))
                        {
                            Console.WriteLine("Neteisingas pasirinkimas. Bandykite dar kartą.");
                        }
                        switch (meniu)
                        {
                            case 1:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                int skaicius;
                                Console.Write("Iveskite sveikaji skaiciu: ");
                                while (!int.TryParse(Console.ReadLine(), out skaicius) )
                                {
                                    Console.WriteLine("Neteisingas pasirinkimas. Bandykite dar kartą.");
                                }
                                if (skaicius % 2 == 0 || skaicius % 3 == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{skaicius}");
                                }
                                Console.Clear();
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Antra uzduotis.");
                                Console.WriteLine("Iveskite skaicius (pirmas - skaicius, antras - laipsnis: ");
                                while (!int.TryParse(Console.ReadLine(), out i))
                                {
                                    Console.WriteLine("Neteisingas skaicius. Bandykite dar kartą.");
                                }
                                while (!int.TryParse(Console.ReadLine(), out j))
                                {
                                    Console.WriteLine("Neteisingas antrasis skaicius. Bandykite dar kartą.");
                                }
                                Console.WriteLine($"Gautas atsakymas: {Math.Pow(i, j)}");
                                break;
                            default:
                                break;
                        }
                        break;
                        Console.ForegroundColor = ConsoleColor.Green;
                        meniu = 99;
                        break;
                    case 4:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Ketvirtas uzduociu lapas.");
                        Console.WriteLine("1. Pirma uzduotis.\n");
                        int skaicius2;
                        Console.Write("Iveskite skaiciu, kuri norite issigryninti: ");
                        Console.ForegroundColor= ConsoleColor.Green;
                        while (!int.TryParse(Console.ReadLine(), out skaicius2))
                        {
                            Console.WriteLine("Neteisingas pasirinkimas. Bandykite dar kartą.");
                        }
                        int count50 = 0;
                        int count20 = 0;
                        int count10 = 0;
                        int count5 = 0;
                        int count2 = 0;
                        int count1 = 0;
                        while (skaicius2 != 0)
                        {
                            while (skaicius2 >= 50)
                            {
                                skaicius2 = skaicius2 - 50;
                                count50++;
                            }
                            while (skaicius2 >= 20)
                            {
                                skaicius2 = skaicius2 - 20;
                                count20++;
                            }
                            while (skaicius2 >= 10)
                            {
                                skaicius2 = skaicius2 - 10;
                                count10++;
                            }
                            while (skaicius2 >= 5)
                            {
                                skaicius2 = skaicius2 - 5;
                                count5++;
                            }
                            while (skaicius2 >= 2)
                            {
                                skaicius2 = skaicius2 - 2;
                                count2++;
                            }
                            while (skaicius2 >= 1)
                            {
                                skaicius2 = skaicius2 - 1;
                                count1++;
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Bankomatas isduoda pasirinkta suma tokiomis kupiuromis: \n");
                        Console.WriteLine($"Po 50: {count50}");
                        Console.WriteLine($"Po 20: {count20}");
                        Console.WriteLine($"Po 10: {count10}");
                        Console.WriteLine($"Po 5: {count5}");
                        Console.WriteLine($"Po 2: {count2}");
                        Console.WriteLine($"Po 1: {count1}");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Uzduotis baigta. Grizti i MENIU? (T/N)");
                        pasirinkimas = char.Parse(Console.ReadLine());
                        Console.Clear();
                        break;
                    case 0:
                        Console.WriteLine("Programa baigia darba.");
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (pasirinkimas != 'n' && pasirinkimas != 'N');
            Console.WriteLine("Programa baigia darba.");
            Console.ReadLine();
        }
    }
}
