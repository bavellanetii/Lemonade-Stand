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
         * Simplified program to get on with other projects. Main objective in making the program was to practice the basics that I'd learned from various tutorials and see if I could create something on my own without any help or direction,
         * which has been a success. I could flesh the game out to be a bit more detailed and random, but it would require more of the same and I want to challenge myself in new ways. 
        */

            decimal money = 25; //total money
            decimal cupsSold;
            int lemons; //25% chance to spoil
            int sugar; //Cups of sugar
            int cups; //Paper cups
            int ice; //Ice cubes. Melt at the end of each day
            int date = 1;
            int maxPitchers;
            int weather;
            int customers;
            int thirst;
            int parsedGameDays;
            string gameDays;
            string deductLemons;
            string deductSugar;
            string deductCups;
            string deductIce;
    



        static void Main()

        {
            var p = new Program();
            p.Start();

            while (p.parsedGameDays > p.date)

            {
                p.NewDay();

                p.ListSupplies();

                p.BuySupplies();

                p.ListSupplies();

                p.RunDay();

                p.date++;

                if (p.date % 2 == 1)
                {
                    p.lemons = 0;
                    Console.WriteLine("Your lemons have spoiled.");
                }

            }

            Console.Clear();
            if (p.money > 25)
            {
                Console.WriteLine("Game over!");
                Console.WriteLine("You ended the game with £" + p.money + ", making a profit of £" + (p.money - 25) + "!");
            }
            if (p.money < 25)
            {
                Console.WriteLine("Game Over!");
                Console.WriteLine("You ended the game with £" + p.money + ", making a loss of £" + (25 - p.money) + "!");
            }
            Console.ReadLine();
        }

        public void Start()
        {
            //Starts the game, prompting the user to select how many days they would like to play for
           
            Console.WriteLine("Welcome To Lemonade Stand!");
            Console.WriteLine();
            Console.WriteLine("The aim of the game is to try and make money selling lemonade!");
            Console.WriteLine("You start off with £25, and are given the weather at the start of each day and asked to buy supplies.");
            Console.WriteLine("It takes 4 lemons and 4 cups of sugar to fill a pitcher, will make 15 cups of lemonade.");
            Console.WriteLine("You will also need 10 ice cubes per pitcher, which melt at the end of each day. Your lemons will spoil every other day.");
            Console.WriteLine();
            Console.WriteLine("How many days would you like to play? (You can play between 7 and 30 days)");
            gameDays = Console.ReadLine();
            
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
            thirst = weather - 14;

            Console.Clear();
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

            Console.WriteLine();
            Console.WriteLine("How many pounds would you like to spend on lemons?");
            deductLemons = Console.ReadLine();
            int parsedDeductLemons;
            
            int.TryParse(deductLemons, out parsedDeductLemons);

            while (parsedDeductLemons > money || !int.TryParse(deductLemons, out parsedDeductLemons))
            {
                Console.WriteLine("Incorrect input or you're trying to spend more than you have. Please try again :)");
                deductLemons = Console.ReadLine();
                int.TryParse(deductLemons, out parsedDeductLemons);
            }


            money = money - parsedDeductLemons;
            lemons = parsedDeductLemons * 10;
            Console.WriteLine("You have £" + money + " remaining");
            Console.WriteLine();






            Console.WriteLine("How many pounds would you like to spend on sugar?");
            deductSugar = Console.ReadLine();
            int parsedDeductSugar;

            int.TryParse(deductSugar, out parsedDeductSugar);

            while (parsedDeductSugar > money || !int.TryParse(deductSugar, out parsedDeductSugar))
            {
                Console.WriteLine("Incorrect input or you're trying to spend more than you have. Please try again :)");
                deductSugar = Console.ReadLine();
                int.TryParse(deductSugar, out parsedDeductSugar);
            }


            money = money - parsedDeductSugar;
            sugar = parsedDeductSugar * 8;
            Console.WriteLine("You have £" + money + " remaining");
            Console.WriteLine();

            
            
            
            Console.WriteLine("How many pounds would you like to spend on paper cups?");
            deductCups = Console.ReadLine();
            int parsedDeductCups;

            int.TryParse(deductCups, out parsedDeductCups);

            while (parsedDeductCups > money || !int.TryParse(deductCups, out parsedDeductCups))
            {
                Console.WriteLine("Incorrect input or you're trying to spend more than you have. Please try again :)");
                deductCups = Console.ReadLine();
                int.TryParse(deductCups, out parsedDeductCups);
            }


            money = money - parsedDeductCups;
            cups = parsedDeductCups * 20;
            Console.WriteLine("You have £" + money + " remaining");
            Console.WriteLine();





            Console.WriteLine("How many pounds would you like to spend on Ice?");
            deductIce = Console.ReadLine();
            int parsedDeductIce;

            int.TryParse(deductIce, out parsedDeductIce);

            while (parsedDeductIce > money || !int.TryParse(deductIce, out parsedDeductIce))
            {
                Console.WriteLine("Incorrect input or you're trying to spend more than you have. Please try again :)");
                deductIce = Console.ReadLine();
                int.TryParse(deductIce, out parsedDeductIce);
            }


            money = money - parsedDeductIce;
            ice = parsedDeductIce * 100;
            Console.WriteLine("You have £" + money + " remaining");
            Console.WriteLine();
            Console.Clear();
        }

        public void ListSupplies()
        {
            //does what it says           
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
                Console.WriteLine("You don't have enough lemons to make a pitcher. Your parents have give you some this time.");
                lemons = lemons + 4;
            }
            if (sugar < 4)
            {
                Console.WriteLine("You don't have enough sugar to make a pitcher. Your parents have give you some this time.");
                sugar = sugar + 4;
            }
            if (ice < 10)
            {
                Console.WriteLine("You don't have enough ice to make a pitcher. Your parents have give you some this time.");
                ice = ice + 4;
            }


            while (lemons >= 4 && sugar >= 4 && ice >= 10)
            {
                lemons = lemons - 4;
                sugar = sugar - 4;
                ice = ice - 10;
                maxPitchers++;
            }
            
            
  
            customers = thirst * 11;

            if (customers > cups)
            {
                cupsSold = cups;
            }

            if (cups > customers)
            {
                cupsSold = customers;
            }
            
            cups = customers - cups;
            if (cups < 0)
            {
                cups = 0;
            }

            money = money + (cupsSold / 2);

            ice = 0;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("You've sold " + cupsSold + " cups of lemonade!");
            Console.WriteLine("You have £" + money + ".");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue to the next day");
            Console.ReadLine();

        }


    }
}
