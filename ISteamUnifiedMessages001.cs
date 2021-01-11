
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamUnifiedMessages001
    {
        public IntPtr SendMethod;
        public IntPtr GetMethodResponseInfo;
        public IntPtr GetMethodResponseData;
        public IntPtr ReleaseMethod;
        public IntPtr SendNotification;
    }
}
