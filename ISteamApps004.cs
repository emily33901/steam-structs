
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamApps004
    {
        public IntPtr BIsSubscribed;
        public IntPtr BIsLowViolence;
        public IntPtr BIsCybercafe;
        public IntPtr BIsVACBanned;
        public IntPtr GetCurrentGameLanguage;
        public IntPtr GetAvailableGameLanguages;
        public IntPtr BIsSubscribedApp;
        public IntPtr BIsDlcInstalled;
        public IntPtr GetEarliestPurchaseUnixTime;
        public IntPtr BIsSubscribedFromFreeWeekend;
        public IntPtr GetDLCCount;
        public IntPtr BGetDLCDataByIndex;
        public IntPtr InstallDLC;
        public IntPtr UninstallDLC;
    }
}
