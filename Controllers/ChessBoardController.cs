using ChessBoard.Services;
using ChessBoard.Interfaces;
using ChessBoard.View;

namespace ChessBoard.Controllers
{
	public class ChessBoardController : IChessBoardController
	{
		public ChessBoardController(string[] args)
		{
			Initialize(args);
		}

		public void Initialize(string[] args)
		{
			IValidator validator = new Validator();
			IChessBoard chessBoard = new ChessBoardCreator(new Parser(args, validator)).createdChessBoard;
			new ChessBoardViewer().DrawChessBoard(chessBoard);
		}
	}
}
