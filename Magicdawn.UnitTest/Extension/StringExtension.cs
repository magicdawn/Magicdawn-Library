﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magicdawn;

namespace Magicdawn.UnitTest.Extension
{
    [NUnit.Framework.TestFixture]
    public class StringExtension
    {
        [NUnit.Framework.Test]
        public void Format()
        {
            var expect = "Hello World";//期望值
            var actual = "{0} {1}".format("Hello","World");//实际运行值

            NUnit.Framework.Assert.AreEqual(expect,actual);
        }
    }
}
