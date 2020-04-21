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

public class EmbedParameters : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal EmbedParameters(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(EmbedParameters obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~EmbedParameters() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RDKFuncsPINVOKE.delete_EmbedParameters(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public uint maxIterations {
    set {
      RDKFuncsPINVOKE.EmbedParameters_maxIterations_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      uint ret = RDKFuncsPINVOKE.EmbedParameters_maxIterations_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int numThreads {
    set {
      RDKFuncsPINVOKE.EmbedParameters_numThreads_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = RDKFuncsPINVOKE.EmbedParameters_numThreads_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int randomSeed {
    set {
      RDKFuncsPINVOKE.EmbedParameters_randomSeed_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = RDKFuncsPINVOKE.EmbedParameters_randomSeed_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool clearConfs {
    set {
      RDKFuncsPINVOKE.EmbedParameters_clearConfs_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = RDKFuncsPINVOKE.EmbedParameters_clearConfs_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool useRandomCoords {
    set {
      RDKFuncsPINVOKE.EmbedParameters_useRandomCoords_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = RDKFuncsPINVOKE.EmbedParameters_useRandomCoords_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double boxSizeMult {
    set {
      RDKFuncsPINVOKE.EmbedParameters_boxSizeMult_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = RDKFuncsPINVOKE.EmbedParameters_boxSizeMult_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool randNegEig {
    set {
      RDKFuncsPINVOKE.EmbedParameters_randNegEig_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = RDKFuncsPINVOKE.EmbedParameters_randNegEig_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint numZeroFail {
    set {
      RDKFuncsPINVOKE.EmbedParameters_numZeroFail_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      uint ret = RDKFuncsPINVOKE.EmbedParameters_numZeroFail_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public Int_Point3D_Map coordMap {
    set {
      RDKFuncsPINVOKE.EmbedParameters_coordMap_set(swigCPtr, Int_Point3D_Map.getCPtr(value));
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = RDKFuncsPINVOKE.EmbedParameters_coordMap_get(swigCPtr);
      Int_Point3D_Map ret = (cPtr == global::System.IntPtr.Zero) ? null : new Int_Point3D_Map(cPtr, false);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double optimizerForceTol {
    set {
      RDKFuncsPINVOKE.EmbedParameters_optimizerForceTol_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = RDKFuncsPINVOKE.EmbedParameters_optimizerForceTol_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool ignoreSmoothingFailures {
    set {
      RDKFuncsPINVOKE.EmbedParameters_ignoreSmoothingFailures_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = RDKFuncsPINVOKE.EmbedParameters_ignoreSmoothingFailures_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool enforceChirality {
    set {
      RDKFuncsPINVOKE.EmbedParameters_enforceChirality_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = RDKFuncsPINVOKE.EmbedParameters_enforceChirality_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool useExpTorsionAnglePrefs {
    set {
      RDKFuncsPINVOKE.EmbedParameters_useExpTorsionAnglePrefs_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = RDKFuncsPINVOKE.EmbedParameters_useExpTorsionAnglePrefs_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool useBasicKnowledge {
    set {
      RDKFuncsPINVOKE.EmbedParameters_useBasicKnowledge_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = RDKFuncsPINVOKE.EmbedParameters_useBasicKnowledge_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool verbose {
    set {
      RDKFuncsPINVOKE.EmbedParameters_verbose_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = RDKFuncsPINVOKE.EmbedParameters_verbose_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double basinThresh {
    set {
      RDKFuncsPINVOKE.EmbedParameters_basinThresh_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = RDKFuncsPINVOKE.EmbedParameters_basinThresh_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double pruneRmsThresh {
    set {
      RDKFuncsPINVOKE.EmbedParameters_pruneRmsThresh_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = RDKFuncsPINVOKE.EmbedParameters_pruneRmsThresh_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool onlyHeavyAtomsForRMS {
    set {
      RDKFuncsPINVOKE.EmbedParameters_onlyHeavyAtomsForRMS_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = RDKFuncsPINVOKE.EmbedParameters_onlyHeavyAtomsForRMS_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint ETversion {
    set {
      RDKFuncsPINVOKE.EmbedParameters_ETversion_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      uint ret = RDKFuncsPINVOKE.EmbedParameters_ETversion_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_boost__shared_ptrT_DistGeom__BoundsMatrix_const_t boundsMat {
    set {
      RDKFuncsPINVOKE.EmbedParameters_boundsMat_set(swigCPtr, SWIGTYPE_p_boost__shared_ptrT_DistGeom__BoundsMatrix_const_t.getCPtr(value));
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = RDKFuncsPINVOKE.EmbedParameters_boundsMat_get(swigCPtr);
      SWIGTYPE_p_boost__shared_ptrT_DistGeom__BoundsMatrix_const_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_boost__shared_ptrT_DistGeom__BoundsMatrix_const_t(cPtr, false);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool embedFragmentsSeparately {
    set {
      RDKFuncsPINVOKE.EmbedParameters_embedFragmentsSeparately_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = RDKFuncsPINVOKE.EmbedParameters_embedFragmentsSeparately_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public EmbedParameters() : this(RDKFuncsPINVOKE.new_EmbedParameters__SWIG_0(), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public EmbedParameters(uint maxIterations, int numThreads, int randomSeed, bool clearConfs, bool useRandomCoords, double boxSizeMult, bool randNegEig, uint numZeroFail, Int_Point3D_Map coordMap, double optimizerForceTol, bool ignoreSmoothingFailures, bool enforceChirality, bool useExpTorsionAnglePrefs, bool useBasicKnowledge, bool verbose, double basinThresh, double pruneRmsThresh, bool onlyHeavyAtomsForRMS, uint ETversion, BoundsMatrix boundsMat, bool embedFragmentsSeparately) : this(RDKFuncsPINVOKE.new_EmbedParameters__SWIG_1(maxIterations, numThreads, randomSeed, clearConfs, useRandomCoords, boxSizeMult, randNegEig, numZeroFail, Int_Point3D_Map.getCPtr(coordMap), optimizerForceTol, ignoreSmoothingFailures, enforceChirality, useExpTorsionAnglePrefs, useBasicKnowledge, verbose, basinThresh, pruneRmsThresh, onlyHeavyAtomsForRMS, ETversion, BoundsMatrix.getCPtr(boundsMat), embedFragmentsSeparately), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public EmbedParameters(uint maxIterations, int numThreads, int randomSeed, bool clearConfs, bool useRandomCoords, double boxSizeMult, bool randNegEig, uint numZeroFail, Int_Point3D_Map coordMap, double optimizerForceTol, bool ignoreSmoothingFailures, bool enforceChirality, bool useExpTorsionAnglePrefs, bool useBasicKnowledge, bool verbose, double basinThresh, double pruneRmsThresh, bool onlyHeavyAtomsForRMS, uint ETversion, BoundsMatrix boundsMat) : this(RDKFuncsPINVOKE.new_EmbedParameters__SWIG_2(maxIterations, numThreads, randomSeed, clearConfs, useRandomCoords, boxSizeMult, randNegEig, numZeroFail, Int_Point3D_Map.getCPtr(coordMap), optimizerForceTol, ignoreSmoothingFailures, enforceChirality, useExpTorsionAnglePrefs, useBasicKnowledge, verbose, basinThresh, pruneRmsThresh, onlyHeavyAtomsForRMS, ETversion, BoundsMatrix.getCPtr(boundsMat)), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public EmbedParameters(uint maxIterations, int numThreads, int randomSeed, bool clearConfs, bool useRandomCoords, double boxSizeMult, bool randNegEig, uint numZeroFail, Int_Point3D_Map coordMap, double optimizerForceTol, bool ignoreSmoothingFailures, bool enforceChirality, bool useExpTorsionAnglePrefs, bool useBasicKnowledge, bool verbose, double basinThresh, double pruneRmsThresh, bool onlyHeavyAtomsForRMS, uint ETversion) : this(RDKFuncsPINVOKE.new_EmbedParameters__SWIG_3(maxIterations, numThreads, randomSeed, clearConfs, useRandomCoords, boxSizeMult, randNegEig, numZeroFail, Int_Point3D_Map.getCPtr(coordMap), optimizerForceTol, ignoreSmoothingFailures, enforceChirality, useExpTorsionAnglePrefs, useBasicKnowledge, verbose, basinThresh, pruneRmsThresh, onlyHeavyAtomsForRMS, ETversion), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public EmbedParameters(uint maxIterations, int numThreads, int randomSeed, bool clearConfs, bool useRandomCoords, double boxSizeMult, bool randNegEig, uint numZeroFail, Int_Point3D_Map coordMap, double optimizerForceTol, bool ignoreSmoothingFailures, bool enforceChirality, bool useExpTorsionAnglePrefs, bool useBasicKnowledge, bool verbose, double basinThresh, double pruneRmsThresh, bool onlyHeavyAtomsForRMS) : this(RDKFuncsPINVOKE.new_EmbedParameters__SWIG_4(maxIterations, numThreads, randomSeed, clearConfs, useRandomCoords, boxSizeMult, randNegEig, numZeroFail, Int_Point3D_Map.getCPtr(coordMap), optimizerForceTol, ignoreSmoothingFailures, enforceChirality, useExpTorsionAnglePrefs, useBasicKnowledge, verbose, basinThresh, pruneRmsThresh, onlyHeavyAtomsForRMS), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public EmbedParameters(EmbedParameters other) : this(RDKFuncsPINVOKE.new_EmbedParameters__SWIG_5(EmbedParameters.getCPtr(other)), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
