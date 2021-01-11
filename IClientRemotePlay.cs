
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientRemotePlay
    {
        public IntPtr GetSessionCount;
        public IntPtr GetSessionID;
        public IntPtr GetSessionSteamID;
        public IntPtr GetSessionClientName;
        public IntPtr GetSessionClientFormFactor;
        public IntPtr BGetSessionClientResolution;
        public IntPtr BSendRemotePlayTogetherInvite;
    }
}
