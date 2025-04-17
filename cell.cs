namespace BattleShipBoard
{
    class Cell
    {
        public Cell(int i, int j)
        {
            İ = i;
            J = j;
        }

        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
        public int İ { get; }
        public int J { get; }
    }
}
