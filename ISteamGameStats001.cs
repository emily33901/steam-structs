
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamGameStats001
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
        public IntPtr AddRowAtributeString;
        public IntPtr AddRowAttributeFloat;
        public IntPtr AddSessionAttributeInt64;
        public IntPtr AddRowAttributeInt64;
    }
}
