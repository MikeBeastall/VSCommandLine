using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using VSCommandLine;

namespace VSCommandLineTests
{
    [TestFixture]
    public class VisualStudioRegistryLocationsTests
    {
        [Test]
        public void CanGetRegistryLocations()
        {
            var locator = new VisualStudioRegistryLocations();

            Assert.That(locator.Locations, Is.Not.Null);
        }
    }
}
