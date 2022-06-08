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
                    this.Fields.Add(new Field(j, i, this));
                }
            }
        }

        public void Randomize()
        {

        }
    }
}
