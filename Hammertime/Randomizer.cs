using System;
using System.Security.Cryptography;

namespace Hammertime.Core
{
    public class Randomizer
    {

        public int GetRandom(int max)
        {
            if(max < 1)
                throw new ArgumentException($"Value can't be less than one, you input was [{max}]");

            using (RNGCryptoServiceProvider rg = new RNGCryptoServiceProvider())
            {
                var rno = new byte[4];
                rg.GetBytes(rno);
                var randomValue = BitConverter.ToInt32(rno, 0);
                return new Random(randomValue).Next(1, max+1);
            }
        }


    }
}
