
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientEngineApp
    {
        public IntPtr D_CSteamClientApp;
        public IntPtr D_CSteamClientApp2;
    }
}
