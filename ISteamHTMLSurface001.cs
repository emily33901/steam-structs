
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamHTMLSurface001
    {
        public IntPtr D_CAdapterSteamHTMLSurface001;
        public IntPtr D_CAdapterSteamHTMLSurface0012;
        public IntPtr Init;
        public IntPtr Shutdown;
        public IntPtr CreateBrowser;
        public IntPtr RemoveBrowser;
        public IntPtr LoadURL;
        public IntPtr SetSize;
        public IntPtr StopLoad;
        public IntPtr Reload;
        public IntPtr GoBack;
        public IntPtr GoForward;
        public IntPtr AddHeader;
        public IntPtr ExecuteJavascript;
        public IntPtr MouseUp;
        public IntPtr MouseDown;
        public IntPtr MouseDoubleClick;
        public IntPtr MouseMove;
        public IntPtr MouseWheel;
        public IntPtr KeyDown;
        public IntPtr KeyUp;
        public IntPtr KeyChar;
        public IntPtr SetHorizontalScroll;
        public IntPtr SetVerticalScroll;
        public IntPtr SetKeyFocus;
        public IntPtr ViewSource;
        public IntPtr CopyToClipboard;
        public IntPtr PasteFromClipboard;
        public IntPtr Find;
        public IntPtr StopFind;
        public IntPtr GetLinkAtPosition;
        public IntPtr AllowStartRequest;
        public IntPtr JSDialogResponse;
        public IntPtr FileLoadDialogResponse;
    }
}
