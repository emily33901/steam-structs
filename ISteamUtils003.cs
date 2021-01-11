
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamUtils003
    {
        public IntPtr GetSecondsSinceAppActive;
        public IntPtr GetSecondsSinceComputerActive;
        public IntPtr GetConnectedUniverse;
        public IntPtr GetServerRealTime;
        public IntPtr GetIPCountry;
        public IntPtr GetImageSize;
        public IntPtr GetImageRGBA;
        public IntPtr GetCSERIPPort;
        public IntPtr GetCurrentBatteryPower;
        public IntPtr GetAppID;
        public IntPtr SetOverlayNotificationPosition;
        public IntPtr IsAPICallCompleted;
        public IntPtr GetAPICallFailureReason;
        public IntPtr GetAPICallResult;
        public IntPtr RunFrame;
        public IntPtr GetIPCCallCount;
        public IntPtr SetWarningMessageHook;
    }
}
