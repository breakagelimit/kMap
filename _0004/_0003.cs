// Decompiled with JetBrains decompiler
// Type: .
// Assembly: kMap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB403103-24EE-4947-BAAC-163727D2381A
// Assembly location: C:\Users\Dev\Downloads\Nouveau dossier (28)\NavTestV2\kMap.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

#nullable disable
namespace \u0004;

internal sealed class \u0003 : IDisposable
{
  private string \u0001;
  private \u0003.\u0005 \u0001;
  private Dictionary<string, \u0004.\u0003.\u0001> \u0001;
  private string \u0002;
  private bool \u0001;

  public \u0003([In] string obj0)
  {
    this.\u0001 = new \u0003.\u0005(new byte[6]
    {
      (byte) 50,
      (byte) 206,
      (byte) 221,
      (byte) 124,
      (byte) 188,
      (byte) 168
    }, 0, 6);
    this.\u0001 = new Dictionary<string, \u0004.\u0003.\u0001>();
    this.\u0002 = \u0001.\u0004.\u0002(741);
    this.\u0001 = false;
    this.\u0001 = obj0;
    BinaryReader binaryReader1 = new BinaryReader((Stream) new FileStream(obj0, FileMode.Open, FileAccess.Read));
    \u0018\u0004.\u007E\u009C\u0007((object) \u001B\u0004.\u007E\u0003\u0008((object) binaryReader1), 0L);
    this.\u0001.Clear();
    char[] chArray = \u0080\u0004.\u007E\u0010\u0008((object) binaryReader1, 30);
    int num1 = (int) \u001F\u0004.\u007E\u000E\u0008((object) binaryReader1);
    int num2 = (int) \u001F\u0004.\u007E\u000E\u0008((object) binaryReader1);
    Stream stream = \u001B\u0004.\u007E\u0003\u0008((object) binaryReader1);
    \u0018\u0004.\u007E\u009C\u0007((object) stream, checked (\u0017\u0004.\u007E\u009B\u0007((object) stream) + 218L));
    byte[] buffer = \u0081\u0004.\u007E\u0011\u0008((object) binaryReader1, 128 /*0x80*/);
    this.\u0001.\u0004(buffer, 0, buffer, 0, 131);
    BinaryReader binaryReader2 = new BinaryReader((Stream) new MemoryStream(buffer));
    try
    {
      byte num3 = \u001C\u0004.\u007E\u0005\u0008((object) binaryReader2);
      string str = new string(\u0080\u0004.\u007E\u0010\u0008((object) binaryReader2, 81));
      byte[] numArray = \u0081\u0004.\u007E\u0011\u0008((object) binaryReader2, 24);
      uint num4 = \u001F\u0004.\u007E\u000E\u0008((object) binaryReader2);
      uint num5 = \u001F\u0004.\u007E\u000E\u0008((object) binaryReader2);
      uint num6 = \u001F\u0004.\u007E\u000E\u0008((object) binaryReader2);
      uint num7 = \u001F\u0004.\u007E\u000E\u0008((object) binaryReader2);
    }
    finally
    {
      if (binaryReader2 != null)
        \u008C\u0002.\u007E\u009F\u0004((object) binaryReader2);
    }
    try
    {
      while (\u0092\u0002.\u0018\u0004(this.\u0002(checked ((uint) \u0017\u0004.\u007E\u009B\u0007((object) \u001B\u0004.\u007E\u0003\u0008((object) binaryReader1))), ref binaryReader1, ref buffer)))
        ;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      \u001F\u0002.\u0082\u0004();
    }
    \u008C\u0002.\u007E\u0004\u0008((object) binaryReader1);
  }

  public object \u0002([In] uint obj0, [In] ref BinaryReader obj1, [In] ref byte[] obj2)
  {
    \u0004.\u0003.\u0002 obj3 = new \u0004.\u0003.\u0002();
    \u0018\u0004.\u007E\u009C\u0007((object) \u001B\u0004.\u007E\u0003\u0008((object) obj1), (long) obj0);
    obj2 = \u0081\u0004.\u007E\u0011\u0008((object) obj1, 128 /*0x80*/);
    if (\u0008\u0003.\u007E\u009C\u0004((object) obj2, 0) != (int) sbyte.MaxValue)
      return (object) false;
    this.\u0001.\u0004(obj2, 0, obj2, 0, 131);
    BinaryReader binaryReader = new BinaryReader((Stream) new MemoryStream(obj2));
    try
    {
      obj3.\u0001 = \u001C\u0004.\u007E\u0005\u0008((object) binaryReader);
      int num1 = 1;
      do
      {
        byte num2 = \u001C\u0004.\u007E\u0005\u0008((object) binaryReader);
        if (num2 >= (byte) 32 /*0x20*/ & num2 <= (byte) 126)
        {
          obj3.Name = \u0019\u0003.\u0015\u0005(obj3.Name, \u009C\u0002.\u001C\u0004(\u0005\u0003.\u0084\u0004((int) num2)));
          checked { ++num1; }
        }
        else
          goto label_6;
      }
      while (num1 <= 81);
      goto label_7;
label_6:
      \u0018\u0004.\u007E\u009C\u0007((object) \u001B\u0004.\u007E\u0003\u0008((object) binaryReader), 82L);
label_7:
      Stream stream = \u001B\u0004.\u007E\u0003\u0008((object) binaryReader);
      \u0018\u0004.\u007E\u009C\u0007((object) stream, checked (\u0017\u0004.\u007E\u009B\u0007((object) stream) + 24L));
      obj3.\u0001 = \u001F\u0004.\u007E\u000E\u0008((object) binaryReader);
      obj3.\u0002 = \u001F\u0004.\u007E\u000E\u0008((object) binaryReader);
      obj3.\u0003 = \u001F\u0004.\u007E\u000E\u0008((object) binaryReader);
      obj3.\u0004 = \u001F\u0004.\u007E\u000E\u0008((object) binaryReader);
    }
    finally
    {
      if (binaryReader != null)
        \u008C\u0002.\u007E\u009F\u0004((object) binaryReader);
    }
    if (obj3.\u0001 == (byte) 2 && obj3.\u0003 != 0U && \u0002\u0003.\u0080\u0004(obj3.Name, \u0001.\u0004.\u0002(746), false) != 0)
    {
      \u0004.\u0003.\u0001 obj4 = new \u0004.\u0003.\u0001();
      obj4.\u0001 = obj3.\u0001;
      obj4.\u0002 = obj3.\u0003;
      if (this.\u0001.ContainsKey(\u0019\u0003.\u0015\u0005(this.\u0002, obj3.Name)))
      {
        \u0083\u0003.\u008E\u0005(\u0001.\u0004.\u0002(747));
        return (object) false;
      }
      this.\u0001.Add(\u0019\u0003.\u0015\u0005(this.\u0002, obj3.Name), obj4);
    }
    if (obj3.\u0001 == (byte) 0)
      return (object) false;
    if (obj3.\u0001 == (byte) 1 & \u0002\u0003.\u0080\u0004(obj3.Name, \u0001.\u0004.\u0002(756), false) != 0 & \u0002\u0003.\u0080\u0004(obj3.Name, \u0001.\u0004.\u0002(761), false) != 0)
    {
      this.\u0002 = \u001A\u0003.\u0016\u0005(this.\u0002, obj3.Name, \u0001.\u0004.\u0002(741));
      this.\u0002 = \u0095\u0002.\u007E\u0010\u0005((object) this.\u0002);
      uint num = checked ((uint) \u0017\u0004.\u007E\u009B\u0007((object) \u001B\u0004.\u007E\u0003\u0008((object) obj1)));
      \u0018\u0004.\u007E\u009C\u0007((object) \u001B\u0004.\u007E\u0003\u0008((object) obj1), (long) obj3.\u0001);
      do
        ;
      while (\u0092\u0002.\u0018\u0004(this.\u0002(checked ((uint) \u0017\u0004.\u007E\u009B\u0007((object) \u001B\u0004.\u007E\u0003\u0008((object) obj1))), ref obj1, ref obj2)));
      \u0018\u0004.\u007E\u009C\u0007((object) \u001B\u0004.\u007E\u0003\u0008((object) obj1), (long) num);
      this.\u0002 = \u0014\u0003.\u007E\u0012\u0005((object) this.\u0002, checked (\u009A\u0002.\u0086\u0004(this.\u0002) - \u009A\u0002.\u0086\u0004(obj3.Name) - 1), checked (\u009A\u0002.\u0086\u0004(obj3.Name) + 1));
    }
    if (obj3.\u0004 > 0U)
      \u0018\u0004.\u007E\u009C\u0007((object) \u001B\u0004.\u007E\u0003\u0008((object) obj1), (long) obj3.\u0004);
    return \u0017\u0004.\u007E\u009B\u0007((object) \u001B\u0004.\u007E\u0003\u0008((object) obj1)) == (long) obj3.\u0001 ? (object) false : (object) true;
  }

  public byte[] \u0002([In] string obj0)
  {
    obj0 = \u0095\u0002.\u007E\u0010\u0005((object) obj0);
    if (!this.\u0001.ContainsKey(obj0))
      return (byte[]) null;
    FileStream input = new FileStream(this.\u0001, FileMode.Open, FileAccess.Read);
    byte[] numArray;
    try
    {
      BinaryReader binaryReader = new BinaryReader((Stream) input);
      try
      {
        \u0018\u0004.\u007E\u009C\u0007((object) \u001B\u0004.\u007E\u0003\u0008((object) binaryReader), (long) this.\u0001[obj0].\u0001);
        numArray = \u0081\u0004.\u007E\u0011\u0008((object) binaryReader, checked ((int) this.\u0001[obj0].\u0002));
      }
      finally
      {
        if (binaryReader != null)
          \u008C\u0002.\u007E\u009F\u0004((object) binaryReader);
      }
    }
    finally
    {
      if (input != null)
        \u008C\u0002.\u007E\u009F\u0004((object) input);
    }
    return numArray;
  }

  protected virtual void \u0002([In] bool obj0)
  {
    if (!this.\u0001)
    {
      if (!obj0)
        ;
      this.\u0001 = (Dictionary<string, \u0004.\u0003.\u0001>) null;
      this.\u0001 = (\u0003.\u0005) null;
    }
    this.\u0001 = true;
  }

  public void Dispose()
  {
    this.\u0002(true);
    \u008C\u0002.\u009C\u0005((object) this);
  }

  internal sealed class \u0001
  {
    public uint \u0001;
    public uint \u0002;

    [DebuggerNonUserCode]
    public \u0001()
    {
    }
  }

  internal struct \u0002
  {
    public byte \u0001;
    public string Name;
    public uint \u0001;
    public uint \u0002;
    public uint \u0003;
    public uint \u0004;
  }
}
