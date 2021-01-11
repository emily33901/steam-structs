
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientControllerProtocolHandlerV1
    {
        public IntPtr D_CSteamControllerProtocolHandlerV1;
        public IntPtr D_CSteamControllerProtocolHandlerV12;
        public IntPtr BIsRemote;
        public IntPtr GetPlatform;
        public IntPtr ReadInput;
        public IntPtr WriteOutput;
        public IntPtr WriteCommand;
        public IntPtr ReadCommand;
        public IntPtr WriteFeatureReport;
        public IntPtr ReadFeatureReport;
        public IntPtr Disconnect;
        public IntPtr GetStreamingSessionID;
        public IntPtr GetSerialString;
        public IntPtr GetProductString;
        public IntPtr GetFeatureReportWriteSize;
        public IntPtr GetFeatureReportReadSize;
    }
}
