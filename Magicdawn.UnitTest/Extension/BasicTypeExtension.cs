using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magicdawn;

namespace Magicdawn.UnitTest.Extension
{
    [NUnit.Framework.TestFixture]
    public class BasicTypeExtension
    {
        [NUnit.Framework.Test]
        public void TestBetween()
        {
            var low = 1;
            var high = 5;
            var actual = 3.Between(low, high);
            NUnit.Framework.Assert.AreEqual(true, actual);

            var lowChar = 'a';
            var highChar = 'z';
            actual = 's'.Between(lowChar, highChar);
            NUnit.Framework.Assert.AreEqual(true, actual);
        }
    }
}