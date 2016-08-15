public enum MessageType
{
    Chatting = 200,

    // Membership : 300번대 
    Signup = 310,
    Signin = 320,
    Modify = 330,
    Delete = 340,

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

    // Heartbeat 
    Heartbeat = 800
}
