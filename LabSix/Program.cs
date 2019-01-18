using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSix
{
    class Program
    {
        static void Main(string[] args)
        {
           Dice();
        }

        public static void Dice()
        {
            //Greets user for dice app
            Console.WriteLine("Welcome to the Grand Circus Casino!");
            int i = 0;
            bool run = true;
            while (run == true)
            {
                //Ask use if they would like to roll the dice
                Console.WriteLine("Roll the dice? (y/n)");
                string userRoll = Console.ReadLine().ToLower();
                //Valdiation is used. Program will only run or exit when y or n is selected
                if (userRoll == "y")
                {
                    //Request how many sided dice the user would like to roll with
                    Console.WriteLine("Enter the number of sides on the pair dice you would like:");
                    int sides = int.Parse(Console.ReadLine());

                    //Generates random number with roll based on number of sides chosen
                    Random num = new Random();
                    sides = num.Next(1, sides + 1);
                    int roll = sides;
                    sides = num.Next(1, sides + 1);
                    int roll2 = sides;
                    i = i + 1;
                    //Displays the results of the roll of both dice
                    Console.WriteLine("Roll " + i + ":" + "\t" + roll);
                    Console.WriteLine("Roll " + i + ":" + "\t" + roll2);

                    if(roll == 1 && roll2 == 1)
                    {
                        Console.WriteLine("Snake Eyes");
                    }
                    if(roll == 6 && roll2 == 6)
                    {
                        Console.WriteLine("Box Cars");
                    }
                }
                else if (userRoll == "n")
                {
                    break;
                }
            }
        }
    }
}
