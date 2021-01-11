
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientUnifiedMessages
    {
        public IntPtr SendMethod;
        public IntPtr GetMethodResponseInfo;
        public IntPtr GetMethodResponseData;
        public IntPtr ReleaseMethod;
        public IntPtr SendNotification;
    }
}
