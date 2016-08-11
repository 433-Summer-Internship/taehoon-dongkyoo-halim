public struct LCNotifyUserRequestBody {
  Cookie cookie;
  
  [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)] 
  char[] id;
}
