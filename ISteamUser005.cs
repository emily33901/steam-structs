
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamUser005
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
        public IntPtr SetSteam2Ticket;
        public IntPtr AddServerNetAddress;
        public IntPtr SetEmail;
        public IntPtr SetRegistryString;
        public IntPtr GetRegistryString;
        public IntPtr SetRegistryInt;
        public IntPtr GetRegistryInt;
        public IntPtr InitiateGameConnection;
        public IntPtr TerminateGameConnection;
        public IntPtr SetSelfAsPrimaryChatDestination;
        public IntPtr IsPrimaryChatDestination;
        public IntPtr RequestLegacyCDKey;
        public IntPtr SendGuestPassByEmail;
        public IntPtr SendGuestPassByAccountID;
        public IntPtr AckGuestPass;
        public IntPtr RedeemGuestPass;
        public IntPtr GetGuestPassToGiveCount;
        public IntPtr GetGuestPassToRedeemCount;
        public IntPtr GetGuestPassLastUpdateTime;
        public IntPtr GetGuestPassToGiveInfo;
        public IntPtr GetGuestPassToRedeemInfo;
        public IntPtr GetGuestPassToRedeemSenderAddress;
        public IntPtr GetGuestPassToRedeemSenderName;
        public IntPtr AcknowledgeMessageByGID;
        public IntPtr SetLanguage;
        public IntPtr TrackAppUsageEvent;
        public IntPtr SetAccountName;
        public IntPtr SetPassword;
        public IntPtr SetAccountCreationTime;
    }
}
