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