using System;

namespace YavuzKaanGezgin_MP_Midterm_215040049
{
    class Program
    {
        static void Main(string[] args)
        {
            // State the values of character and enemy
            Character player = new Character("Player", 100, 20);
            Enemy enemy = new Enemy("Zombie", 80, 15);

            Console.WriteLine("Welcome to the Battle Arena!");
            Console.WriteLine("You are the Player, and you have encountered a Zombie.");

            bool gameOver = false;
            while (!gameOver)
            {
                Console.WriteLine("\nWhat do you want to do?");
                Console.WriteLine("1. Attack Zombie");
                Console.WriteLine("2. Check Your Status");
                Console.WriteLine("3. Exit Game");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // player is attacking the enemy
                        player.Attack(enemy);
                        if (enemy.health <= 0)
                        {
                            Console.WriteLine("You defeated the Zombie!");
                            gameOver = true;
                        }
                        else
                        {
                            // enemy attacks player
                            enemy.Attack(player);
                            if (player.health <= 0)
                            {
                                Console.WriteLine("Game Over! The Zombie defeated you.");
                                gameOver = true;
                            }
                        }
                        break;
                    case "2":
                        // checking player status
                        player.Status();
                        break;
                    case "3":
                        // exit game
                        Console.WriteLine("Exiting game...");
                        gameOver = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please enter a valid option.");
                        break;
                }
            }
        }
    }
}