namespace ChessBoard.Interfaces
{
	public interface IValidator
	{
		bool FormatValidation(string[] inputArgs, out string[] validArgs);
		bool SizeValidation(int[] inputArgs, out int[] validSizeArgs);
	}
}
