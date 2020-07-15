using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Utils.Test.Misc
{
    [TestClass]
    public class RandomStrings_Test
    {
        [TestMethod]
        public void Get_1charValue_CheckLength()
        {
            var randomString = Utils.Misc.RandomStrings.Get(1);
            Assert.IsTrue(randomString.Length == 1);
        }

        [TestMethod]
        public void Get_DefaultValue_CheckLength()
        {
            var randomString = Utils.Misc.RandomStrings.Get();
            Assert.IsTrue(randomString.Length == 16);
        }

        [TestMethod]
        public void Get_32charValue_CheckLength()
        {
            var randomString = Utils.Misc.RandomStrings.Get(32);
            Assert.IsTrue(randomString.Length == 32);
        }

        [TestMethod]
        public void Get_64charValue_CheckLength()
        {
            var randomString = Utils.Misc.RandomStrings.Get(64);
            Assert.IsTrue(randomString.Length == 64);
        }

        [TestMethod]
        public void Get_TenRandomValues_Default()
        {
            var randomValues = new List<string>(10);
            for (int i = 0; i < 10; i++)
            {
                randomValues.Add(Utils.Misc.RandomStrings.Get());
            }

            var differentValues = randomValues.GroupBy(x => x).Count();
            Assert.IsTrue(differentValues == 10);
        }

        [TestMethod]
        public void Get_TenRandomValues_32char()
        {
            var randomValues = new List<string>(10);
            for (int i = 0; i < 10; i++)
            {
                randomValues.Add(Utils.Misc.RandomStrings.Get(32));
            }

            var differentValues = randomValues.GroupBy(x => x).Count();
            Assert.IsTrue(differentValues == 10);
        }
    }
}
