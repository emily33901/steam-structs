class ISteamNetworking001 {
	virtual unknown_ret CreateListenSocket(int, unsigned int, unsigned short) = 0;
	virtual unknown_ret CreateP2PConnectionSocket(CSteamID, int, int) = 0;
	virtual unknown_ret CreateConnectionSocket(unsigned int, unsigned short, int) = 0;
	virtual unknown_ret DestroySocket(unsigned int, bool) = 0;
	virtual unknown_ret DestroyListenSocket(unsigned int, bool) = 0;
	virtual unknown_ret SendDataOnSocket(unsigned int, void*, unsigned int, bool) = 0;
	virtual unknown_ret IsDataAvailableOnSocket(unsigned int, unsigned int*) = 0;
	virtual unknown_ret RetrieveDataFromSocket(unsigned int, void*, unsigned int, unsigned int*) = 0;
	virtual unknown_ret IsDataAvailable(unsigned int, unsigned int*, unsigned int*) = 0;
	virtual unknown_ret RetrieveData(unsigned int, void*, unsigned int, unsigned int*, unsigned int*) = 0;
	virtual unknown_ret GetSocketInfo(unsigned int, CSteamID*, int*, unsigned int*, unsigned short*) = 0;
	virtual unknown_ret GetListenSocketInfo(unsigned int, unsigned int*, unsigned short*) = 0;
};
