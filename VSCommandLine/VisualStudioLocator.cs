using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSCommandLine
{
    public class VisualStudioLocator
    {
        private VisualStudioRegistryLocations _registryLocations;

        public VisualStudioLocator()
        {
            _registryLocations = new VisualStudioRegistryLocations();
        }

        public string FindVisualStudio()
        {
            return _registryLocations.DefaultLocation();
        }
    }
}
