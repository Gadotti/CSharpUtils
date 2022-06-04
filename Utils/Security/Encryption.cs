using System;
using System.Text;
using System.Security.Cryptography;


namespace Utils.Security
{
    public class Encryption
    {
        public struct EncryptData
        {
            public string EncryptedData { get; set; }
            public string AuthTag { get; set; }
        }

        /// <summary>
        /// AES/GCM symetric encryptation based
        /// BlockSize: 128
        /// </summary>
        /// <param name="info"></param>
        /// <returns>Returns encrypted information converted in base64</returns>
        public static EncryptData Encrypt(string info, string key, string vector)
        {
            KeyAndVectorValidation(key, vector);

            if (string.IsNullOrEmpty(info))
            {
                return new EncryptData();
            }

            var plainBytes = Encoding.UTF8.GetBytes(info);
            var keyBytes = Encoding.UTF8.GetBytes(key);
            var vectorBytes = Encoding.UTF8.GetBytes(vector);
            var authTag = new byte[16]; //it will generate automatically and has to be the same to decrypt

            var result = new byte[plainBytes.Length];

            using (var aesGcm = new AesGcm(keyBytes))
            {
                aesGcm.Encrypt(vectorBytes, plainBytes, result, authTag);
            }

            return new EncryptData()
            {
                EncryptedData = Convert.ToBase64String(result),
                AuthTag = Convert.ToBase64String(authTag)
            };
        }

        /// <summary>
        /// AES/GCM symetric encryptation based
        /// BlockSize: 128
        /// </summary>
        /// <param name="info">Encrypted info in base64 format</param>
        /// <returns>return the plain text information</returns>
        public static string Decrypt(string encryptedData, string key, string vector, string authTag)
        {
            if (string.IsNullOrEmpty(encryptedData))
            {
                return encryptedData;
            }

            KeyAndVectorValidation(key, vector);

            if (string.IsNullOrEmpty(authTag))
            {
                throw new ArgumentNullException(authTag);
            }

            var padL = encryptedData.Length + (encryptedData.Length % 4);
            var info = encryptedData.PadRight(padL, '=');
            var cipherBytes = Convert.FromBase64String(info);


            padL = authTag.Length + (authTag.Length % 4);
            info = authTag.PadRight(padL, '=');
            var authTagBytes = Convert.FromBase64String(info);

            var keyBytes = Encoding.UTF8.GetBytes(key);
            var vectorBytes = Encoding.UTF8.GetBytes(vector);            

            byte[] decryptedBytes = new byte[cipherBytes.Length];
            using (var aesGcm = new AesGcm(keyBytes))
            {
                aesGcm.Decrypt(vectorBytes, cipherBytes, authTagBytes, decryptedBytes);
            }

            return Encoding.UTF8.GetString(decryptedBytes);
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

            if (vector.Length != 12)
            {
                throw new ArgumentOutOfRangeException(vector, "Vector must have 12 bytes");
            }
        }
    }
}
