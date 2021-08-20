using System;

namespace BMI
{
    class CalculateBmi
    {
        private int weight;
        private int height;
        private string gender;

        public CalculateBmi(int w,int h, string g)
        {
            this.weight = w;
            this.height = h;
            this.gender = g;
        }

        private double calculate(int wght, int hght)
        {
            double ht = hght / 100.0;
            double bmi = wght/(ht*ht);
            return bmi;
        }

        public void checkMyBMI() {
            double bmi = calculate(weight, height);
            if (bmi <19 & gender == "f") {
                Console.WriteLine("BMI is {0}",bmi);
                Console.WriteLine("UnderWeight");
            }
            if (bmi >= 19 & bmi <= 24 & gender == "f")
            {
                Console.WriteLine("BMI is {0}", bmi);
                Console.WriteLine("Normal");
            }
            if (bmi > 24 & gender == "f")
            {
                Console.WriteLine("BMI is {0}", bmi);
                Console.WriteLine("Overweight");
            }
            if (bmi < 20 & gender == "m")
            {
                Console.WriteLine("BMI is {0}", bmi);
                Console.WriteLine("UnderWeight");
            }
            if (bmi >= 20 & bmi <= 25 & gender == "m")
            {
                Console.WriteLine("BMI is {0}", bmi);
                Console.WriteLine("Normal");
            }
            if (bmi > 25 & gender == "m")
            {
                Console.WriteLine("BMI is {0}", bmi);
                Console.WriteLine("Overweight");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== BMI Calculator =====");
            Console.WriteLine();
            Console.WriteLine("Enter weight in Kg");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height in cm");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter m for male or f for female");
            string gender = Console.ReadLine();
            CalculateBmi myhealth = new CalculateBmi(weight,height,gender);
            myhealth.checkMyBMI();
        }
    }
}
