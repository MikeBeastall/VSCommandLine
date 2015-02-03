using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSCommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentDirectory = Environment.CurrentDirectory;

            var files = Directory.GetFiles(currentDirectory, "*.sln");

            if (files.Length == 0)
            {
                Console.WriteLine("No *.sln files found.");
                return;
            }

            if (files.Length > 1)
            {
                Console.WriteLine("Multiple *.sln files found.");
                return;
            }

            Console.WriteLine("Opening " + Path.GetFileName(files[0]));

            var vsLocation = new VisualStudioLocator().FindVisualStudio();

            Process.Start(vsLocation, files[0]);
        }
    }
}
