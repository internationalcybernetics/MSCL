//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace mscl {

public class mscl {
  public static Version MSCL_VERSION {
    get {
      global::System.IntPtr cPtr = msclPINVOKE.MSCL_VERSION_get();
      Version ret = (cPtr == global::System.IntPtr.Zero) ? null : new Version(cPtr, false);
      if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}

}
