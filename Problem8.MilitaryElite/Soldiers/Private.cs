using Problem8.MilitaryElite.Interfaces;

namespace Problem8.MilitaryElite
{
    public class Private : Soldier,IPrivate
    {
        private decimal salary;

        public Private(string id,string firstName, string lastName, decimal salary) 
            : base(firstName, lastName, id)
        {
            this.Salary = salary;
        }

        public decimal Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public override string ToString()
        {
            return $"{base.ToString()} Salary: {this.Salary:F2}";
        }
    }
}