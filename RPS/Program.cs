using System;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)


        {

            int pl1 = 0;
            int pl2 = 0;

            Console.WriteLine("Welcome to Rock Paper Scissor Game");

            for (int round = 1; round <= 100; round++)
            {
                string player1 = "ROCK";
                Console.WriteLine("Player 1 choice: " + player1);

                string[] choices = new string[3] { "ROCK", "PAPER", "SCISSOR" };
                Random rnd = new Random();
                int n = rnd.Next(0, 3);


                Console.WriteLine("Player 2 choice: " + choices[n]);
                Console.ReadLine();


                switch (choices[n])
                {
                    case "SCISSOR":
                        Console.WriteLine("Player1 wins");
                        pl1 += 1;
                        break;

                    case "PAPER":
                        Console.WriteLine("Player2 wins");
                        pl2 += 1;
                        break;
                    case "ROCK":
                        Console.WriteLine("Same choices");
                        break;



                }


                Console.WriteLine("You just finished the " + round + "round of the game");
                Console.WriteLine("**************************************************");
                Console.ReadLine();
            }
            Console.WriteLine("Player1 wins " + pl1 + " times");
            Console.ReadLine();
            Console.WriteLine("Player2 wins " + pl2 + " times");
            Console.ReadLine();
            if (pl1 > pl2)
            {
                Console.WriteLine("The winner is player1");
                Console.ReadLine();

            }
            else if (pl1 < pl2)
            {
                Console.WriteLine("The winner is player2");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Both players have scored same points");
                Console.ReadLine();
            }

            Console.WriteLine("Thank you for playing Rock Paper Scissor");
            Console.ReadLine();
        }
    }
}