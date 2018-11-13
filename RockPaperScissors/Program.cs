using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            GameLogic game = new GameLogic();

            Console.WriteLine("Welcome to Rock, Paper, Scissors in C#! Enter 'q' at any time to quit.");
            string userChoice = "";
            while (userChoice != "q")
            {
                string compChoice = game.GetCompChoice();
                userChoice = game.GetUserIn();

                game.ResOutput(compChoice, game.Play(userChoice, compChoice));
            }
        }
    }
}
