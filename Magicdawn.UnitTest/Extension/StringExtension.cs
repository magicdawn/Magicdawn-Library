using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magicdawn;
using NUnit.Framework;

namespace Magicdawn.UnitTest.Extension
{
    [NUnit.Framework.TestFixture]
    public class StringExtension
    {
        [NUnit.Framework.Test]
        public void format()
        {
            object expect = "Hello World";//期望值
            var actual = "{0} {1}".format("Hello","World");//实际运行值

            NUnit.Framework.Assert.AreEqual(expect,actual);
        }

        [NUnit.Framework.Test]
        public void ContainOneOf()
        {
            var s = "a b c d";
            Assert.AreEqual(true,s.ContainOneOf("a b"));
            Assert.AreEqual(true,s.ContainOneOf("a","e"));
            Assert.AreEqual(false,s.ContainOneOf("ab"));
        }
    }
}
