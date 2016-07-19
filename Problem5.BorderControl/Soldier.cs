using System.Collections.Generic;

namespace Problem5.BorderControl
{
    public class Soldier
    {
        private string checkPattern;

        public Soldier(string checkPattern)
        {
            this.checkPattern = checkPattern;
            this.Violators=new List<IId>();
        }

        public List<IId> Violators { get;}

        public void CheckOfId(IId id)
        {
            if (id.Id.EndsWith(this.checkPattern))
            {
                this.Violators.Add(id);
            }
        }
    }
}