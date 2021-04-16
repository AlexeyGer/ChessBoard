namespace ChessBoard.Interfaces
{
	public interface IParser
	{
		int Height { get; set; }
		int Width { get; set; }
		void Parse(string[] args, IValidator validator);
	}
}
