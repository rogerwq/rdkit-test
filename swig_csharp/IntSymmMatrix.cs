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

public class IntSymmMatrix : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal IntSymmMatrix(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(IntSymmMatrix obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~IntSymmMatrix() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RDKFuncsPINVOKE.delete_IntSymmMatrix(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public IntSymmMatrix(uint N) : this(RDKFuncsPINVOKE.new_IntSymmMatrix__SWIG_0(N), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public IntSymmMatrix(uint N, int val) : this(RDKFuncsPINVOKE.new_IntSymmMatrix__SWIG_1(N, val), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public IntSymmMatrix(uint N, Shared_Int_Array data) : this(RDKFuncsPINVOKE.new_IntSymmMatrix__SWIG_2(N, Shared_Int_Array.getCPtr(data)), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public IntSymmMatrix(IntSymmMatrix other) : this(RDKFuncsPINVOKE.new_IntSymmMatrix__SWIG_3(IntSymmMatrix.getCPtr(other)), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint numRows() {
    uint ret = RDKFuncsPINVOKE.IntSymmMatrix_numRows(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint numCols() {
    uint ret = RDKFuncsPINVOKE.IntSymmMatrix_numCols(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getDataSize() {
    uint ret = RDKFuncsPINVOKE.IntSymmMatrix_getDataSize(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setToIdentity() {
    RDKFuncsPINVOKE.IntSymmMatrix_setToIdentity(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public int getVal(uint i, uint j) {
    int ret = RDKFuncsPINVOKE.IntSymmMatrix_getVal(swigCPtr, i, j);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setVal(uint i, uint j, int val) {
    RDKFuncsPINVOKE.IntSymmMatrix_setVal(swigCPtr, i, j, val);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void getRow(uint i, SWIGTYPE_p_RDNumeric__VectorT_int_t row) {
    RDKFuncsPINVOKE.IntSymmMatrix_getRow(swigCPtr, i, SWIGTYPE_p_RDNumeric__VectorT_int_t.getCPtr(row));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void getCol(uint i, SWIGTYPE_p_RDNumeric__VectorT_int_t col) {
    RDKFuncsPINVOKE.IntSymmMatrix_getCol(swigCPtr, i, SWIGTYPE_p_RDNumeric__VectorT_int_t.getCPtr(col));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_int getData() {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.IntSymmMatrix_getData__SWIG_0(swigCPtr);
    SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public IntSymmMatrix transpose(IntSymmMatrix transpose) {
    IntSymmMatrix ret = new IntSymmMatrix(RDKFuncsPINVOKE.IntSymmMatrix_transpose(swigCPtr, IntSymmMatrix.getCPtr(transpose)), false);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public IntSymmMatrix transposeInplace() {
    IntSymmMatrix ret = new IntSymmMatrix(RDKFuncsPINVOKE.IntSymmMatrix_transposeInplace(swigCPtr), false);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}