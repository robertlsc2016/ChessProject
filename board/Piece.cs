using board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject.board
{
    class Piece
    {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int amountOfMovements { get; protected set; }
        public Board board { get; protected set; }

        public Piece(Position position, Board board, Color color)
        {
            this.position = position;
            this.board = board;
            this.color = color;
            this.amountOfMovements = 0;
        }
    }
}
