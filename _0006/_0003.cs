// Decompiled with JetBrains decompiler
// Type: .
// Assembly: kMap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB403103-24EE-4947-BAAC-163727D2381A
// Assembly location: C:\Users\Dev\Downloads\Nouveau dossier (28)\NavTestV2\kMap.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace \u0006;

internal sealed class \u0003
{
  private int \u0001;
  private int \u0002;
  private int \u0003;
  private int \u0004;
  private int \u0005;
  private int \u0006;
  private int \u0007;
  private int \u0008;
  public List<\u0006.\u0003.\u0001> \u0001;
  public List<\u0006.\u0003.\u0003> \u0001;
  public List<\u0006.\u0003.\u0002> \u0001;
  public List<\u0006.\u0003.\u0002> \u0002;
  public bool \u0001;
  public bool \u0002;

  public \u0003([In] string obj0)
  {
    this.\u0001 = new List<\u0006.\u0003.\u0001>();
    this.\u0001 = new List<\u0006.\u0003.\u0003>();
    this.\u0001 = new List<\u0006.\u0003.\u0002>();
    this.\u0002 = new List<\u0006.\u0003.\u0002>();
    obj0 = \u0019\u0003.\u0015\u0005(\u0001.\u0004.\u0002(741), obj0);
    byte[] buffer = \u0005.\u0005.\u0002.\u0002(obj0);
    if (buffer == null)
      return;
    BinaryReader binaryReader = new BinaryReader((Stream) new MemoryStream(buffer));
    char[] chArray = \u0080\u0004.\u007E\u0010\u0008((object) binaryReader, 12);
    this.\u0001 = \u0011\u0003.\u007E\u0008\u0008((object) binaryReader);
    this.\u0002 = \u0011\u0003.\u007E\u0008\u0008((object) binaryReader);
    this.\u0003 = \u0011\u0003.\u007E\u0008\u0008((object) binaryReader);
    this.\u0004 = \u0011\u0003.\u007E\u0008\u0008((object) binaryReader);
    this.\u0005 = \u0011\u0003.\u007E\u0008\u0008((object) binaryReader);
    this.\u0006 = \u0011\u0003.\u007E\u0008\u0008((object) binaryReader);
    this.\u0007 = \u0011\u0003.\u007E\u0008\u0008((object) binaryReader);
    this.\u0008 = \u0011\u0003.\u007E\u0008\u0008((object) binaryReader);
    \u0018\u0004.\u007E\u009C\u0007((object) \u001B\u0004.\u007E\u0003\u0008((object) binaryReader), (long) this.\u0008);
    int num1 = \u0011\u0003.\u007E\u0008\u0008((object) binaryReader);
    this.\u0001.Clear();
    int num2 = num1;
    int num3 = 1;
    while (num3 <= num2)
    {
      \u0006.\u0003.\u0001 obj = new \u0006.\u0003.\u0001();
      obj.\u0002(\u007F\u0004.\u007E\u000F\u0008((object) binaryReader) / 10f);
      obj.\u0004(\u007F\u0004.\u007E\u000F\u0008((object) binaryReader) / 10f);
      obj.\u0003(\u007F\u0004.\u007E\u000F\u0008((object) binaryReader) / 10f);
      int num4 = (int) \u001C\u0004.\u007E\u0005\u0008((object) binaryReader);
      this.\u0001.Add(obj);
      checked { ++num3; }
    }
    int num5 = \u0011\u0003.\u007E\u0008\u0008((object) binaryReader);
    this.\u0001.Clear();
    int num6 = num5;
    int num7 = 1;
    while (num7 <= num6)
    {
      \u0006.\u0003.\u0003 obj = new \u0006.\u0003.\u0003();
      obj.\u0002(\u001E\u0004.\u007E\u0007\u0008((object) binaryReader));
      obj.\u0003(\u001E\u0004.\u007E\u0007\u0008((object) binaryReader));
      obj.\u0004(\u001E\u0004.\u007E\u0007\u0008((object) binaryReader));
      obj.\u0005(\u001E\u0004.\u007E\u0007\u0008((object) binaryReader));
      if (obj.\u0005() != (ushort) 0)
        throw new Exception(\u0001.\u0004.\u0002(747));
      this.\u0001.Add(obj);
      checked { ++num7; }
    }
    int num8 = \u0011\u0003.\u007E\u0008\u0008((object) binaryReader);
    this.\u0002.Clear();
    int num9 = num8;
    int num10 = 1;
    while (num10 <= num9)
    {
      \u0006.\u0003.\u0002 obj = new \u0006.\u0003.\u0002();
      obj.\u0002(\u001E\u0004.\u007E\u0007\u0008((object) binaryReader));
      obj.\u0003(\u001E\u0004.\u007E\u0007\u0008((object) binaryReader));
      obj.\u0004(\u001E\u0004.\u007E\u0007\u0008((object) binaryReader));
      obj.\u0005(\u001E\u0004.\u007E\u0007\u0008((object) binaryReader));
      obj.\u0002(\u001C\u0004.\u007E\u0005\u0008((object) binaryReader));
      if (obj.\u0002() == (byte) 3)
        this.\u0001 = true;
      if (obj.\u0002() == byte.MaxValue)
        \u0083\u0003.\u008E\u0005(\u0001.\u0004.\u0002(746));
      this.\u0002.Add(obj);
      try
      {
        if (obj.\u0004() != ushort.MaxValue)
          this.\u0001[(int) obj.\u0004()].\u0006(checked ((ushort) (this.\u0002.Count - 1)));
        if (obj.\u0005() != ushort.MaxValue)
          this.\u0001[(int) obj.\u0005()].\u0006(checked ((ushort) (this.\u0002.Count - 1)));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        \u001F\u0002.\u0082\u0004();
      }
      checked { ++num10; }
    }
    int num11 = \u0011\u0003.\u007E\u0008\u0008((object) binaryReader);
    this.\u0001.Clear();
    int num12 = num11;
    int num13 = 1;
    while (num13 <= num12)
    {
      \u0006.\u0003.\u0002 obj = new \u0006.\u0003.\u0002();
      obj.\u0002(\u001E\u0004.\u007E\u0007\u0008((object) binaryReader));
      obj.\u0003(\u001E\u0004.\u007E\u0007\u0008((object) binaryReader));
      obj.\u0004(\u001E\u0004.\u007E\u0007\u0008((object) binaryReader));
      obj.\u0005(\u001E\u0004.\u007E\u0007\u0008((object) binaryReader));
      obj.\u0002(\u001C\u0004.\u007E\u0005\u0008((object) binaryReader));
      if (obj.\u0002() == (byte) 7)
        this.\u0002 = true;
      this.\u0001.Add(obj);
      if (obj.\u0004() != ushort.MaxValue)
        this.\u0001[(int) obj.\u0004()].\u0006(checked ((ushort) (this.\u0001.Count - 1)));
      if (obj.\u0005() != ushort.MaxValue)
        this.\u0001[(int) obj.\u0005()].\u0006(checked ((ushort) (this.\u0001.Count - 1)));
      checked { ++num13; }
    }
    \u008C\u0002.\u007E\u0004\u0008((object) binaryReader);
  }

  internal sealed class \u0001
  {
    [DebuggerNonUserCode]
    public \u0001()
    {
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
    public void \u0004([In] float obj0) => this.\u0003 = obj0;

    [SpecialName]
    public PointF \u0002() => new PointF(this.\u0002(), this.\u0003());
  }

  internal sealed class \u0002
  {
    [DebuggerNonUserCode]
    public \u0002()
    {
    }

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

    [DebuggerNonUserCode]
    [SpecialName]
    public byte \u0002() => this.\u0001;

    [DebuggerNonUserCode]
    [SpecialName]
    public void \u0002([In] byte obj0) => this.\u0001 = obj0;
  }

  internal sealed class \u0003
  {
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

    [DebuggerNonUserCode]
    [SpecialName]
    public ushort[] \u0002() => this.\u0001;

    [DebuggerNonUserCode]
    [SpecialName]
    public void \u0002([In] ushort[] obj0) => this.\u0001 = obj0;

    public void \u0006([In] ushort obj0)
    {
      this.\u0002()[(int) this.\u0005()] = obj0;
      this.\u0005(checked ((ushort) ((int) this.\u0005() + 1)));
    }

    public \u0003() => this.\u0002(new ushort[3]);
  }
}
