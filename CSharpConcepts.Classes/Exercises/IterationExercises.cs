using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.Classes.Exercises
{
    public static class IterationExercises
    {
        // Q1: Centuries
        // Calculate the number of times a batter scored a century (100 runs) or more in a match
        public static int NumberOfCenturiesScored(List<int> runsScored)
        {
            int centuries = 0;
            foreach (int num in runsScored)
            {
                if (num >= 100)
                {
                    centuries++;
                }
            }
            return centuries;
        }

        // Q2: Batting Average
        // Calculate the batting average.
        // Exclude any values where the runs scored were negative as a negative value indicates that they did not bat in that match.
        public static double BattingAverage(List<int> runsScored)
        {
            double total = 0;
            int bats = runsScored.Count;
            foreach (int num in runsScored)
            {
                if (num >= 0)
                {
                    total += num;
                }

            }
            double average = total / bats;
            return average;
        }

        // Q3: User Names
        // Determine the user names
        // It will be the first three characters of their name and a number, which will be the order of the name in the list.
        public static List<string> UserNames(List<string> names)
        {
            List<string> username = new List<string>();
            for (int i = 0; i< names.Count; i++)
            {
                username.Add(names[i].Substring(0, 3) + Convert.ToString(i));
            }
            return username;
        }

        // Q4: Calculate Multiples
        // Write a function that will output the multiple of a number from 1 to the max number specified
        // So called with 6 and 10 it would output [6, 12, 18, 24, 30, 36, 42, 48, 54, 50]
        public static List<int> CalculateMultiples(int number, int maximumMultiple)
        {
            List<int> multiples = new List<int>();
            for (int i = 1; i <= maximumMultiple/number; i++)
            {
               multiples.Add(i*number);
            }
            return multiples;
        }

        // Q5: Is Prime
        // Write a function to determine whether a number is prime
        public static bool isPrime(int num)
        {
            int factors = 0;
            bool prime = false;
            for (int i = num; i >= 1; i--)
            {
                if (num % i == 0)
                {
                    factors++;
                }
                 
            }
            if (factors == 2)
            {
                prime = true;
                return prime;
            }
            else
            {
                prime = false;
                return prime;
            }
            
        }
        // Q6: Star Pattern
        // Write a procedure to output a star pattern based on the number of stars input
        // So for example if the user enters 6 then it will output:

        //*
        //**
        //***
        //****
        //*****
        //******
        //*****
        //****
        //***
        //**
        //*
        public static void starPattern(int num)
        {
            string star = "";
            for (int i = 0; i <= num; i++)
            {
                star += "*";
                Console.WriteLine(star);
            }
            for (int i = num; i >= 0; i--)
            {
                Console.WriteLine(star.Substring(0,i));
            }
        }
        // Q7: This function should take a noughts and crosses board represented as an character list,
        // A space represents an empty space as shown below.



        public static char noughtsandcrosses(List<List<char>> board)
        {
            char winner = 'n';

            for (int i = 0; i <= 2; i++)
            {
                if (board[i][0] == 'X' && board[i][1] == 'X' && board[i][2] == 'X')
                {
                    winner = 'X';
                }
                else if (board[i][0] == '0' && board[i][1] == '0' && board[i][2] == '0')
                {
                    winner = '0';
                }
                if (board[0][i] == 'X' && board[1][i] == 'X' && board[2][i] == 'X')
                {
                    winner = 'X';
                }
                else if (board[0][i] == '0' && board[1][i] == '0' && board[2][i] == '0')
                {
                    winner = '0';
                }
            }
            if (board[0][0] == 'X' && board[1][1] == 'X' && board[2][2] == 'X')
            {
                winner = 'X';
            }
            else if (board[0][0] == '0' && board[1][1] == '0' && board[2][2] == '0')
            {
                winner = '0';
            }
            if (board[0][2] == 'X' && board[1][1] == 'X' && board[2][0] == 'X')
            {
                winner = 'X';
            }
            else if (board[0][2] == '0' && board[1][1] == '0' && board[2][0] == '0')
            {
                winner = '0';
            }

            return winner;
        }

        // The function should return a char: 'X' if player X has won, '0' if the player 0 has won,
        // and ' ' if there is currently no winner.
    }
}
