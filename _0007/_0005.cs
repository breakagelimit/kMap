// Decompiled with JetBrains decompiler
// Type: .
// Assembly: kMap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB403103-24EE-4947-BAAC-163727D2381A
// Assembly location: C:\Users\Dev\Downloads\Nouveau dossier (28)\NavTestV2\kMap.exe

using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;

#nullable disable
namespace \u0007;

internal sealed class \u0005
{
  public List<PointF> \u0001;
  public List<\u0005.\u0001> \u0001;
  public List<\u0005.\u0002> \u0001;
  public List<\u0006.\u0005> \u0001;
  public List<\u0006.\u0002> \u0001;

  public \u0005()
  {
    this.\u0001 = new List<PointF>();
    this.\u0001 = new List<\u0005.\u0001>();
    this.\u0001 = new List<\u0005.\u0002>();
    this.\u0001 = new List<\u0006.\u0005>();
    this.\u0001 = new List<\u0006.\u0002>();
  }

  internal sealed class \u0001 : IEqualityComparer<\u0005.\u0001>
  {
    public ushort \u0001;
    public ushort \u0002;
    public \u0005.\u0003 \u0001;
    public List<ushort> \u0001;
    public ushort \u0003;

    public \u0001([In] ushort obj0, [In] ushort obj1)
    {
      this.\u0001 = \u0005.\u0003.\u0001;
      this.\u0001 = new List<ushort>();
      this.\u0001 = obj0;
      this.\u0002 = obj1;
    }

    public bool \u0002([In] \u0005.\u0001 obj0, [In] \u0005.\u0001 obj1)
    {
      return (int) obj0.\u0001 == (int) obj1.\u0001 & (int) obj0.\u0002 == (int) obj1.\u0002 | (int) obj0.\u0001 == (int) obj1.\u0002 & (int) obj0.\u0002 == (int) obj1.\u0001;
    }

    public int \u0002([In] \u0005.\u0001 obj0)
    {
      int num;
      return num;
    }
  }

  internal sealed class \u0002
  {
    public ushort \u0001;
    public ushort \u0002;
    public ushort \u0003;
    public ushort \u0004;
    public ushort \u0005;
    public ushort \u0006;

    public \u0002([In] ushort obj0, [In] ushort obj1, [In] ushort obj2, [In] ushort obj3, [In] ushort obj4, [In] ushort obj5)
    {
      this.\u0001 = obj0;
      this.\u0002 = obj1;
      this.\u0003 = obj2;
      this.\u0004 = obj3;
      this.\u0005 = obj4;
      this.\u0006 = obj5;
    }
  }

  internal enum \u0003 : byte
  {
    \u0002,
    \u0001,
    \u0003,
    \u0004,
    \u0005,
  }
}
