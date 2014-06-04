using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magicdawn.UnitTest.Extension
{
    [NUnit.Framework.TestFixture]
    public class ArrayExtension
    {
        [NUnit.Framework.Test]
        public static void ForEach() {
            Console.WriteLine("应输出1,2,3换行");
            var arr = new int[]{ 1,2,3 };
            arr.ForEach(Console.WriteLine);
        }
    }
}
