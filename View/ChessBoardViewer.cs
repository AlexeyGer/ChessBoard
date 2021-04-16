using System;
using ChessBoard.Interfaces;

namespace ChessBoard.View
{
	class ChessBoardViewer : IChessBoardViewer
    {
        public void DrawChessBoard(IChessBoard chessboard)
        {
            Console.WriteLine($"{chessboard.Height} x {chessboard.Width} Chessboard \n");
            for (int i = 0; i < chessboard.Height; i++)
            {
                for (int j = 0; j < chessboard.Width; j++)
                {
                    Console.Write((char)chessboard[i, j].Color);
                }
                Console.Write("\n");
            }
        }
    }
}
