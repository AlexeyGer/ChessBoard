namespace ChessBoard.Interfaces
{
	public interface IChessBoardCreator
	{
		IChessBoard Create(IParser parser);
	}
}
