
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamHTTP001
    {
        public IntPtr CreateHTTPRequest;
        public IntPtr SetHTTPRequestContextValue;
        public IntPtr SetHTTPRequestNetworkActivityTimeout;
        public IntPtr SetHTTPRequestHeaderValue;
        public IntPtr SetHTTPRequestGetOrPostParameter;
        public IntPtr SendHTTPRequest;
        public IntPtr DeferHTTPRequest;
        public IntPtr PrioritizeHTTPRequest;
        public IntPtr GetHTTPResponseHeaderSize;
        public IntPtr GetHTTPResponseHeaderValue;
        public IntPtr GetHTTPResponseBodySize;
        public IntPtr GetHTTPResponseBodyData;
        public IntPtr ReleaseHTTPRequest;
        public IntPtr GetHTTPDownloadProgressPct;
        public IntPtr SetHTTPRequestRawPostBody;
    }
}
