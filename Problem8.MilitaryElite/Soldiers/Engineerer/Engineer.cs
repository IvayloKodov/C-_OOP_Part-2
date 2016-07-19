using System;
using System.Collections.Generic;
using Problem8.MilitaryElite.Interfaces;

namespace Problem8.MilitaryElite
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private HashSet<Repair> repairs;

        public Engineer(string id, string firstName, string lastName, decimal salary, string corps, HashSet<Repair> repairs)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = repairs;
        }

        public HashSet<Repair> Repairs
        {
            get { return this.repairs; }
            private set { this.repairs = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}\nRepairs:{1}",
                base.ToString(), this.Repairs.Count != 0 ? "\n" + string.Join("\n", this.Repairs) : "");
        }
    }
}