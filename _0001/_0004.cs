// Decompiled with JetBrains decompiler
// Type: .
// Assembly: kMap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB403103-24EE-4947-BAAC-163727D2381A
// Assembly location: C:\Users\Dev\Downloads\Nouveau dossier (28)\NavTestV2\kMap.exe

using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace \u0001;

internal sealed class \u0004
{
  private static string \u0001 = "0";
  private static string \u0002 = "206";
  private static byte[] \u0001 = (byte[]) null;
  private static Hashtable \u0001 = (Hashtable) null;
  private static bool \u0001 = false;
  private static int \u0001 = 0;

  public static string \u0002([In] int obj0)
  {
    obj0 -= \u0004.\u0001;
    if (\u0004.\u0001)
    {
      string str = (string) \u0099\u0003.\u007E\u0082\u0006((object) \u0004.\u0001, (object) obj0);
      if (str != null)
        return str;
    }
    int num1 = obj0;
    byte[] numArray1 = \u0004.\u0001;
    int index1 = num1;
    int num2 = index1 + 1;
    int num3 = (int) numArray1[index1];
    int num4;
    if ((num3 & 128 /*0x80*/) == 0)
    {
      num4 = num3;
      if (num4 == 0)
        return string.Empty;
    }
    else if ((num3 & 64 /*0x40*/) == 0)
    {
      num4 = ((num3 & 63 /*0x3F*/) << 8) + (int) \u0004.\u0001[num2++];
    }
    else
    {
      int num5 = (num3 & 31 /*0x1F*/) << 24;
      byte[] numArray2 = \u0004.\u0001;
      int index2 = num2;
      int num6 = index2 + 1;
      int num7 = (int) numArray2[index2] << 16 /*0x10*/;
      int num8 = num5 + num7;
      byte[] numArray3 = \u0004.\u0001;
      int index3 = num6;
      int num9 = index3 + 1;
      int num10 = (int) numArray3[index3] << 8;
      int num11 = num8 + num10;
      byte[] numArray4 = \u0004.\u0001;
      int index4 = num9;
      num2 = index4 + 1;
      int num12 = (int) numArray4[index4];
      num4 = num11 + num12;
    }
    try
    {
      byte[] numArray5 = \u0089\u0003.\u0094\u0005(\u0013\u0004.\u007E\u0092\u0007((object) \u0014\u0004.\u0093\u0007(), \u0004.\u0001, num2, num4));
      string str = \u001D\u0003.\u0019\u0005(\u0013\u0004.\u007E\u0092\u0007((object) \u0014\u0004.\u0093\u0007(), numArray5, 0, numArray5.Length));
      if (\u0004.\u0001)
      {
        try
        {
          \u0098\u0003.\u007E\u0080\u0006((object) \u0004.\u0001, (object) obj0, (object) str);
        }
        catch
        {
        }
      }
      return str;
    }
    catch
    {
      return (string) null;
    }
  }

  static \u0004()
  {
    if (\u000F\u0003.\u0001\u0005(\u0004.\u0001, "1"))
    {
      \u0004.\u0001 = true;
      \u0004.\u0001 = new Hashtable();
    }
    \u0004.\u0001 = \u009A\u0002.\u0092\u0005(\u0004.\u0002);
    Assembly assembly = \u0004\u0004.\u001A\u0007();
    Stream stream = \u009E\u0003.\u007E\u0014\u0007((object) assembly, "{db403103-24ee-4947-baac-163727d2381a}");
    try
    {
      int length = \u0087\u0003.\u0091\u0005(\u0017\u0004.\u007E\u009A\u0007((object) stream));
      byte[] numArray = new byte[(int) checked ((uint) length)];
      int num = \u0019\u0004.\u007E\u009E\u0007((object) stream, numArray, 0, length);
      \u0004.\u0001 = \u0002.\u0004.\u0002(numArray);
      \u008C\u0002.\u007E\u009D\u0007((object) stream);
    }
    finally
    {
      if (stream != null)
        \u008C\u0002.\u007E\u009F\u0004((object) stream);
    }
  }
}
