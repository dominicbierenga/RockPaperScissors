using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class GameLogic
    {
        private int[] scores = new int[] { 0, 0 };
        private string[] choices = new string[] { "rock", "paper", "scissors" };
        private Random rnd = new Random();

        public string GetUserIn()
        {
            Console.WriteLine("Rock, paper, or scissors?");
            return Console.ReadLine().ToLower();
        }

        public string GetCompChoice()
        {
            return choices[rnd.Next(3)];
        }

        public void ResOutput(string compChoice, char result)
        {
            switch (result)
            {
                case 'u':
                    scores[0]++;
                    Console.WriteLine("The computer chose {0}. You win! User: {1}, Computer: {2}.\n", compChoice, scores[0], scores[1]);
                    break;
                case 'c':
                    scores[1]++;
                    Console.WriteLine("The computer chose {0}. You lose! User: {1}, Computer: {2}.\n", compChoice, scores[0], scores[1]);
                    break;
                case 'd':
                    Console.WriteLine("The computer also chose {0}. It's a draw! User: {1}, Computer: {2}.\n", compChoice, scores[0], scores[1]);
                    break;
                default:
                    break;
            }
        }

        public char Play(string userChoice, string compChoice)
        {
            if (userChoice == compChoice)
            {
                return 'd';
            }

            else if (userChoice == "rock")
            {
                if (compChoice == "paper")
                {
                    return 'c';
                }
                else if (compChoice == "scissors")
                {
                    return 'u';
                }
            }

            else if (userChoice == "paper")
            {
                if (compChoice == "rock")
                {
                    return 'u';
                }
                else if (compChoice == "scissors")
                {
                    return 'c';
                }
            }

            else if (userChoice == "scissors")
            {
                if (compChoice == "rock")
                {
                    return 'c';
                }
                else if (compChoice == "paper")
                {
                    return 'u';
                }
            }
            return 'x';
        }
    }
}
