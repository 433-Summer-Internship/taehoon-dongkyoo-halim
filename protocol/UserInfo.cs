public struct UserInfo{
  [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)] 
  char[] id;
  [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)] 
  char[] pwd;  
  [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
  bool isDummy;  
}
