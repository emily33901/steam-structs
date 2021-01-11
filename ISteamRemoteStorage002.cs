
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamRemoteStorage002
    {
        public IntPtr FileWrite;
        public IntPtr GetFileSize;
        public IntPtr FileRead;
        public IntPtr FileExists;
        public IntPtr GetFileCount;
        public IntPtr GetFileNameAndSize;
        public IntPtr GetQuota;
    }
}
