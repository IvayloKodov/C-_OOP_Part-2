using System;
using System.Collections.Generic;
using Problem8.MilitaryElite.Interfaces;

namespace Problem8.MilitaryElite
{
    public class LeutenantGeneral : Private,ILeutenantGeneral
    {
        public LeutenantGeneral(string id, string firstName, string lastName, decimal salary, HashSet<Private> privates ) 
            : base(id, firstName, lastName, salary)
        {
            this.Privates = privates;
        }

        public HashSet<Private> Privates { get; private set; }


        public override string ToString()
        {
            return string.Format("{0}\nPrivates:{1}",
                base.ToString(), this.Privates.Count != 0 ? "\n  " + string.Join("\n  ", this.Privates) : "");
        }
    }
}