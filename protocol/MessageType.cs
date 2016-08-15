public class MessageType{

  public const short CHATTING          = 200; // normal msg  
  
  // Membership : 300번대 
  public const short SIGNUP       = 310; // signup req
  public const short SIGNIN       = 320; // login req
  public const short MODIFY = 330; // modify 
  public const short DELETE = 340;// delete 
  
  // Chatting Room : 400번대
  public const short LIST         = 400; // room list req
  public const short JOIN         = 410; // join room req
  public const short LEAVE        = 420; // leave room req
  public const short CREATE       = 430; // create room req
  
  
  // Admin tool : 500번대 
  public const short START = 500;
  public const short SHUTDOWN = 510;
  public const short RESTART = 520;
  
  /*
  Monitoring 
  */
  
  public const short HEARTBEAT    = 800; // heartbeat
			
}
