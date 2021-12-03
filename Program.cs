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

            decimal money = 25; //total money
            decimal price; //set daily dependent on weather
            int lemons; //25% chance to spoil
            int sugar; //Cups of sugar
            int cups; //Paper cups
            int ice; //Ice cubes. Melt at the end of each day
            int date = 1;
            int maxPitchers;
            int weather;
            string gameDays;
            string deductLemons;
            string deductSugar;
            string deductCups;
            string deductIce;
            string cubesPerCup;
            


        static void Main()

        {
            var p = new Program();
            p.Start();
            
            p.NewDay();

            p.BuySupplies();

            p.ListSupplies();

            p.RunDay();

            Console.ReadLine();

        }

        public void Start()
        {
            //Starts the game, prompting the user to select how many days they would like to play for
           
            Console.WriteLine("Welcome To Lemonade Stand!");
            Console.WriteLine("How many days would you like to play? (You can play between 7 and 30 days)");
            gameDays = Console.ReadLine();
            int parsedGameDays;
            int.TryParse(gameDays, out parsedGameDays);     
            
            while (parsedGameDays > 30 || parsedGameDays <7 || !int.TryParse(gameDays, out parsedGameDays))
            {
            Console.WriteLine("Invalid Number, please enter a number between 7 and 35");
            gameDays = Console.ReadLine();
            int.TryParse(gameDays, out parsedGameDays);
            }

            Console.Clear();
            
        }


        public void NewDay()
        {
            //Each day will be assigned a random temperature, and will ask the user to buy supplies. Will need to be nested in a loop for each day.
           
            Random r = new Random();
            weather = r.Next(15, 32);
            int thirst = weather - 15;

            Console.WriteLine("Day " + date);
            Console.WriteLine("Today's Weather is " + weather + " degrees.");
            Console.WriteLine("You have £" + money + ".");
            Console.WriteLine();
            Console.WriteLine("Price List:");
            Console.WriteLine("Lemons: 10 for £1 ");
            Console.WriteLine("Paper Cups: 20 for £1");
            Console.WriteLine("Sugar: 8 cups for Sugar for £1");
            Console.WriteLine("Ice: 100 cubes for £1");
            Console.WriteLine();        

        }

        public void BuySupplies()
        {
            //need to change all to TryParse to better handle exceptions
            

            Console.WriteLine("How many pounds would you like to spend on lemons?");
            deductLemons = Console.ReadLine();
            int parsedDeductLemons = int.Parse(deductLemons);

            while (parsedDeductLemons > money)
            {
                Console.WriteLine("You only have £" + money + ", please try again.");
                Console.WriteLine();
                Console.WriteLine("How many pounds would you like to spend on lemons?");
                deductLemons = Console.ReadLine();
                parsedDeductLemons = int.Parse(deductLemons);
            }

            money = money - parsedDeductLemons;
            lemons = parsedDeductLemons * 10;
            Console.WriteLine("You have £" + money + " remaining");
            Console.WriteLine();






            Console.WriteLine("How many pounds would you like to spend on sugar?");
            deductSugar = Console.ReadLine();
            int parsedDeductSugar = int.Parse(deductSugar);
            
            while (parsedDeductSugar > money)
            { 
                Console.WriteLine("You only have £" + money + ", please try again.");
                Console.WriteLine();
                Console.WriteLine("How many pounds would you like to spend on sugar?");
                deductSugar = Console.ReadLine();
                parsedDeductSugar = int.Parse(deductSugar);
            }
            
            money = money - parsedDeductSugar;
            sugar = parsedDeductSugar * 8;
            Console.WriteLine("You have £" + money + " remaining");
            Console.WriteLine();

            
            
            
            Console.WriteLine("How many pounds would you like to spend on paper cups?");
            deductCups = Console.ReadLine();
            int parsedDeductCups = int.Parse(deductCups);

            while (parsedDeductCups > money)
            {
                Console.WriteLine("You only have £" + money + ", please try again.");
                Console.WriteLine();
                Console.WriteLine("How many pounds would you like to spend on paper cups?");
                deductCups = Console.ReadLine();
                parsedDeductCups = int.Parse(deductCups);
            }

            money = money - parsedDeductCups;
            cups = parsedDeductCups * 20;
            Console.WriteLine("You have £" + money + " remaining");
            Console.WriteLine();





            Console.WriteLine("How many pounds would you like to spend on Ice?");
            deductIce = Console.ReadLine();
            int parsedDeductIce = int.Parse(deductIce);

            while (parsedDeductIce > money)
            {
                Console.WriteLine("You only have £" + money + ", please try again.");
                Console.WriteLine();
                Console.WriteLine("How many pounds would you like to spend on Ice?");
                deductIce = Console.ReadLine();
                parsedDeductIce = int.Parse(deductIce);
            }

            money = money - parsedDeductIce;
            ice = parsedDeductIce * 100;
            Console.WriteLine("You have £" + money + " remaining");
            Console.WriteLine();

        }

        public void ListSupplies()
        {
            Console.Clear();
            Console.WriteLine("Today's Weather is " + weather + " degrees.");
            Console.WriteLine("You have " + lemons + " lemons.");
            Console.WriteLine("You have " + sugar + " cups of sugar.");
            Console.WriteLine("You have " + cups + " paper cups.");
            Console.WriteLine("You have " + ice + " ice cubes.");
            Console.WriteLine("You have £" + money + ".");

        }

        public void RunDay()
        {
            //This will simulate one day
            if (lemons < 4)
            {
                Console.WriteLine("You don't have enough lemons to make a pitcher");
                lemons = lemons + 4;
            }
            if (sugar < 4)
            {
                Console.WriteLine("You don't have enough sugar to make a pitcher");
                sugar = sugar + 4;
            }

            while (lemons >= 4 && sugar >= 4)
            {
                lemons = lemons - 4;
                sugar = sugar - 4;
                maxPitchers++;
            }
            
            Console.WriteLine("How many ice cubes would you like to put in each cup?");
            cubesPerCup = Console.ReadLine();
            int parsedCubesPerCup;

            int.TryParse(cubesPerCup, out parsedCubesPerCup);
            while (!int.TryParse(cubesPerCup, out parsedCubesPerCup) || parsedCubesPerCup < 1 || parsedCubesPerCup > 4)
            {
                Console.WriteLine("Invalid Number, please enter a number between 1 and 4");
                cubesPerCup = Console.ReadLine();
                int.TryParse(cubesPerCup, out parsedCubesPerCup);
            }
        }


    }
}
