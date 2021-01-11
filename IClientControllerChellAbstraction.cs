
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientControllerChellAbstraction
    {
        public IntPtr SetupController;
        public IntPtr SetControllerIndex;
        public IntPtr TurnOffController;
        public IntPtr OnDisconnect;
        public IntPtr ReadInput;
        public IntPtr GetControllerInfo;
        public IntPtr GetCachedControllerInfo;
        public IntPtr GetControllerHandle;
        public IntPtr ResetCachedControllerDetails;
        public IntPtr GetChipId;
        public IntPtr ProcessState;
        public IntPtr ProcessActivityFromState;
        public IntPtr UpdateStateTimestamps;
        public IntPtr GetWirelessEvent;
        public IntPtr GetStatus;
        public IntPtr SetSettings;
        public IntPtr SetUserLedColor;
        public IntPtr SetControllerSlot;
        public IntPtr GetStickExtents;
        public IntPtr SetStickExtents;
        public IntPtr ResetStickExtents;
        public IntPtr TriggerHapticPulse;
        public IntPtr FinishInitialization;
        public IntPtr SetRumble;
        public IntPtr SendIRCode;
        public IntPtr StopIR;
        public IntPtr BRecentlyActive;
        public IntPtr IsStreamingController;
        public IntPtr SetTimeInTicks;
        public IntPtr SetFloatTime;
        public IntPtr GetSocket;
        public IntPtr GetType;
        public IntPtr BHapticsCapable;
        public IntPtr BRumbleCapable;
        public IntPtr D_CSteamControllerChellAbstraction;
        public IntPtr D_CSteamControllerChellAbstraction2;
    }
}
