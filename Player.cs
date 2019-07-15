using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Craps
{
    class Player
    {
        // A player has money, has a place in the table
        // and can place bets on the table, and roll dice. 

        int money { get; set; }
        
        
        string id;
        

        public Player(int betMoney, string place)
        {
            money = betMoney;
            id = place;
        }

        public int shoot(Dice shooter)
        {
            Random rnd = new Random();
            return shooter.myRollAlgo(rnd);
        }


    }
}
