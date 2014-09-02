using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Magicdawn;
using NUnit.Framework;
namespace Magicdawn.UnitTest.Extension
{
    [TestFixture]
    public class QueueExtension
    {
        [Test]
        public void EnqueueRange()
        {
            var queue = new Queue<string>();
            Assert.DoesNotThrow(delegate {
                queue.EnqueueRange(new List<string> { "1","2","3" });
            });
        }
    }
}
