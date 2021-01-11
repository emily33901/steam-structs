
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamMusic001
    {
        public IntPtr BIsEnabled;
        public IntPtr BIsPlaying;
        public IntPtr GetPlaybackStatus;
        public IntPtr Play;
        public IntPtr Pause;
        public IntPtr PlayPrevious;
        public IntPtr PlayNext;
        public IntPtr SetVolume;
        public IntPtr GetVolume;
    }
}
