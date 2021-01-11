
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientDepotBuilder
    {
        public IntPtr BGetDepotBuildStatus;
        public IntPtr VerifyChunkStore;
        public IntPtr DownloadDepot;
        public IntPtr StartDepotBuild;
        public IntPtr CommitAppBuild;
    }
}
