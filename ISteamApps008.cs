
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamApps008
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
        public IntPtr RequestAppProofOfPurchaseKey;
        public IntPtr GetCurrentBetaName;
        public IntPtr MarkContentCorrupt;
        public IntPtr GetInstalledDepots;
        public IntPtr GetAppInstallDir;
        public IntPtr BIsAppInstalled;
        public IntPtr GetAppOwner;
        public IntPtr GetLaunchQueryParam;
        public IntPtr GetDlcDownloadProgress;
        public IntPtr GetAppBuildId;
        public IntPtr RequestAllProofOfPurchaseKeys;
        public IntPtr GetFileDetails;
        public IntPtr GetLaunchCommandLine;
        public IntPtr BIsSubscribedFromFamilySharing;
        public IntPtr BIsTimedTrial;
    }
}
