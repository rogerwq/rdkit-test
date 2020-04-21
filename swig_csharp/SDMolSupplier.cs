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

public class SDMolSupplier : ForwardSDMolSupplier {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal SDMolSupplier(global::System.IntPtr cPtr, bool cMemoryOwn) : base(RDKFuncsPINVOKE.SDMolSupplier_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SDMolSupplier obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SDMolSupplier() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RDKFuncsPINVOKE.delete_SDMolSupplier(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public SDMolSupplier() : this(RDKFuncsPINVOKE.new_SDMolSupplier__SWIG_0(), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SDMolSupplier(string fileName, bool sanitize, bool removeHs, bool strictParsing) : this(RDKFuncsPINVOKE.new_SDMolSupplier__SWIG_1(fileName, sanitize, removeHs, strictParsing), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SDMolSupplier(string fileName, bool sanitize, bool removeHs) : this(RDKFuncsPINVOKE.new_SDMolSupplier__SWIG_2(fileName, sanitize, removeHs), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SDMolSupplier(string fileName, bool sanitize) : this(RDKFuncsPINVOKE.new_SDMolSupplier__SWIG_3(fileName, sanitize), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SDMolSupplier(string fileName) : this(RDKFuncsPINVOKE.new_SDMolSupplier__SWIG_4(fileName), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SDMolSupplier(SWIGTYPE_p_std__istream inStream, bool takeOwnership, bool sanitize, bool removeHs, bool strictParsing) : this(RDKFuncsPINVOKE.new_SDMolSupplier__SWIG_5(SWIGTYPE_p_std__istream.getCPtr(inStream), takeOwnership, sanitize, removeHs, strictParsing), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SDMolSupplier(SWIGTYPE_p_std__istream inStream, bool takeOwnership, bool sanitize, bool removeHs) : this(RDKFuncsPINVOKE.new_SDMolSupplier__SWIG_6(SWIGTYPE_p_std__istream.getCPtr(inStream), takeOwnership, sanitize, removeHs), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SDMolSupplier(SWIGTYPE_p_std__istream inStream, bool takeOwnership, bool sanitize) : this(RDKFuncsPINVOKE.new_SDMolSupplier__SWIG_7(SWIGTYPE_p_std__istream.getCPtr(inStream), takeOwnership, sanitize), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SDMolSupplier(SWIGTYPE_p_std__istream inStream, bool takeOwnership) : this(RDKFuncsPINVOKE.new_SDMolSupplier__SWIG_8(SWIGTYPE_p_std__istream.getCPtr(inStream), takeOwnership), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SDMolSupplier(SWIGTYPE_p_std__istream inStream) : this(RDKFuncsPINVOKE.new_SDMolSupplier__SWIG_9(SWIGTYPE_p_std__istream.getCPtr(inStream)), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void init() {
    RDKFuncsPINVOKE.SDMolSupplier_init(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void reset() {
    RDKFuncsPINVOKE.SDMolSupplier_reset(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ROMol next() {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.SDMolSupplier_next(swigCPtr);
    ROMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new ROMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool atEnd() {
    bool ret = RDKFuncsPINVOKE.SDMolSupplier_atEnd(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void moveTo(uint idx) {
    RDKFuncsPINVOKE.SDMolSupplier_moveTo(swigCPtr, idx);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public string getItemText(uint idx) {
    string ret = RDKFuncsPINVOKE.SDMolSupplier_getItemText(swigCPtr, idx);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint length() {
    uint ret = RDKFuncsPINVOKE.SDMolSupplier_length(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setData(string text, bool sanitize, bool removeHs) {
    RDKFuncsPINVOKE.SDMolSupplier_setData__SWIG_0(swigCPtr, text, sanitize, removeHs);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setData(string text, bool sanitize) {
    RDKFuncsPINVOKE.SDMolSupplier_setData__SWIG_1(swigCPtr, text, sanitize);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setData(string text) {
    RDKFuncsPINVOKE.SDMolSupplier_setData__SWIG_2(swigCPtr, text);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setData(string text, bool sanitize, bool removeHs, bool strictParsing) {
    RDKFuncsPINVOKE.SDMolSupplier_setData__SWIG_3(swigCPtr, text, sanitize, removeHs, strictParsing);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setStreamIndices(SWIGTYPE_p_std__vectorT_std__streampos_t locs) {
    RDKFuncsPINVOKE.SDMolSupplier_setStreamIndices(swigCPtr, SWIGTYPE_p_std__vectorT_std__streampos_t.getCPtr(locs));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
