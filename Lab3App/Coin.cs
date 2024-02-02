using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Coin : Treasure
    {
        public int Value;

        public Coin(string description, int score, int value) : base(description, score)
        {
            this.Value = value;
        }

        public void UpdateTotalValue()
        {
            this.Board.TotalValue += this.Value;
            Console.WriteLine("Total Value is update to: " + this.Board.TotalValue);
        }

        public override void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine(Description + " Collected, Congrats!!!!");
            UpdateTotalScore();
            UpdateTotalValue();
        }

        public override void Display()
        {
            Console.WriteLine(GetType().Name + " " + Description + " is displayed.");
        }
    }
}
