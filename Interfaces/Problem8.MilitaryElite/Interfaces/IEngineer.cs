using System.Collections.Generic;

namespace Problem8.MilitaryElite.Interfaces
{
    public interface IEngineer
    {
        HashSet<Repair> Repairs { get; }
    }
}