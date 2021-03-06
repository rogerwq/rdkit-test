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

public class BitVect : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BitVect(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BitVect obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BitVect() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RDKFuncsPINVOKE.delete_BitVect(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual bool setBit(uint which) {
    bool ret = RDKFuncsPINVOKE.BitVect_setBit(swigCPtr, which);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool unsetBit(uint which) {
    bool ret = RDKFuncsPINVOKE.BitVect_unsetBit(swigCPtr, which);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool getBit(uint which) {
    bool ret = RDKFuncsPINVOKE.BitVect_getBit(swigCPtr, which);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual uint getNumBits() {
    uint ret = RDKFuncsPINVOKE.BitVect_getNumBits(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual uint getNumOnBits() {
    uint ret = RDKFuncsPINVOKE.BitVect_getNumOnBits(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual uint getNumOffBits() {
    uint ret = RDKFuncsPINVOKE.BitVect_getNumOffBits(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void getOnBits(Int_Vect v) {
    RDKFuncsPINVOKE.BitVect_getOnBits(swigCPtr, Int_Vect.getCPtr(v));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void clearBits() {
    RDKFuncsPINVOKE.BitVect_clearBits(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void initFromText(string data, uint dataLen, bool isBase64, bool allowOldFormat) {
    RDKFuncsPINVOKE.BitVect_initFromText__SWIG_0(swigCPtr, data, dataLen, isBase64, allowOldFormat);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void initFromText(string data, uint dataLen, bool isBase64) {
    RDKFuncsPINVOKE.BitVect_initFromText__SWIG_1(swigCPtr, data, dataLen, isBase64);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void initFromText(string data, uint dataLen) {
    RDKFuncsPINVOKE.BitVect_initFromText__SWIG_2(swigCPtr, data, dataLen);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual string toString() {
    string ret = RDKFuncsPINVOKE.BitVect_toString(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint size() {
    uint ret = RDKFuncsPINVOKE.BitVect_size(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
