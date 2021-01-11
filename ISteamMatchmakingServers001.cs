
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamMatchmakingServers001
    {
        public IntPtr RequestInternetServerList;
        public IntPtr RequestLANServerList;
        public IntPtr RequestFriendsServerList;
        public IntPtr RequestFavoritesServerList;
        public IntPtr RequestHistoryServerList;
        public IntPtr RequestSpectatorServerList;
        public IntPtr GetServerDetails;
        public IntPtr CancelQuery;
        public IntPtr RefreshQuery;
        public IntPtr IsRefreshing;
        public IntPtr GetServerCount;
        public IntPtr RefreshServer;
        public IntPtr PingServer;
        public IntPtr PlayerDetails;
        public IntPtr ServerRules;
        public IntPtr CancelServerQuery;
    }
}
