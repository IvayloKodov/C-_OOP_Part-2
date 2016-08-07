using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem8.PetClinic
{
    public class Clinic
    {
        private string name;
        private int numberOfRooms;
        private Dictionary<int, Pet> rooms;

        public Clinic(string name, int numberOfRooms)
        {
            this.Name = name;
            this.NumberOfRooms = numberOfRooms;
            this.CreateClinicRooms();
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

        public IDictionary<int, Pet> Rooms => rooms;

        public int NumberOfRooms
        {
            get { return this.numberOfRooms; }
            private set
            {
                if (value % 2 == 0)
                {
                    throw new InvalidOperationException();
                }
                if (value < 1 || value > 101)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.numberOfRooms = value;
            }
        }

        public void CreateClinicRooms()
        {
            this.rooms = new Dictionary<int, Pet>();
            for (int i = 0; i < numberOfRooms; i++)
            {
                rooms.Add(i, null);
            }
        }

        public bool HasEmptyRooms()
        {
            return this.rooms.Any(r => r.Value == null);
        }

        public bool Add(Pet pet)
        {
            int indexToAdd = NumberOfRooms / 2;
            if (this.Rooms[indexToAdd] == null)
            {
                this.rooms[indexToAdd] = pet;
                return true;
            }
            for (int i = 1; i <= this.rooms.Count / 2; i++)
            {
                if (this.Rooms[indexToAdd - i] == null)
                {
                    this.rooms[indexToAdd - i] = pet;
                    return true;
                }
                else if (this.Rooms[indexToAdd + i] == null)
                {
                    this.rooms[indexToAdd + i] = pet;
                    return true;
                }
            }
            return false;
        }

        public bool Release()
        {
            int indexToRelease = NumberOfRooms / 2;
            for (int i = 0; i < this.rooms.Count; i++)
            {
                if (this.rooms[(i + indexToRelease) % this.NumberOfRooms] != null)
                {
                    this.rooms[(i + indexToRelease) % this.NumberOfRooms] = null;
                    return true;
                }
            }
            return false;
        }

        public string PrintClinic()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.Rooms.Count; i++)
            {
                sb.AppendLine(this.PrintClinicRoom(i));
            }
            return sb.ToString().TrimEnd();
        }

        public string PrintClinicRoom(int roomNumber)
        {
            if (this.Rooms[roomNumber] == null)
            {
                return "Room empty";
            }
            return this.Rooms[roomNumber].ToString();
        }
    }
}