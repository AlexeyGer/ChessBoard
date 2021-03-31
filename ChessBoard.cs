using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoard
{
    class ChessBoard
    {
        int height;
        int width;
        string[,] board;

        public ChessBoard()
        {
            GetBoardSize();
            new ChessBoard(height, width);
        }

        public ChessBoard(int h, int w)
        {
            height = h;
            width = w;

            MakeChessBoard();
            DrawChessBoard();
        }

        void GetBoardSize()
        {
            string inputHeight;
            string inputWidth;
            do
            {
                Console.WriteLine("\nTo create new chessboard \nPlease enter the height of the chessboard");
                inputHeight = Console.ReadLine();
            }
            while (BoardSizeValidation(inputHeight) == 0);
            height = BoardSizeValidation(inputHeight);

            do
            {
                Console.WriteLine("\nPlease enter the width of the chessboard");
                inputWidth = Console.ReadLine();
            }
            while (BoardSizeValidation(inputWidth) == 0);
            width = BoardSizeValidation(inputWidth);
        }

        int BoardSizeValidation(string input)
        {
            const int MIN_SIZE = 2;
            const int MAX_SIZE = 10;

            if (Int32.TryParse(input, out int h))
            {
                if (h >= MIN_SIZE && h <= MAX_SIZE)
                {
                    return h;
                }
                else
                {
                    Console.WriteLine($"\nThe value must be in the range {MIN_SIZE} - {MAX_SIZE}");
                }
            }
            else
            {
                Console.WriteLine($"\nThe value must be a positive integer");
            }
            return 0;
        }

        void MakeChessBoard()
        {
            board = new string[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    bool isWhiteCellPosition = (i % 2 == 0) && (j % 2 == 0) || (i % 2 != 0) && (j % 2 != 0);

                    if (isWhiteCellPosition)
                    {
                        board[i, j] = " ";
                    }
                    else
                    {
                        board[i, j] = "*";
                    }
                }
            }
        }

        void DrawChessBoard()
        {
            Console.WriteLine($"\n{height} x {width} Chessboard \n");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("{0}", board[i, j]);
                }
                Console.Write("\n");
            }
        }
    }
}
