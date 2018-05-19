using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Single;

namespace SingletonTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var instance1 = Singleton.Instance;
            var instance2 = Singleton.Instance;

            bool expectedSimilarity = true;
            bool actualSimilarity = instance1 == instance2;

            Assert.AreEqual(expectedSimilarity, actualSimilarity);

            instance1.Makename("Mad", "Max");

            bool expectedNameSimilarity = true;
            bool actualNameSimilarity = instance1.FullName == instance2.FullName;

            Assert.AreEqual(expectedNameSimilarity, actualNameSimilarity);
        }
    }
}
