
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientGameStats
    {
        public IntPtr GetNewSession;
        public IntPtr EndSession;
        public IntPtr AddSessionAttributeInt;
        public IntPtr AddSessionAttributeString;
        public IntPtr AddSessionAttributeFloat;
        public IntPtr AddNewRow;
        public IntPtr CommitRow;
        public IntPtr CommitOutstandingRows;
        public IntPtr AddRowAttributeInt;
        public IntPtr AddRowAttributeString;
        public IntPtr AddRowAttributeFloat;
        public IntPtr AddSessionAttributeInt64;
        public IntPtr AddRowAttributeInt64;
    }
}
