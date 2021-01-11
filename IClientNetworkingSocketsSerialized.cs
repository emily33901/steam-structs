
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientNetworkingSocketsSerialized
    {
        public IntPtr SendP2PRendezvous;
        public IntPtr SendP2PConnectionFailureLegacy;
        public IntPtr GetCertAsync;
        public IntPtr CacheRelayTicket;
        public IntPtr GetCachedRelayTicketCount;
        public IntPtr GetCachedRelayTicket;
        public IntPtr PostConnectionStateMsg;
        public IntPtr GetSTUNServer;
        public IntPtr AllowDirectConnectToPeerString;
        public IntPtr BeginAsyncRequestFakeIP;
        public IntPtr AllowDirectConnectToPeer;
        public IntPtr SetAllowShareIPUserSetting;
        public IntPtr GetAllowShareIPUserSetting;
        public IntPtr TEST_ClearInMemoryCachedCredentials;
    }
}
