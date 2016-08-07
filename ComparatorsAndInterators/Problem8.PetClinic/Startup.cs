using System;
using System.Collections.Generic;

namespace Problem8.PetClinic
{
    class Startup
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());

            var pets = new Dictionary<string, Pet>();
            var clinics = new Dictionary<string, Clinic>();

            for (int i = 0; i < lines; i++)
            {
                string[] commandInfo = Console.ReadLine().Split();

                switch (commandInfo[0])
                {
                    case "Create":
                        try
                        {
                            CreatePetOrClinic(commandInfo, pets, clinics);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid Operation!");
                        }

                        break;
                    case "Add":
                        Console.WriteLine(AddPet(commandInfo, clinics, pets));
                        break;
                    case "Release":
                        var clinic = clinics[commandInfo[1]];
                        Console.WriteLine(clinic.Release());
                        break;
                    case "HasEmptyRooms":
                        Console.WriteLine("{0}",
                            clinics[commandInfo[1]].HasEmptyRooms());
                        break;
                    case "Print":
                        PrintRoomOrClinic(commandInfo, clinics);
                        break;
                }
            }
        }


        private static void PrintRoomOrClinic(string[] commandInfo, Dictionary<string, Clinic> clinics)
        {
            string result = string.Empty;
            if (commandInfo.Length == 2) //print clinic
            {
                result = clinics[commandInfo[1]].PrintClinic();
            }
            else if (commandInfo.Length == 3) //print clinic room
            {
                result = clinics[commandInfo[1]].PrintClinicRoom(int.Parse(commandInfo[2])-1);
            }
            Console.WriteLine(result);
        }

        private static bool AddPet(string[] commandInfo, Dictionary<string, Clinic> clinics, Dictionary<string, Pet> pets)
        {
            string petName = commandInfo[1];
            string clinicName = commandInfo[2];
            var clinic = clinics[clinicName];
            var pet = pets[petName];

            return clinic.Add(pet);
        }


        private static void CreatePetOrClinic(string[] commandInfo, Dictionary<string, Pet> pets, Dictionary<string, Clinic> clinics)
        {
            if (commandInfo[1] == "Pet")
            {
                Pet pet = new Pet(commandInfo[2], int.Parse(commandInfo[3]), commandInfo[4]);
                pets.Add(commandInfo[2], pet);
            }
            else
            {
                Clinic clinic = new Clinic(commandInfo[2], int.Parse(commandInfo[3]));
                clinics.Add(commandInfo[2], clinic);
            }
        }
    }
}