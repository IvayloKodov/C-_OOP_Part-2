using System;

namespace Problem5.KingGambit.Soldiers
{
    public abstract class Soldier
    {
        protected string name;
        protected int lives;

        protected Soldier(string name)
        {
            this.name = name;
        }

        public event EventHandler Died;

        public string Name
        {
            get { return name; }
        }

        public void Attacked()
        {
            if (--this.lives == 0)
            {
                Died?.Invoke(this, EventArgs.Empty);
            }
        }

        public abstract void SoldierReplique(object sender, EventArgs e);
    }
}