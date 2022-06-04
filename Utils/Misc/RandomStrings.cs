using System.Text;
using System.Security.Cryptography;

namespace Utils.Misc
{
    public static class RandomStrings
    {
        const string ValidCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

        /// <summary>
        /// Get a random string with specific length.
        /// Valid characteres: abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890
        /// Before .Net 5
        /// </summary>
        /// <param name="size">Default size 16</param>
        /// <returns></returns>
        [Obsolete]
        public static string Get_BeforeNet5(int size = 16)
        {
            var result = new StringBuilder();
            using (var rng = new RNGCryptoServiceProvider())
            {
                var uintBuffer = new byte[sizeof(uint)];

                for (int length = 0; length < size; length++)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    result.Append(ValidCharacters[(int)(num % (uint)ValidCharacters.Length)]);
                }
            }

            return result.ToString();
        }

        /// <summary>
        /// Get a random string with specific length.
        /// Valid characteres: abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890
        /// Updated to use 'RandomNumberGenerator' to give a random string key
        /// </summary>
        /// <param name="size">Default size is 16</param>
        /// <returns></returns>
        public static string Get(int size = 16)
        {
            var result = new StringBuilder();
            var uintBuffer = new byte[sizeof(uint)];

            for (int length = 0; length < size; length++)
            {
                RandomNumberGenerator.Fill(uintBuffer);
                uint num = BitConverter.ToUInt32(uintBuffer, 0);
                result.Append(ValidCharacters[(int)(num % (uint)ValidCharacters.Length)]);
            }

            return result.ToString();
        }
    }
}
