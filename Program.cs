namespace wk3ex2_Review;
class Program
{
    // Declaring variables that store user inputs and the final result
    public static double num1, num2, result;
    // Variable to store the selected menu option
    public static int menuOption;
    // String to store the name of the operation performed
    public static string operations = " ";
    // Boolean to check input validation (currently unused)
    public static bool valid = false;

    static void Main(string[] args)
    {
        // Title of the application
        Console.WriteLine("CALCULATOR APPLICATION");
        // Prompting user to enter the first number
        Console.Write("What is the first number? ");
        num1 = Convert.ToDouble(Console.ReadLine());
        // Prompting user to enter the second number
        Console.Write("What is the second number? ");
        num2 = Convert.ToDouble(Console.ReadLine());
        // Repeat until user enters a valid option between 1 and 4
        do
        {
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Substraction"); // Note: spelling typo, should be "Subtraction"
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.Write("Enter your choice (1-4): ");
            menuOption = Convert.ToInt32(Console.ReadLine());
            // Let the user know if input was invalid
            if (menuOption < 1 || menuOption > 4)
            {
                Console.WriteLine("Select a valid option (1–4).");
            }
        } while (menuOption < 1 || menuOption > 4); // Keeps looping until valid input is entered
        // Executes operation based on user's selection
        switch (menuOption)
        {
            case 1:
                operations = "Addition";
                Operations.Addition(operations, num1, num2); // Call addition method
                Operations.ShowResults(); // Display results
                break;
            case 2:
                operations = "Substraction"; // same typo here
                Operations.Substraction(operations, num1, num2); // Call subtraction
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
                // Shouldn’t happen, but just in case
                Console.WriteLine("Select a valid option");
                break;
        }
        // Keep the console open until user presses a key
        Console.Read();
    }
    // Inner class containing all calculator operations
    public class Operations
    {
        public static double Addition(string operation, double num1, double num2)
        {
            result = num1 + num2; // adds two numbers
            return result;
        }
        public static double Substraction(string operation, double num1, double num2)
        {
            result = num1 - num2; // subtracts second number from first
            return result;
        }
        public static double Multiplication(string operation, double num1, double num2)
        {
            result = num1 * num2; // multiplies numbers
            return result;
        }
        public static double Division(string operation, double num1, double num2)
        {
            result = num1 / num2; // divides num1 by num2, no zero check
            return result;
        }
        public static void ShowResults()
        {
            // Displays result twice with 2 decimal places
            Console.WriteLine($"The result of {operations} is: {result:F2}");
            Console.WriteLine($"Here is the result: {result:F2}");
        }
    }
}
