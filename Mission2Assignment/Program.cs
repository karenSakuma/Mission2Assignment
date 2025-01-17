// See https://aka.ms/new-console-template for more information
using System;
using Mission2Assignment;

internal class Program 
{
    public static void Main(string[] args)
    {
        RollDice roll = new RollDice();
        Console.WriteLine("Welcome to the dice throwing simulator!\n");
        Console.Write("How many dice rolls would you like to simulate? ");
        string numRoll = Console.ReadLine();
        int percentage = 0; //the percentage that will be used in the calculation
        
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + numRoll + "\n");

        int numRolls = int.Parse(numRoll); //change from string to integer
        int[] results = roll.Throw(numRolls); //pass to the RollDice class
        
        //start the for loop at 2 and end at 12 because thats the range of the results
        for (int i = 2; i <= 12; i++)
        {
            int numCounter = 0; //used for calculating percentage
            foreach (int num in results) //loop through each result and compare it to the dice number
            {
                if (num == i)
                {
                    numCounter++;
                }
            }
            percentage = (numCounter * 100) / numRolls;  //calculate the percentage and then print it
            Console.WriteLine(i + ": " + new string('*', percentage));
        }
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}