
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientProcessMonitor
    {
        public IntPtr RegisterProcess;
        public IntPtr UnregisterProcess;
        public IntPtr TerminateProcess;
    }
}
