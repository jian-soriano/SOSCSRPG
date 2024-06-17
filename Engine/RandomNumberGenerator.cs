using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Net.NetworkInformation;

namespace Engine
{
    // Complex version, with more randomness

    public static class RandomNumberGenerator
    {
        private static readonly RNGCryptoServiceProvider _generator = new RNGCryptoServiceProvider();

        public static int NumberBetween(int minimumValue, int maximumValue)
        {
            // creates array of bytes
            byte[] randomNumber = new byte[1];

            // populates each index of the array with a random byte value (max value = 255)
            _generator.GetBytes(randomNumber);

            // converts the first index of the byte array to a double (max value = 255)
            double asciiValueOfRandomCharacter = Convert.ToDouble(randomNumber[0]);

            // converts random number to a fraction multiplier between 0 a 1
            double multiplier = asciiValueOfRandomCharacter / 255d;

            // gets the range of desired values
            int range = maximumValue - minimumValue;

            // apply the fraction multiplier to our valid range, and round down to the nearest whole number
            double randomValueInRange = Math.Floor(multiplier * range);

            return (int) (minimumValue + randomValueInRange);
        }

        // Simple version, with less randomness.

        private static readonly Random _simpleGenerator = new Random();
        public static int SimpleNumberBetween(int minimumValue, int maximumValue)
        {
            return _simpleGenerator.Next(minimumValue, maximumValue + 1);
        }
    }
}
