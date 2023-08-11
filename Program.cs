using System;

namespace AliSalmeh_ProjectWeek4.BMI_Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            try
            {
                GetUserInputs(calculator);
                calculator.CalculateBmi();
                Console.WriteLine(calculator);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void GetUserInputs(Calculator calculator)
        {
            Console.WriteLine("Please Enter Your Name: ");
            calculator.Name = Console.ReadLine();

            Console.WriteLine("Enter Your Weight (kg): ");
            calculator.Weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Your Height (m): ");
            calculator.Height = Convert.ToDouble(Console.ReadLine());
        }
    }
}