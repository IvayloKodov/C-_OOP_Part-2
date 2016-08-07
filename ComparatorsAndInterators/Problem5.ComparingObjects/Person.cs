using System;

namespace Problem5.ComparingObjects
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

        public Person(string name, int age, string town)
        {
            this.name = name;
            this.age = age;
            this.town = town;
        }

        public int CompareTo(Person other)
        {
            if (this.name.CompareTo(other.name) > 0)
            {
                return 1;
            }
            else if (this.name.CompareTo(other.name) < 0)
            {
                return -1;
            }

            if (this.age.CompareTo(other.age) > 0)
            {
                return 1;
            }
            else if (this.age.CompareTo(other.age) < 0)
            {
                return -1;
            }

            if (this.town.CompareTo(other.town) > 0)
            {
                return 1;
            }
            else if(this.town.CompareTo(other.town) < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}