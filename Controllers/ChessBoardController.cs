using ChessBoard.Services;
using ChessBoard.Interfaces;
using ChessBoard.View;



namespace ChessBoard.Controllers
{
	public class ChessBoardController
	{
		public ChessBoardController(string[] args)
		{
			Parser parser = new Parser(args);
			ChessBoardCreator newChessBoard = new ChessBoardCreator(parser.Height, parser.Width);
			IChessBoard chessBoard = new Models.ChessBoard(newChessBoard.cells, newChessBoard.Height, newChessBoard.Width);
			IChessBoardViewer viewer = new ChessBoardViewer();
			viewer.DrawChessBoard(chessBoard);
		}
	}
}
