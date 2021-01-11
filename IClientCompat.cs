
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientCompat
    {
        public IntPtr BIsCompatLayerEnabled;
        public IntPtr EnableCompat;
        public IntPtr GetAvailableCompatTools;
        public IntPtr GetAvailableCompatToolsFiltered;
        public IntPtr GetAvailableCompatToolsForApp;
        public IntPtr SpecifyCompatTool;
        public IntPtr BIsCompatibilityToolEnabled;
        public IntPtr GetCompatToolName;
        public IntPtr GetCompatToolMappingPriority;
        public IntPtr GetCompatToolDisplayName;
        public IntPtr GetWhitelistedGameList;
        public IntPtr GetControllerConfigOverrides;
        public IntPtr StartSession;
        public IntPtr ReleaseSession;
    }
}
