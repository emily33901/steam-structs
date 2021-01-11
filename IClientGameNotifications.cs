
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientGameNotifications
    {
        public IntPtr EnumerateNotifications;
        public IntPtr GetNotificationCount;
        public IntPtr GetNotification;
        public IntPtr RemoveSession;
        public IntPtr UpdateSession;
    }
}
