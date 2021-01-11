
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientModuleManager
    {
        public IntPtr LoadModule;
        public IntPtr UnloadModule;
        public IntPtr CallFunction;
        public IntPtr CallFunctionAsync;
        public IntPtr PollResponseAsync;
    }
}
