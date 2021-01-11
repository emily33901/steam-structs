
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamVideo001
    {
        public IntPtr GetVideoURL;
        public IntPtr IsBroadcasting;
    }
}
