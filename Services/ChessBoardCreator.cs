using ChessBoard.Models;
using ChessBoard.Enums;
using ChessBoard.Interfaces;

namespace ChessBoard.Services
{
	public class ChessBoardCreator : IChessBoardCreator
	{
		public IChessBoard createdChessBoard;
		public ChessBoardCreator(IParser parser)
		{
			createdChessBoard = Create(parser);
		}

		public IChessBoard Create(IParser parser)
		{
			int Height = parser.Height;
			int Width = parser.Width;

			ICell[,] cells = new ICell[Height, Width];

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
					if (isBlackCellPosition)
					{
						cells[i, j] = new Cell(CellsColors.Black);
					}
				}
			}

			return new Models.ChessBoard(cells, Height, Width);
		}

		//public ChessBoardCreator(int height, int width)
		//{
		//	this.Height = height;
		//	this.Width = width;

		//	this.cells = new ICell[Height, Width];

		//	for (int i = 0; i < Height; i++)
		//	{
		//		for (int j = 0; j < Width; j++)
		//		{
		//			bool isWhiteCellPosition = (i % 2 == 0) && (j % 2 == 0) || (i % 2 != 0) && (j % 2 != 0);
		//			bool isBlackCellPosition = (i % 2 != 0) && (j % 2 == 0) || (i % 2 == 0) && (j % 2 != 0);

		//			if (isWhiteCellPosition)
		//			{
		//				cells[i, j] = new Cell(CellsColors.White);
		//			}
		//			if (isBlackCellPosition)
		//			{
		//				cells[i, j] = new Cell(CellsColors.Black);
		//			}
		//			//else
		//			//{
		//			//	throw new Exception("Color of cell has not been defined");
		//			//}
		//		}
		//	}
		//}
	}
}
