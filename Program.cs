using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Program
    {
        /* Game will be in stages
         * First you will decide how long you would like to play. 7, 14, or 30 days.
         * Each day you will be told the days weather forecast. Hot humid days you will have potential to sell the most, cold wet days least.
         * You then will buy stock.
         * You will then price your lemonade accordingly & decide how much ice to use in each cup.
         * It takes 4 Lemons and 4 cups of sugar per pitcher. A pitcher fills anywhere from 10-20 cups depending on how much ice you use in each cup.
         * 
         * 
        */

            decimal money = 20; //total money
            decimal price; //set daily dependent on weather
            int lemons; //25% chance to spoil
            int sugar; //Cups of sugar
            int cups; //Paper cups
            int ice; //Ice cubes. Melt at the end of each day
            int date = 1;
            string gameDays;

        static void Main(string[] args)
        {

            
           

           
            
            
            
       
        }

        public void Start()
        {
            Console.WriteLine("Welcome To Lemonade Stand!");
            Console.WriteLine("How many days would you like to play? (You can play up to 30 days)");
            gameDays = Console.ReadLine();
            int parsedGameDays = int.Parse(gameDays);
            Console.Clear();
        }


        public void NewDay()
        {
            Random random = new Random();
            Console.WriteLine("Day " + date);
            Console.WriteLine("Today's Weather is " + random.Next(15, 35) + " degrees.");
            Console.WriteLine("You have £" + money + ".");
            Console.WriteLine("Price List:");
            Console.WriteLine("Paper Cups: 20 for £1 or 50 for £2");
            Console.WriteLine("Sugar: 8 cups for Sugar for £1");
            Console.ReadLine();
        }
    }
}
