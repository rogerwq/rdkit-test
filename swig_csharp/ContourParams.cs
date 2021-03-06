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

public class ContourParams : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ContourParams(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ContourParams obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ContourParams() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RDKFuncsPINVOKE.delete_ContourParams(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public bool setScale {
    set {
      RDKFuncsPINVOKE.ContourParams_setScale_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = RDKFuncsPINVOKE.ContourParams_setScale_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool dashNegative {
    set {
      RDKFuncsPINVOKE.ContourParams_dashNegative_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = RDKFuncsPINVOKE.ContourParams_dashNegative_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool fillGrid {
    set {
      RDKFuncsPINVOKE.ContourParams_fillGrid_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = RDKFuncsPINVOKE.ContourParams_fillGrid_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double gridResolution {
    set {
      RDKFuncsPINVOKE.ContourParams_gridResolution_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = RDKFuncsPINVOKE.ContourParams_gridResolution_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double contourWidth {
    set {
      RDKFuncsPINVOKE.ContourParams_contourWidth_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = RDKFuncsPINVOKE.ContourParams_contourWidth_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double extraGridPadding {
    set {
      RDKFuncsPINVOKE.ContourParams_extraGridPadding_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = RDKFuncsPINVOKE.ContourParams_extraGridPadding_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DrawColour contourColour {
    set {
      RDKFuncsPINVOKE.ContourParams_contourColour_set(swigCPtr, DrawColour.getCPtr(value));
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = RDKFuncsPINVOKE.ContourParams_contourColour_get(swigCPtr);
      DrawColour ret = (cPtr == global::System.IntPtr.Zero) ? null : new DrawColour(cPtr, false);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_std__vectorT_RDKit__DrawColour_t colourMap {
    set {
      RDKFuncsPINVOKE.ContourParams_colourMap_set(swigCPtr, SWIGTYPE_p_std__vectorT_RDKit__DrawColour_t.getCPtr(value));
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = RDKFuncsPINVOKE.ContourParams_colourMap_get(swigCPtr);
      SWIGTYPE_p_std__vectorT_RDKit__DrawColour_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__vectorT_RDKit__DrawColour_t(cPtr, false);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public ContourParams() : this(RDKFuncsPINVOKE.new_ContourParams(), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
