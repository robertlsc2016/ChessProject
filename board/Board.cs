﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject.board
{
    class Board
    {
        public int rows { get; set; }
        public int columns { get; set; }
        private Piece[,] pieces;

        public Board(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;

            pieces = new Piece[rows, columns];
        }
    }
}
