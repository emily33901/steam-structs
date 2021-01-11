
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientProductBuilder
    {
        public IntPtr SignInstallScript;
        public IntPtr DRMWrap;
        public IntPtr CEGWrap;
    }
}
