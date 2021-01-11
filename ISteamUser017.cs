
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamUser017
    {
        public IntPtr GetHSteamUser;
        public IntPtr BLoggedOn;
        public IntPtr GetSteamID;
        public IntPtr InitiateGameConnection;
        public IntPtr TerminateGameConnection;
        public IntPtr TrackAppUsageEvent;
        public IntPtr GetUserDataFolder;
        public IntPtr StartVoiceRecording;
        public IntPtr StopVoiceRecording;
        public IntPtr GetAvailableVoice;
        public IntPtr GetVoice;
        public IntPtr DecompressVoice;
        public IntPtr GetVoiceOptimalSampleRate;
        public IntPtr GetAuthSessionTicket;
        public IntPtr BeginAuthSession;
        public IntPtr EndAuthSession;
        public IntPtr CancelAuthTicket;
        public IntPtr UserHasLicenseForApp;
        public IntPtr BIsBehindNAT;
        public IntPtr AdvertiseGame;
        public IntPtr RequestEncryptedAppTicket;
        public IntPtr GetEncryptedAppTicket;
        public IntPtr GetGameBadgeLevel;
        public IntPtr GetPlayerSteamLevel;
    }
}
