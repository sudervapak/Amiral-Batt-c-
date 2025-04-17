using BattleShipBoard;
using System;
namespace BattleShipBoard
{
    class Program
    {
        static Board myBoard = new Board(8);
        private static readonly Cell? theGrid;

        static void Main(string[] args)
        {
            printBoard(myBoard, GetC());


            Console.ReadLine();

        }

        private static Cell GetC()
        {
            return theGrid;
        }

        private static void printBoard(Board myBoard, Cell c)
        {
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    Cell[,] theGrid = myBoard.TheGrid1;
                }
                Console.WriteLine();
            }
            Console.WriteLine("=================");
        }

    }
}
