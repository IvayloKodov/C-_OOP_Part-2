using System;
using Problem5.KingGambit.Interfaces;

namespace Problem5.KingGambit
{
    public class King : IAttackable
    {
        private string name;

        public King(string name)
        {
            this.name = name;
        }

        public event EventHandler RespondToTheAttack;


        public void RespondAttack()
        {
            Console.WriteLine($"King {this.name} is under attack!");
            this.Respond();
        }

        private void Respond()
        {
            RespondToTheAttack?.Invoke(this, EventArgs.Empty);
        }
    }
}