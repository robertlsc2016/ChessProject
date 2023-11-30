using ChessProject.board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject
{
    class ScreenBoard
    {
        public static void printOutBoard(Board board)
        {
            for (int row = 0; row < board.rows; row++)
            {
                for (int column = 0; column < board.columns; column++)
                {
                    if (board.positionPiece(row, column) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(board.positionPiece(row, column) + "");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
