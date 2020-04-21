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

public class MolDraw2DSVG : MolDraw2D {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal MolDraw2DSVG(global::System.IntPtr cPtr, bool cMemoryOwn) : base(RDKFuncsPINVOKE.MolDraw2DSVG_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MolDraw2DSVG obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MolDraw2DSVG() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RDKFuncsPINVOKE.delete_MolDraw2DSVG(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public MolDraw2DSVG(int width, int height, SWIGTYPE_p_std__ostream os, int panelWidth, int panelHeight) : this(RDKFuncsPINVOKE.new_MolDraw2DSVG__SWIG_0(width, height, SWIGTYPE_p_std__ostream.getCPtr(os), panelWidth, panelHeight), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public MolDraw2DSVG(int width, int height, SWIGTYPE_p_std__ostream os, int panelWidth) : this(RDKFuncsPINVOKE.new_MolDraw2DSVG__SWIG_1(width, height, SWIGTYPE_p_std__ostream.getCPtr(os), panelWidth), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public MolDraw2DSVG(int width, int height, int panelWidth, int panelHeight) : this(RDKFuncsPINVOKE.new_MolDraw2DSVG__SWIG_2(width, height, panelWidth, panelHeight), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public MolDraw2DSVG(int width, int height, int panelWidth) : this(RDKFuncsPINVOKE.new_MolDraw2DSVG__SWIG_3(width, height, panelWidth), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public MolDraw2DSVG(int width, int height) : this(RDKFuncsPINVOKE.new_MolDraw2DSVG__SWIG_4(width, height), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setFontSize(double new_size) {
    RDKFuncsPINVOKE.MolDraw2DSVG_setFontSize(swigCPtr, new_size);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setColour(DrawColour col) {
    RDKFuncsPINVOKE.MolDraw2DSVG_setColour(swigCPtr, DrawColour.getCPtr(col));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void finishDrawing() {
    RDKFuncsPINVOKE.MolDraw2DSVG_finishDrawing(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawLine(Point2D cds1, Point2D cds2) {
    RDKFuncsPINVOKE.MolDraw2DSVG_drawLine(swigCPtr, Point2D.getCPtr(cds1), Point2D.getCPtr(cds2));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawString(string str, Point2D cds) {
    RDKFuncsPINVOKE.MolDraw2DSVG_drawString(swigCPtr, str, Point2D.getCPtr(cds));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawPolygon(SWIGTYPE_p_std__vectorT_RDGeom__Point2D_t cds) {
    RDKFuncsPINVOKE.MolDraw2DSVG_drawPolygon(swigCPtr, SWIGTYPE_p_std__vectorT_RDGeom__Point2D_t.getCPtr(cds));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawEllipse(Point2D cds1, Point2D cds2) {
    RDKFuncsPINVOKE.MolDraw2DSVG_drawEllipse(swigCPtr, Point2D.getCPtr(cds1), Point2D.getCPtr(cds2));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void clearDrawing() {
    RDKFuncsPINVOKE.MolDraw2DSVG_clearDrawing(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawWavyLine(Point2D cds1, Point2D cds2, DrawColour col1, DrawColour col2, uint nSegments, double vertOffset) {
    RDKFuncsPINVOKE.MolDraw2DSVG_drawWavyLine__SWIG_0(swigCPtr, Point2D.getCPtr(cds1), Point2D.getCPtr(cds2), DrawColour.getCPtr(col1), DrawColour.getCPtr(col2), nSegments, vertOffset);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawWavyLine(Point2D cds1, Point2D cds2, DrawColour col1, DrawColour col2, uint nSegments) {
    RDKFuncsPINVOKE.MolDraw2DSVG_drawWavyLine__SWIG_1(swigCPtr, Point2D.getCPtr(cds1), Point2D.getCPtr(cds2), DrawColour.getCPtr(col1), DrawColour.getCPtr(col2), nSegments);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawWavyLine(Point2D cds1, Point2D cds2, DrawColour col1, DrawColour col2) {
    RDKFuncsPINVOKE.MolDraw2DSVG_drawWavyLine__SWIG_2(swigCPtr, Point2D.getCPtr(cds1), Point2D.getCPtr(cds2), DrawColour.getCPtr(col1), DrawColour.getCPtr(col2));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void getStringSize(string label, SWIGTYPE_p_double label_width, SWIGTYPE_p_double label_height) {
    RDKFuncsPINVOKE.MolDraw2DSVG_getStringSize(swigCPtr, label, SWIGTYPE_p_double.getCPtr(label_width), SWIGTYPE_p_double.getCPtr(label_height));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public string getDrawingText() {
    string ret = RDKFuncsPINVOKE.MolDraw2DSVG_getDrawingText(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void tagAtoms(ROMol mol) {
    RDKFuncsPINVOKE.MolDraw2DSVG_tagAtoms__SWIG_0_0(swigCPtr, ROMol.getCPtr(mol));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void tagAtoms(ROMol mol, double radius, String_String_Map events) {
    RDKFuncsPINVOKE.MolDraw2DSVG_tagAtoms__SWIG_2(swigCPtr, ROMol.getCPtr(mol), radius, String_String_Map.getCPtr(events));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void tagAtoms(ROMol mol, double radius) {
    RDKFuncsPINVOKE.MolDraw2DSVG_tagAtoms__SWIG_3(swigCPtr, ROMol.getCPtr(mol), radius);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void addMoleculeMetadata(ROMol mol, int confId) {
    RDKFuncsPINVOKE.MolDraw2DSVG_addMoleculeMetadata__SWIG_0(swigCPtr, ROMol.getCPtr(mol), confId);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void addMoleculeMetadata(ROMol mol) {
    RDKFuncsPINVOKE.MolDraw2DSVG_addMoleculeMetadata__SWIG_1(swigCPtr, ROMol.getCPtr(mol));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void addMoleculeMetadata(SWIGTYPE_p_std__vectorT_RDKit__ROMol_p_t mols, Int_Vect confIds) {
    RDKFuncsPINVOKE.MolDraw2DSVG_addMoleculeMetadata__SWIG_2(swigCPtr, SWIGTYPE_p_std__vectorT_RDKit__ROMol_p_t.getCPtr(mols), Int_Vect.getCPtr(confIds));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void addMoleculeMetadata(SWIGTYPE_p_std__vectorT_RDKit__ROMol_p_t mols) {
    RDKFuncsPINVOKE.MolDraw2DSVG_addMoleculeMetadata__SWIG_3(swigCPtr, SWIGTYPE_p_std__vectorT_RDKit__ROMol_p_t.getCPtr(mols));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

}

}