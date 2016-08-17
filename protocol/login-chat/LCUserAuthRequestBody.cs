public struct LCUserAuthRequestBody {
  Cookie cookie;
  UserInfo userInfo; // use only id 
  /*
  [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)] 
  char[] id;
  */
}
