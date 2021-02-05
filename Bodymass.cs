using System;

namespace Palm_Pilot
{
    public class Bodymass
    {
        
        // declaring variables used below
            public double Height { get; set; }
            public double Weight { get; set; }
            public double Bmi { get; private set; }

        public Bodymass(double height, double weight)
        {
            Height = height;
            Weight = weight;
            CalculateBMI();
        }
        
        private void CalculateBMI()
        {
            this.Bmi = (this.Weight * 703) / (this.Height * this.Height);
        }

        public string DisplayBMI()
        {
            if (Bmi < 18)
            {
                return "underweight";
            }
            if (Bmi > 24)
            {
                return "fluffy";
            }
            else
            {
                return "normal weight";
            }
        }
        
        // public void Bodymassindex()
        // {          
        //     //prompt user for weight in pounds and then height in inches
        //     Console.WriteLine("Please enter your height (in inches): ");
        //     height = Convert.ToInt32(Console.ReadLine());

        //     Console.WriteLine("Please enter your weight (in pounds): ");
        //     weight = Convert.ToInt32(Console.ReadLine());

        //     bmi = (weight * 703)/(height * height);

        //     if (bmi >= 18 && bmi <= 24)
        //     {
        //         Console.WriteLine("Your BMI is {0}. You are normal weight.",bmi);
        //     }
        //     if (bmi < 18)
        //     {
        //         Console.WriteLine("Your BMI is {0}. You are underweight.",bmi);
        //     }
        //     if (bmi > 24)
        //     {
        //         Console.WriteLine("Your BMI is {0}. You are overweight.",bmi);
        //     }
        // }
    }
}