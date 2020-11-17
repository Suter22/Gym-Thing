using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Thing
{
    class Program
    {
        static void Main(string[] args)
        {
            float weightx;
            float heightx;
            float agex;
            float weightBMR;
            float heightBMR;
            float ageBMR;
            float heightsquared;
            int weight;
            float BMRMulti;
            int option;
            float heightm;

            while (true)
            {
                Console.Write("Enter Gender(M/F): ");
                string gender = Console.ReadLine();
                gender = gender.ToUpper();

                if (gender == "M")
                {
                    weightx = 13.397f;
                    heightx = 4.799f;
                    agex = 5.677f;
                    break;
                }

                if (gender == "F")
                {
                    weightx = 9.247f;
                    heightx = 3.098f;
                    agex = 4.330f;
                    break;
                }

            }

            while (true)
            {
                Console.Clear();
                Console.Write("Enter Weight(30-250KG): ");
                weight = Convert.ToInt32(Console.ReadLine());

                if (30 <= weight && weight <= 250)
                {
                    weightBMR = weight * weightx;
                    break;

                }
            }

            while (true)
            {
                Console.Clear();
                Console.Write("Enter Height(120-210cm): ");
                int height = Convert.ToInt32(Console.ReadLine());

                if (120 <= height && height <= 210)
                {
                    
                    heightBMR = height * heightx;
                    heightm = height / 100;
                    heightsquared = heightm * heightm;
                    break;
                }
            }

            while (true)
            {
                Console.Clear();
                Console.Write("Enter Age(14-100 Years): ");
                int age = Convert.ToInt32(Console.ReadLine());

                if (14 <= age && age <= 100)
                {
                    ageBMR = age * agex;
                    break;
                }
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter Your Exercise Level(1-5)");
                Console.WriteLine("1. Little To No Exercise");
                Console.WriteLine("2. Light Exercise(1-3 Days Per Week)");
                Console.WriteLine("3. Moderate Exercise(3-5 Days Per Week)");
                Console.WriteLine("4. Heavy Exercise(6-7 Days Per Week)");
                Console.WriteLine("5. Very Heavy Exercise(Twice Per Day)");
                Console.Write("Enter Level: ");

                option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    BMRMulti = 1.2f;
                    break;
                }

                if (option == 2)
                {
                    BMRMulti = 1.375f;
                    break;
                }

                if (option == 3)
                {
                    BMRMulti = 1.55f;
                    break;
                }

                if (option == 4)
                {
                    BMRMulti = 1.725f;
                    break;
                }

                if (option == 5)
                {
                    BMRMulti = 1.9f;
                    break;
                }
            }

            double BMR = 88.362 + weightBMR + heightx - agex;
            float BMI = weight / heightsquared;
            double KalIn = BMR * BMRMulti;

            Console.Clear();
       
            Console.WriteLine("BMR");
            Console.WriteLine("------");
            Console.WriteLine(BMR);
            Console.WriteLine("------");
            Console.WriteLine(" ");

            Console.WriteLine("BMI");
            Console.WriteLine("------");
            Console.WriteLine(BMI);
            Console.WriteLine("------");
            Console.WriteLine(" ");

            Console.WriteLine("Your BMI Category");
            Console.WriteLine("------");
            if (BMI < 18.5)
            {
                Console.WriteLine("Your Underwieght");
            }

            if (BMI > 18.5 && BMI < 24.9)
            {
                Console.WriteLine("Your Normal Weight");
            }

            if (BMI > 25 && BMI < 29.9)
            {
                Console.WriteLine("Your Overweight");
            }

            if (BMI > 30)
            {
                Console.WriteLine("Your Obese");
            }
            Console.WriteLine("------");
            Console.WriteLine(" ");

            Console.WriteLine("BMI Target");
            Console.WriteLine("------");
            Console.WriteLine("BMI Target = 22 (Normal Weight)");
            Console.WriteLine("------");
            Console.WriteLine(" ");

            Console.WriteLine("Kilocalorie Intake");
            Console.WriteLine("------");
            Console.WriteLine(KalIn);
            Console.WriteLine("------");

            Console.ReadKey();
        }
    }
}
