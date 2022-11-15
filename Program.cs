// Tic Tac Toe

using System;
using System.Runtime.CompilerServices;
using static System.Console;

namespace Lab09
{
    public class Program
    {
        static void Main(string[] args)
        {
            const int MAX_TURNS = 9;

            WriteLine("\n----------------------------------");
            WriteLine("Welcome to tic-tac-toe");
            WriteLine("----------------------------------");
            WriteLine("Players will take turns choosing an unoccupied cell.");
            WriteLine("The first player to get 3 in a row (or column or diagonal) wins!\n");

            char[] board = new char[9] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i' };
            // will hold the winning player when there is one
            int winner = 0;

            for (int turn = 0; turn < MAX_TURNS; turn++)
            {
                // player X on even turns, player O on odd turns
                char currentPlayer = turn % 2 == 0 ? 'X' : 'O';
                WriteLine($"currentPlayer={currentPlayer}; turn={turn}");
                WriteLine("Current Board: ");
                DisplayBoard(board);
                board = MakeMove(currentPlayer, board);
                if (HasWinner(board))
                {
                    winner = currentPlayer;
                    break;
                }
            }
            DisplayBoard(board);

            // print the game outcome
            if (winner == 'X')
            {
                WriteLine("\n/----------------\\");
                WriteLine($"|     X wins!    |");
                WriteLine("\\----------------/");
            }
            else if (winner == 'O')
            {
                WriteLine("\n/----------------\\");
                WriteLine($"|     O wins!    |");
                WriteLine("\\----------------/");
            }
            else
            {
                WriteLine("Looks like a draw");
            }
        }

        // TODO: write the functions used in main (and any other helper functions you want to use)

        public static void DisplayBoard(char[] board)
        {
            //char[] board = new char[9] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i' };

            WriteLine(@" {0} | {1} | {2}", board[0], board[1], board[2]);
            WriteLine(" ---+---+---");
            WriteLine(@" {0} | {1} | {2}", board[3], board[4], board[5]);
            WriteLine(" ---+---+---");
            WriteLine(@" {0} | {1} | {2}", board[6], board[7], board[8]);
        }

        /**
         * displays the tic-tac-toe board
         * given the contents of the named cells
         *  a | b | c
         * ---+---+---
         *  d | e | f
         * ---+---+--
         *  g | h | i
         */

        public static char GetMove(string prompt)
        {
            WriteLine(prompt);

            while (true)
            {
                try
                {
                    char cell = Convert.ToChar(ReadLine());
                    if (cell >= 'a' && cell <= 'i')
                    {
                        return cell;

                    }
                }
                catch
                {
                }
                WriteLine("Not a valid input. Try again.");
            }


        }
        /* given a string to prompt the user for input, get a cell.
         * verify the cell is a valid cell defined in the board.  
         * numbers and words are not valid cells.
         * return the valid cell.
        */


        public static bool HasWinner(char[] board)
        {
            return (CellsAreTheSame(board[0], board[1], board[2])) || 
            (CellsAreTheSame(board[3], board[4], board[5])) || 
            (CellsAreTheSame(board[6], board[7], board[8])) || 
            (CellsAreTheSame(board[0], board[3], board[6])) || 
            (CellsAreTheSame(board[1], board[4], board[7])) || 
            (CellsAreTheSame(board[2], board[5], board[8])) || 
            (CellsAreTheSame(board[6], board[4], board[2])) || 
            (CellsAreTheSame(board[0], board[4], board[8]));
        
        }
        /**
         * given the board,
         * returns true if the board has a winner
         */
        

        public static bool CellsAreTheSame(char a, char b, char c)
        {
            return a == b && b == c;
            

        }
        /**
         *  returns true if a, b, and c are all the same
         */

        public static char[] MakeMove(char currentPlayer, char[] board)

        {
            int choice = 0;
            do
            {
                char cell = GetMove($"{currentPlayer} choose a cell");
                choice = cell - 'a';

                if (board[choice] == 'X' || board[choice] == 'O')
                {
                    WriteLine("Cell is already taken. Choose another cell");
                }
                else
                {
                    board[choice] = currentPlayer;
                    break;
                }

            } while (true);
            return board;


        }
      


    }
}
