using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using Microsoft.Win32;

namespace VSCommandLine
{
    public class VisualStudioRegistryLocations
    {
        private readonly Dictionary<string, string> _locationDictionary;

        private const string LocationSuffix = @"\Common7\IDE\devenv.exe";
        private const string DefaultKey = "Default";
        private const string RegistryLocationBase =
            @"SOFTWARE\Wow6432Node\Microsoft\VisualStudio\SxS\VS7";

        public IEnumerable<string> Locations { get { return _locationDictionary.Values; }}

        public VisualStudioRegistryLocations()
        {
            _locationDictionary = new Dictionary<string, string>();

            var key = Registry.LocalMachine
                .OpenSubKey(RegistryLocationBase);

            _locationDictionary.Add(DefaultKey, key.GetValue("").ToString());
            _locationDictionary.Add("10", key.GetValue("10.0").ToString());
            _locationDictionary.Add("12", key.GetValue("12.0").ToString());
        }

        public string DefaultLocation()
        {
            return _locationDictionary[DefaultKey] + LocationSuffix;
        }

        public string LocationForVersion(string version)
        {
            if (!_locationDictionary.ContainsKey(version))
                return null;

            return _locationDictionary[version] + LocationSuffix;
        }
    }
}