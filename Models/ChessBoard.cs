using ChessBoard.Interfaces;

namespace ChessBoard.Models
{
	public class ChessBoard : IChessBoard
	{
		ICell[,] cells;
		public int Height { get; set; }
		public int Width { get; set; }

		public ChessBoard (ICell[,] cells, int height, int width)
		{
			this.cells = cells;
			Height = height;
			Width = width;
		}

		public ICell this[int rowPosition, int columnPosition]
		{
			get
			{
				return cells[rowPosition, columnPosition];
			}
			set
			{
				cells[rowPosition, columnPosition] = value;
			}
		}
	}
}
