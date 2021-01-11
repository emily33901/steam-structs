
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientGameServer
    {
        public IntPtr GetHSteamUser;
        public IntPtr GetHSteamPipe;
        public IntPtr SetSDRLogin;
        public IntPtr InitGameServer;
        public IntPtr SetProduct;
        public IntPtr SetGameDescription;
        public IntPtr SetModDir;
        public IntPtr SetDedicatedServer;
        public IntPtr LogOn;
        public IntPtr LogOnAnonymous;
        public IntPtr LogOff;
        public IntPtr GetSteamID;
        public IntPtr BLoggedOn;
        public IntPtr BSecure;
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
        public IntPtr IsUserSubscribedAppInTicket;
        public IntPtr RequestUserGroupStatus;
        public IntPtr GetGameplayStats;
        public IntPtr GetServerReputation;
        public IntPtr GetPublicIP;
        public IntPtr EnableHeartbeats;
        public IntPtr SetHeartbeatInterval;
        public IntPtr ForceHeartbeat;
        public IntPtr GetLogonState;
        public IntPtr BConnected;
        public IntPtr RaiseConnectionPriority;
        public IntPtr ResetConnectionPriority;
        public IntPtr SetCellID;
        public IntPtr TrackSteamUsageEvent;
        public IntPtr SetCountOfSimultaneousGuestUsersPerSteamAccount;
        public IntPtr EnumerateConnectedUsers;
        public IntPtr AssociateWithClan;
        public IntPtr ComputeNewPlayerCompatibility;
        public IntPtr _BGetUserAchievementStatus;
        public IntPtr _GSSetSpawnCount;
        public IntPtr _GSGetSteam2GetEncryptionKeyToSendToNewClient;
        public IntPtr _GSSendSteam2UserConnect;
        public IntPtr _GSSendSteam3UserConnect;
        public IntPtr _GSSendUserConnect;
        public IntPtr _GSRemoveUserConnect;
        public IntPtr _GSUpdateStatus;
        public IntPtr _GSCreateUnauthenticatedUser;
        public IntPtr _GSSetServerType;
        public IntPtr _SetBasicServerData;
        public IntPtr _GSSendUserDisconnect;
    }
}
