
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamController005
    {
        public IntPtr Init;
        public IntPtr Shutdown;
        public IntPtr RunFrame;
        public IntPtr GetConnectedControllers;
        public IntPtr ShowBindingPanel;
        public IntPtr GetActionSetHandle;
        public IntPtr ActivateActionSet;
        public IntPtr GetCurrentActionSet;
        public IntPtr GetDigitalActionHandle;
        public IntPtr GetDigitalActionData;
        public IntPtr GetDigitalActionOrigins;
        public IntPtr GetAnalogActionHandle;
        public IntPtr GetAnalogActionData;
        public IntPtr GetAnalogActionOrigins;
        public IntPtr StopAnalogActionMomentum;
        public IntPtr TriggerHapticPulse;
        public IntPtr TriggerRepeatedHapticPulse;
        public IntPtr TriggerVibration;
        public IntPtr SetLEDColor;
        public IntPtr GetGamepadIndexForController;
        public IntPtr GetControllerForGamepadIndex;
        public IntPtr GetMotionData;
        public IntPtr ShowDigitalActionOrigins;
        public IntPtr ShowAnalogActionOrigins;
        public IntPtr GetStringForActionOrigin;
        public IntPtr GetGlyphForActionOrigin;
    }
}
