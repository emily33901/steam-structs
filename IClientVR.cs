
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientVR
    {
        public IntPtr GetCurrentHmd;
        public IntPtr GetCompositor;
        public IntPtr GetOverlay;
        public IntPtr GetChaperone;
        public IntPtr GetSettings;
        public IntPtr GetExternalEventSource;
        public IntPtr GetOverlayHandle;
        public IntPtr IsHmdPresent;
        public IntPtr UpdateHmdStatus;
        public IntPtr IsVRModeActive;
        public IntPtr InitVR;
        public IntPtr StartSteamVR;
        public IntPtr CleanupVR;
        public IntPtr QuitAllVR;
        public IntPtr QuitApplication;
        public IntPtr GetStringForHmdError;
        public IntPtr LaunchApplication;
        public IntPtr GetSteamVRAppId;
        public IntPtr GetSteamVRPid;
        public IntPtr GetWebSecret;
    }
}
