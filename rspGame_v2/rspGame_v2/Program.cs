using System;

namespace rspGame_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            string player, ai;
            int randomInt;
            bool playAgain = true;

            while (playAgain)
            {
                int scoreAi = 0;
                int scorePlayer = 0;

                while (scorePlayer < 3 && scoreAi < 3)
                {
                    Console.Write("Choose between Rock, Scissors and Paper.");
                    player = Console.ReadLine();
                    player = player.ToUpper();

                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            ai = "ROCK";
                            Console.WriteLine("AI chooses Rock!");
                            if (player == "ROCK")
                            {
                                Console.WriteLine("Draw!!\n\n");
                            }
                            else if (player == "PAPER")
                            {
                                Console.WriteLine("Player wins");
                                scorePlayer++;
                            }
                            else if (player == "SCISSORS")
                            {
                                Console.WriteLine("AI wins");
                                scoreAi++;
                            }
                            
                            break;

                        case 2:
                            ai = "SCISSORS";
                            Console.WriteLine("AI chooses Rock!");
                            if (player == "SCISSORS")
                            {
                                Console.WriteLine("Draw");
                            }
                            else if (player == "ROCK")
                            {
                                Console.WriteLine("Player wins");
                                scorePlayer++;
                            }
                            else if (player == "PAPER")
                            {
                                Console.WriteLine("AI wins");
                                scoreAi++;
                            }
                            
                            break;

                        case 3:
                            ai = "PAPER";
                            if (player == "PAPER")
                            {
                                Console.WriteLine("Draw");
                            }
                            else if (player == "SCISSORS")
                            {
                                Console.WriteLine("Player wins");
                                scorePlayer++;
                            }
                            else if (player == "ROCK")
                            {
                                Console.WriteLine("AI wins");
                                scoreAi++;
                            }
                            
                            break;

                        default:
                            Console.WriteLine("Invalid Entry!");
                            break;

                    }
                    Console.WriteLine("Score : Player : " + scorePlayer + "  AI : " + scoreAi);
                }
                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player won!!");
                }
                else if (scoreAi == 3)
                {
                    Console.WriteLine("AI won!!");
                }
                else
                {

                }
                Console.WriteLine("Do you want to play again? (y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                {

                }
            }
        }
    }
}
