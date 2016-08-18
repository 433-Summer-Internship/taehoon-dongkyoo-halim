public struct CLModifyRequestBody : Body{
  // UserInfo info;
  
  [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
  char[] npwd;
}
