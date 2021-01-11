
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamGameCoordinator001
    {
        public IntPtr SendMessage;
        public IntPtr IsMessageAvailable;
        public IntPtr RetrieveMessage;
    }
}
