public struct CLModifyRequest{
  UserInfo info;
  
  [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
  char[] npwd;
}
