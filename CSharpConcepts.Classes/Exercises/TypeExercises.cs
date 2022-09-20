using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharpConcepts.Classes.Examples.TypeExamples;

namespace CSharpConcepts.Classes.Exercises
{
    public static class TypeExercises
    {
        // Q1: Calculator 1
        // Write to the console correctly the results of: +. - , *, /
        public static void Calculator(int num1, int num2)
        {
            //throw new NotImplementedException();
            Console.WriteLine("the sum of these numbers is:");
            Console.WriteLine(num1 + num2);
            Console.WriteLine("the difference of these numbers is:");
            Console.WriteLine(num1 - num2);
            Console.WriteLine("the product of these numbers is:");
            Console.WriteLine(num1 * num2);
            Console.WriteLine("the quotient of these numbers is:");
            Console.WriteLine(num1 / num2);
        }

        // Q2: Calculator 2
        // Try to convert both the values to a double and write to the console the results of: +. - , *, /
        public static void Calculator(string value1, string value2)
        {
            //throw new NotImplementedException();
            double num1 = Convert.ToDouble(value1);
            double num2 = Convert.ToDouble(value2);
            Console.WriteLine("the sum of these numbers is:");
            Console.WriteLine(num1 + num2);
            Console.WriteLine("the difference of these numbers is:");
            Console.WriteLine(num1 - num2);
            Console.WriteLine("the product of these numbers is:");
            Console.WriteLine(num1 * num2);
            Console.WriteLine("the quotient of these numbers is:");
            Console.WriteLine(num1 / num2);
        }

        // Q3: Binary Strings
        // Write to the console the number printed in Binary, Decimal and Hex formats
        public static void BinaryStrings(int num)
        {
            //throw new NotImplementedException();
            string binnum = Convert.ToString(num, 2);
            string hexnum = Convert.ToString(num, 16);
            Console.WriteLine(binnum);
            Console.WriteLine(num);
            Console.WriteLine(hexnum);
        }

        // Q4: BMI
        // Calculate and return the BMI - Body mass index
        public static double BMICalculator(double height, double weight)
        {
            //throw new NotImplementedException();
            double bmi = weight / (height * height);
            Console.WriteLine(bmi);
            return bmi;
        }

        // Q5: FutureDate
        // Write to the console today's date. Return the date that it will be when the days passed in are added to the current date. 
        public static DateTime FutureDate(int days)
        {
            //throw new NotImplementedException();
            Console.WriteLine(DateTime.Now);
            DateTime newDate = DateTime.Now.AddDays(days);
            Console.WriteLine(newDate);
            return newDate;
        }
        
        // Q6: Languages
        // Using the enum below write a program that will convert the proposed language to the enum if availabe
        // Otherwise it should randomly assign a language
        public enum Language
        {
            French,
            Italian,
            Spanish,
            Finnish
        }
        public static Language SelectLanguage(string proposedLanguage)
        {
            //throw new NotImplementedException();
            if (Enum.TryParse(proposedLanguage, true, out Language lang))
            {
                Console.WriteLine(lang);
                return lang;
            }
            else
            {
                Console.WriteLine("language not valid, randomly selecting");
                Random random = new Random();
                int num = random.Next(0, 4);
                Language langRandom = (Language)num;
                Console.WriteLine(langRandom);
                return langRandom;
            }
                
        }


    }
}
