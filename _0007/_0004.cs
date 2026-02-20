// Decompiled with JetBrains decompiler
// Type: .
// Assembly: kMap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB403103-24EE-4947-BAAC-163727D2381A
// Assembly location: C:\Users\Dev\Downloads\Nouveau dossier (28)\NavTestV2\kMap.exe

using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace \u0007;

internal sealed class \u0004
{
  public \u0004()
  {
    this.\u0002(new List<ushort>());
    this.\u0003(new List<ushort>());
    this.\u0004(new List<ushort>());
  }

  [DebuggerNonUserCode]
  [SpecialName]
  public float \u0002() => this.\u0001;

  [DebuggerNonUserCode]
  [SpecialName]
  public void \u0002([In] float obj0) => this.\u0001 = obj0;

  [DebuggerNonUserCode]
  [SpecialName]
  public float \u0003() => this.\u0002;

  [DebuggerNonUserCode]
  [SpecialName]
  public void \u0003([In] float obj0) => this.\u0002 = obj0;

  [DebuggerNonUserCode]
  [SpecialName]
  public float \u0004() => this.\u0003;

  [DebuggerNonUserCode]
  [SpecialName]
  public void \u0004([In] float obj0) => this.\u0003 = obj0;

  [DebuggerNonUserCode]
  [SpecialName]
  public float \u0005() => this.\u0004;

  [DebuggerNonUserCode]
  [SpecialName]
  public void \u0005([In] float obj0) => this.\u0004 = obj0;

  [DebuggerNonUserCode]
  [SpecialName]
  public List<ushort> \u0002() => this.\u0001;

  [DebuggerNonUserCode]
  [SpecialName]
  public void \u0002([In] List<ushort> obj0) => this.\u0001 = obj0;

  [DebuggerNonUserCode]
  [SpecialName]
  public List<ushort> \u0003() => this.\u0002;

  [DebuggerNonUserCode]
  [SpecialName]
  public void \u0003([In] List<ushort> obj0) => this.\u0002 = obj0;

  [DebuggerNonUserCode]
  [SpecialName]
  public List<ushort> \u0004() => this.\u0003;

  [DebuggerNonUserCode]
  [SpecialName]
  public void \u0004([In] List<ushort> obj0) => this.\u0003 = obj0;

  public bool \u0002() => this.\u0002().Count != 0;

  public RectangleF \u0002([In] float obj0)
  {
    PointF location = new PointF(this.\u0002() * obj0, this.\u0005() * obj0);
    float width = (this.\u0003() - this.\u0002()) * obj0;
    float height = (this.\u0004() - this.\u0005()) * obj0;
    if ((double) width < 0.0)
    {
      location.X += width;
      width *= -1f;
    }
    if ((double) height < 0.0)
    {
      location.Y += height;
      height *= -1f;
    }
    return new RectangleF(location, new SizeF(width, height));
  }
}
