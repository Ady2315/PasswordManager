using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    internal class PIN
    {
        //int currentPINLength = 0;
        Random digit = new Random();

        public PIN() { }
        public PIN(int pinLength)
        {
            PINGenerator(pinLength);
        }

        public string PINGenerator(int pinLength)
        {
            string randomPIN = "";

            for (int i = 0; i < pinLength; i++)
            {
                int randomNum = digit.Next(0, 9);
                randomPIN += randomNum;
            }
            return randomPIN;
        }
    }
}
