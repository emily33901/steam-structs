
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamScreenshots003
    {
        public IntPtr WriteScreenshot;
        public IntPtr AddScreenshotToLibrary;
        public IntPtr TriggerScreenshot;
        public IntPtr HookScreenshots;
        public IntPtr SetLocation;
        public IntPtr TagUser;
        public IntPtr TagPublishedFile;
        public IntPtr IsScreenshotsHooked;
        public IntPtr AddVRScreenshotToLibrary;
    }
}
