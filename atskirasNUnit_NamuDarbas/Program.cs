using System;

namespace atskirasNUnit_NamuDarbas
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int choice = CalcMenu();
                if (choice == -1)
                {
                    break;
                }
                double result = CalcChoiceProcessor(choice);
                Console.WriteLine($"The answer is: {result}");
            }
        }

        public static int CalcMenu()
        {
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("C A L C U L A T O R\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Square root");
            Console.WriteLine("6. Power");
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("Q. Quit");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Choose action: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string input = Console.ReadLine();
            if (input.Equals("q", StringComparison.OrdinalIgnoreCase))
            {
                return -1;
            }

            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 6)
            {
                return choice;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Wrong choice selected. Please repeat.");
            Console.ForegroundColor = ConsoleColor.Green;
            return CalcMenu();
        }

        public static double[] UserInput()
        {
            double[] numbers = new double[2];

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Type the first number: ");
            Console.ForegroundColor = ConsoleColor.Green;
            while (!double.TryParse(Console.ReadLine(), out numbers[0]))
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("This is not a number. Try again: ");
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Type the second number: ");
            Console.ForegroundColor = ConsoleColor.Green;
            while (!double.TryParse(Console.ReadLine(), out numbers[1]))
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("This is not a number. Try again: ");
                Console.ForegroundColor = ConsoleColor.Green;
            }

            return numbers;
        }

        public static double CalcChoiceProcessor(int choice)
        {
            double[] numbers;
            if (choice != 5)
            {
                numbers = UserInput();
            }
            else
            {
                numbers = new double[2];
                numbers[0] = UserInput()[0]; // Using only the first number for square root calculation
            }

            switch (choice)
            {
                case 1:
                    return CalcAdd(numbers[0], numbers[1]);
                case 2:
                    return CalcSubtract(numbers[0], numbers[1]);
                case 3:
                    return CalcMultiply(numbers[0], numbers[1]);
                case 4:
                    return CalcDivide(numbers[0], numbers[1]);
                case 5:
                    return CalcSqrt(numbers[0]);
                case 6:
                    return CalcPow(numbers[0], numbers[1]);
                default:
                    Console.WriteLine("Something went wrong.");
                    return 0;
            }
        }

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
            return number1 / number2;
        }

        public static double CalcSqrt(double number1)
        {
            return Math.Sqrt(number1);
        }

        public static double CalcPow(double number1, double number2)
        {
            return Math.Pow(number1, number2);
        }
    }
}
