//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace GraphMolWrap {

public class UFFBond : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UFFBond(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UFFBond obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UFFBond() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RDKFuncsPINVOKE.delete_UFFBond(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public double kb {
    set {
      RDKFuncsPINVOKE.UFFBond_kb_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = RDKFuncsPINVOKE.UFFBond_kb_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double r0 {
    set {
      RDKFuncsPINVOKE.UFFBond_r0_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = RDKFuncsPINVOKE.UFFBond_r0_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public UFFBond() : this(RDKFuncsPINVOKE.new_UFFBond(), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
