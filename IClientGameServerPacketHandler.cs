
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientGameServerPacketHandler
    {
        public IntPtr HandleIncomingPacket;
        public IntPtr GetNextOutgoingPacket;
    }
}
