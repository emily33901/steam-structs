
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamGameServer003
    {
        public IntPtr LogOn;
        public IntPtr LogOff;
        public IntPtr BLoggedOn;
        public IntPtr BSecure;
        public IntPtr GetSteamID;
        public IntPtr GSGetSteam2GetEncryptionKeyToSendToNewClient;
        public IntPtr GSSendUserConnect;
        public IntPtr GSRemoveUserConnect;
        public IntPtr GSSendUserDisconnect;
        public IntPtr GSSetSpawnCount;
        public IntPtr GSSetServerType;
        public IntPtr GSUpdateStatus;
        public IntPtr GSCreateUnauthenticatedUser;
        public IntPtr GSSetUserData;
        public IntPtr GSUpdateSpectatorPort;
        public IntPtr GSSetGameType;
        public IntPtr GSGetUserAchievementStatus;
    }
}
