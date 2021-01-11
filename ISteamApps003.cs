
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamApps003
    {
        public IntPtr BIsSubscribed;
        public IntPtr BIsLowViolence;
        public IntPtr BIsCybercafe;
        public IntPtr BIsVACBanned;
        public IntPtr GetCurrentGameLanguage;
        public IntPtr GetAvailableGameLanguages;
        public IntPtr BIsSubscribedApp;
        public IntPtr BIsDlcInstalled;
    }
}
