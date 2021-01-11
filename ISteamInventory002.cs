
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamInventory002
    {
        public IntPtr GetResultStatus;
        public IntPtr GetResultItems;
        public IntPtr GetResultItemProperty;
        public IntPtr GetResultTimestamp;
        public IntPtr CheckResultSteamID;
        public IntPtr DestroyResult;
        public IntPtr GetAllItems;
        public IntPtr GetItemsByID;
        public IntPtr SerializeResult;
        public IntPtr DeserializeResult;
        public IntPtr GenerateItems;
        public IntPtr GrantPromoItems;
        public IntPtr AddPromoItem;
        public IntPtr AddPromoItems;
        public IntPtr ConsumeItem;
        public IntPtr ExchangeItems;
        public IntPtr TransferItemQuantity;
        public IntPtr SendItemDropHeartbeat;
        public IntPtr TriggerItemDrop;
        public IntPtr TradeItems;
        public IntPtr LoadItemDefinitions;
        public IntPtr GetItemDefinitionIDs;
        public IntPtr GetItemDefinitionProperty;
        public IntPtr RequestEligiblePromoItemDefinitionsIDs;
        public IntPtr GetEligiblePromoItemDefinitionIDs;
        public IntPtr StartPurchase;
        public IntPtr RequestPrices;
        public IntPtr GetNumItemsWithPrices;
        public IntPtr GetItemsWithPrices;
        public IntPtr GetItemPrice;
        public IntPtr StartUpdateProperties;
        public IntPtr RemoveProperty;
        public IntPtr SetProperty;
        public IntPtr SetProperty2;
        public IntPtr SetProperty3;
        public IntPtr SetProperty4;
        public IntPtr SubmitUpdateProperties;
    }
}
