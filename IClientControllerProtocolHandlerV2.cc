class IClientControllerProtocolHandlerV2 {
	virtual unknown_ret D_CSteamControllerProtocolHandlerV2() = 0;
	virtual unknown_ret D_CSteamControllerProtocolHandlerV2() = 0;
	virtual unknown_ret BIsRemote() = 0;
	virtual unknown_ret GetPlatform() = 0;
	virtual unknown_ret ReadInput(unsigned char*, unsigned long, int) = 0;
	virtual unknown_ret WriteOutput(unsigned char const*, unsigned long) = 0;
	virtual unknown_ret WriteCommand(unsigned char const*, unsigned long) = 0;
	virtual unknown_ret ReadCommand(unsigned char*, unsigned long) = 0;
	virtual unknown_ret WriteFeatureReport(unsigned char, unsigned char const*, unsigned long) = 0;
	virtual unknown_ret ReadFeatureReport(unsigned char, unsigned char*, unsigned long) = 0;
	virtual unknown_ret Disconnect(EHIDDeviceDisconnectMethod, unsigned char const*, unsigned long) = 0;
	virtual unknown_ret GetStreamingSessionID() = 0;
	virtual unknown_ret GetSerialString() = 0;
	virtual unknown_ret GetProductString() = 0;
	virtual unknown_ret GetFeatureReportWriteSize() = 0;
	virtual unknown_ret GetFeatureReportReadSize() = 0;
};
