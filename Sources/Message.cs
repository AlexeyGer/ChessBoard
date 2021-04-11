using System;
using ChessBoard.Enums;

namespace ChessBoard.Sources
{
	public static class Message
	{
		public static void Instruction()
		{
			Console.WriteLine($"To create new chessboard" +
			$"\nPlease enter height and width of the chessboard as arguments of command line" +
			$"\nThe arguments must be integer values from {(int)BoardSizeLimits.MIN} to {(int)BoardSizeLimits.MAX}");
		}
	}
}
