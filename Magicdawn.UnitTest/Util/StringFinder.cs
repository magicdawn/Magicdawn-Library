using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magicdawn.UnitTest.Util
{
    [NUnit.Framework.TestFixture]
    public class StringFinder
    {
        [NUnit.Framework.Test]
        public static void TestGetSecondIndex()
        {
            var s = "{abcd{}efgh}";
            var secIndex = Magicdawn.Util.StringFinder.GetSecondIndex(s,0);

            NUnit.Framework.Assert.AreEqual(secIndex,11);
        }
    }
}