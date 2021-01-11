
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamUser009
    {
        public IntPtr GetHSteamUser;
        public IntPtr BLoggedOn;
        public IntPtr GetSteamID;
        public IntPtr InitiateGameConnection;
        public IntPtr TerminateGameConnection;
        public IntPtr TrackAppUsageEvent;
        public IntPtr RefreshSteam2Login;
    }
}
