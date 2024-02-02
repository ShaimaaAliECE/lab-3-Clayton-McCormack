using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract class Treasure : Collectable
    {
        public int Score;

        public Treasure(string description, int score) : base(description)
        {
            this.Score = score;
        }
 
        public void UpdateTotalScore()
        {
            this.Board.TotalScore += this.Score;
            Console.WriteLine("Total Score is update to: " + this.Board.TotalScore);
        }

        public override void AddMe(List<Collectable> collectable)
        {
            base.AddMe(collectable);
            UpdateTotalScore();
        }
    }
}
