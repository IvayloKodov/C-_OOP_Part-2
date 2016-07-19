using System.Collections.Generic;

namespace Problem8.MilitaryElite.Interfaces
{
    public interface ILeutenantGeneral 
    {
        HashSet<Private> Privates { get; }
    }
}