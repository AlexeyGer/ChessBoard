using System;
using ChessBoard.Controllers;
using ChessBoard.Sources;

namespace ChessBoard
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				new ChessBoardController(args);
			}
			catch (Exception e)
			{
				Message.Instruction();
				//Console.WriteLine("\n" + e);
			}
			Console.ReadKey();
		}
	}
}
