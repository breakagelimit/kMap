// Decompiled with JetBrains decompiler
// Type: .
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
namespace \u0007;

internal sealed class \u0003
{
  public int \u0001;
  public int \u0002;
  public int \u0003;
  public int \u0004;

  [DebuggerNonUserCode]
  [SpecialName]
  public \u0007.\u0001[] \u0002() => this.\u0001;

  [DebuggerNonUserCode]
  [SpecialName]
  public void \u0002([In] \u0007.\u0001[] obj0) => this.\u0001 = obj0;

  [DebuggerNonUserCode]
  [SpecialName]
  public \u0007.\u0004[] \u0002() => this.\u0001;

  [DebuggerNonUserCode]
  [SpecialName]
  public void \u0002([In] \u0007.\u0004[] obj0) => this.\u0001 = obj0;

  [DebuggerNonUserCode]
  [SpecialName]
  public float[] \u0002() => this.\u0001;

  [DebuggerNonUserCode]
  [SpecialName]
  public void \u0002([In] float[] obj0) => this.\u0001 = obj0;

  [DebuggerNonUserCode]
  [SpecialName]
  public \u0006.\u0005[] \u0002() => this.\u0001;

  [DebuggerNonUserCode]
  [SpecialName]
  public void \u0002([In] \u0006.\u0005[] obj0) => this.\u0001 = obj0;

  [DebuggerNonUserCode]
  [SpecialName]
  public \u0006.\u0002[] \u0002() => this.\u0001;

  [DebuggerNonUserCode]
  [SpecialName]
  public void \u0002([In] \u0006.\u0002[] obj0) => this.\u0001 = obj0;

  [DebuggerNonUserCode]
  [SpecialName]
  public byte \u0002() => this.\u0001;

  [DebuggerNonUserCode]
  [SpecialName]
  public void \u0002([In] byte obj0) => this.\u0001 = obj0;

  [DebuggerNonUserCode]
  [SpecialName]
  public byte \u0003() => this.\u0002;

  [DebuggerNonUserCode]
  [SpecialName]
  public void \u0003([In] byte obj0) => this.\u0002 = obj0;

  public \u0003([In] byte obj0, [In] byte obj1)
  {
    this.\u0002(obj0);
    this.\u0003(obj1);
    this.\u0001 = 0;
    this.\u0002 = 192 /*0xC0*/;
    this.\u0003 = 0;
    this.\u0004 = 192 /*0xC0*/;
    this.\u0002();
  }

  private void \u0002()
  {
    \u0004.\u0003 obj1 = \u0005.\u0005.\u0002;
    \u001B\u0003 obj2 = \u001B\u0003.\u0017\u0005;
    string str1 = \u0001.\u0004.\u0002(2058);
    byte num1 = this.\u0003();
    string str2 = num1.ToString(\u0001.\u0004.\u0002(2075));
    byte num2 = this.\u0002();
    string str3 = num2.ToString(\u0001.\u0004.\u0002(2075));
    string str4 = \u0001.\u0004.\u0002(2080);
    string str5 = obj2(str1, str2, str3, str4);
    byte[] buffer = obj1.\u0002(str5);
    if (buffer == null)
    {
      \u0084\u0003 obj3 = \u0084\u0003.\u008F\u0005;
      string str6 = \u0001.\u0004.\u0002(2089);
      \u001B\u0003 obj4 = \u001B\u0003.\u0017\u0005;
      string str7 = \u0001.\u0004.\u0002(2058);
      num2 = this.\u0003();
      string str8 = num2.ToString(\u0001.\u0004.\u0002(2075));
      num1 = this.\u0002();
      string str9 = num1.ToString(\u0001.\u0004.\u0002(2075));
      string str10 = \u0001.\u0004.\u0002(2080);
      string str11 = obj4(str7, str8, str9, str10);
      obj3(str6, (object) str11);
    }
    else
    {
      BinaryReader binaryReader = new BinaryReader((Stream) new MemoryStream(buffer));
      char[] chArray = \u0080\u0004.\u007E\u0010\u0008((object) binaryReader, 12);
      this.\u0002(ref binaryReader);
      this.\u0003(ref binaryReader);
      this.\u0004(ref binaryReader);
      this.\u0005(ref binaryReader);
      this.\u0006(ref binaryReader);
      this.\u0007(ref binaryReader);
      \u008C\u0002.\u007E\u0004\u0008((object) binaryReader);
    }
  }

  private void \u0002([In] ref BinaryReader obj0)
  {
    ushort num1 = \u001E\u0004.\u007E\u0007\u0008((object) obj0);
    this.\u0002(new \u0007.\u0001[checked ((int) num1 - 1 + 1)]);
    short num2 = checked ((short) ((int) num1 - 1));
    short index = 0;
    while ((int) index <= (int) num2)
    {
      \u0007.\u0001 obj = new \u0007.\u0001();
      obj.\u0002(\u001F\u0004.\u007E\u000E\u0008((object) obj0));
      obj.\u0002().\u0002(\u007F\u0004.\u007E\u000F\u0008((object) obj0) / 10f);
      obj.\u0002().\u0004(\u007F\u0004.\u007E\u000F\u0008((object) obj0) / 10f);
      obj.\u0002().\u0003((float) (192.0 - (double) \u007F\u0004.\u007E\u000F\u0008((object) obj0) / 10.0));
      obj.\u0002(\u001D\u0004.\u007E\u0006\u0008((object) obj0));
      obj.\u0002(\u007F\u0004.\u007E\u000F\u0008((object) obj0));
      obj.\u0003(\u001D\u0004.\u007E\u0006\u0008((object) obj0));
      obj.\u0004(\u001D\u0004.\u007E\u0006\u0008((object) obj0));
      obj.\u0005(\u001D\u0004.\u007E\u0006\u0008((object) obj0));
      obj.\u0006(\u001D\u0004.\u007E\u0006\u0008((object) obj0));
      short num3 = checked ((short) \u001E\u0004.\u007E\u0007\u0008((object) obj0));
      short num4 = 1;
      while ((int) num4 <= (int) num3)
      {
        Stream stream = \u001B\u0004.\u007E\u0003\u0008((object) obj0);
        \u0018\u0004.\u007E\u009C\u0007((object) stream, checked (\u0017\u0004.\u007E\u009B\u0007((object) stream) + 6L));
        checked { ++num4; }
      }
      this.\u0002()[(int) index] = obj;
      checked { ++index; }
    }
  }

  private void \u0003([In] ref BinaryReader obj0)
  {
    int num1 = \u0011\u0003.\u007E\u0008\u0008((object) obj0);
    int num2 = \u0011\u0003.\u007E\u0008\u0008((object) obj0);
    this.\u0002(new \u0007.\u0004[checked (num1 - 1 + 1)]);
    int num3 = checked (num1 - 1);
    int index = 0;
    while (index <= num3)
    {
      \u0007.\u0004 obj = new \u0007.\u0004();
      obj.\u0002(\u007F\u0004.\u007E\u000F\u0008((object) obj0) / 10f);
      obj.\u0004((float) (192.0 - (double) \u007F\u0004.\u007E\u000F\u0008((object) obj0) / 10.0));
      obj.\u0003(\u007F\u0004.\u007E\u000F\u0008((object) obj0) / 10f);
      obj.\u0005((float) (192.0 - (double) \u007F\u0004.\u007E\u000F\u0008((object) obj0) / 10.0));
      byte num4 = \u001C\u0004.\u007E\u0005\u0008((object) obj0);
      byte num5 = 1;
      while ((uint) num5 <= (uint) num4)
      {
        ushort num6 = \u001E\u0004.\u007E\u0007\u0008((object) obj0);
        obj.\u0002().Add(num6);
        checked { ++num5; }
      }
      this.\u0002()[index] = obj;
      checked { ++index; }
    }
  }

  private void \u0004([In] ref BinaryReader obj0)
  {
    int num1 = \u0011\u0003.\u007E\u0008\u0008((object) obj0);
    this.\u0002(new \u0006.\u0002[checked (num1 - 1 + 1)]);
    int num2 = checked (num1 - 1);
    int index = 0;
    while (index <= num2)
    {
      \u0006.\u0002 obj1 = new \u0006.\u0002();
      \u0006.\u0002 obj2 = obj1;
      PointF pointF1 = new PointF(\u007F\u0004.\u007E\u000F\u0008((object) obj0) / 10f, (float) (192.0 - (double) \u007F\u0004.\u007E\u000F\u0008((object) obj0) / 10.0));
      PointF pointF2 = pointF1;
      obj2.\u0002(pointF2);
      \u0006.\u0002 obj3 = obj1;
      pointF1 = new PointF(\u007F\u0004.\u007E\u000F\u0008((object) obj0) / 10f, (float) (192.0 - (double) \u007F\u0004.\u007E\u000F\u0008((object) obj0) / 10.0));
      PointF pointF3 = pointF1;
      obj3.\u0003(pointF3);
      byte num3 = \u001C\u0004.\u007E\u0005\u0008((object) obj0);
      byte num4 = \u001C\u0004.\u007E\u0005\u0008((object) obj0);
      byte num5 = \u001C\u0004.\u007E\u0005\u0008((object) obj0);
      obj1.\u0002(\u001E\u0004.\u007E\u0007\u0008((object) obj0));
      obj1.\u0003(\u001E\u0004.\u007E\u0007\u0008((object) obj0));
      obj1.\u0004(\u001E\u0004.\u007E\u0007\u0008((object) obj0));
      obj1.\u0005(\u001E\u0004.\u007E\u0007\u0008((object) obj0));
      if (!(num4 != byte.MaxValue & num5 != byte.MaxValue))
        \u0083\u0003.\u008E\u0005(\u0001.\u0004.\u0002(2118));
      this.\u0002()[index] = obj1;
      if ((int) this.\u0002() == (int) obj1.\u0004())
        this.\u0002()[(int) obj1.\u0002()].\u0004().Add(checked ((ushort) index));
      else
        this.\u0002()[(int) obj1.\u0003()].\u0004().Add(checked ((ushort) index));
      checked { ++index; }
    }
  }

  private void \u0005([In] ref BinaryReader obj0)
  {
    int num1 = \u0011\u0003.\u007E\u0008\u0008((object) obj0);
    this.\u0002(new \u0006.\u0005[checked (num1 - 1 + 1)]);
    int num2 = checked (num1 - 1);
    int index = 0;
    while (index <= num2)
    {
      \u0006.\u0005 obj1 = new \u0006.\u0005();
      \u0006.\u0005 obj2 = obj1;
      PointF pointF1 = new PointF(\u007F\u0004.\u007E\u000F\u0008((object) obj0) / 10f, (float) (192.0 - (double) \u007F\u0004.\u007E\u000F\u0008((object) obj0) / 10.0));
      PointF pointF2 = pointF1;
      obj2.\u0002(pointF2);
      \u0006.\u0005 obj3 = obj1;
      pointF1 = new PointF(\u007F\u0004.\u007E\u000F\u0008((object) obj0) / 10f, (float) (192.0 - (double) \u007F\u0004.\u007E\u000F\u0008((object) obj0) / 10.0));
      PointF pointF3 = pointF1;
      obj3.\u0003(pointF3);
      byte num3 = \u001C\u0004.\u007E\u0005\u0008((object) obj0);
      byte num4 = \u001C\u0004.\u007E\u0005\u0008((object) obj0);
      byte num5 = \u001C\u0004.\u007E\u0005\u0008((object) obj0);
      obj1.\u0002(\u001E\u0004.\u007E\u0007\u0008((object) obj0));
      obj1.\u0003(\u001E\u0004.\u007E\u0007\u0008((object) obj0));
      this.\u0002()[index] = obj1;
      if (obj1.\u0002() != ushort.MaxValue)
        this.\u0002()[(int) obj1.\u0002()].\u0003().Add(checked ((ushort) index));
      if (obj1.\u0003() != ushort.MaxValue)
        this.\u0002()[(int) obj1.\u0003()].\u0003().Add(checked ((ushort) index));
      checked { ++index; }
    }
  }

  private void \u0006([In] ref BinaryReader obj0)
  {
    Stream stream = \u001B\u0004.\u007E\u0003\u0008((object) obj0);
    \u0018\u0004.\u007E\u009C\u0007((object) stream, checked (\u0017\u0004.\u007E\u009B\u0007((object) stream) + 73728L /*0x012000*/));
  }

  private void \u0007([In] ref BinaryReader obj0)
  {
    this.\u0002(new float[9409]);
    int index = 0;
    do
    {
      this.\u0002()[index] = \u007F\u0004.\u007E\u000F\u0008((object) obj0);
      checked { ++index; }
    }
    while (index <= 9408);
  }

  public \u0006.\u0003 \u0002([In] ref \u0007.\u0001 obj0, [In] ref \u0007.\u0002 obj1)
  {
    string str = obj1.\u0002(checked ((int) obj0.\u0002()));
    \u0006.\u0004 obj2 = \u0002\u0003.\u0080\u0004(str, \u0001.\u0004.\u0002(746), false) != 0 ? new \u0006.\u0004(str) : throw new Exception(\u0001.\u0004.\u0002(2127));
    \u0006.\u0003 obj3;
    \u0006.\u0003 obj4;
    try
    {
      obj3 = new \u0006.\u0003(obj2.\u0001);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      \u0083\u0003.\u008E\u0005(\u0019\u0003.\u0015\u0005(\u0001.\u0004.\u0002(2172), obj2.\u0001));
      obj4 = (\u0006.\u0003) null;
      \u001F\u0002.\u0082\u0004();
      goto label_10;
    }
    try
    {
      foreach (\u0006.\u0003.\u0001 obj5 in obj3.\u0001)
      {
        float num1 = (float) ((double) obj5.\u0002() * \u008C\u0003.\u009E\u0005(-(double) obj0.\u0002()) - -(double) obj5.\u0003() * \u008C\u0003.\u0001\u0006(-(double) obj0.\u0002()));
        float num2 = (float) ((double) obj5.\u0002() * \u008C\u0003.\u0001\u0006(-(double) obj0.\u0002()) + -(double) obj5.\u0003() * \u008C\u0003.\u009E\u0005(-(double) obj0.\u0002()));
        obj5.\u0002(num1 + obj0.\u0002().\u0002());
        obj5.\u0003(num2 + obj0.\u0002().\u0003());
      }
    }
    finally
    {
      List<\u0006.\u0003.\u0001>.Enumerator enumerator;
      enumerator.Dispose();
    }
    obj4 = obj3;
label_10:
    return obj4;
  }

  public ushort \u0002()
  {
    return (ushort) ((int) (ushort) ((int) this.\u0003() << 8) ^ (int) this.\u0002());
  }
}
