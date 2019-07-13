using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Craps
{
    // The class simulates a dice roll. Once
    // invoked this gives back a number 1-6
    public class Dice
    {

        Random dice = new Random();
       

        public int Roll()
        {
            
            int diceRoll = dice.Next(1, 6);
            return diceRoll;
        }
    }
}
