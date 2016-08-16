    public struct ServerInfo
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
        char[] ip;//15
        int port;
    }
