public struct CCJoinRequestBody : Body{
  [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)] 
  char[] id;
  
  int roomNumber;
}
