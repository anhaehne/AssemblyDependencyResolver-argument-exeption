using System;
using System.IO;
using System.Runtime.Loader;

namespace hhnl.PlugIn.Host
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var t = new AssemblyDependencyResolver(Path.GetFullPath("../../../../hhnl.PlugIn.Tests.TestPlugin/bin/Debug/netstandard2.0/hhnl.PlugIn.Tests.TestPlugIn.dll"));
           
        }
    }
}