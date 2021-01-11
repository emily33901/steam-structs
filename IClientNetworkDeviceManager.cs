
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientNetworkDeviceManager
    {
        public IntPtr IsInterfaceValid;
        public IntPtr RefreshDevices;
        public IntPtr EnumerateNetworkDevices;
        public IntPtr GetDeviceType;
        public IntPtr IsCurrentDevice;
        public IntPtr IsCurrentlyConnected;
        public IntPtr GetDeviceIP4;
        public IntPtr GetDeviceBroadcastIP4;
        public IntPtr GetDeviceIPV6InterfaceIndex;
        public IntPtr GetDeviceVendor;
        public IntPtr GetDeviceProduct;
        public IntPtr GetMacAddress;
        public IntPtr GetSubnetMaskBitCount;
        public IntPtr GetRouterAddressIP4;
        public IntPtr GetDNSResolversIP4;
        public IntPtr GetDeviceState;
        public IntPtr GetDevicePluggedState;
        public IntPtr EnumerateWirelessEndpoints;
        public IntPtr GetConnectedWirelessEndpointSSID;
        public IntPtr GetWirelessSecurityCapabilities;
        public IntPtr GetWirelessEndpointSSIDUserDisplayString;
        public IntPtr GetWirelessEndpointStrength;
        public IntPtr IsSecurityRequired;
        public IntPtr GetCachedWirelessCredentials;
        public IntPtr DisconnectFromDevice;
        public IntPtr SetCustomIPSettings;
        public IntPtr ConnectToDevice;
        public IntPtr IsWirelessEndpointForgettable;
        public IntPtr ForgetWirelessEndpointAutoconnect;
        public IntPtr IsUsingDHCP;
        public IntPtr GetCustomIPSettings;
    }
}
