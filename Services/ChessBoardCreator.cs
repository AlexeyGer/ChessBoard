using ChessBoard.Models;
using ChessBoard.Enums;
using ChessBoard.Interfaces;


namespace ChessBoard.Services
{
	public class ChessBoardCreator
	{
		public int Height;
		public int Width;

		public ICell[,] cells;

		public ChessBoardCreator(int height, int width)
		{
			this.Height = height;
			this.Width = width;

			this.cells = new ICell[Height, Width];

			for (int i = 0; i < Height; i++)
			{
				for (int j = 0; j < Width; j++)
				{
					bool isWhiteCellPosition = (i % 2 == 0) && (j % 2 == 0) || (i % 2 != 0) && (j % 2 != 0);
					bool isBlackCellPosition = (i % 2 != 0) && (j % 2 == 0) || (i % 2 == 0) && (j % 2 != 0);

					if (isWhiteCellPosition)
					{
						cells[i, j] = new Cell(CellsColors.White);
					}
					/*else*/ if (isBlackCellPosition)
					{
						cells[i, j] = new Cell(CellsColors.Black);
					}
					//else
					//{
					//	throw new Exception("Color of cell has not been defined");
					//}
				}
			}
		}
	}
}
