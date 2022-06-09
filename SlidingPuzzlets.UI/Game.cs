using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlidingPuzzlets.UI
{
    public class Game
    {
        public int Time { get; set; }
        public List<Field> Fields { get; set; }
        public Position EmptyField { get; set; }
        public string ImageURL { get; set; }
        public int NumberOfCols { get; set; }

        public Game(string imageURL, int numberOfCols)
        {
            this.Time = 0;
            this.Fields = new List<Field>();
            this.EmptyField = new Position(numberOfCols-1, numberOfCols-1);
            this.ImageURL = imageURL;
            this.NumberOfCols = numberOfCols;

            for (int i = 0; i < this.NumberOfCols; i++)
            {
                for (int j = 0; j < this.NumberOfCols; j++)
                {
                    if (j != this.EmptyField.Col || i != this.EmptyField.Row) this.Fields.Add(new Field(j, i, this));
                }
            }
        }

        public void Randomize()
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                int ranCol = random.Next(0, this.numberOfCols);
                int ranRow = random.Next(0, this.numberOfCols);
                this.MovePieces(new Position(ranCol, ranRow, General.Width/this.numCols));
            }
        }

        public void MovePieces(Position pos)
        {
            List<Field> movingFields = new List<Field>();
            Direction direction;
            if (pos.Col == this.EmptyField.Col)
            {
                if (pos.Row < this.EmptyField.Row)
                {
                    direction = Direction.Down;
                    foreach (var f in this.Fields)
                    {
                        if (f.CurrentPosition.Col == pos.Col && f.CurrentPosition.Row >= pos.Row && f.CurrentPosition.Row < this.EmptyField.Row) movingFields.Add(f);
                    }
                }
                else if (pos.Row > this.EmptyField.Row)
                {
                    direction = Direction.Up;
                    foreach(var f in this.Fields)
                    {
                        if (f.CurrentPosition.Col == pos.Col && f.CurrentPosition.Row <= pos.Row && f.CurrentPosition.Row > this.EmptyField.Row) movingFields.Add(f);
                    }
                }
            } 
            else if (pos.Row == this.EmptyField.Row)
            {
                if (pos.Col < this.EmptyField.Col)
                {
                    direction = Direction.Right;
                    foreach (var f in this.Fields)
                    {
                        if (f.CurrentPosition.Row == pos.Row && f.CurrentPosition.Col >= pos.Col && f.CurrentPosition.Col < this.EmptyField.Col) movingFields.Add(f);
                    }
                }
                else if (pos.Col > this.EmptyField.Col)
                {
                    direction = Direction.Left;
                    foreach (var f in this.Fields)
                    {
                        if (f.CurrentPosition.Row == pos.Row && f.CurrentPosition.Col <= pos.Col && f.CurrentPosition.Col > this.EmptyField.Col) movingFields.Add(f);
                    }
                }
            }

            foreach (var f in movingFields) f.move(direction);
        }
    }
}
