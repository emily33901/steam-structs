
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamUtils009
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
        public IntPtr IsOverlayEnabled;
        public IntPtr BOverlayNeedsPresent;
        public IntPtr CheckFileSignature;
        public IntPtr ShowGamepadTextInput;
        public IntPtr GetEnteredGamepadTextLength;
        public IntPtr GetEnteredGamepadTextInput;
        public IntPtr GetSteamUILanguage;
        public IntPtr IsSteamRunningInVR;
        public IntPtr SetOverlayNotificationInset;
        public IntPtr IsSteamInBigPictureMode;
        public IntPtr StartVRDashboard;
        public IntPtr IsVRHeadsetStreamingEnabled;
        public IntPtr SetVRHeadsetStreamingEnabled;
        public IntPtr IsSteamChinaLauncher;
        public IntPtr InitFilterText;
        public IntPtr FilterText;
        public IntPtr GetIPv6ConnectivityState;
    }
}
