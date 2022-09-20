using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using CSharpConcepts.Classes.Exercises;

namespace CSharpConcepts
{
    internal class Exercises
    {
        internal static void Run()
        {
            CallTypeExercises();
            CallSelectionExercises();
        }

        private static void CallTypeExercises()
        {
            // Add your calling code here for the questions an example is below

            Console.WriteLine("# Calculator");
            TypeExercises.Calculator(12, 5);
            Console.WriteLine();

            Console.WriteLine("# Calculator 2");
            TypeExercises.Calculator("10", "3");
            Console.WriteLine();

            Console.WriteLine("numbers");
            TypeExercises.BinaryStrings(12);
            Console.WriteLine();

            Console.WriteLine("bmi");
            TypeExercises.BMICalculator(1.7, 50);
            Console.WriteLine();

            Console.WriteLine("future date");
            TypeExercises.FutureDate(7);
            Console.WriteLine();

            Console.WriteLine("language");
            TypeExercises.SelectLanguage("French");
            Console.WriteLine();
        }

        private static void CallSelectionExercises()
        {
            // Add your calling code here for the selection questions

            Console.WriteLine("fizzbuzz");
            SelectionExercises.FizzBuzz(15);
            Console.WriteLine();

            Console.WriteLine("vowel or no");
            SelectionExercises.VowelOrConsonant('a');
            Console.WriteLine();

            Console.WriteLine("dice roller");
            SelectionExercises.DiceRoller(1);
            Console.WriteLine();

            Console.WriteLine("angle checker");
            SelectionExercises.AngleChecker(200);
            Console.WriteLine();

            Console.WriteLine("1 for rock 2 for paper 3 for scissors");
            SelectionExercises.rps(1);
            Console.WriteLine();

            Console.WriteLine("triangle type");
            SelectionExercises.triangle(1,4,7);
            Console.WriteLine();
        }
    }
}
