using ChessBoard.Models;

namespace ChessBoard.Interfaces
{
	public interface IChessBoard
	{
		int Height { get; set; }
		int Width { get; set; }
		ICell this[int rowPosition, int columnPosition] { get; set; }
	}
}
