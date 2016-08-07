using System;

namespace Problem8.PetClinic
{
    public class Pet
    {
        private string name;
        private int age;
        private string kind;

        public Pet(string name, int age, string kind)
        {
            this.Name = name;
            this.Age = age;
            this.Kind = kind;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                Validator.ValidateInput(value);

                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            private set
            {
                if (value<1 || value>100)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.age = value;
            }
        }

        public string Kind
        {
            get { return this.kind; }
            private set
            {
                Validator.ValidateInput(value);

                this.kind = value;
            }
        }

        public override string ToString()
        {
            return $"{this.name} {this.Age} {this.Kind}";
        }
    }
}