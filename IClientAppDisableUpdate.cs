
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientAppDisableUpdate
    {
        public IntPtr SetAppUpdateDisabledSecondsRemaining;
    }
}
