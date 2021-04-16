using ChessBoard.Services;
using ChessBoard.Interfaces;
using ChessBoard.View;

namespace ChessBoard.Controllers
{
	public class ChessBoardController
	{
		public ChessBoardController(string[] args)
		{
			IChessBoard chessBoard = new ChessBoardCreator(new Parser(args)).createdChessBoard;
			new ChessBoardViewer().DrawChessBoard(chessBoard);
		}
	}
}
