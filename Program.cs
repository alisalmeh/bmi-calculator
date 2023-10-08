using System;

namespace AliSalmeh_ProjectWeek5_BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Calculator calculator = new Calculator();

            try
            {
                GetUserInputs(calculator);
                calculator.CalculateBmi();
                Console.WriteLine(calculator);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private static void GetUserInputs(Calculator calculator)
        {
            GetUserName(calculator);
            GetWeight(calculator);
            GetHeight(calculator);
        }

        // Avoid getting empty input as a name
        private static void GetUserName(Calculator calculator)
        {
            while (string.IsNullOrEmpty(calculator.Name))
            {
                Console.WriteLine("Please Enter Your Name: ");
                string name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("\"Name\" cannot be empty!");
                }
                else
                {
                    calculator.Name = name;
                }
            }
        }

        // Determine a logical range for weight
        private static void GetWeight(Calculator calculator)
        {
            while (true)
            {
                Console.WriteLine("\nEnter Your Weight (kg): ");
                if (double.TryParse(Console.ReadLine(), out double weight) && weight > 0 && weight < 1000)
                {
                    calculator.Weight = weight;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid number for weight.");
                }
            }
        }

        // Determine a logical range for height
        private static void GetHeight(Calculator calculator)
        {
            while (true)
            {
                Console.WriteLine("\nEnter Your Height (m): ");
                if (double.TryParse(Console.ReadLine(), out double height) && height > 0 && height < 3)
                {
                    calculator.Height = height;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid number for height.");
                }
            }
        }
    }
}