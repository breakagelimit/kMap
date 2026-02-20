// Decompiled with JetBrains decompiler
// Type: .
// Assembly: kMap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB403103-24EE-4947-BAAC-163727D2381A
// Assembly location: C:\Users\Dev\Downloads\Nouveau dossier (28)\NavTestV2\kMap.exe

using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace \u0006;

internal sealed class \u0002
{
  public \u0002()
  {
    this.\u0002(ushort.MaxValue);
    this.\u0003(ushort.MaxValue);
    this.\u0004(ushort.MaxValue);
    this.\u0005(ushort.MaxValue);
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

  [DebuggerNonUserCode]
  [SpecialName]
  public ushort \u0004() => this.\u0003;

  [DebuggerNonUserCode]
  [SpecialName]
  public void \u0004([In] ushort obj0) => this.\u0003 = obj0;

  [DebuggerNonUserCode]
  [SpecialName]
  public ushort \u0005() => this.\u0004;

  [DebuggerNonUserCode]
  [SpecialName]
  public void \u0005([In] ushort obj0) => this.\u0004 = obj0;

  public \u0006.\u0002.\u0001 \u0002([In] ref ushort obj0)
  {
    if ((int) obj0 == (int) this.\u0004())
    {
      \u0006.\u0002.\u0001 obj1;
      ref \u0006.\u0002.\u0001 local1 = ref obj1;
      ushort num1 = this.\u0005();
      ref ushort local2 = ref num1;
      ushort num2 = this.\u0003();
      ref ushort local3 = ref num2;
      local1 = new \u0006.\u0002.\u0001(ref local2, ref local3);
      \u0006.\u0002.\u0001 obj2 = obj1;
      this.\u0003(num2);
      this.\u0005(num1);
      return obj2;
    }
    \u0006.\u0002.\u0001 obj3;
    ref \u0006.\u0002.\u0001 local4 = ref obj3;
    ushort num3 = this.\u0004();
    ref ushort local5 = ref num3;
    ushort num4 = this.\u0002();
    ref ushort local6 = ref num4;
    local4 = new \u0006.\u0002.\u0001(ref local5, ref local6);
    \u0006.\u0002.\u0001 obj4 = obj3;
    this.\u0002(num4);
    this.\u0004(num3);
    return obj4;
  }

  public bool \u0002() => !(this.\u0002() == ushort.MaxValue | this.\u0003() == ushort.MaxValue);

  internal struct \u0001
  {
    public ushort \u0001;
    public ushort \u0002;

    public \u0001([In] ref ushort obj0, [In] ref ushort obj1)
      : this()
    {
      this.\u0001 = obj0;
      this.\u0002 = obj1;
    }
  }
}
