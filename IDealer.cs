   class Player: IDealer
    {
        // A player has money, has a place in the table
        // and can place bets on the table, and roll dice. 

        public int money {  get; set; }
        
        // Sure our player can have a name
        string tablePlace;

        public Player(int betMoney, string place)
        {
            money = betMoney;
            tablePlace = place;
        }

        public int shoot(Dice dices)
        {
            int dice_Roll = dices.myRollAlgo();
           
            return dice_Roll;
        }

        public string CallNumber(int n1, int n2)
        {
            // Add the two numbers 
            //  int c = n1 + n2;
            string number = (n1 + n2).ToString();

            return number;
            
        }
    }
