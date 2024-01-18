
using MoreCSharpFun;
public class Program
{
    static void Main(string[] args) // the start of the program
    {

        int numRolls = 0;

        System.Console.WriteLine("Please enter the number of rolls");
        numRolls = int.Parse(System.Console.ReadLine());

        // Create an instance of the DiceRoll class
        diceRoll diceRollInstance = new diceRoll(numRolls); //Declaration--making an instance of the diceRoll function
                                                            // you need a constructor of numRolls bc that is what makes the instance unique

        // Call the GetResults method to get the array of results
        int[] results = diceRollInstance.getResults(); // int[] puts the results into an array 

        for (int i = 2; i <= 12; i++) // i variable representing each possible combination of dice rolls starting at 2
        {
            int percentage = (int)Math.Round((double)results[i] / numRolls * 100); // calculate the percentage of rolls for each number and convert the first number to a double float
            string output = new string('*', percentage); // make a new string variable that adds a * for each percentage point
            Console.WriteLine($"{i}: {output} "); // concatinate the output and print it
        }

        System.Console.WriteLine("Thank you for using this cool dice rolling simulator!");
    }


}

//if a class is static you can't create instances from it. 
