
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamGameServer002
    {
        public IntPtr LogOn;
        public IntPtr LogOff;
        public IntPtr BLoggedOn;
        public IntPtr GSSetSpawnCount;
        public IntPtr GSGetSteam2GetEncryptionKeyToSendToNewClient;
        public IntPtr GSSendSteam2UserConnect;
        public IntPtr GSSendSteam3UserConnect;
        public IntPtr GSRemoveUserConnect;
        public IntPtr GSSendUserDisconnect;
        public IntPtr GSSendUserStatusResponse;
        public IntPtr Obsolete_GSSetStatus;
        public IntPtr GSUpdateStatus;
        public IntPtr BSecure;
        public IntPtr GetSteamID;
        public IntPtr GSSetServerType;
        public IntPtr GSSetServerType2;
        public IntPtr GSUpdateStatus2;
        public IntPtr GSCreateUnauthenticatedUser;
        public IntPtr GSSetUserData;
        public IntPtr GSUpdateSpectatorPort;
        public IntPtr GSSetGameType;
    }
}
