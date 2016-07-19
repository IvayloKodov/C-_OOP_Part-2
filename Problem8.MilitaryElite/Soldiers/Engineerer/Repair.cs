using Problem8.MilitaryElite.Interfaces;

namespace Problem8.MilitaryElite
{
    public class Repair :IRepair
    {
        public Repair(string partName, int workedHour)
        {
            PartName = partName;
            WorkedHour = workedHour;
        }

        public string PartName { get; private set; }
        public int WorkedHour { get; private set; }

        public override string ToString()
        {
            return $"  Part Name: {this.PartName} Hours Worked: {this.WorkedHour}";
        }
    }
}