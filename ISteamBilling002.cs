
using System;
using System.Runtime.InteropServices;

namespace SteamStructs {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ISteamBilling002
    {
        public IntPtr InitCreditCardPurchase;
        public IntPtr InitPayPalPurchase;
        public IntPtr GetActivationCodeInfo;
        public IntPtr PurchaseWithActivationCode;
        public IntPtr GetFinalPrice;
        public IntPtr CancelPurchase;
        public IntPtr CompletePurchase;
        public IntPtr UpdateCardInfo;
        public IntPtr DeleteCard;
        public IntPtr GetCardList;
        public IntPtr Obsolete_GetLicenses;
        public IntPtr CancelLicense;
        public IntPtr GetPurchaseReceipts;
        public IntPtr SetBillingAddress;
        public IntPtr GetBillingAddress;
        public IntPtr SetShippingAddress;
        public IntPtr GetShippingAddress;
        public IntPtr SetCardInfo;
        public IntPtr GetCardInfo;
        public IntPtr GetLicensePackageID;
        public IntPtr GetLicenseTimeCreated;
        public IntPtr GetLicenseTimeNextProcess;
        public IntPtr GetLicenseMinuteLimit;
        public IntPtr GetLicenseMinutesUsed;
        public IntPtr GetLicensePaymentMethod;
        public IntPtr GetLicenseFlags;
        public IntPtr GetLicensePurchaseCountryCode;
        public IntPtr GetReceiptPackageID;
        public IntPtr GetReceiptStatus;
        public IntPtr GetReceiptResultDetail;
        public IntPtr GetReceiptTransTime;
        public IntPtr GetReceiptTransID;
        public IntPtr GetReceiptPaymentMethod;
        public IntPtr GetReceiptBaseCost;
        public IntPtr GetReceiptTotalDiscount;
        public IntPtr GetReceiptTax;
        public IntPtr GetReceiptShipping;
        public IntPtr GetReceiptCountryCode;
        public IntPtr GetNumLicenses;
        public IntPtr GetNumReceipts;
        public IntPtr PurchaseWithMachineID;
        public IntPtr InitClickAndBuyPurchase;
        public IntPtr GetPreviousClickAndBuyAccount;
    }
}
