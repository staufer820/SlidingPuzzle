using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlidingPuzzlets.UI
{
    public enum Direction
    {
        UP, Left, Down, Right
    }

    public class Piece
    {
        public Position CurrentPosition { get; set; }
        public Position CorrectPosition { get; set; }
        public Game Game { get; set; }

        public Piece(int col, int row, Game game)
        {
            this.CurrentPosition = new Position(col, row);
            this.CorrectPosition = new Position(col, row);
            this.Game = game;
        }

        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    this.Position.Row++;
                    break;

                case Direction.Left:
                    this.Position.Col++;
                    break;

                case Direction.Down:
                    this.Position.Row--;
                    break;

                case Direction.Right:
                    this.Position.Col--;
                    break;
            }

            this.CurrentPosition.Update();
        }
    }
}
