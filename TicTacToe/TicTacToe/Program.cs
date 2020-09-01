using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            StartGame();
        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
            Console.WriteLine("Player 1, what's your name?");
            string name1 = Console.ReadLine();
            Console.WriteLine("Player 2, what's your name?");
            string name2 = Console.ReadLine();

            Player player1 = new Player("X", name1);
            Player player2 = new Player("O", name2);

            Game newGame = new Game(player1, player2);
            Player winPlayer = newGame.Play();
            string winner = winPlayer.Name;
            if (winner != "Cat's Game")
                Console.WriteLine($"{winner} won!");
            else
                Console.WriteLine(winner);
        }
    }
}