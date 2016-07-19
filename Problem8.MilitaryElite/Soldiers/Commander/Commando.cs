using System;
using System.Collections.Generic;
using Problem8.MilitaryElite.Interfaces;

namespace Problem8.MilitaryElite
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string id, string firstName, string lastName, decimal salary, string corps, HashSet<Mission> missions ) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = missions;
        }

        public HashSet<Mission> Missions { get; private set; }

        public override string ToString()
        {
            return string.Format("{0}\nMissions:{1}",
                base.ToString(), this.Missions.Count!=0? "\n"+string.Join("\n", this.Missions) : "");
        }
    }
}