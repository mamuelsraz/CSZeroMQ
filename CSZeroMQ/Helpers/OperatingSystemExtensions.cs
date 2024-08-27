using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSZeroMQ.Helpers
{
    public static class OperatingSystemExtensions
    {
        public static bool IsWindows(this OperatingSystem os)
        {
            return Environment.OSVersion.Platform == PlatformID.Win32NT;
        }

        public static bool IsLinux(this OperatingSystem os)
        {
            return Environment.OSVersion.Platform == PlatformID.Unix;
        }

        public static bool IsMacOS(this OperatingSystem os)
        {
            return Environment.OSVersion.Platform == PlatformID.MacOSX;
        }
    }
}
