
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientShader
    {
        public IntPtr BIsShaderManagementEnabled;
        public IntPtr BIsShaderBackgroundProcessingEnabled;
        public IntPtr EnableShaderManagement;
        public IntPtr EnableShaderBackgroundProcessing;
        public IntPtr GetShaderDepotsTotalDiskUsage;
        public IntPtr StartShaderScan;
        public IntPtr StartPipelineBuild;
        public IntPtr StartShaderConversion;
        public IntPtr StartShaderPruning;
        public IntPtr ProcessShaderCache;
        public IntPtr GetShaderCacheProcessingCompletion;
        public IntPtr GetShaderCacheProcessingAppID;
        public IntPtr SkipShaderProcessing;
        public IntPtr BAppHasPendingShaderContentDownload;
        public IntPtr GetAppPendingShaderDownloadSize;
        public IntPtr GetBucketManifest;
        public IntPtr GetStaleBucket;
        public IntPtr ReportExternalBuild;
    }
}
