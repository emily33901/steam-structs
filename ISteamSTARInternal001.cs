
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamSTARInternal001
    {
        public IntPtr SendSerializedMessage;
        public IntPtr GetMessageResponse;
    }
}
