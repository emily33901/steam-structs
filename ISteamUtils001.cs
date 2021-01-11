
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamUtils001
    {
        public IntPtr GetSecondsSinceAppActive;
        public IntPtr GetSecondsSinceComputerActive;
        public IntPtr GetConnectedUniverse;
        public IntPtr GetServerRealTime;
        public IntPtr GetIPCountry;
        public IntPtr GetImageSize;
        public IntPtr GetImageRGBA;
    }
}
