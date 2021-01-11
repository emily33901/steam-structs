
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientBluetoothManager
    {
        public IntPtr SetDiscovering;
        public IntPtr EnumerateDevice;
        public IntPtr GetDeviceType;
        public IntPtr GetDeviceName;
        public IntPtr IsConnected;
        public IntPtr IsPaired;
        public IntPtr Pair;
        public IntPtr UnPair;
        public IntPtr Connect;
        public IntPtr Disconnect;
        public IntPtr IsAvailable;
    }
}
