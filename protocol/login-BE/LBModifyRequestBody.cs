public struct LBModifyRequestBody {
  UserInfo userInfo;
  
  [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]  
  char[] npwd;
}
