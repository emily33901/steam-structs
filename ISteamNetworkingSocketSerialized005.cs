
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamNetworkingSocketSerialized005
    {
        public IntPtr SendP2PRendezvous;
        public IntPtr SendP2PConnectionFailureLegacy;
        public IntPtr GetCertAsync;
        public IntPtr GetNetworkConfigJSON_DEPRECATED;
        public IntPtr CacheRelayTicket;
        public IntPtr GetCachedRelayTicketCount;
        public IntPtr GetCachedRelayTicket;
        public IntPtr PostConnectionStateMsg;
        public IntPtr GetSTUNServer;
        public IntPtr AllowDirectConnectToPeer;
        public IntPtr BeginAsyncRequestFakeIP;
    }
}
