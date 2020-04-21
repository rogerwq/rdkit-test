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

public class TDTMolSupplier : MolSupplier {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal TDTMolSupplier(global::System.IntPtr cPtr, bool cMemoryOwn) : base(RDKFuncsPINVOKE.TDTMolSupplier_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TDTMolSupplier obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TDTMolSupplier() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RDKFuncsPINVOKE.delete_TDTMolSupplier(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public TDTMolSupplier(string fileName, string nameRecord, int confId2D, int confId3D, bool sanitize) : this(RDKFuncsPINVOKE.new_TDTMolSupplier__SWIG_0(fileName, nameRecord, confId2D, confId3D, sanitize), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public TDTMolSupplier(string fileName, string nameRecord, int confId2D, int confId3D) : this(RDKFuncsPINVOKE.new_TDTMolSupplier__SWIG_1(fileName, nameRecord, confId2D, confId3D), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public TDTMolSupplier(string fileName, string nameRecord, int confId2D) : this(RDKFuncsPINVOKE.new_TDTMolSupplier__SWIG_2(fileName, nameRecord, confId2D), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public TDTMolSupplier(string fileName, string nameRecord) : this(RDKFuncsPINVOKE.new_TDTMolSupplier__SWIG_3(fileName, nameRecord), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public TDTMolSupplier(string fileName) : this(RDKFuncsPINVOKE.new_TDTMolSupplier__SWIG_4(fileName), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public TDTMolSupplier(SWIGTYPE_p_std__istream inStream, bool takeOwnership, string nameRecord, int confId2D, int confId3D, bool sanitize) : this(RDKFuncsPINVOKE.new_TDTMolSupplier__SWIG_5(SWIGTYPE_p_std__istream.getCPtr(inStream), takeOwnership, nameRecord, confId2D, confId3D, sanitize), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public TDTMolSupplier(SWIGTYPE_p_std__istream inStream, bool takeOwnership, string nameRecord, int confId2D, int confId3D) : this(RDKFuncsPINVOKE.new_TDTMolSupplier__SWIG_6(SWIGTYPE_p_std__istream.getCPtr(inStream), takeOwnership, nameRecord, confId2D, confId3D), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public TDTMolSupplier(SWIGTYPE_p_std__istream inStream, bool takeOwnership, string nameRecord, int confId2D) : this(RDKFuncsPINVOKE.new_TDTMolSupplier__SWIG_7(SWIGTYPE_p_std__istream.getCPtr(inStream), takeOwnership, nameRecord, confId2D), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public TDTMolSupplier(SWIGTYPE_p_std__istream inStream, bool takeOwnership, string nameRecord) : this(RDKFuncsPINVOKE.new_TDTMolSupplier__SWIG_8(SWIGTYPE_p_std__istream.getCPtr(inStream), takeOwnership, nameRecord), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public TDTMolSupplier(SWIGTYPE_p_std__istream inStream, bool takeOwnership) : this(RDKFuncsPINVOKE.new_TDTMolSupplier__SWIG_9(SWIGTYPE_p_std__istream.getCPtr(inStream), takeOwnership), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public TDTMolSupplier(SWIGTYPE_p_std__istream inStream) : this(RDKFuncsPINVOKE.new_TDTMolSupplier__SWIG_10(SWIGTYPE_p_std__istream.getCPtr(inStream)), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public TDTMolSupplier() : this(RDKFuncsPINVOKE.new_TDTMolSupplier__SWIG_11(), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setData(string text, string nameRecord, int confId2D, int confId3D, bool sanitize) {
    RDKFuncsPINVOKE.TDTMolSupplier_setData__SWIG_0(swigCPtr, text, nameRecord, confId2D, confId3D, sanitize);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setData(string text, string nameRecord, int confId2D, int confId3D) {
    RDKFuncsPINVOKE.TDTMolSupplier_setData__SWIG_1(swigCPtr, text, nameRecord, confId2D, confId3D);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setData(string text, string nameRecord, int confId2D) {
    RDKFuncsPINVOKE.TDTMolSupplier_setData__SWIG_2(swigCPtr, text, nameRecord, confId2D);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setData(string text, string nameRecord) {
    RDKFuncsPINVOKE.TDTMolSupplier_setData__SWIG_3(swigCPtr, text, nameRecord);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setData(string text) {
    RDKFuncsPINVOKE.TDTMolSupplier_setData__SWIG_4(swigCPtr, text);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void init() {
    RDKFuncsPINVOKE.TDTMolSupplier_init(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void reset() {
    RDKFuncsPINVOKE.TDTMolSupplier_reset(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ROMol next() {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.TDTMolSupplier_next(swigCPtr);
    ROMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new ROMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool atEnd() {
    bool ret = RDKFuncsPINVOKE.TDTMolSupplier_atEnd(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void moveTo(uint idx) {
    RDKFuncsPINVOKE.TDTMolSupplier_moveTo(swigCPtr, idx);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public string getItemText(uint idx) {
    string ret = RDKFuncsPINVOKE.TDTMolSupplier_getItemText(swigCPtr, idx);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint length() {
    uint ret = RDKFuncsPINVOKE.TDTMolSupplier_length(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
