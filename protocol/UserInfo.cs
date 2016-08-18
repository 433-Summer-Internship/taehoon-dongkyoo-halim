public struct UserInfo{
  [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)] 
  char[] id;
  [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)] 
  char[] pwd;  
  bool isDummy;  
}
