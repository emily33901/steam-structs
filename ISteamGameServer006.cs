
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamGameServer006
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
        public IntPtr SetGameType;
        public IntPtr BGetUserAchievementStatus;
        public IntPtr GetGameplayStats;
    }
}
