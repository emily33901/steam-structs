
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamClient011
    {
        public IntPtr CreateSteamPipe;
        public IntPtr BReleaseSteamPipe;
        public IntPtr ConnectToGlobalUser;
        public IntPtr CreateLocalUser;
        public IntPtr ReleaseUser;
        public IntPtr GetISteamUser;
        public IntPtr GetISteamGameServer;
        public IntPtr SetLocalIPBinding;
        public IntPtr GetISteamFriends;
        public IntPtr GetISteamUtils;
        public IntPtr GetISteamMatchmaking;
        public IntPtr GetISteamMasterServerUpdater;
        public IntPtr GetISteamMatchmakingServers;
        public IntPtr GetISteamGenericInterface;
        public IntPtr GetISteamUserStats;
        public IntPtr GetISteamGameServerStats;
        public IntPtr GetISteamApps;
        public IntPtr GetISteamNetworking;
        public IntPtr GetISteamRemoteStorage;
        public IntPtr GetISteamScreenshots;
        public IntPtr RunFrame;
        public IntPtr GetIPCCallCount;
        public IntPtr SetWarningMessageHook;
        public IntPtr BShutdownIfAllPipesClosed;
        public IntPtr GetISteamHTTP;
    }
}
