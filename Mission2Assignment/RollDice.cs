using Microsoft.VisualBasic;

namespace Mission2Assignment;

public class RollDice
{
    public RollDice()
    {
        
    }
    public int[] Throw(int numThrow)
    {
        Random random = new Random();
        int[] rollResults = [];
        int total = 0; //the total after adding up the two dice numbers will be stored here
        List<int> results = new List<int>();  //create a list first because arrays can't append elements
        for (int i = 0; i < numThrow; i++)
        {
            int dice1 = random.Next(1, 7); //randomly choose a number between 1 and 6 for both dice
            int dice2 = random.Next(1, 7); 
            total = dice1 + dice2;
            results.Add(total); //add the results of the two dice
        }
        return results.ToArray(); //change to an array
    }
}