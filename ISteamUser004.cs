
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamUser004
    {
        public IntPtr GetHSteamUser;
        public IntPtr LogOn;
        public IntPtr LogOff;
        public IntPtr BLoggedOn;
        public IntPtr GetLogonState;
        public IntPtr BConnected;
        public IntPtr GetSteamID;
        public IntPtr IsVACBanned;
        public IntPtr RequireShowVACBannedMessage;
        public IntPtr AcknowledgeVACBanning;
        public IntPtr NClientGameIDAdd;
        public IntPtr RemoveClientGame;
        public IntPtr SetClientGameServer;
        public IntPtr SetSteam2Ticket;
        public IntPtr AddServerNetAddress;
        public IntPtr SetEmail;
        public IntPtr GetSteamGameConnectToken;
        public IntPtr SetRegistryString;
        public IntPtr GetRegistryString;
        public IntPtr SetRegistryInt;
        public IntPtr GetRegistryInt;
        public IntPtr InitiateGameConnection;
        public IntPtr TerminateGameConnection;
        public IntPtr SetSelfAsPrimaryChatDestination;
        public IntPtr IsPrimaryChatDestination;
        public IntPtr RequestLegacyCDKey;
    }
}
