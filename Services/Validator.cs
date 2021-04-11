using System;
using ChessBoard.Enums;

namespace ChessBoard.Services
{
	public static class Validator
	{
        public static bool FormatValidation (string[] inputArgs, out string[] validArgs)
        {
            validArgs = new string[2];
    
            for (int i = 0;  i < inputArgs.Length; i++)
            {
                if (Int32.TryParse(inputArgs[i], out _))
                {
                    validArgs[i] = inputArgs[i];
                }
                else
                {
                    throw new Exception();
                }
            }
            return true;
        }

        public static bool SizeValidation(int[] inputArgs, out int[] validSizeArgs)
        {
            validSizeArgs = new int[2];

            for (int i = 0; i < inputArgs.Length; i++)
            {
                if (inputArgs[i] >= (int)BoardSizeLimits.MIN && inputArgs[i] <= (int)BoardSizeLimits.MAX)
                {
                    validSizeArgs[i] = inputArgs[i];
                }
                else
                {
                    throw new Exception();
                }
            }
            return true;
        }
    }
}
