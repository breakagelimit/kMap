// Decompiled with JetBrains decompiler
// Type: .
// Assembly: kMap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB403103-24EE-4947-BAAC-163727D2381A
// Assembly location: C:\Users\Dev\Downloads\Nouveau dossier (28)\NavTestV2\kMap.exe

using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace \u0006;

internal sealed class \u0005
{
  public \u0005()
  {
    this.\u0002(ushort.MaxValue);
    this.\u0003(ushort.MaxValue);
  }

  [DebuggerNonUserCode]
  [SpecialName]
  public PointF \u0002() => this.\u0001;

  [DebuggerNonUserCode]
  [SpecialName]
  public void \u0002([In] PointF obj0) => this.\u0001 = obj0;

  [DebuggerNonUserCode]
  [SpecialName]
  public PointF \u0003() => this.\u0002;

  [DebuggerNonUserCode]
  [SpecialName]
  public void \u0003([In] PointF obj0) => this.\u0002 = obj0;

  [DebuggerNonUserCode]
  [SpecialName]
  public ushort \u0002() => this.\u0001;

  [DebuggerNonUserCode]
  [SpecialName]
  public void \u0002([In] ushort obj0) => this.\u0001 = obj0;

  [DebuggerNonUserCode]
  [SpecialName]
  public ushort \u0003() => this.\u0002;

  [DebuggerNonUserCode]
  [SpecialName]
  public void \u0003([In] ushort obj0) => this.\u0002 = obj0;

  public ushort \u0002([In] ref ushort obj0)
  {
    return (int) this.\u0002() == (int) obj0 ? this.\u0003() : this.\u0002();
  }

  public bool \u0002() => !(this.\u0002() == ushort.MaxValue | this.\u0003() == ushort.MaxValue);
}
