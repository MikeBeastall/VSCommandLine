namespace VSCommandLine
{
    public class VisualStudioLocator
    {
        private readonly VisualStudioRegistryLocations _registryLocations;

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