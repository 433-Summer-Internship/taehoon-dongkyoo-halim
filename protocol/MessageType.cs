public enum MessageType
{
    // connection setup between client ~ chat server 
    ConnectionSetup = 100,

    // chatting 
    Chatting = 200,

    // Membership : 300번대 
    Signup = 310,
    Signin = 320,
    Logout = 330,
    Modify = 340,
    Delete = 350,

    // Chatting Room : 400번대
    ListRoom = 400,
    JoinRoom = 410,
    LeaveRoom = 420,
    CreateRoom = 430,

    // Admin tool : 500번대 
    StartApp = 500,
    ShutdownApp = 510,
    RestartApp = 520,

    /*
    Monitoring 
    */
    
    
    Auth = 600, // for login~chat
    FENotice = 610, // for login ~ chat 
    VerifyCookie = 620,
    AgentInfo = 630,
    // Heartbeat 
    Heartbeat = 800
}
