using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipBoard
{
    public class Board : BoardBase
    {
        public int Size { get; set; }

        private Cell[,] theGrid;

        public Cell[,] TheGrid1 => theGrid;

        private void SetTheGrid1(Cell[,] value)
        {
            theGrid = value;
        }

        public Board(int s)
        {
            Size = s;

            SetTheGrid((new Cell[Size, Size]));
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    TheGrid1[i, j] = new Cell(i, j);

                }
            }
        }
    }
}