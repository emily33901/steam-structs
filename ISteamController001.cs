
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamController001
    {
        public IntPtr Init;
        public IntPtr Shutdown;
        public IntPtr RunFrame;
        public IntPtr GetControllerState;
        public IntPtr TriggerHapticPulse;
        public IntPtr SetOverrideMode;
    }
}
