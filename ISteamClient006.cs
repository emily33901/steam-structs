
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamClient006
    {
        public IntPtr CreateSteamPipe;
        public IntPtr BReleaseSteamPipe;
        public IntPtr CreateGlobalUser;
        public IntPtr ConnectToGlobalUser;
        public IntPtr CreateLocalUser;
        public IntPtr ReleaseUser;
        public IntPtr GetISteamUser;
        public IntPtr GetIVAC;
        public IntPtr GetISteamGameServer;
        public IntPtr SetLocalIPBinding;
        public IntPtr GetUniverseName;
        public IntPtr GetISteamFriends;
        public IntPtr GetISteamUtils;
        public IntPtr GetISteamBilling;
        public IntPtr GetISteamMatchmaking;
        public IntPtr GetISteamApps;
        public IntPtr GetISteamContentServer;
        public IntPtr GetISteamMasterServerUpdater;
        public IntPtr GetISteamMatchmakingServers;
        public IntPtr RunFrame;
        public IntPtr GetIPCCallCount;
    }
}
