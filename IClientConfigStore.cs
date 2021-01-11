
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientConfigStore
    {
        public IntPtr IsSet;
        public IntPtr GetBool;
        public IntPtr GetInt;
        public IntPtr GetUint64;
        public IntPtr GetFloat;
        public IntPtr GetString;
        public IntPtr GetBinary;
        public IntPtr GetBinary2;
        public IntPtr GetBinaryWatermarked;
        public IntPtr SetBool;
        public IntPtr SetInt;
        public IntPtr SetUint64;
        public IntPtr SetFloat;
        public IntPtr SetString;
        public IntPtr SetBinary;
        public IntPtr SetBinaryWatermarked;
        public IntPtr RemoveKey;
        public IntPtr GetKeySerialized;
        public IntPtr FlushToDisk;
    }
}
