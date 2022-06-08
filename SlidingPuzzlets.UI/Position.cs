using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlidingPuzzlets.UI
{
    public class Position
    {
        public int Col { get; set; }
        public int Row { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        
        public Position(int col, int row, int pieceSize)
        {
            this.Col = col;
            this.Row = row;
            this.PieceSize = pieceSize;
            this.Update();
        }

        public void Update()
        {
            this.X = this.Col * this.PieceSize;
            this.Y = this.Row * this.PieceSize;
        }
    }
}
