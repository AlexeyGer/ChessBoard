using ChessBoard.Interfaces;
using ChessBoard.Enums;

namespace ChessBoard.Models
{
	public class Cell : ICell
	{
		public CellsColors Color { get; set; }

		public Cell(CellsColors color)
		{
			Color = color;
		}
	}
}
