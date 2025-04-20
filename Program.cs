namespace wk3ex2_Review;
class Program
{
    public static double num1, num2, result;
    public static int menuOption;
    public static string operations = " ";
    public static bool valid = false;
    static void Main(string[] args)
    {
        Console.WriteLine("CALCULATOR APPLICATION");

        Console.Write("What is the first number? ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("What is the second number? ");
        num2 = Convert.ToDouble(Console.ReadLine());
        do
        {
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Substraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.Write("Enter your choice (1-4): ");
            menuOption = Convert.ToInt32(Console.ReadLine());

            if (menuOption < 1 || menuOption > 4)
            {
                Console.WriteLine("Select a valid option (1–4).");
            }
        } while (menuOption < 1 || menuOption > 4);

            switch (menuOption)
            {
                case 1:
                    operations = "Addition";
                    Operations.Addition(operations, num1, num2);
                    Operations.ShowResults();
                    break;
                case 2:
                    operations = "Substraction";
                    Operations.Substraction(operations, num1, num2);
                    Operations.ShowResults();
                    break;
                case 3:
                    operations = "Multiplication";
                    Operations.Multiplication(operations, num1, num2);
                    Operations.ShowResults();
                    break;
                case 4:
                    operations = "Division";
                    Operations.Division(operations, num1, num2);
                    Operations.ShowResults();
                    break;
                default:
                    Console.WriteLine("Select a valid option");
                    break;
            }

        Console.Read();
    }
    public class Operations
    {
        public static double Addition(string operation, double num1, double num2)
        {
            result = num1 + num2;
            return result;
        }
        public static double Substraction(string operation, double num1, double num2)
        {
            result = num1 - num2;
            return result;
        }
        public static double Multiplication(string operation, double num1, double num2)
        {
            result = num1 * num2;
            return result;
        }
        public static double Division(string operation, double num1, double num2)
        {
            result = num1 / num2;
            return result;
        }
        public static void ShowResults()
        {
            Console.WriteLine($"The result of {operations} is: {result:F2}");
            Console.WriteLine($"Here is the result: {result:F2}");
        }
    }
}

