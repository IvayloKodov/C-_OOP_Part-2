using System;
using Problem8.MilitaryElite.Interfaces;

namespace Problem8.MilitaryElite
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corps;
        public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }


        public string Corps
        {
            get { return this.corps; }
            private set
            {
                if (value != "Airforces" && value != "Marines")
                {
                    throw new ArgumentException("Haven't this kind of corps");
                }
                this.corps = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nCorps: {this.Corps}";
        }
    }
}