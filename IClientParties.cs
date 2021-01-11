
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct IClientParties
    {
        public IntPtr GetNumActiveBeacons;
        public IntPtr GetBeaconByIndex;
        public IntPtr GetBeaconDetails;
        public IntPtr JoinParty;
        public IntPtr GetNumAvailableBeaconLocations;
        public IntPtr GetAvailableBeaconLocations;
        public IntPtr CreateBeacon;
        public IntPtr OnReservationCompleted;
        public IntPtr CancelReservation;
        public IntPtr ChangeNumOpenSlots;
        public IntPtr DestroyBeacon;
        public IntPtr GetBeaconLocationData;
        public IntPtr ReservePartySlot;
    }
}
