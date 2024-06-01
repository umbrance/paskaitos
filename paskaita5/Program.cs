namespace paskaita5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Paskaitos data 2024-05-28 //

            //PirmaSuDo();
            //TikrinkSlaptazodi();


            // PASSWORD //

            //if (IsPasswordValid(EnterPassword()))
            //{
            //    Console.WriteLine("Password accepted.");
            //}
            //else
            //{
            //    Console.WriteLine("Password rejected.");
            //}

            // EMAIL Eil. 136 //

            //if (IsEmailValid(EnterEmail()))
            //{
            //    Console.WriteLine("Email is valid.");
            //}
            //else
            //{
            //    Console.WriteLine("Email is NOT valid.");
            //}

            // CONVERT TO EUROS //

            //Console.WriteLine(ConvertToEuros(GeneralInput()));

            // GET INITIALS

            //string firstName;
            //string lastName;
            //Console.Write($"Enter your first name: ");
            //firstName = Console.ReadLine();
            //Console.Write($"Enter your last name: ");
            //lastName = Console.ReadLine();
            //Console.WriteLine(GetInitials(firstName, lastName));

            // CYLINDER VOLUME //

            //double radius, height;
            //Console.Write("Enter cylinder radius: ");
            //while (!double.TryParse(Console.ReadLine(), out radius))
            //{
            //    Console.WriteLine("Wrong radius, try again.");
            //}
            //Console.Write("Enter cylinder height: ");
            //while (!double.TryParse(Console.ReadLine(), out height))
            //{
            //    Console.WriteLine("Wrong height, try again.");
            //}
            //Console.WriteLine($"The volume of meant cylinder: {CalculateCylinderVolume(radius, height):F2}");

            // IS NUMBER EVEN

            //int number;
            //Console.Write("Enter a number in order to check if it's even or not: ");
            //while (!int.TryParse(Console.ReadLine(), out number))
            //{
            //    Console.Write("Wrong number entered. Enter number again: ");
            //}
            //if (IsNumberEven(number))
            //{
            //    Console.WriteLine("The number is even.");
            //}
            //else
            //{
            //    Console.WriteLine("The number is uneven.");
            //}

            // RACTANGLE AREA

            //double number1, number2;
            //Console.Write("Please enter ractangle's length: ");
            //while (!double.TryParse(Console.ReadLine(), out number1))
            //{
            //    Console.Write("Wrong length entered. Check the number and try again: ");
            //}
            //Console.Write("Please enter ractangle's width: ");
            //while (!double.TryParse(Console.ReadLine(), out number2))
            //{
            //    Console.Write("Wrong width entered. Check the number and try again: ");
            //}
            //Console.WriteLine($"Ractangle's area is equal to: {CalculateRactangleArea(number1, number2):F2}");
        }
        public static void PirmaSuDo()
        {
            char pasirinkimas = 'A';
            int skaicius, suma = 0;
            do
            {
                Console.Write("Iveskite skaiciu: ");
                int.TryParse(Console.ReadLine(), out skaicius);
                suma = skaicius + suma;
                Console.WriteLine("Ar norite testi? (T/N)");
                Char.TryParse(Console.ReadLine(), out pasirinkimas);
                pasirinkimas.ToString().ToLower();
            } while (pasirinkimas != 'n');
            Console.WriteLine($"Gauta suma lygi {suma}");
        }
        public static void TikrinkSlaptazodi()
        {
            string slaptazodis = "abc123";
            string bandymas = "zero";
            do
            {
                Console.Write("Iveskite slaptazodi: ");
                bandymas = Console.ReadLine();
            } while (bandymas != slaptazodis);
        }
        public static bool IsPasswordValid(string password)
        {
            if (password.Length > 7)
            {
                return true;
            }
            return false;
        }
        public static string EnterPassword()
        {
            string thePassword;
            Console.WriteLine("Enter password: ");
            return thePassword = Console.ReadLine();
            IsPasswordValid(thePassword);
        }
        public static string EnterEmail()
        {
            Console.Write("Enter email address: ");
            string email = Console.ReadLine();
            return email;
        }
        public static bool IsEmailValid(string email)
        {
            if (email.Contains('@') && email.Contains('.'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static double GeneralInput()
        {
            double number;
            Console.Write("Enter number: ");
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Wrong number. Try again: ");
            }
            return number;
        }
        public static double ConvertToEuros(double dollars)
        {
            double result = dollars * 0.85;
            return result;
        }
        public static string GetInitials(string firstName, string lastName)
        {
            string returnedText = ($"Your name is: {firstName} and surname: {lastName}");
            return returnedText;
        }
        public static double CalculateCylinderVolume(double radius, double height)
        {
            double answer = Math.PI * Math.Pow(radius, 2) * height;
            return answer;
        }
        public static bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static double CalculateRactangleArea(double length, double width)
        {
            double answer = Math.Truncate((length * width) * 1000) / 1000;
            // Apvalina iki sveikojo skaiciaus
            //Math.Round(answer);
            return answer;

        }
    }
}
