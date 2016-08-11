public struct LBModifyRequestBody {
  // --> MySQL
  UserInfo userInfo;
  
  [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]  
  char[] npwd;
}
