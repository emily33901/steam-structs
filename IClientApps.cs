
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientApps
    {
        public IntPtr GetAppData;
        public IntPtr SetLocalAppConfig;
        public IntPtr GetInternalAppIDFromGameID;
        public IntPtr GetAllOwnedMultiplayerApps;
        public IntPtr GetAvailableLaunchOptions;
        public IntPtr GetAppDataSection;
        public IntPtr GetMultipleAppDataSections;
        public IntPtr RequestAppInfoUpdate;
        public IntPtr GetDLCCount;
        public IntPtr BGetDLCDataByIndex;
        public IntPtr GetAppType;
        public IntPtr GetStoreTagLocalization;
    }
}
