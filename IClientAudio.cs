
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientAudio
    {
        public IntPtr StartVoiceRecording;
        public IntPtr StopVoiceRecording;
        public IntPtr ResetVoiceRecording;
        public IntPtr GetAvailableVoice;
        public IntPtr GetVoice;
        public IntPtr GetCompressedVoice;
        public IntPtr DecompressVoice;
        public IntPtr GetVoiceOptimalSampleRate;
        public IntPtr BAppUsesVoice;
        public IntPtr GetGameSystemVolume;
        public IntPtr SetGameSystemVolume;
    }
}
