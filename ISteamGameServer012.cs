
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamGameServer012
    {
        public IntPtr InitGameServer;
        public IntPtr SetProduct;
        public IntPtr SetGameDescription;
        public IntPtr SetModDir;
        public IntPtr SetDedicatedServer;
        public IntPtr LogOn;
        public IntPtr LogOnAnonymous;
        public IntPtr LogOff;
        public IntPtr BLoggedOn;
        public IntPtr BSecure;
        public IntPtr GetSteamID;
        public IntPtr WasRestartRequested;
        public IntPtr SetMaxPlayerCount;
        public IntPtr SetBotPlayerCount;
        public IntPtr SetServerName;
        public IntPtr SetMapName;
        public IntPtr SetPasswordProtected;
        public IntPtr SetSpectatorPort;
        public IntPtr SetSpectatorServerName;
        public IntPtr ClearAllKeyValues;
        public IntPtr SetKeyValue;
        public IntPtr SetGameTags;
        public IntPtr SetGameData;
        public IntPtr SetRegion;
        public IntPtr SendUserConnectAndAuthenticate;
        public IntPtr CreateUnauthenticatedUserConnection;
        public IntPtr SendUserDisconnect;
        public IntPtr BUpdateUserData;
        public IntPtr GetAuthSessionTicket;
        public IntPtr BeginAuthSession;
        public IntPtr EndAuthSession;
        public IntPtr CancelAuthTicket;
        public IntPtr UserHasLicenseForApp;
        public IntPtr RequestUserGroupStatus;
        public IntPtr GetGameplayStats;
        public IntPtr GetServerReputation;
        public IntPtr GetPublicIP;
        public IntPtr HandleIncomingPacket;
        public IntPtr GetNextOutgoingPacket;
        public IntPtr EnableHeartbeats;
        public IntPtr SetHeartbeatInterval;
        public IntPtr ForceHeartbeat;
        public IntPtr AssociateWithClan;
        public IntPtr ComputeNewPlayerCompatibility;
    }
}
