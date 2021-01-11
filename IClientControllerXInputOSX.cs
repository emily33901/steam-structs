
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientControllerXInputOSX
    {
        public IntPtr D_CSteamControllerXInputOSX;
        public IntPtr D_CSteamControllerXInputOSX2;
        public IntPtr SetDefaultControllerEnabledMask;
        public IntPtr BAllocateHandle;
        public IntPtr DeallocateHandle;
        public IntPtr BIsConnected;
        public IntPtr SetConnected;
        public IntPtr SetDeviceInfo;
        public IntPtr SendGamePadButtonEvent;
        public IntPtr SendAxisEvent;
        public IntPtr SetEnabledByAppID;
        public IntPtr BGetRumbleRequest;
        public IntPtr GetGamepadIndex;
        public IntPtr GetGamepadIndexForXInputIndex;
        public IntPtr GetGamepadIndexChangeCounter;
        public IntPtr BSwapGamepadIndex;
        public IntPtr SendActivity;
        public IntPtr SendEndOfFrame;
        public IntPtr Validate;
    }
}
