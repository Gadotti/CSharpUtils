using System;
using System.Text;

namespace Utils.Misc
{
    public static class RandomStrings
    {
        /// <summary>
        /// Get a random string with specific length.
        /// Valid characteres: abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890
        /// </summary>
        /// <param name="size">Default size 16</param>
        /// <returns></returns>
        public static string Get(int size = 16)
        {
            const string validCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            var result = new StringBuilder();
            using (var rng = new System.Security.Cryptography.RNGCryptoServiceProvider())
            {
                var uintBuffer = new byte[sizeof(uint)];

                for (int length = 0; length < size; length++)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    result.Append(validCharacters[(int)(num % (uint)validCharacters.Length)]);
                }
            }

            return result.ToString();
        }
    }
}
