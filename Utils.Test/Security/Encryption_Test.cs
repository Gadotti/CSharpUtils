using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Utils.Test.Security
{
    [TestClass]
    public class Encryption_Test
    {
        [TestMethod]
        public void EncryptDecrypt_ShortInfo_ValidWithKey16()
        {
            var key = "O1nJguFkybBrV2OX";
            var vector = "DJjb01OMRr3e0gED";
            var text = "This is a short text áéçãàü!@#$%¨&*";

            var encryptedText = Utils.Security.Encryption.Encrypt(text, key, vector);
            Assert.IsTrue(encryptedText != text);

            var decryptedText = Utils.Security.Encryption.Decrypt(encryptedText, key, vector);
            Assert.IsTrue(decryptedText == text);
        }

        [TestMethod]
        public void EncryptDecrypt_ShortInfo_ValidWithKey24()
        {
            var key = "rMZlU6M9lePikqNyeJy0Ju74";
            var vector = "5tz4XIBQzd1Kz4C0";
            var text = "This is a short text áéçãàü!@#$%¨&*";

            var encryptedText = Utils.Security.Encryption.Encrypt(text, key, vector);
            Assert.IsTrue(encryptedText != text);

            var decryptedText = Utils.Security.Encryption.Decrypt(encryptedText, key, vector);
            Assert.IsTrue(decryptedText == text);
        }

        [TestMethod]
        public void EncryptDecrypt_ShortInfo_ValidWithKey32()
        {
            var key = "O1nJguFkybBrV2OXfg98RC1HHhfsVP3s";
            var vector = "nB6AHIwp1tk1DkdC";
            var text = "This is a short text áéçãàü!@#$%¨&*";

            var encryptedText = Utils.Security.Encryption.Encrypt(text, key, vector);
            Assert.IsTrue(encryptedText != text);

            var decryptedText = Utils.Security.Encryption.Decrypt(encryptedText, key, vector);
            Assert.IsTrue(decryptedText == text);
        }

        [TestMethod]
        public void EncryptDecrypt_LongInfo_ValidWithKey16()
        {
            var key = "O1nJguFkybBrV2OX";
            var vector = "DJjb01OMRr3e0gED";
            var text = "This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- ";

            var encryptedText = Utils.Security.Encryption.Encrypt(text, key, vector);
            Assert.IsTrue(encryptedText != text);

            var decryptedText = Utils.Security.Encryption.Decrypt(encryptedText, key, vector);
            Assert.IsTrue(decryptedText == text);
        }

        [TestMethod]
        public void EncryptDecrypt_LongInfo_ValidWithKey24()
        {
            var key = "rMZlU6M9lePikqNyeJy0Ju74";
            var vector = "5tz4XIBQzd1Kz4C0";
            var text = "This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- ";

            var encryptedText = Utils.Security.Encryption.Encrypt(text, key, vector);
            Assert.IsTrue(encryptedText != text);

            var decryptedText = Utils.Security.Encryption.Decrypt(encryptedText, key, vector);
            Assert.IsTrue(decryptedText == text);
        }

        [TestMethod]
        public void EncryptDecrypt_LongInfo_ValidWithKey32()
        {
            var key = "O1nJguFkybBrV2OXfg98RC1HHhfsVP3s";
            var vector = "nB6AHIwp1tk1DkdC";
            var text = "This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- This is a long text áéçãàü!@#$%¨&* -- ";

            var encryptedText = Utils.Security.Encryption.Encrypt(text, key, vector);
            Assert.IsTrue(encryptedText != text);

            var decryptedText = Utils.Security.Encryption.Decrypt(encryptedText, key, vector);
            Assert.IsTrue(decryptedText == text);
        }

        [TestMethod]
        public void Encrypt_InvalidKeysOrVector()
        {
            var text = "any text";
            Assert.ThrowsException<ArgumentNullException>(() => Utils.Security.Encryption.Encrypt(text, "", ""));
            Assert.ThrowsException<ArgumentNullException>(() => Utils.Security.Encryption.Encrypt(text, "PnQrn4ySCkQmkNVv", ""));
            Assert.ThrowsException<ArgumentNullException>(() => Utils.Security.Encryption.Encrypt(text, "", "PnQrn4ySCkQmkNVv"));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Utils.Security.Encryption.Encrypt(text, "1", "PnQrn4ySCkQmkNVv"));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Utils.Security.Encryption.Encrypt(text, "PnQrn4ySCkQmkNVv", "1"));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Utils.Security.Encryption.Encrypt(text, "PnQrn4ySCkQmkNVv1", "PnQrn4ySCkQmkNVv"));
        }

    }
}
