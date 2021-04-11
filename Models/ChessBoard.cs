using ChessBoard.Interfaces;

namespace ChessBoard.Models
{
	public class ChessBoard : IChessBoard
	{
		ICell[,] cell;
		public int Height { get; set; }
		public int Width { get; set; }

		public ChessBoard (ICell[,] cell, int height, int width)
		{
			this.cell = cell;
			Height = height;
			Width = width;
		}

		public ICell this[int rowPosition, int columnPosition]
		{
			get
			{
				return cell[rowPosition, columnPosition];
			}
			set
			{
				cell[rowPosition, columnPosition] = value;
			}
		}

	}
}
