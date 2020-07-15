using System;
using System.Text;
using System.Security.Cryptography;

namespace Utils.Security
{
    public static class Encryption
    {
        /// <summary>
        /// Rijndael symetric encryptation based
        /// KeySize: 256
        /// </summary>
        /// <param name="info"></param>
        /// <returns>Returns encrypted information converted in base64</returns>
        public static string Encrypt(string info, string key, string vector)
        {
            KeyAndVectorValidation(key, vector);

            if (string.IsNullOrEmpty(info))
            {
                return info;
            }

            byte[] result;
            var plainText = Encoding.UTF8.GetBytes(info);

            using (var rijndael = new RijndaelManaged())
            {
                rijndael.KeySize = 256;
                rijndael.BlockSize = 128;
                rijndael.Mode = CipherMode.CBC;
                rijndael.Padding = PaddingMode.ISO10126;
                result = rijndael.CreateEncryptor(Encoding.UTF8.GetBytes(key),
                                                  Encoding.UTF8.GetBytes(vector))
                                       .TransformFinalBlock(plainText, 0, plainText.Length);
            }

            return Convert.ToBase64String(result);
        }

        /// <summary>
        /// Rijndael symetric encryptation based
        /// KeySize: 256
        /// </summary>
        /// <param name="info">Encrypted info in base64 format</param>
        /// <returns>return the plain text information</returns>
        public static string Decrypt(string info, string key, string vector)
        {
            if (string.IsNullOrEmpty(info))
            {
                return info;
            }

            var padL = info.Length + (info.Length % 4);
            info = info.PadRight(padL, '=');

            var cipherText = Convert.FromBase64String(info);

            using (var rijndael = new RijndaelManaged())
            {
                rijndael.KeySize = 256;
                rijndael.BlockSize = 128;
                rijndael.Mode = CipherMode.CBC;
                rijndael.Padding = PaddingMode.ISO10126;
                var plainText = rijndael.CreateDecryptor(Encoding.UTF8.GetBytes(key),
                                                         Encoding.UTF8.GetBytes(vector))
                                      .TransformFinalBlock(cipherText, 0, cipherText.Length);
                return Encoding.UTF8.GetString(plainText);
            }
        }  

        private static void KeyAndVectorValidation(string key, string vector)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException(key);
            }

            if (string.IsNullOrEmpty(vector))
            {
                throw new ArgumentNullException(vector);
            }

            if (key.Length != 16 && key.Length != 24 && key.Length != 32)
            {
                throw new ArgumentOutOfRangeException(key, "Key must have 16, 24 or 32 bytes");
            }

            if (vector.Length != 16)
            {
                throw new ArgumentOutOfRangeException(vector, "Vector must have 16 bytes");
            }
        }

    }
}
