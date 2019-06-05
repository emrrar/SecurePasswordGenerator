﻿namespace SecurePasswordGenerator
{
    using System;
    using System.Text;

    public class RandomPassword : IRandomPassword
    {
        private string generatedPassword;

        public RandomPassword(int passwordStrength)
        {
            this.GenerateRandomPassword(passwordStrength);
        }

        public void GenerateRandomPassword(int passwordStrength)
        {
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < passwordStrength; i++)
            {
                int randonASCIINumber = random.Next(33, 127);
                char charNumber = (char)randonASCIINumber;

                password.Append(charNumber.ToString());
            }

            generatedPassword = password.ToString();
        }

        public override string ToString()
        {
            return generatedPassword;
        }
    }
}
