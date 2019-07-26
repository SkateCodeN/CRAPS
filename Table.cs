
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Craps
{
    class Table
    {
        Button[] points = new Button[5];

        // Table has points 
        // 4,5,6,8,9,10 are point numbers 
        // 
        // Table also has a Pass Line
        // Table Has a field 2,3,4,9,10,11,12 are field numbers
        // Table has a come 
        // Table has a don't come
        // Table has a Dont pass
        Dictionary<string, int> tableNumbers = new Dictionary<string, int>();
        int[] tableField = new int[6];
        int[] tablePoints = new int[5];
        
        public Table()
        {
            loadBets();
        }
        
        void loadBets()
        {
            // Load points into the Dictionary
            tableNumbers.Add("Snake Eyes", 2);
            tableNumbers.Add("Ace Deuce", 3);
            tableNumbers.Add("Four", 4);
            tableNumbers.Add("Fever",5);
            tableNumbers.Add("Six",6);
            tableNumbers.Add("Seven",7);
            tableNumbers.Add("Eight",8);
            tableNumbers.Add("Nine",9);
            tableNumbers.Add("ten", 10);
            tableNumbers.Add("YO!", 11);
            tableNumbers.Add("BoxCars", 12);

            //Load the field 
            tableField[0] = 2;
            tableField[1] = 3;
            tableField[2] = 4;
            tableField[3] = 9;
            tableField[4] = 10;
            tableField[5] = 11;
            tableField[6] = 12;

            //Load the table points
            tablePoints[0] = 4;
            tablePoints[1] = 5;
            tablePoints[2] = 6;
            tablePoints[3] = 8;
            tablePoints[4] = 9;
            tablePoints[5] = 10;

        }

    }
}


