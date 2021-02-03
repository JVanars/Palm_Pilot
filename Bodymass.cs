using System;

namespace Palm_Pilot
{
    public class Bodymass
    {
        public void Bodymassindex()
        {
            // declaring variables used below
            int height;
            int weight;
            int bmi;

            //prompt user for weight in pounds and then height in inches
            Console.WriteLine("Please enter your height (in inches): ");
            height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your weight (in pounds): ");
            weight = Convert.ToInt32(Console.ReadLine());

            bmi = (weight * 703)/(height * height);

            if (bmi >= 18 && bmi <= 24)
            {
                Console.WriteLine("Your BMI is {0}. You are normal weight.",bmi);
            }
            if (bmi < 18)
            {
                Console.WriteLine("Your BMI is {0}. You are underweight.",bmi);
            }
            if (bmi > 24)
            {
                Console.WriteLine("Your BMI is {0}. You are overweight.",bmi);
            }
        }
    }
}