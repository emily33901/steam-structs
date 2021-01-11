
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamUser006
    {
        public IntPtr GetHSteamUser;
        public IntPtr LogOn;
        public IntPtr LogOff;
        public IntPtr BLoggedOn;
        public IntPtr GetSteamID;
        public IntPtr SetRegistryString;
        public IntPtr GetRegistryString;
        public IntPtr SetRegistryInt;
        public IntPtr GetRegistryInt;
        public IntPtr InitiateGameConnection;
        public IntPtr TerminateGameConnection;
        public IntPtr TrackAppUsageEvent;
    }
}
