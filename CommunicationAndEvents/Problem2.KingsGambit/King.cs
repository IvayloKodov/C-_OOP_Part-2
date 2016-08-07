using System;

namespace Problem2.KingsGambit
{
    public delegate void AttackedEventHandler(object sender, EventArgs args);

    public class King
    {
        public string Name { get; private set; }
        public event AttackedEventHandler kingAttacked;
    
        public King(string name)
        {
            this.Name = name;
        }

        public void SomeoneAttackKing()
        {
            Console.WriteLine($"King {this.Name} is under attack!");
            kingAttacked(this.Name, EventArgs.Empty );
        }
    }
}