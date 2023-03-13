using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    internal class Password
    {
        //int currentPasswordLength = 0;
        Random character = new Random();
        string allCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";
        string specialCharacters = @"`~!@#$%^&*()_-+={}[]:;""'\|<,>.?/";

        public Password() { }
        public Password(int passwordLength)
        {
            PasswordGenerator(passwordLength);
        }

        public string PasswordGenerator(int passwordLength)
        {
            string randomPassword = "";

            for (int i = 0; i < passwordLength; i++)
            {
                int randomNum = character.Next(0, allCharacters.Length);
                randomPassword += allCharacters[randomNum];
            }
            return randomPassword;
        }

        public void AddSpecialChars()
        {
            allCharacters += specialCharacters;
        }

        public void RemoveSpecialChars()
        {
            if (allCharacters.Contains(specialCharacters))
            {
                allCharacters = allCharacters.Remove(allCharacters.IndexOf(specialCharacters));
            }
        }
    }
}
