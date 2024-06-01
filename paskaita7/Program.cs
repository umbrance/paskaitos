using System.Security.Cryptography.X509Certificates;

namespace paskaita7
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Paskaitos data 2024-05-30

            // REF & OUT
            int num1 = 15;
            int num2 = 30;
            string word = "tuscia";
            int pasirinkimas;
            do
            {
                Console.WriteLine("M E N U :\n");
                Console.WriteLine("1. Swap.");
                Console.WriteLine("2. IncrementByN.");
                Console.WriteLine("3. TrimAndCapitalize.");
                Console.WriteLine("0. Quit.");
                int.TryParse(Console.ReadLine(), out pasirinkimas);
                switch (pasirinkimas)
                {
                    case 1:
                        Swap(ref num1, ref num2);
                        Console.WriteLine($"Pries tai skaiciai: {num1} ir {num2}");
                        Console.WriteLine($"Po Swap skaiciai: {num2} ir {num1}");
                        Console.ReadKey();
                        break;
                    case 2:
                        while (!int.TryParse(Console.ReadLine(), out num1))
                        {
                            Console.Write("Netinkamas skaicius, pakartokite: ");
                        }
                        Console.WriteLine($"Prie jusu skaiciaus {num1} pridejus 5 gaunasi {IncrementByN(ref num1)}");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Write("Iveskite zodi: ");
                        word = Console.ReadLine();
                        Console.WriteLine($"Jusu naujas zodis: {TrimAndCapitalize(ref word)}");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Iseinama...");
                        break;
                }
            } while (pasirinkimas != 0);
            static int Swap(ref int number1, ref int number2)
            {
                int numeris1 = number2;
                int numeris2 = number1;
                return numeris1;
            }
            static int IncrementByN(ref int numeris1)
            {
                int atsakymas = numeris1 + 5;
                return atsakymas;
            }
            static string TrimAndCapitalize(ref string zodis)
            {
                zodis = zodis.Trim(); zodis.ToCharArray();
                zodis[0] = char.ToUpper(zodis[0]);
                zodis = zodis.ToString();
                return zodis;
            }
        }
    }
}