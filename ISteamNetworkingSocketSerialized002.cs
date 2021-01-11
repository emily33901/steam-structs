
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamNetworkingSocketSerialized002
    {
        public IntPtr SendP2PRendezvous;
        public IntPtr SendP2PConnectionFailure;
        public IntPtr GetCertAsync;
        public IntPtr GetNetworkConfigJSON;
        public IntPtr CacheRelayTicket;
        public IntPtr GetCachedRelayTicketCount;
        public IntPtr GetCachedRelayTicket;
        public IntPtr PostConnectionStateMsg;
    }
}
