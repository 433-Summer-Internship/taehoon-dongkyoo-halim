using LunkerLibrary.common.protocol;

public struct LCFENoticeRequestBody
{
    ServerInfo serverInfo;

    public LCFENoticeRequestBody(ServerInfo serverInfo)
    {
        this.serverInfo = serverInfo;
    }

    public ServerInfo ServerInfo
    {
        get { return serverInfo; }
        set { serverInfo = value; }
    }

}
