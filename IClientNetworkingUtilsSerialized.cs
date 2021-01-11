
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientNetworkingUtilsSerialized
    {
        public IntPtr GetNetworkConfigJSON_DEPRECATED;
        public IntPtr GetLauncherType;
        public IntPtr TEST_ClearCachedNetworkConfig;
    }
}
