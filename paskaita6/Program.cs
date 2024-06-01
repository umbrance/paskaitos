namespace paskaita6
{
    public class Skaiciuotuvas
    {
        public static void Main(string[] args)
        {
            string choice;
            do
            {
                choice = CalcMenu();
                CalcChoice(choice);
            } while (choice != "q");
        }

        public static string CalcMenu()
        {
            Console.Clear();
            Console.WriteLine("C A L C U L A T O R\n");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Square root");
            Console.WriteLine("6. Power\n");
            Console.WriteLine("Q. Exit");
            string choice = Console.ReadLine().ToLower();
            return choice;
        }

        public static void CalcChoice(string choice)
        {
            string theAnswerIs = "The answer is: ";
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"{theAnswerIs}{CalcAdd()}");
                    break;
                case "2":
                    Console.WriteLine($"{theAnswerIs}{CalcSubtract()}");
                    break;
                case "3":
                    Console.WriteLine($"{theAnswerIs}{CalcMultiply()}");
                    break;
                case "4":
                    Console.WriteLine($"{theAnswerIs}{CalcDivide()}");
                    break;
                case "5":
                    Console.WriteLine($"{theAnswerIs}{CalcSqrt()}");
                    break;
                case "6":
                    Console.WriteLine($"{theAnswerIs}{CalcPow()}");
                    break;
                case "q":
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }

        // Overloaded methods for testing purposes
        public static double CalcAdd(double number1, double number2)
        {
            return number1 + number2;
        }

        public static double CalcSubtract(double number1, double number2)
        {
            return number1 - number2;
        }

        public static double CalcMultiply(double number1, double number2)
        {
            return number1 * number2;
        }

        public static double CalcDivide(double number1, double number2)
        {
            if (number2 == 0)
            {
                Console.WriteLine("The number cannot be divided by zero");
            }
            return number1 / number2;
        }

        public static double CalcSqrt(double number1)
        {
            if (number1 < 0)
            {
                throw new ArgumentOutOfRangeException("Cannot take the square root of a negative number.");
            }
            return Math.Sqrt(number1);
        }

        public static double CalcPow(double number1, double number2)
        {
            return Math.Pow(number1, number2);
        }

        // Original methods for interactive console input
        public static double CalcAdd()
        {
            double number1, number2;
            Console.Clear();
            Console.WriteLine("1. Add");
            Console.Write("Enter first digit: ");
            while (!double.TryParse(Console.ReadLine(), out number1))
            {
                Console.Write("Wrong number, try again: ");
            }
            Console.Write("Enter second digit: ");
            while (!double.TryParse(Console.ReadLine(), out number2))
            {
                Console.Write("Wrong number, try again: ");
            }
            return CalcAdd(number1, number2);
        }

        public static double CalcSubtract()
        {
            double number1, number2;
            Console.Clear();
            Console.WriteLine("2. Subtract");
            Console.Write("Enter first digit: ");
            while (!double.TryParse(Console.ReadLine(), out number1))
            {
                Console.Write("Wrong number, try again: ");
            }
            Console.Write("Enter second digit: ");
            while (!double.TryParse(Console.ReadLine(), out number2))
            {
                Console.Write("Wrong number, try again: ");
            }
            return CalcSubtract(number1, number2);
        }

        public static double CalcMultiply()
        {
            double number1, number2;
            Console.Clear();
            Console.WriteLine("3. Multiply");
            Console.Write("Enter first digit: ");
            while (!double.TryParse(Console.ReadLine(), out number1))
            {
                Console.Write("Wrong number, try again: ");
            }
            Console.Write("Enter second digit: ");
            while (!double.TryParse(Console.ReadLine(), out number2))
            {
                Console.Write("Wrong number, try again: ");
            }
            return CalcMultiply(number1, number2);
        }

        public static double CalcDivide()
        {
            double number1, number2;
            Console.Clear();
            Console.WriteLine("4. Divide");
            Console.Write("Enter first digit: ");
            while (!double.TryParse(Console.ReadLine(), out number1))
            {
                Console.Write("Wrong number, try again: ");
            }
            Console.Write("Enter second digit: ");
            while (!double.TryParse(Console.ReadLine(), out number2))
            {
                Console.Write("Wrong number, try again: ");
            }
            return CalcDivide(number1, number2);
        }

        public static double CalcSqrt()
        {
            double number1;
            Console.Clear();
            Console.WriteLine("5. Square root");
            Console.Write("Enter a digit: ");
            while (!double.TryParse(Console.ReadLine(), out number1))
            {
                Console.Write("Wrong number, try again: ");
            }
            return CalcSqrt(number1);
        }

        public static double CalcPow()
        {
            double number1, number2;
            Console.Clear();
            Console.WriteLine("6. Power");
            Console.Write("Enter first digit: ");
            while (!double.TryParse(Console.ReadLine(), out number1))
            {
                Console.Write("Wrong number, try again: ");
            }
            Console.Write("Enter second digit: ");
            while (!double.TryParse(Console.ReadLine(), out number2))
            {
                Console.Write("Wrong number, try again: ");
            }
            return CalcPow(number1, number2);
        }
    }
}
