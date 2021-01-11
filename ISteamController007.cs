
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamController007
    {
        public IntPtr Init;
        public IntPtr Shutdown;
        public IntPtr RunFrame;
        public IntPtr GetConnectedControllers;
        public IntPtr GetActionSetHandle;
        public IntPtr ActivateActionSet;
        public IntPtr GetCurrentActionSet;
        public IntPtr ActivateActionSetLayer;
        public IntPtr DeactivateActionSetLayer;
        public IntPtr DeactivateAllActionSetLayers;
        public IntPtr GetActiveActionSetLayers;
        public IntPtr GetDigitalActionHandle;
        public IntPtr GetDigitalActionData;
        public IntPtr GetDigitalActionOrigins;
        public IntPtr GetAnalogActionHandle;
        public IntPtr GetAnalogActionData;
        public IntPtr GetAnalogActionOrigins;
        public IntPtr GetGlyphForActionOrigin;
        public IntPtr GetStringForActionOrigin;
        public IntPtr StopAnalogActionMomentum;
        public IntPtr GetMotionData;
        public IntPtr TriggerHapticPulse;
        public IntPtr TriggerRepeatedHapticPulse;
        public IntPtr TriggerVibration;
        public IntPtr SetLEDColor;
        public IntPtr ShowBindingPanel;
        public IntPtr GetInputTypeForHandle;
        public IntPtr GetControllerForGamepadIndex;
        public IntPtr GetGamepadIndexForController;
        public IntPtr GetStringForXboxOrigin;
        public IntPtr GetGlyphForXboxOrigin;
        public IntPtr GetActionOriginFromXboxOrigin;
        public IntPtr TranslateActionOrigin;
        public IntPtr GetControllerBindingRevision;
    }
}
