using System;
using ChessBoard.Interfaces;

namespace ChessBoard.Services
{
	public class Parser : IParser
	{
		public int Height { get; set; }
		public int Width { get; set; }

		public Parser(string[] args, IValidator validator)
		{
			Parse(args, validator);
		}

		public void Parse(string[] args, IValidator validator)
		{
			int[] parsedArgs = new int[2];

			if (validator.FormatValidation(args, out string[] validArgs))
			{
				for (int i = 0; i < validArgs.Length; i++)
				{
					parsedArgs[i] = Int32.Parse(validArgs[i]);
				}
			}

			if (validator.SizeValidation(parsedArgs, out int[] validSizeArgs))
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
