
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientSecureDesktop
    {
        public IntPtr BStartStreaming;
        public IntPtr StopStreaming;
        public IntPtr SendSAS;
    }
}
