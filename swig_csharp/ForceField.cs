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

public class ForceField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ForceField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ForceField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ForceField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RDKFuncsPINVOKE.delete_ForceField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ForceField(uint dimension) : this(RDKFuncsPINVOKE.new_ForceField__SWIG_0(dimension), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public ForceField() : this(RDKFuncsPINVOKE.new_ForceField__SWIG_1(), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public ForceField(ForceField other) : this(RDKFuncsPINVOKE.new_ForceField__SWIG_2(ForceField.getCPtr(other)), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void initialize() {
    RDKFuncsPINVOKE.ForceField_initialize(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public double calcEnergy(Double_Vect contribs) {
    double ret = RDKFuncsPINVOKE.ForceField_calcEnergy__SWIG_0(swigCPtr, Double_Vect.getCPtr(contribs));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double calcEnergy() {
    double ret = RDKFuncsPINVOKE.ForceField_calcEnergy__SWIG_1(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double calcEnergy(SWIGTYPE_p_double pos) {
    double ret = RDKFuncsPINVOKE.ForceField_calcEnergy__SWIG_2(swigCPtr, SWIGTYPE_p_double.getCPtr(pos));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void calcGrad(SWIGTYPE_p_double forces) {
    RDKFuncsPINVOKE.ForceField_calcGrad__SWIG_0(swigCPtr, SWIGTYPE_p_double.getCPtr(forces));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void calcGrad(SWIGTYPE_p_double pos, SWIGTYPE_p_double forces) {
    RDKFuncsPINVOKE.ForceField_calcGrad__SWIG_1(swigCPtr, SWIGTYPE_p_double.getCPtr(pos), SWIGTYPE_p_double.getCPtr(forces));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public int minimize(uint snapshotFreq, SWIGTYPE_p_std__vectorT_RDKit__Snapshot_t snapshotVect, uint maxIts, double forceTol, double energyTol) {
    int ret = RDKFuncsPINVOKE.ForceField_minimize__SWIG_0(swigCPtr, snapshotFreq, SWIGTYPE_p_std__vectorT_RDKit__Snapshot_t.getCPtr(snapshotVect), maxIts, forceTol, energyTol);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int minimize(uint snapshotFreq, SWIGTYPE_p_std__vectorT_RDKit__Snapshot_t snapshotVect, uint maxIts, double forceTol) {
    int ret = RDKFuncsPINVOKE.ForceField_minimize__SWIG_1(swigCPtr, snapshotFreq, SWIGTYPE_p_std__vectorT_RDKit__Snapshot_t.getCPtr(snapshotVect), maxIts, forceTol);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int minimize(uint snapshotFreq, SWIGTYPE_p_std__vectorT_RDKit__Snapshot_t snapshotVect, uint maxIts) {
    int ret = RDKFuncsPINVOKE.ForceField_minimize__SWIG_2(swigCPtr, snapshotFreq, SWIGTYPE_p_std__vectorT_RDKit__Snapshot_t.getCPtr(snapshotVect), maxIts);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int minimize(uint snapshotFreq, SWIGTYPE_p_std__vectorT_RDKit__Snapshot_t snapshotVect) {
    int ret = RDKFuncsPINVOKE.ForceField_minimize__SWIG_3(swigCPtr, snapshotFreq, SWIGTYPE_p_std__vectorT_RDKit__Snapshot_t.getCPtr(snapshotVect));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int minimize(uint maxIts, double forceTol, double energyTol) {
    int ret = RDKFuncsPINVOKE.ForceField_minimize__SWIG_4(swigCPtr, maxIts, forceTol, energyTol);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int minimize(uint maxIts, double forceTol) {
    int ret = RDKFuncsPINVOKE.ForceField_minimize__SWIG_5(swigCPtr, maxIts, forceTol);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int minimize(uint maxIts) {
    int ret = RDKFuncsPINVOKE.ForceField_minimize__SWIG_6(swigCPtr, maxIts);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int minimize() {
    int ret = RDKFuncsPINVOKE.ForceField_minimize__SWIG_7(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FF_Contrib_Vect contribs() {
    FF_Contrib_Vect ret = new FF_Contrib_Vect(RDKFuncsPINVOKE.ForceField_contribs__SWIG_0(swigCPtr), false);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double distance(uint i, uint j, SWIGTYPE_p_double pos) {
    double ret = RDKFuncsPINVOKE.ForceField_distance__SWIG_0(swigCPtr, i, j, SWIGTYPE_p_double.getCPtr(pos));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double distance(uint i, uint j) {
    double ret = RDKFuncsPINVOKE.ForceField_distance__SWIG_1(swigCPtr, i, j);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint dimension() {
    uint ret = RDKFuncsPINVOKE.ForceField_dimension(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint numPoints() {
    uint ret = RDKFuncsPINVOKE.ForceField_numPoints(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Int_Vect fixedPoints() {
    Int_Vect ret = new Int_Vect(RDKFuncsPINVOKE.ForceField_fixedPoints__SWIG_0(swigCPtr), false);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Point3D_Vect positions3D() {
    Point3D_Vect ret = new Point3D_Vect(RDKFuncsPINVOKE.ForceField_positions3D(swigCPtr), false);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int UFFOptimizeMolecule(ROMol mol, int maxIters, double vdwThresh, int confId, bool ignoreInterfragInteractions) {
    int ret = RDKFuncsPINVOKE.ForceField_UFFOptimizeMolecule__SWIG_0(ROMol.getCPtr(mol), maxIters, vdwThresh, confId, ignoreInterfragInteractions);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int UFFOptimizeMolecule(ROMol mol, int maxIters, double vdwThresh, int confId) {
    int ret = RDKFuncsPINVOKE.ForceField_UFFOptimizeMolecule__SWIG_1(ROMol.getCPtr(mol), maxIters, vdwThresh, confId);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int UFFOptimizeMolecule(ROMol mol, int maxIters, double vdwThresh) {
    int ret = RDKFuncsPINVOKE.ForceField_UFFOptimizeMolecule__SWIG_2(ROMol.getCPtr(mol), maxIters, vdwThresh);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int UFFOptimizeMolecule(ROMol mol, int maxIters) {
    int ret = RDKFuncsPINVOKE.ForceField_UFFOptimizeMolecule__SWIG_3(ROMol.getCPtr(mol), maxIters);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int UFFOptimizeMolecule(ROMol mol) {
    int ret = RDKFuncsPINVOKE.ForceField_UFFOptimizeMolecule__SWIG_4(ROMol.getCPtr(mol));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static ForceField UFFGetMoleculeForceField(ROMol mol, double vdwThresh, int confId, bool ignoreInterfragInteractions) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.ForceField_UFFGetMoleculeForceField__SWIG_0(ROMol.getCPtr(mol), vdwThresh, confId, ignoreInterfragInteractions);
    ForceField ret = (cPtr == global::System.IntPtr.Zero) ? null : new ForceField(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static ForceField UFFGetMoleculeForceField(ROMol mol, double vdwThresh, int confId) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.ForceField_UFFGetMoleculeForceField__SWIG_1(ROMol.getCPtr(mol), vdwThresh, confId);
    ForceField ret = (cPtr == global::System.IntPtr.Zero) ? null : new ForceField(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static ForceField UFFGetMoleculeForceField(ROMol mol, double vdwThresh) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.ForceField_UFFGetMoleculeForceField__SWIG_2(ROMol.getCPtr(mol), vdwThresh);
    ForceField ret = (cPtr == global::System.IntPtr.Zero) ? null : new ForceField(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static ForceField UFFGetMoleculeForceField(ROMol mol) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.ForceField_UFFGetMoleculeForceField__SWIG_3(ROMol.getCPtr(mol));
    ForceField ret = (cPtr == global::System.IntPtr.Zero) ? null : new ForceField(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool UFFHasAllMoleculeParams(ROMol mol) {
    bool ret = RDKFuncsPINVOKE.ForceField_UFFHasAllMoleculeParams(ROMol.getCPtr(mol));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void UFFAddAtomChargeFlags(Atom atom, SWIGTYPE_p_std__string atomKey, bool tolerateChargeMismatch) {
    RDKFuncsPINVOKE.ForceField_UFFAddAtomChargeFlags__SWIG_0(Atom.getCPtr(atom), SWIGTYPE_p_std__string.getCPtr(atomKey), tolerateChargeMismatch);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void UFFAddAtomChargeFlags(Atom atom, SWIGTYPE_p_std__string atomKey) {
    RDKFuncsPINVOKE.ForceField_UFFAddAtomChargeFlags__SWIG_1(Atom.getCPtr(atom), SWIGTYPE_p_std__string.getCPtr(atomKey));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static string UFFGetAtomLabel(Atom atom) {
    string ret = RDKFuncsPINVOKE.ForceField_UFFGetAtomLabel(Atom.getCPtr(atom));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Flagged_Atomic_Params_Vect UFFGetAtomTypes(ROMol mol, string paramData) {
    Flagged_Atomic_Params_Vect ret = new Flagged_Atomic_Params_Vect(RDKFuncsPINVOKE.ForceField_UFFGetAtomTypes__SWIG_0(ROMol.getCPtr(mol), paramData), true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Flagged_Atomic_Params_Vect UFFGetAtomTypes(ROMol mol) {
    Flagged_Atomic_Params_Vect ret = new Flagged_Atomic_Params_Vect(RDKFuncsPINVOKE.ForceField_UFFGetAtomTypes__SWIG_1(ROMol.getCPtr(mol)), true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int MMFFOptimizeMolecule(ROMol mol, string mmffVariant, int maxIters, double nonBondedThresh, int confId, bool ignoreInterfragInteractions) {
    int ret = RDKFuncsPINVOKE.ForceField_MMFFOptimizeMolecule__SWIG_0(ROMol.getCPtr(mol), mmffVariant, maxIters, nonBondedThresh, confId, ignoreInterfragInteractions);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int MMFFOptimizeMolecule(ROMol mol, string mmffVariant, int maxIters, double nonBondedThresh, int confId) {
    int ret = RDKFuncsPINVOKE.ForceField_MMFFOptimizeMolecule__SWIG_1(ROMol.getCPtr(mol), mmffVariant, maxIters, nonBondedThresh, confId);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int MMFFOptimizeMolecule(ROMol mol, string mmffVariant, int maxIters, double nonBondedThresh) {
    int ret = RDKFuncsPINVOKE.ForceField_MMFFOptimizeMolecule__SWIG_2(ROMol.getCPtr(mol), mmffVariant, maxIters, nonBondedThresh);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int MMFFOptimizeMolecule(ROMol mol, string mmffVariant, int maxIters) {
    int ret = RDKFuncsPINVOKE.ForceField_MMFFOptimizeMolecule__SWIG_3(ROMol.getCPtr(mol), mmffVariant, maxIters);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int MMFFOptimizeMolecule(ROMol mol, string mmffVariant) {
    int ret = RDKFuncsPINVOKE.ForceField_MMFFOptimizeMolecule__SWIG_4(ROMol.getCPtr(mol), mmffVariant);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int MMFFOptimizeMolecule(ROMol mol) {
    int ret = RDKFuncsPINVOKE.ForceField_MMFFOptimizeMolecule__SWIG_5(ROMol.getCPtr(mol));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static ForceField MMFFGetMoleculeForceField(ROMol mol, string mmffVariant, double nonBondedThresh, int confId, bool ignoreInterfragInteractions) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.ForceField_MMFFGetMoleculeForceField__SWIG_0(ROMol.getCPtr(mol), mmffVariant, nonBondedThresh, confId, ignoreInterfragInteractions);
    ForceField ret = (cPtr == global::System.IntPtr.Zero) ? null : new ForceField(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static ForceField MMFFGetMoleculeForceField(ROMol mol, string mmffVariant, double nonBondedThresh, int confId) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.ForceField_MMFFGetMoleculeForceField__SWIG_1(ROMol.getCPtr(mol), mmffVariant, nonBondedThresh, confId);
    ForceField ret = (cPtr == global::System.IntPtr.Zero) ? null : new ForceField(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static ForceField MMFFGetMoleculeForceField(ROMol mol, string mmffVariant, double nonBondedThresh) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.ForceField_MMFFGetMoleculeForceField__SWIG_2(ROMol.getCPtr(mol), mmffVariant, nonBondedThresh);
    ForceField ret = (cPtr == global::System.IntPtr.Zero) ? null : new ForceField(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static ForceField MMFFGetMoleculeForceField(ROMol mol, string mmffVariant) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.ForceField_MMFFGetMoleculeForceField__SWIG_3(ROMol.getCPtr(mol), mmffVariant);
    ForceField ret = (cPtr == global::System.IntPtr.Zero) ? null : new ForceField(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static ForceField MMFFGetMoleculeForceField(ROMol mol) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.ForceField_MMFFGetMoleculeForceField__SWIG_4(ROMol.getCPtr(mol));
    ForceField ret = (cPtr == global::System.IntPtr.Zero) ? null : new ForceField(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool MMFFHasAllMoleculeParams(ROMol mol) {
    bool ret = RDKFuncsPINVOKE.ForceField_MMFFHasAllMoleculeParams(ROMol.getCPtr(mol));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
