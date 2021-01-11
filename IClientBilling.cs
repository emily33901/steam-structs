
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientBilling
    {
        public IntPtr PurchaseWithActivationCode;
        public IntPtr HasActiveLicense;
        public IntPtr GetLicenseInfo;
        public IntPtr EnableTestLicense;
        public IntPtr DisableTestLicense;
        public IntPtr GetAppsInPackage;
        public IntPtr RequestFreeLicenseForApps;
    }
}
