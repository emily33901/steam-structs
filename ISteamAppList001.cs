
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamAppList001
    {
        public IntPtr GetNumInstalledApps;
        public IntPtr GetInstalledApps;
        public IntPtr GetAppName;
        public IntPtr GetAppInstallDir;
        public IntPtr GetAppBuildId;
    }
}
