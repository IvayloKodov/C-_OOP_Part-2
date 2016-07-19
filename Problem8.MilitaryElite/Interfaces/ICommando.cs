using System.Collections.Generic;

namespace Problem8.MilitaryElite.Interfaces
{
    public interface ICommando
    {
        HashSet<Mission> Missions { get; }
    }
}