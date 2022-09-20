using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.Classes.Exercises
{
    public static class SelectionExercises
    {
        // Q1: FizzBuzz
        // Return Fizz if divisible by 3. Buzz if divisible by 5. FizzBuzz if divisible by both.
        // If divisible by neither return the number itself (as a string)
        public static string FizzBuzz(int num)
        {
            //throw new NotImplementedException();

            if (num % 15 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (num % 3 == 0) {
                Console.WriteLine("Fizz");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {

            }
            return " ";
        }

        // Q2: Vowel or Consonant
        // Using a switch statement write a function which returns true if the input is a vowel and
        // false if it is a consonant
        public static bool VowelOrConsonant(char letter)
        {
            //throw new NotImplementedException();
            switch (letter)
            {
                case 'a':
                    Console.WriteLine("vowel");
                    break;
                case 'e':
                    Console.WriteLine("vowel");
                    break;
                case 'i':
                    Console.WriteLine("vowel");
                    break;
                case 'o':
                    Console.WriteLine("vowel");
                    break;
                case 'u':
                    Console.WriteLine("vowel");
                    break;
                default:
                    Console.WriteLine("consonant");
                    break;

            }
            return true;
        }

        // Q3: DiceRoller
        // Write a procedure which rolls three dice and write the following messages to the console
        // If all three dice have the same value write, "Three of a kind"
        // If two of the dice have the same value write, "You have a pair!
        // Otherwise write, "Sorry you lose
        public static void DiceRoller(int anything)
        {
            Random number = new Random();
            int roll1 = number.Next(0, 6);
            int roll2 = number.Next(0, 6);
            int roll3 = number.Next(0, 6);

            if (roll1 == roll2)
            {
                Console.WriteLine("you have a pair!");
            }
            else if (roll2 == roll3)
            {
                Console.WriteLine("you have a pair!");
            }
            else if (roll1 == roll3)
            {
                Console.WriteLine("you have a pair!");
            }
            else if (roll1 == roll2 && roll2 == roll3)
            {
                Console.WriteLine("3 of a kind!");
            }
            else
            {
                Console.WriteLine("you lose");
            }
        }
        // Q4: Angles
        // Write a function to return whether the angle input is acute, right angle, obtuse, straight or reflex
        // Use an enum for the different angle types

        public enum angleTypes
        {
            acute,
            right,
            obtuse,
            straight,
            reflex
        }

        public static double AngleChecker(double angle)
        {
            if (angle < 90d) {
                Console.WriteLine((angleTypes)0);
            }
            else if (angle == 90d)
            {
                Console.WriteLine((angleTypes)1);
            }
            else if (angle > 90d && angle < 180d)
            {
                Console.WriteLine((angleTypes)2);
            }

            else if (angle == 180d)
            {
                Console.WriteLine((angleTypes)3);
            }
            else if (angle > 180d)
            {
                Console.WriteLine((angleTypes)4);
            }
            return angle;
        }





        // Q5: Rock, Paper Scissors
        // Write a procedure which takes the user's choice as input and randomly generate the computer's choice
        // It should write the computer's choice to the console and write whether the user lost, won, or drew.
        // Handle the user input in the calling code in Program.cs
        public static int rps(int choice)
        {
            int userChoice = Convert.ToInt32(Console.ReadLine());

            if (userChoice == 1)
            {
                if (choice == 1)
                {
                    Console.WriteLine("draw");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("lose");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("win");
                }
            }
            else if (userChoice == 2)
            {
                if (choice == 1)
                {
                    Console.WriteLine("win");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("draw");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("lose");
                }
            }
            else if (userChoice == 3)
            {
                if (choice == 1)
                {
                    Console.WriteLine("lose");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("win");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("draw");
                }
            }
            return choice;

        }
        // Q6: Triangle
        // Write a function that takes in three side lengths.
        // Determine whether a triangle with those sides is equilateral, isosceles, scalene or impossible
        public static int triangle(int choice, int choice2, int choice3)
        {
            if (choice == choice2 || choice2 == choice3 || choice == choice3)
            {
                if (choice == choice2 && choice2 == choice3)
                {
                    Console.WriteLine("equilateral");
                }
                else
                {
                    Console.WriteLine("isosceles");
                }
            }
            else if (choice == 0 || choice2 == 0 || choice3 == 0)
            {
                Console.WriteLine("impossible");
            }
            else
            {
                Console.WriteLine("scalene");
            }
            return choice;
        }
        

    }
}
