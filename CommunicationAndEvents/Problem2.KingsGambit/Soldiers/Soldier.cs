using System.Collections.Generic;

namespace Problem2.KingsGambit
{
    public abstract class Soldier 
    {
        public static Dictionary<string, Soldier> soldiers=new Dictionary<string, Soldier>();
        private string name;

        public Soldier(string name)
        {
            this.Name = name;
            Soldier.soldiers.Add(this.Name,this);
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public abstract void ReactionOnAttack();
    }
}