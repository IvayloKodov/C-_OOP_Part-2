using System;

namespace Problem8.PetClinic
{
    public static class Validator
    {
        public static void ValidateInput(string value)
        {
            if (value.Length < 1 || value.Length > 50)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]))
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}