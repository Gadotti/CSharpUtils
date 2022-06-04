using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Test.Security
{
    [TestClass]
    public class Encryption_Test
    {
        [TestMethod]
        public void EncryptDecrypt_ShortInfo_ValidWithKey16()
        {
            var key = "O1nJguFkybBrV2OX";
            var vector = "DJjb01OMRr3e";
            var text = "This is a short text áéçãàü!@#$%¨&*";

            var encryptedResult = Utils.Security.Encryption.Encrypt(text, key, vector);
            Assert.IsTrue(encryptedResult.EncryptedData != text);

            var decryptedText = Utils.Security.Encryption.Decrypt(encryptedResult.EncryptedData, key, vector, encryptedResult.AuthTag);
            Assert.IsTrue(decryptedText == text);
        }

        [TestMethod]
        public void EncryptDecrypt_ShortInfo_ValidWithKey24()
        {
            var key = "rMZlU6M9lePikqNyeJy0Ju74";
            var vector = "5tz4XIBQzd1K";
            var text = "This is a short text áéçãàü!@#$%¨&*";

            var encryptedResult = Utils.Security.Encryption.Encrypt(text, key, vector);
            Assert.IsTrue(encryptedResult.EncryptedData != text);

            var decryptedText = Utils.Security.Encryption.Decrypt(encryptedResult.EncryptedData, key, vector, encryptedResult.AuthTag);
            Assert.IsTrue(decryptedText == text);
        }

        [TestMethod]
        public void EncryptDecrypt_ShortInfo_ValidWithKey32()
        {
            var key = "O1nJguFkybBrV2OXfg98RC1HHhfsVP3s";
            var vector = "nB6AHIwp1tk1";
            var text = "This is a short text áéçãàü!@#$%¨&*";

            var encryptedResult = Utils.Security.Encryption.Encrypt(text, key, vector);
            Assert.IsTrue(encryptedResult.EncryptedData != text);

            var decryptedText = Utils.Security.Encryption.Decrypt(encryptedResult.EncryptedData, key, vector, encryptedResult.AuthTag);
            Assert.IsTrue(decryptedText == text);
        }

        [TestMethod]
        public void EncryptDecrypt_LongInfo_ValidWithKey16()
        {
            var key = "O1nJguFkybBrV2OX";
            var vector = "DJjb01OMRr3e";
            var text = "This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- ";

            var encryptedResult = Utils.Security.Encryption.Encrypt(text, key, vector);
            Assert.IsTrue(encryptedResult.EncryptedData != text);

            var decryptedText = Utils.Security.Encryption.Decrypt(encryptedResult.EncryptedData, key, vector, encryptedResult.AuthTag);
            Assert.IsTrue(decryptedText == text);
        }

        [TestMethod]
        public void EncryptDecrypt_LongInfo_ValidWithKey24()
        {
            var key = "rMZlU6M9lePikqNyeJy0Ju74";
            var vector = "5tz4XIBQzd1K";
            var text = "This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- ";

            var encryptedResult = Utils.Security.Encryption.Encrypt(text, key, vector);
            Assert.IsTrue(encryptedResult.EncryptedData != text);

            var decryptedText = Utils.Security.Encryption.Decrypt(encryptedResult.EncryptedData, key, vector, encryptedResult.AuthTag);
            Assert.IsTrue(decryptedText == text);
        }

        [TestMethod]
        public void EncryptDecrypt_LongInfo_ValidWithKey32()
        {
            var key = "O1nJguFkybBrV2OXfg98RC1HHhfsVP3s";
            var vector = "nB6AHIwp1tk1";
            var text = "This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- ";

            var encryptedResult = Utils.Security.Encryption.Encrypt(text, key, vector);
            Assert.IsTrue(encryptedResult.EncryptedData != text);

            var decryptedText = Utils.Security.Encryption.Decrypt(encryptedResult.EncryptedData, key, vector, encryptedResult.AuthTag);
            Assert.IsTrue(decryptedText == text);
        }

        [TestMethod]
        public void Encrypt_InvalidKeysOrVector()
        {
            var text = "any text";
            Assert.ThrowsException<ArgumentNullException>(() => Utils.Security.Encryption.Encrypt(text, "", ""));
            Assert.ThrowsException<ArgumentNullException>(() => Utils.Security.Encryption.Encrypt(text, "PnQrn4ySCkQmkNVv", ""));
            Assert.ThrowsException<ArgumentNullException>(() => Utils.Security.Encryption.Encrypt(text, "", "PnQrn4ySCkQm"));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Utils.Security.Encryption.Encrypt(text, "1", "PnQrn4ySCkQm"));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Utils.Security.Encryption.Encrypt(text, "PnQrn4ySCkQmkNVv", "1"));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Utils.Security.Encryption.Encrypt(text, "PnQrn4ySCkQmkNVv1", "PnQrn4ySCkQm"));
        }
    }
}
