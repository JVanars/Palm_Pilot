using System;

namespace Palm_Pilot
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            
            Console.WriteLine("Please enter or select 1 program: ");
            response = Console.ReadLine();

            if (response.ToLower() == "quit")
            {
                return;
            }
            if (response == "1")
            {
                LoadBodyMass();
            }
            else 
            {
                Console.WriteLine("Goodbye!");
            }          
        }

        static void LoadBodyMass()
        {
            //prompt user for weight in pounds and then height in inches
            Console.WriteLine("Please enter your height (in inches): ");
            var height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter your weight (in pounds): ");
            var weight = Convert.ToDouble(Console.ReadLine());
            
            Bodymass instance = new Bodymass(height, weight);

            // Console.WriteLine("Your BMI is: {0}. You are {1}.", instance.Bmi.ToString("d2"), instance.DisplayBMI());
            Console.WriteLine("Your BMI is: {0:f2}. You are {1}.", instance.Bmi, instance.DisplayBMI());
        }
    }
}
