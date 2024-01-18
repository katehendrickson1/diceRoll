using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreCSharpFun
{
    internal class diceRoll
    {
        int[] results = new int[13]; // Array to store counts of each possible combination (2 to 12)
        public diceRoll(int numRolls)
        {


            Random random = new Random(); //import random class and make a random instance

            for (int iCount=0; iCount < numRolls; iCount++ )
            {
                //generate 2 seperate random numbers for dice 1 and dice 2 
                int dice1 = new Random().Next(1, 7);
                int dice2 = new Random().Next(1, 7);

                int combo = dice1 + dice2; //add dice rolls together

                results[combo]++; // add results of the roll to reults array

               

            }
        }
        public int[] getResults()
        {
            return results; // a method that returns the results array 
        }
    }
}
