namespace esrmnt.pelican.tests
{
    using System;
    using System.Linq;
    using System.Text;
    using NUnit.Framework;
    using System.Collections.Generic;
    using esrmnt.pelican.tests.Properties;

    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            var test = new Pelican();
            var result = test.GetPelican(Resources.test);
            Assert.AreEqual(result, "Pelican");
        }
    }
     
}