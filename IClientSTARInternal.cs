
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientSTARInternal
    {
        public IntPtr SendSerializedMessage;
        public IntPtr GetMessageResponse;
    }
}
