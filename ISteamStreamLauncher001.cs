
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamStreamLauncher001
    {
        public IntPtr StartStreaming;
        public IntPtr StopStreaming;
    }
}
