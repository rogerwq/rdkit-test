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

public class Bond : RDProps {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal Bond(global::System.IntPtr cPtr, bool cMemoryOwn) : base(RDKFuncsPINVOKE.Bond_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Bond obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Bond() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          RDKFuncsPINVOKE.delete_Bond(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Bond() : this(RDKFuncsPINVOKE.new_Bond__SWIG_0(), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public Bond(Bond.BondType bT) : this(RDKFuncsPINVOKE.new_Bond__SWIG_1((int)bT), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public Bond(Bond other) : this(RDKFuncsPINVOKE.new_Bond__SWIG_2(Bond.getCPtr(other)), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual Bond copy() {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.Bond_copy(swigCPtr);
    Bond ret = (cPtr == global::System.IntPtr.Zero) ? null : new Bond(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Bond.BondType getBondType() {
    Bond.BondType ret = (Bond.BondType)RDKFuncsPINVOKE.Bond_getBondType(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setBondType(Bond.BondType bT) {
    RDKFuncsPINVOKE.Bond_setBondType(swigCPtr, (int)bT);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public double getBondTypeAsDouble() {
    double ret = RDKFuncsPINVOKE.Bond_getBondTypeAsDouble(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setIsAromatic(bool what) {
    RDKFuncsPINVOKE.Bond_setIsAromatic(swigCPtr, what);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getIsAromatic() {
    bool ret = RDKFuncsPINVOKE.Bond_getIsAromatic(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setIsConjugated(bool what) {
    RDKFuncsPINVOKE.Bond_setIsConjugated(swigCPtr, what);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getIsConjugated() {
    bool ret = RDKFuncsPINVOKE.Bond_getIsConjugated(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool hasOwningMol() {
    bool ret = RDKFuncsPINVOKE.Bond_hasOwningMol(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ROMol getOwningMol() {
    ROMol ret = new ROMol(RDKFuncsPINVOKE.Bond_getOwningMol(swigCPtr), true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setOwningMol(ROMol other) {
    RDKFuncsPINVOKE.Bond_setOwningMol__SWIG_0(swigCPtr, ROMol.getCPtr(other));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getIdx() {
    uint ret = RDKFuncsPINVOKE.Bond_getIdx(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setIdx(uint index) {
    RDKFuncsPINVOKE.Bond_setIdx(swigCPtr, index);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getBeginAtomIdx() {
    uint ret = RDKFuncsPINVOKE.Bond_getBeginAtomIdx(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getEndAtomIdx() {
    uint ret = RDKFuncsPINVOKE.Bond_getEndAtomIdx(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getOtherAtomIdx(uint thisIdx) {
    uint ret = RDKFuncsPINVOKE.Bond_getOtherAtomIdx(swigCPtr, thisIdx);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setBeginAtomIdx(uint what) {
    RDKFuncsPINVOKE.Bond_setBeginAtomIdx(swigCPtr, what);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setEndAtomIdx(uint what) {
    RDKFuncsPINVOKE.Bond_setEndAtomIdx(swigCPtr, what);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public Atom getBeginAtom() {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.Bond_getBeginAtom(swigCPtr);
    Atom ret = (cPtr == global::System.IntPtr.Zero) ? null : new Atom(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Atom getEndAtom() {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.Bond_getEndAtom(swigCPtr);
    Atom ret = (cPtr == global::System.IntPtr.Zero) ? null : new Atom(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Atom getOtherAtom(Atom what) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.Bond_getOtherAtom(swigCPtr, Atom.getCPtr(what));
    Atom ret = (cPtr == global::System.IntPtr.Zero) ? null : new Atom(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool hasQuery() {
    bool ret = RDKFuncsPINVOKE.Bond_hasQuery(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void setQuery(SWIGTYPE_p_Queries__QueryT_int_RDKit__Bond_const_p_true_t what) {
    RDKFuncsPINVOKE.Bond_setQuery(swigCPtr, SWIGTYPE_p_Queries__QueryT_int_RDKit__Bond_const_p_true_t.getCPtr(what));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual SWIGTYPE_p_Queries__QueryT_int_RDKit__Bond_const_p_true_t getQuery() {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.Bond_getQuery(swigCPtr);
    SWIGTYPE_p_Queries__QueryT_int_RDKit__Bond_const_p_true_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Queries__QueryT_int_RDKit__Bond_const_p_true_t(cPtr, false);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void expandQuery(SWIGTYPE_p_Queries__QueryT_int_RDKit__Bond_const_p_true_t what, CompositeQueryType how, bool maintainOrder) {
    RDKFuncsPINVOKE.Bond_expandQuery__SWIG_0(swigCPtr, SWIGTYPE_p_Queries__QueryT_int_RDKit__Bond_const_p_true_t.getCPtr(what), (int)how, maintainOrder);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void expandQuery(SWIGTYPE_p_Queries__QueryT_int_RDKit__Bond_const_p_true_t what, CompositeQueryType how) {
    RDKFuncsPINVOKE.Bond_expandQuery__SWIG_1(swigCPtr, SWIGTYPE_p_Queries__QueryT_int_RDKit__Bond_const_p_true_t.getCPtr(what), (int)how);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void expandQuery(SWIGTYPE_p_Queries__QueryT_int_RDKit__Bond_const_p_true_t what) {
    RDKFuncsPINVOKE.Bond_expandQuery__SWIG_2(swigCPtr, SWIGTYPE_p_Queries__QueryT_int_RDKit__Bond_const_p_true_t.getCPtr(what));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setBondDir(Bond.BondDir what) {
    RDKFuncsPINVOKE.Bond_setBondDir(swigCPtr, (int)what);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public Bond.BondDir getBondDir() {
    Bond.BondDir ret = (Bond.BondDir)RDKFuncsPINVOKE.Bond_getBondDir(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setStereo(Bond.BondStereo what) {
    RDKFuncsPINVOKE.Bond_setStereo(swigCPtr, (int)what);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public Bond.BondStereo getStereo() {
    Bond.BondStereo ret = (Bond.BondStereo)RDKFuncsPINVOKE.Bond_getStereo(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setStereoAtoms(uint bgnIdx, uint endIdx) {
    RDKFuncsPINVOKE.Bond_setStereoAtoms(swigCPtr, bgnIdx, endIdx);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public Int_Vect getStereoAtoms() {
    Int_Vect ret = new Int_Vect(RDKFuncsPINVOKE.Bond_getStereoAtoms__SWIG_0(swigCPtr), false);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void updatePropertyCache(bool strict) {
    RDKFuncsPINVOKE.Bond_updatePropertyCache__SWIG_0(swigCPtr, strict);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void updatePropertyCache() {
    RDKFuncsPINVOKE.Bond_updatePropertyCache__SWIG_1(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public string getProp(string key) {
    string ret = RDKFuncsPINVOKE.Bond_getProp(swigCPtr, key);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Bond.BondDir DetermineBondWedgeState(Int_Int_Map wedgeBonds, Conformer conf) {
    Bond.BondDir ret = (Bond.BondDir)RDKFuncsPINVOKE.Bond_DetermineBondWedgeState(swigCPtr, Int_Int_Map.getCPtr(wedgeBonds), Conformer.getCPtr(conf));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsInRing() {
    bool ret = RDKFuncsPINVOKE.Bond_IsInRing(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsInRingSize(int size) {
    bool ret = RDKFuncsPINVOKE.Bond_IsInRingSize(swigCPtr, size);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum BondType {
    UNSPECIFIED = 0,
    SINGLE,
    DOUBLE,
    TRIPLE,
    QUADRUPLE,
    QUINTUPLE,
    HEXTUPLE,
    ONEANDAHALF,
    TWOANDAHALF,
    THREEANDAHALF,
    FOURANDAHALF,
    FIVEANDAHALF,
    AROMATIC,
    IONIC,
    HYDROGEN,
    THREECENTER,
    DATIVEONE,
    DATIVE,
    DATIVEL,
    DATIVER,
    OTHER,
    ZERO
  }

  public enum BondDir {
    NONE = 0,
    BEGINWEDGE,
    BEGINDASH,
    ENDDOWNRIGHT,
    ENDUPRIGHT,
    EITHERDOUBLE,
    UNKNOWN
  }

  public enum BondStereo {
    STEREONONE = 0,
    STEREOANY,
    STEREOZ,
    STEREOE,
    STEREOCIS,
    STEREOTRANS
  }

}

}
