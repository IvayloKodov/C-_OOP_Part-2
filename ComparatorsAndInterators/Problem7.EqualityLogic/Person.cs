using System;

namespace Problem7.EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() ^ this.Age ^ 213;
        }

        public override bool Equals(object obj)
        {
            return this.CompareTo((Person)obj) == 0;
        }

        public int CompareTo(Person other)
        {
            int nameComparer = this.Name.CompareTo(other.Name);
            int ageComparer = this.Age.CompareTo(other.Age);

            if (nameComparer == 0)
            {
                return ageComparer;;
            }
            return nameComparer;
        }
    }
}