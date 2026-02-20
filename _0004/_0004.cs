// Decompiled with JetBrains decompiler
// Type: .
// Assembly: kMap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB403103-24EE-4947-BAAC-163727D2381A
// Assembly location: C:\Users\Dev\Downloads\Nouveau dossier (28)\NavTestV2\kMap.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace \u0004;

internal sealed class \u0004
{
  private \u0005.\u0003 \u0001;
  private \u0005.\u0003 \u0002;
  private Dictionary<uint, \u0007.\u0003> \u0001;
  private Dictionary<uint, \u0007.\u0005> \u0001;
  private \u0007.\u0005 \u0001;
  private Dictionary<ulong, \u0004.\u0004.\u0002> \u0001;
  private Dictionary<ulong, \u0004.\u0004.\u0002> \u0002;
  private ulong[] \u0001;
  private ulong \u0001;
  private bool \u0001;
  private float \u0001;

  public \u0004()
  {
    this.\u0001 = new Dictionary<uint, \u0007.\u0003>();
    this.\u0001 = new Dictionary<uint, \u0007.\u0005>();
    this.\u0001 = new Dictionary<ulong, \u0004.\u0004.\u0002>();
    this.\u0002 = new Dictionary<ulong, \u0004.\u0004.\u0002>();
    this.\u0001 = 1f;
  }

  public ushort \u0002([In] ref byte obj0, [In] ref byte obj1)
  {
    return (ushort) ((int) (ushort) ((uint) obj1 << 8) | (int) obj0);
  }

  public \u0007.\u0003 \u0002([In] ref ushort obj0)
  {
    if (this.\u0001.ContainsKey((uint) obj0))
      return this.\u0001[(uint) obj0];
    \u0007.\u0003 obj = new \u0007.\u0003(checked ((byte) ((int) obj0 & (int) byte.MaxValue)), checked ((byte) unchecked ((ushort) ((uint) obj0 >> 8))));
    this.\u0001.Add((uint) obj0, obj);
    return obj;
  }

  public \u0007.\u0003 \u0002([In] ref byte obj0, [In] ref byte obj1)
  {
    ushort num = this.\u0002(ref obj0, ref obj1);
    return this.\u0002(ref num);
  }

  public \u0007.\u0005 \u0002([In] ref ushort obj0, [In] ref ushort obj1)
  {
    uint key = (uint) obj0 << 16 /*0x10*/ | (uint) obj1;
    \u0007.\u0005 obj2;
    if (!this.\u0001.ContainsKey(key))
    {
      \u0004.\u0005 obj3;
      try
      {
        \u0007.\u0003 obj4 = this.\u0002(ref obj0);
        obj3 = new \u0004.\u0005(ref obj4, (int) obj1);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        \u0086\u0003.\u0090\u0005(\u0001.\u0004.\u0002(766), (object) obj0.ToString(\u0001.\u0004.\u0002(827)), (object) obj1);
        obj2 = (\u0007.\u0005) null;
        \u001F\u0002.\u0082\u0004();
        goto label_4;
      }
      this.\u0001.Add(key, obj3.\u0001);
      obj2 = obj3.\u0001;
    }
    else
      goto label_5;
label_4:
    return obj2;
label_5:
    obj2 = this.\u0001[key];
    goto label_4;
  }

  public bool \u0002([In] ref \u0005.\u0003 obj0, [In] ref \u0005.\u0003 obj1, [In] ref \u0005.\u0003[] obj2, [In] float obj3)
  {
    if (this.\u0001.Count > 15)
    {
      this.\u0001.Clear();
      this.\u0001.Clear();
    }
    this.\u0001 = obj3;
    this.\u0001.Clear();
    this.\u0002.Clear();
    this.\u0001 = obj0;
    this.\u0002 = obj1;
    this.\u0001 = false;
    this.\u0002();
    this.\u0003();
    if (this.\u0001.Count == 0 | this.\u0001.Length == 0)
    {
      \u0083\u0003.\u008E\u0005(\u0001.\u0004.\u0002(832));
      return false;
    }
    while (this.\u0001.Count != 0)
    {
      ulong num1 = this.\u0002();
      if (!this.\u0002(ref num1))
      {
        \u0083\u0003.\u008E\u0005(\u0001.\u0004.\u0002(898));
        \u0086\u0003.\u0090\u0005(\u0001.\u0004.\u0002(923), (object) this.\u0001.Count, (object) this.\u0002.Count);
        \u0004.\u0004.\u0002 obj = this.\u0002[this.\u0001];
        List<\u0005.\u0003> objList = new List<\u0005.\u0003>();
        while (true)
        {
          \u0005.\u0003[] objArray1 = this.\u0002(ref obj);
          float num2 = objArray1[0].\u0002() - objArray1[1].\u0002();
          float num3 = objArray1[0].\u0003() - objArray1[1].\u0003();
          \u0005.\u0003[] objArray2 = objArray1;
          \u0005.\u0003[] objArray3 = objArray2;
          int index1 = 0;
          int index2 = index1;
          objArray3[index2].\u0002(objArray2[index1].\u0002() - num2 / 2f);
          \u0005.\u0003[] objArray4 = objArray1;
          \u0005.\u0003[] objArray5 = objArray4;
          int index3 = 0;
          int index4 = index3;
          objArray5[index4].\u0003(objArray4[index3].\u0003() - num3 / 2f);
          objList.Add(objArray1[0]);
          if (\u008A\u0003.\u0096\u0005(new Decimal(obj.\u0001), 0M) != 0)
            obj = this.\u0002[obj.\u0001];
          else
            break;
        }
        obj2 = objList.ToArray();
        return true;
      }
    }
    \u0083\u0003.\u008E\u0005(\u0001.\u0004.\u0002(865));
    return false;
  }

  public bool \u0002([In] ref ulong obj0)
  {
    \u0004.\u0004.\u0002 obj1 = this.\u0001[obj0];
    this.\u0001.Remove(obj0);
    this.\u0002.Add(obj1.\u0002(), obj1);
    ulong[] numArray = this.\u0001;
    int index1 = 0;
    while (index1 < numArray.Length)
    {
      ulong num = numArray[index1];
      if ((long) obj0 == (long) num)
      {
        this.\u0001 = obj0;
        return false;
      }
      checked { ++index1; }
    }
    \u0004.\u0004.\u0002[] objArray1 = this.\u0002(ref obj1);
    if (objArray1 == null)
      return true;
    \u0004.\u0004.\u0002[] objArray2 = objArray1;
    int index2 = 0;
    while (index2 < objArray2.Length)
    {
      \u0004.\u0004.\u0002 obj2 = objArray2[index2];
      ulong key = obj2.\u0002();
      if (!this.\u0002.ContainsKey(key))
      {
        obj2.\u0002 = checked (obj1.\u0002 + this.\u0002(ref obj1, ref obj2));
        if (this.\u0001.ContainsKey(key))
        {
          if (obj2.\u0002 < this.\u0001[key].\u0002)
          {
            obj2.\u0001 = this.\u0001[key].\u0002;
            obj2.\u0001 = obj0;
            this.\u0001[key] = obj2;
          }
        }
        else
        {
          obj2.\u0001 = obj0;
          obj2.\u0001 = this.\u0002(obj2);
          this.\u0001.Add(key, obj2);
        }
      }
      checked { ++index2; }
    }
    return true;
  }

  public \u0004.\u0004.\u0002[] \u0002([In] ref \u0004.\u0004.\u0002 obj0)
  {
    \u0004.\u0004.\u0002[] objArray;
    switch (obj0.\u0001)
    {
      case \u0004.\u0004.\u0001.\u0002:
        \u0007.\u0003 obj1 = this.\u0002(ref obj0.\u0003);
        ref ushort local1 = ref obj0.\u0003;
        ushort num = obj1.\u0002()[(int) obj0.\u0002].\u0002(ref obj0.\u0001);
        ref ushort local2 = ref num;
        int fromZ = (int) obj0.\u0003;
        int fromS = (int) obj0.\u0001;
        objArray = this.\u0002(ref local1, ref local2, fromZ, fromS);
        break;
      case \u0004.\u0004.\u0001.\u0003:
        \u0006.\u0002.\u0001 obj2 = this.\u0002(ref obj0.\u0003).\u0002()[(int) obj0.\u0002].\u0002(ref obj0.\u0003);
        objArray = this.\u0002(ref obj2.\u0001, ref obj2.\u0002, (int) obj0.\u0003, (int) obj0.\u0001);
        break;
      case \u0004.\u0004.\u0001.\u0004:
        objArray = this.\u0003(ref obj0);
        break;
    }
    return objArray;
  }

  public \u0004.\u0004.\u0002[] \u0002(
    ref ushort SectorYX,
    ref ushort ZoneIndex,
    int fromZ = -1,
    int fromS = -1)
  {
    List<\u0004.\u0004.\u0002> objList = new List<\u0004.\u0004.\u0002>();
    \u0007.\u0003 obj1 = this.\u0002(ref SectorYX);
    \u0007.\u0004 obj2 = obj1.\u0002()[(int) ZoneIndex];
    try
    {
      foreach (ushort index1 in obj2.\u0003())
      {
        \u0006.\u0005 obj3 = obj1.\u0002()[(int) index1];
        if (obj3.\u0002())
        {
          ushort index2 = obj3.\u0002(ref ZoneIndex);
          if ((int) index2 != fromZ)
          {
            if (!obj1.\u0002()[(int) index2].\u0002())
            {
              objList.Add(new \u0004.\u0004.\u0002()
              {
                \u0001 = ZoneIndex,
                \u0003 = SectorYX,
                \u0001 = \u0004.\u0004.\u0001.\u0002,
                \u0002 = index1
              });
            }
            else
            {
              \u0007.\u0005 obj4 = this.\u0002(ref SectorYX, ref index2);
              if (obj4 != null)
              {
                int num = checked (obj4.\u0001.Count - 1);
                int index3 = 0;
                while (index3 <= num)
                {
                  \u0007.\u0005.\u0001 obj5 = obj4.\u0001[index3];
                  if (obj5.\u0001 == \u0007.\u0005.\u0003.\u0003 && this.\u0002(obj4.\u0001[(int) obj5.\u0001], obj4.\u0001[(int) obj5.\u0002], obj3.\u0002(), obj3.\u0003(), false))
                    objList.Add(new \u0004.\u0004.\u0002()
                    {
                      \u0001 = index2,
                      \u0003 = SectorYX,
                      \u0001 = \u0004.\u0004.\u0001.\u0004,
                      \u0002 = checked ((ushort) index3)
                    });
                  checked { ++index3; }
                }
              }
              else
                break;
            }
          }
        }
      }
    }
    finally
    {
      List<ushort>.Enumerator enumerator;
      enumerator.Dispose();
    }
    try
    {
      foreach (ushort index4 in obj2.\u0004())
      {
        \u0006.\u0002 obj6 = obj1.\u0002()[(int) index4];
        if (obj6.\u0002())
        {
          \u0006.\u0002.\u0001 obj7 = obj6.\u0002(ref SectorYX);
          if (!((int) obj7.\u0002 == fromZ & (int) obj7.\u0001 == fromS))
          {
            if (!this.\u0002(ref obj7.\u0001).\u0002()[(int) obj7.\u0002].\u0002())
            {
              objList.Add(new \u0004.\u0004.\u0002()
              {
                \u0001 = ZoneIndex,
                \u0003 = SectorYX,
                \u0001 = \u0004.\u0004.\u0001.\u0003,
                \u0002 = index4
              });
            }
            else
            {
              \u0007.\u0005 obj8 = this.\u0002(ref obj7.\u0001, ref obj7.\u0002);
              if (obj8 == null)
                return objList.ToArray();
              int num = checked (obj8.\u0001.Count - 1);
              int index5 = 0;
              while (index5 <= num)
              {
                \u0007.\u0005.\u0001 obj9 = obj8.\u0001[index5];
                if (obj9.\u0001 == \u0007.\u0005.\u0003.\u0004 && this.\u0002(obj8.\u0001[(int) obj9.\u0001], obj8.\u0001[(int) obj9.\u0002], obj6.\u0002(), obj6.\u0003(), true))
                  objList.Add(new \u0004.\u0004.\u0002()
                  {
                    \u0001 = obj7.\u0002,
                    \u0003 = obj7.\u0001,
                    \u0001 = \u0004.\u0004.\u0001.\u0004,
                    \u0002 = checked ((ushort) index5)
                  });
                checked { ++index5; }
              }
            }
          }
        }
      }
    }
    finally
    {
      List<ushort>.Enumerator enumerator;
      enumerator.Dispose();
    }
    return objList.ToArray();
  }

  public \u0004.\u0004.\u0002[] \u0003([In] ref \u0004.\u0004.\u0002 obj0)
  {
    \u0007.\u0005 obj1 = this.\u0002(ref obj0.\u0003, ref obj0.\u0001);
    List<\u0004.\u0004.\u0002> objList = new List<\u0004.\u0004.\u0002>();
    ushort[] array = obj1.\u0001[(int) obj0.\u0002].\u0001.ToArray();
    int index1 = 0;
    while (index1 < array.Length)
    {
      ushort index2 = array[index1];
      switch (obj1.\u0001[(int) index2].\u0001)
      {
        case \u0007.\u0005.\u0003.\u0001:
          objList.Add(new \u0004.\u0004.\u0002()
          {
            \u0002 = index2,
            \u0001 = \u0004.\u0004.\u0001.\u0004,
            \u0003 = obj0.\u0003,
            \u0001 = obj0.\u0001
          });
          break;
        case \u0007.\u0005.\u0003.\u0003:
          objList.Add(new \u0004.\u0004.\u0002()
          {
            \u0002 = index2,
            \u0001 = \u0004.\u0004.\u0001.\u0004,
            \u0003 = obj0.\u0003,
            \u0001 = obj0.\u0001
          });
          break;
        case \u0007.\u0005.\u0003.\u0004:
          objList.Add(new \u0004.\u0004.\u0002()
          {
            \u0002 = index2,
            \u0001 = \u0004.\u0004.\u0001.\u0004,
            \u0003 = obj0.\u0003,
            \u0001 = obj0.\u0001
          });
          break;
      }
      checked { ++index1; }
    }
    \u0007.\u0005.\u0001 obj2 = obj1.\u0001[(int) obj0.\u0002];
    switch (obj2.\u0001)
    {
      case \u0007.\u0005.\u0003.\u0003:
        \u0007.\u0003 obj3 = this.\u0002(ref obj0.\u0003);
        ushort index3;
        \u0006.\u0005 obj4;
        try
        {
          foreach (ushort num in obj3.\u0002()[(int) obj0.\u0001].\u0003())
          {
            index3 = num;
            if (this.\u0002(obj3.\u0002()[(int) index3].\u0002(), obj3.\u0002()[(int) index3].\u0003(), obj1.\u0001[(int) obj2.\u0001], obj1.\u0001[(int) obj2.\u0002], false))
            {
              obj4 = obj3.\u0002()[(int) index3];
              break;
            }
          }
        }
        finally
        {
          List<ushort>.Enumerator enumerator;
          enumerator.Dispose();
        }
        if (obj4 == null)
          throw new Exception(\u0001.\u0004.\u0002(985));
        ushort index4 = obj4.\u0002(ref obj0.\u0001);
        if (!obj3.\u0002()[(int) index4].\u0002())
        {
          objList.Add(new \u0004.\u0004.\u0002()
          {
            \u0002 = index3,
            \u0001 = \u0004.\u0004.\u0001.\u0002,
            \u0003 = obj0.\u0003,
            \u0001 = obj0.\u0001
          });
        }
        else
        {
          \u0007.\u0005 obj5 = this.\u0002(ref obj0.\u0003, ref index4);
          if (obj5 != null)
          {
            ushort num = checked ((ushort) (obj5.\u0001.Count - 1));
            ushort index5 = 0;
            while ((uint) index5 <= (uint) num)
            {
              if (obj5.\u0001[(int) index5].\u0001 == \u0007.\u0005.\u0003.\u0003 && this.\u0002(obj1.\u0001[(int) obj2.\u0001], obj1.\u0001[(int) obj2.\u0002], obj5.\u0001[(int) obj5.\u0001[(int) index5].\u0001], obj5.\u0001[(int) obj5.\u0001[(int) index5].\u0002], false))
                objList.Add(new \u0004.\u0004.\u0002()
                {
                  \u0001 = index4,
                  \u0003 = obj0.\u0003,
                  \u0001 = \u0004.\u0004.\u0001.\u0004,
                  \u0002 = index5
                });
              checked { ++index5; }
            }
          }
          else
            break;
        }
        break;
      case \u0007.\u0005.\u0003.\u0004:
        \u0007.\u0003 obj6 = this.\u0002(ref obj0.\u0003);
        ushort index6;
        \u0006.\u0002 obj7;
        try
        {
          foreach (ushort num in obj6.\u0002()[(int) obj0.\u0001].\u0004())
          {
            index6 = num;
            if (this.\u0002(obj6.\u0002()[(int) index6].\u0002(), obj6.\u0002()[(int) index6].\u0003(), obj1.\u0001[(int) obj2.\u0001], obj1.\u0001[(int) obj2.\u0002], false))
            {
              obj7 = obj6.\u0002()[(int) index6];
              break;
            }
          }
        }
        finally
        {
          List<ushort>.Enumerator enumerator;
          enumerator.Dispose();
        }
        if (obj7 == null)
          throw new Exception(\u0001.\u0004.\u0002(964));
        \u0006.\u0002.\u0001 obj8 = obj7.\u0002(ref obj0.\u0003);
        if (!this.\u0002(ref obj8.\u0001).\u0002()[(int) obj8.\u0002].\u0002())
        {
          objList.Add(new \u0004.\u0004.\u0002()
          {
            \u0002 = index6,
            \u0001 = \u0004.\u0004.\u0001.\u0003,
            \u0003 = obj0.\u0003,
            \u0001 = obj0.\u0001
          });
          break;
        }
        \u0007.\u0005 obj9 = this.\u0002(ref obj8.\u0001, ref obj8.\u0002);
        if (obj9 == null)
          return objList.ToArray();
        ushort num1 = checked ((ushort) (obj9.\u0001.Count - 1));
        ushort index7 = 0;
        while ((uint) index7 <= (uint) num1)
        {
          if (obj9.\u0001[(int) index7].\u0001 == \u0007.\u0005.\u0003.\u0004 && this.\u0002(obj1.\u0001[(int) obj2.\u0001], obj1.\u0001[(int) obj2.\u0002], obj9.\u0001[(int) obj9.\u0001[(int) index7].\u0001], obj9.\u0001[(int) obj9.\u0001[(int) index7].\u0002], true))
            objList.Add(new \u0004.\u0004.\u0002()
            {
              \u0001 = obj8.\u0002,
              \u0003 = obj8.\u0001,
              \u0001 = \u0004.\u0004.\u0001.\u0004,
              \u0002 = index7
            });
          checked { ++index7; }
        }
        break;
    }
    return objList.ToArray();
  }

  public \u0004.\u0004.\u0002[] \u0002([In] ref \u0005.\u0003 obj0_1)
  {
    List<\u0004.\u0004.\u0002> objList = new List<\u0004.\u0004.\u0002>();
    uint num1 = 0;
    byte num2 = obj0_1.\u0003();
    ref byte local1 = ref num2;
    byte num3 = obj0_1.\u0002();
    ref byte local2 = ref num3;
    \u0007.\u0003 obj1 = this.\u0002(ref local1, ref local2);
    uint num4 = checked ((uint) (((IEnumerable<\u0007.\u0004>) obj1.\u0002()).Count<\u0007.\u0004>() - 1));
    uint index = 0;
    while (index <= num4 && (!((double) obj1.\u0002()[checked ((int) index)].\u0002() <= (double) obj0_1.\u0002() & (double) obj1.\u0002()[checked ((int) index)].\u0003() >= (double) obj0_1.\u0002()) || !((double) obj1.\u0002()[checked ((int) index)].\u0005() <= (double) checked (192 /*0xC0*/ - obj0_1.\u0003()) & (double) obj1.\u0002()[checked ((int) index)].\u0004() >= (double) checked (192 /*0xC0*/ - obj0_1.\u0003()))))
      checked { ++index; }
    if (!obj1.\u0002()[checked ((int) index)].\u0002())
    {
      ushort num5 = obj1.\u0002();
      ref ushort local3 = ref num5;
      ushort num6 = checked ((ushort) index);
      ref ushort local4 = ref num6;
      \u0004.\u0004.\u0002[] objArray = this.\u0002(ref local3, ref local4, -1, -1);
      num1 = (uint) num6;
      return objArray;
    }
    ushort num7 = obj1.\u0002();
    ref ushort local5 = ref num7;
    ushort num8 = checked ((ushort) index);
    ref ushort local6 = ref num8;
    \u0007.\u0005 obj2 = this.\u0002(ref local5, ref local6);
    uint num9 = (uint) num8;
    this.\u0001 = obj2;
    if (this.\u0001 == null)
      return objList.ToArray();
    PointF pointF = new PointF((float) obj0_1.\u0002(), (float) checked (192 /*0xC0*/ - obj0_1.\u0003()));
    try
    {
      foreach (\u0007.\u0005.\u0002 obj3 in this.\u0001.\u0001)
      {
        if (this.\u0002(this.\u0001.\u0001[(int) obj3.\u0001], this.\u0001.\u0001[(int) obj3.\u0002], this.\u0001.\u0001[(int) obj3.\u0003], pointF))
        {
          if (this.\u0001.\u0001[(int) obj3.\u0004].\u0001 != \u0007.\u0005.\u0003.\u0002)
            objList.Add(new \u0004.\u0004.\u0002()
            {
              \u0002 = obj3.\u0004,
              \u0001 = \u0004.\u0004.\u0001.\u0004,
              \u0001 = checked ((ushort) num9),
              \u0003 = obj1.\u0002()
            });
          if (this.\u0001.\u0001[(int) obj3.\u0005].\u0001 != \u0007.\u0005.\u0003.\u0002)
            objList.Add(new \u0004.\u0004.\u0002()
            {
              \u0002 = obj3.\u0005,
              \u0001 = \u0004.\u0004.\u0001.\u0004,
              \u0001 = checked ((ushort) num9),
              \u0003 = obj1.\u0002()
            });
          if (this.\u0001.\u0001[(int) obj3.\u0006].\u0001 != \u0007.\u0005.\u0003.\u0002)
            objList.Add(new \u0004.\u0004.\u0002()
            {
              \u0002 = obj3.\u0006,
              \u0001 = \u0004.\u0004.\u0001.\u0004,
              \u0001 = checked ((ushort) num9),
              \u0003 = obj1.\u0002()
            });
        }
      }
    }
    finally
    {
      List<\u0007.\u0005.\u0002>.Enumerator enumerator;
      enumerator.Dispose();
    }
    objList.ForEach((Action<\u0004.\u0004.\u0002>) ([SpecialName] ([In] obj0_2) => obj0_2.\u0001 = this.\u0002(obj0_2)));
    return objList.ToArray();
  }

  public bool \u0002(PointF p1, PointF p2, PointF p3, PointF p4, bool BC = false)
  {
    if (BC)
    {
      if ((double) p1.Y == (double) p2.Y)
      {
        p1.Y = 192f - p1.Y;
        p2.Y = 192f - p2.Y;
      }
      if ((double) p1.X == (double) p2.X)
      {
        p1.X = 192f - p1.X;
        p2.X = 192f - p2.X;
      }
    }
    bool flag1;
    bool flag2;
    if ((double) p1.X == (double) p2.X & (double) p3.X == (double) p4.X & (double) p2.X == (double) p3.X)
      flag1 = true;
    else if ((double) p1.Y == (double) p2.Y & (double) p3.Y == (double) p4.Y & (double) p2.Y == (double) p3.Y)
      flag2 = true;
    if (!(flag2 | flag1))
      return false;
    if (flag1)
    {
      if ((double) p1.Y == (double) p3.Y & (double) p2.Y == (double) p4.Y || (double) p2.Y == (double) p3.Y & (double) p1.Y == (double) p4.Y)
        return true;
      float num = p1.Y - p2.Y;
      return this.\u0002(p1.Y - num, p1.Y, p3.Y) || this.\u0002(p1.Y - num, p1.Y, p4.Y);
    }
    if ((double) p1.X == (double) p3.X & (double) p2.X == (double) p4.X || (double) p2.X == (double) p3.X & (double) p1.X == (double) p4.X)
      return true;
    float num1 = p1.X - p2.X;
    return this.\u0002(p1.X - num1, p1.X, p3.X) || this.\u0002(p1.X - num1, p1.X, p4.X);
  }

  public bool \u0002([In] float obj0, [In] float obj1, [In] float obj2)
  {
    return (double) obj0 > (double) obj2 & (double) obj1 < (double) obj2 || (double) obj1 > (double) obj2 & (double) obj0 < (double) obj2;
  }

  public void \u0002()
  {
    \u0004.\u0004.\u0002[] objArray = this.\u0002(ref this.\u0001);
    this.\u0001.Clear();
    \u0004.\u0004.\u0002[] array = objArray;
    \u0004.\u0004 obj = this;
    // ISSUE: virtual method pointer
    Action<\u0004.\u0004.\u0002> action = new Action<\u0004.\u0004.\u0002>((object) obj, __vmethodptr(obj, \u0003));
    Array.ForEach<\u0004.\u0004.\u0002>(array, action);
  }

  public void \u0003()
  {
    \u0004.\u0004.\u0002[] source = this.\u0002(ref this.\u0002);
    this.\u0001 = new ulong[checked (((IEnumerable<\u0004.\u0004.\u0002>) source).Count<\u0004.\u0004.\u0002>() - 1 + 1)];
    if (source.Length == 0)
      return;
    byte num = checked ((byte) (((IEnumerable<\u0004.\u0004.\u0002>) source).Count<\u0004.\u0004.\u0002>() - 1));
    byte index = 0;
    while ((uint) index <= (uint) num)
    {
      this.\u0001[(int) index] = source[(int) index].\u0002();
      checked { ++index; }
    }
  }

  public ulong \u0002()
  {
    uint num1 = uint.MaxValue;
    ulong num2;
    try
    {
      foreach (\u0004.\u0004.\u0002 obj in this.\u0001.Values)
      {
        if (checked (obj.\u0002 + obj.\u0001) < num1)
        {
          num1 = checked (obj.\u0002 + obj.\u0001);
          num2 = obj.\u0002();
        }
      }
    }
    finally
    {
      Dictionary<ulong, \u0004.\u0004.\u0002>.ValueCollection.Enumerator enumerator;
      enumerator.Dispose();
    }
    return num2;
  }

  private \u0005.\u0003[] \u0002([In] ref \u0004.\u0004.\u0002 obj0)
  {
    \u0005.\u0003[] objArray1 = new \u0005.\u0003[2];
    \u0007.\u0003 obj1 = this.\u0002(ref obj0.\u0003);
    switch (obj0.\u0001)
    {
      case \u0004.\u0004.\u0001.\u0002:
        \u0005.\u0003[] objArray2 = objArray1;
        double num1 = (double) checked ((int) obj0.\u0002() - 135 * 192 /*0xC0*/);
        PointF pointF = obj1.\u0002()[(int) obj0.\u0002].\u0002();
        double x1 = (double) pointF.X;
        \u0005.\u0003 obj2 = new \u0005.\u0003((float) (num1 + x1), (float) checked ((int) obj0.\u0003() - 92 * 192 /*0xC0*/) + (192f - obj1.\u0002()[(int) obj0.\u0002].\u0002().Y), 0.0f);
        objArray2[0] = obj2;
        \u0005.\u0003[] objArray3 = objArray1;
        double num2 = (double) checked ((int) obj0.\u0002() - 135 * 192 /*0xC0*/);
        pointF = obj1.\u0002()[(int) obj0.\u0002].\u0003();
        double x2 = (double) pointF.X;
        \u0005.\u0003 obj3 = new \u0005.\u0003((float) (num2 + x2), (float) checked ((int) obj0.\u0003() - 92 * 192 /*0xC0*/) + (192f - obj1.\u0002()[(int) obj0.\u0002].\u0003().Y), 0.0f);
        objArray3[1] = obj3;
        break;
      case \u0004.\u0004.\u0001.\u0003:
        objArray1[0] = new \u0005.\u0003((float) checked ((int) obj0.\u0002() - 135 * 192 /*0xC0*/) + obj1.\u0002()[(int) obj0.\u0002].\u0002().X, (float) checked ((int) obj0.\u0003() - 92 * 192 /*0xC0*/) + (192f - obj1.\u0002()[(int) obj0.\u0002].\u0002().Y), 0.0f);
        objArray1[1] = new \u0005.\u0003((float) checked ((int) obj0.\u0002() - 135 * 192 /*0xC0*/) + obj1.\u0002()[(int) obj0.\u0002].\u0003().X, (float) checked ((int) obj0.\u0003() - 92 * 192 /*0xC0*/) + (192f - obj1.\u0002()[(int) obj0.\u0002].\u0003().Y), 0.0f);
        break;
      case \u0004.\u0004.\u0001.\u0004:
        \u0007.\u0005 obj4 = this.\u0002(ref obj0.\u0003, ref obj0.\u0001);
        objArray1[0] = new \u0005.\u0003((float) checked ((int) obj0.\u0002() - 135 * 192 /*0xC0*/) + obj4.\u0001[(int) obj4.\u0001[(int) obj0.\u0002].\u0001].X, (float) checked ((int) obj0.\u0003() - 92 * 192 /*0xC0*/) + (192f - obj4.\u0001[(int) obj4.\u0001[(int) obj0.\u0002].\u0001].Y), 0.0f);
        objArray1[1] = new \u0005.\u0003((float) checked ((int) obj0.\u0002() - 135 * 192 /*0xC0*/) + obj4.\u0001[(int) obj4.\u0001[(int) obj0.\u0002].\u0002].X, (float) checked ((int) obj0.\u0003() - 92 * 192 /*0xC0*/) + (192f - obj4.\u0001[(int) obj4.\u0001[(int) obj0.\u0002].\u0002].Y), 0.0f);
        break;
      case \u0004.\u0004.\u0001.\u0005:
        throw new Exception(\u0001.\u0004.\u0002(1006));
    }
    return objArray1;
  }

  public uint \u0002([In] ref \u0004.\u0004.\u0002 obj0, [In] ref \u0005.\u0003 obj1)
  {
    \u0005.\u0003[] objArray = this.\u0002(ref obj0);
    float num1 = objArray[0].\u0002() - objArray[1].\u0002();
    float num2 = objArray[0].\u0003() - objArray[1].\u0003();
    objArray[0].\u0002(objArray[0].\u0002() - num1 / 2f);
    objArray[0].\u0003(objArray[0].\u0003() - num2 / 2f);
    float num3 = (float) \u008C\u0003.\u0005\u0006(\u008C\u0003.\u0004\u0006(((double) objArray[0].\u0002() - (double) obj1.\u0002()) * ((double) objArray[0].\u0002() - (double) obj1.\u0002()) + ((double) objArray[0].\u0003() - (double) obj1.\u0003()) * ((double) objArray[0].\u0003() - (double) obj1.\u0003())));
    return checked ((uint) \u008C\u0003.\u0002\u0006((double) num3));
  }

  public uint \u0002([In] ref \u0004.\u0004.\u0002 obj0, [In] ref \u0004.\u0004.\u0002 obj1)
  {
    \u0005.\u0003[] objArray1 = this.\u0002(ref obj0);
    \u0005.\u0003[] objArray2 = this.\u0002(ref obj1);
    float num1 = objArray1[0].\u0002() - objArray1[1].\u0002();
    float num2 = objArray1[0].\u0003() - objArray1[1].\u0003();
    objArray1[0].\u0002(objArray1[0].\u0002() - num1 / 2f);
    objArray1[0].\u0003(objArray1[0].\u0003() - num2 / 2f);
    float num3 = objArray2[0].\u0002() - objArray2[1].\u0002();
    float num4 = objArray2[0].\u0003() - objArray2[1].\u0003();
    objArray2[0].\u0002(objArray2[0].\u0002() - num3 / 2f);
    objArray2[0].\u0003(objArray2[0].\u0003() - num4 / 2f);
    float num5 = (float) \u008C\u0003.\u0005\u0006(\u008C\u0003.\u0004\u0006(((double) objArray1[0].\u0002() - (double) objArray2[0].\u0002()) * ((double) objArray1[0].\u0002() - (double) objArray2[0].\u0002()) + ((double) objArray1[0].\u0003() - (double) objArray2[0].\u0003()) * ((double) objArray1[0].\u0003() - (double) objArray2[0].\u0003())));
    return checked ((uint) \u008C\u0003.\u0002\u0006((double) num5));
  }

  public uint \u0002([In] \u0004.\u0004.\u0002 obj0)
  {
    \u0005.\u0003[] objArray = this.\u0002(ref obj0);
    float num1 = objArray[0].\u0002() - objArray[1].\u0002();
    float num2 = objArray[0].\u0003() - objArray[1].\u0003();
    objArray[0].\u0002(objArray[0].\u0002() - num1 / 2f);
    objArray[0].\u0003(objArray[0].\u0003() - num2 / 2f);
    float num3 = (float) \u008C\u0003.\u0005\u0006(\u008C\u0003.\u0004\u0006(((double) objArray[0].\u0002() - (double) this.\u0002.\u0002()) * ((double) objArray[0].\u0002() - (double) this.\u0002.\u0002()) + ((double) objArray[0].\u0003() - (double) this.\u0002.\u0003()) * ((double) objArray[0].\u0003() - (double) this.\u0002.\u0003())));
    return checked ((uint) \u008C\u0003.\u0002\u0006((double) unchecked (this.\u0001 * num3)));
  }

  public bool \u0002([In] PointF obj0, [In] PointF obj1, [In] PointF obj2, [In] PointF obj3)
  {
    return (double) obj1.X * (double) obj2.Y - (double) obj2.X * (double) obj1.Y + ((double) obj1.Y - (double) obj2.Y) * (double) obj3.X + ((double) obj2.X - (double) obj1.X) * (double) obj3.Y >= 0.0 && (double) obj2.X * (double) obj0.Y - (double) obj0.X * (double) obj2.Y + ((double) obj2.Y - (double) obj0.Y) * (double) obj3.X + ((double) obj0.X - (double) obj2.X) * (double) obj3.Y >= 0.0 && (double) obj0.X * (double) obj1.Y - (double) obj1.X * (double) obj0.Y + ((double) obj0.Y - (double) obj1.Y) * (double) obj3.X + ((double) obj1.X - (double) obj0.X) * (double) obj3.Y >= 0.0;
  }

  internal enum \u0001 : byte
  {
    \u0001,
    \u0002,
    \u0003,
    \u0004,
    \u0005,
  }

  internal struct \u0002
  {
    public \u0004.\u0004.\u0001 \u0001;
    public ushort \u0001;
    public ushort \u0002;
    public ushort \u0003;
    public uint \u0001;
    public uint \u0002;
    public ulong \u0001;

    public ulong \u0002()
    {
      ulong num = checked ((ulong) ((long) this.\u0001 << 40 | (long) this.\u0002 << 24 | (long) this.\u0001 << 16 /*0x10*/ | (long) this.\u0003));
      return checked ((ulong) ((long) this.\u0001 << 40 | (long) this.\u0002 << 24 | (long) this.\u0001 << 16 /*0x10*/ | (long) this.\u0003));
    }

    public byte \u0002() => checked ((byte) ((int) byte.MaxValue & (int) this.\u0003));

    public byte \u0003() => checked ((byte) unchecked ((ushort) ((uint) this.\u0003 >> 8)));
  }
}
