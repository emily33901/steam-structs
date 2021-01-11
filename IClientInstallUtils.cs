
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientInstallUtils
    {
        public IntPtr SetUniverse;
        public IntPtr AddShortcut;
        public IntPtr RemoveShortcut;
        public IntPtr AddUninstallEntry;
        public IntPtr RemoveUninstallEntry;
        public IntPtr AddToFirewall;
        public IntPtr RemoveFromFirewall;
        public IntPtr RegisterSteamProtocolHandler;
        public IntPtr AddInstallScriptToWhiteList;
        public IntPtr RunInstallScript;
        public IntPtr GetInstallScriptExitCode;
        public IntPtr ConfigureNetworDeviceIPAddresses;
    }
}
