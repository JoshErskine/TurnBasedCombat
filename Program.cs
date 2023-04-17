using System;

namespace TurnBasedCombat
{
    class Program
    {
        static void Main(string[] args)
        {

            int playerHP = 40;
            int enemyHP = 20;

            int playerAttack = 5;
            int enemyAttack = 7;

            int healAmount = 5;

            Random random = new Random();


            while(playerHP > 0 && enemyHP > 0)
            {

                // Players Turn

                Console.WriteLine("-- Player Turn --");
                Console.WriteLine("Player HP - " + playerHP + ". Enemy HP - " + enemyHP);
                Console.WriteLine("Enter 'a' to attack or 'h' to heal");


                string choice = Console.ReadLine();

                if(choice == "a")
                {
                    enemyHP -= playerAttack;
                    Console.WriteLine("Player attacks enemy and deals " + playerAttack + " damage!");
                }
                else
                {
                    playerHP += healAmount;
                    Console.WriteLine("Player restores " + healAmount + " health points!");
                }


                // Enemy Turn
                if (enemyHP > 0)
                {
                    Console.WriteLine("-- Enemy Turn --");
                    Console.WriteLine("Player HP - " + playerHP + ". Enemy HP - " + enemyHP);

                    int enemyChoice = random.Next(0, 2);

                    if(enemyChoice == 0)
                    {
                        playerHP -= enemyAttack;
                        Console.WriteLine("Enemy attacks and deals " + enemyAttack + " damage!");
                    }
                    else
                    {
                        enemyHP += healAmount;
                        Console.WriteLine("Enemy restores " + healAmount + " health points!");
                    }
                }
            }

            if(playerHP > 0)
            {
                Console.WriteLine("Congratulations, you have won!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }

        }
    }
}