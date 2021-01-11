
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamGameServer010
    {
        public IntPtr LogOn;
        public IntPtr LogOff;
        public IntPtr BLoggedOn;
        public IntPtr BSecure;
        public IntPtr GetSteamID;
        public IntPtr SendUserConnectAndAuthenticate;
        public IntPtr CreateUnauthenticatedUserConnection;
        public IntPtr SendUserDisconnect;
        public IntPtr BUpdateUserData;
        public IntPtr BSetServerType;
        public IntPtr UpdateServerStatus;
        public IntPtr UpdateSpectatorPort;
        public IntPtr SetGameTags;
        public IntPtr GetGameplayStats;
        public IntPtr GetServerReputation;
        public IntPtr RequestUserGroupStatus;
        public IntPtr GetPublicIP;
        public IntPtr SetGameData;
        public IntPtr UserHasLicenseForApp;
        public IntPtr GetAuthSessionTicket;
        public IntPtr BeginAuthSession;
        public IntPtr EndAuthSession;
        public IntPtr CancelAuthTicket;
    }
}
