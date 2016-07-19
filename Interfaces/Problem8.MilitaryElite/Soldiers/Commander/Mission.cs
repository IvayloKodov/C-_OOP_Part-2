using System;
using Problem8.MilitaryElite.Interfaces;

namespace Problem8.MilitaryElite
{
    public class Mission : IMission
    {
        private string codeName;
        private string state;

        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName { get { return this.codeName; } private set { this.codeName = value; } }

        public string State
        {
            get { return this.state; }
            private set
            {
                if (value != "inProgress" && value != "Finished")
                {
                    throw new ArgumentException("No such kind of mission state!");
                }
                this.state = value;
            }
        }

        public void CompleteMission()
        {
            this.state = "Finished";
        }

        public override string ToString()
        {
            return $"  Code Name: {this.CodeName} State: {this.State}";
        }
    }
}