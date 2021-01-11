
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamController003
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
    }
}
