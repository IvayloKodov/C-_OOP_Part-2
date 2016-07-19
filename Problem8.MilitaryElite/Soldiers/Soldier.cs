using Problem8.MilitaryElite.Interfaces;

namespace Problem8.MilitaryElite
{
    public abstract class Soldier : ISoldier
    {
        private string firstName;
        private string lastName;
        private string id;

        protected Soldier(string firstName, string lastName, string id)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }

        public string FirstName { get;protected set; }
        public string LastName { get; protected set; }
        public string Id { get; protected set; }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id}";
        }
    }
}