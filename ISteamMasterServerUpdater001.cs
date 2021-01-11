
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamMasterServerUpdater001
    {
        public IntPtr SetActive;
        public IntPtr SetHeartbeatInterval;
        public IntPtr HandleIncomingPacket;
        public IntPtr GetNextOutgoingPacket;
        public IntPtr SetBasicServerData;
        public IntPtr ClearAllKeyValues;
        public IntPtr SetKeyValue;
        public IntPtr NotifyShutdown;
        public IntPtr WasRestartRequested;
        public IntPtr ForceHeartbeat;
        public IntPtr AddMasterServer;
        public IntPtr RemoveMasterServer;
        public IntPtr GetNumMasterServers;
        public IntPtr GetMasterServerAddress;
    }
}
