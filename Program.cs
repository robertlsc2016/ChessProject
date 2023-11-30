using board;
using ChessProject.board;

namespace ChessProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8, 8);
            ScreenBoard.printOutBoard(board);
        }
    }
}