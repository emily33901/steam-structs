
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientSharedConnection
    {
        public IntPtr AllocateSharedConnection;
        public IntPtr ReleaseSharedConnection;
        public IntPtr SendMessage;
        public IntPtr SendMessageAndAwaitResponse;
        public IntPtr RegisterEMsgHandler;
        public IntPtr RegisterServiceMethodHandler;
        public IntPtr BPopReceivedMessage;
    }
}
