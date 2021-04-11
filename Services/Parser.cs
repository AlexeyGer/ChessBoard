using System;

namespace ChessBoard.Services
{
	public class Parser
	{
		public int Height;
		public int Width;
		//string[] parseArgs;
		//int[] parsedArgs;
		//height = -1;
		//width = -1;

		public Parser(string[] args/*, out int height, out int width*/)
		{
			string[] parseArgs = args;
			int[] parsedArgs = new int[2];

			//height = -1;
			//width = -1;

			if (Validator.FormatValidation(parseArgs, out string[] validArgs))
			{
				for (int i = 0; i < validArgs.Length; i++)
				{
					parsedArgs[i] = Int32.Parse(validArgs[i]);
				}
			}

			if (Validator.SizeValidation(parsedArgs, out int[] validSizeArgs))
			{
				for (int i = 0; i < validArgs.Length; i++)
				{
					Height = validSizeArgs[0];
					Width = validSizeArgs[1];
				}
			}
		}
	}
}
