// Decompiled with JetBrains decompiler
// Type: .
// Assembly: kMap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB403103-24EE-4947-BAAC-163727D2381A
// Assembly location: C:\Users\Dev\Downloads\Nouveau dossier (28)\NavTestV2\kMap.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Poly2Tri;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;

#nullable disable
namespace \u0004;

internal sealed class \u0005
{
  private RectangleF \u0001;
  public \u0007.\u0005 \u0001;

  public \u0005([In] ref \u0007.\u0003 obj0, [In] int obj1)
  {
    this.\u0001 = new \u0007.\u0005();
    List<\u0004.\u0005.\u0002> objList1 = new List<\u0004.\u0005.\u0002>();
    List<TriangulationPoint> triangulationPointList = new List<TriangulationPoint>();
    \u0007.\u0004 obj2 = obj0.\u0002()[obj1];
    this.\u0001 = new RectangleF(obj2.\u0002(), obj2.\u0005(), obj2.\u0003() - obj2.\u0002(), obj2.\u0004() - obj2.\u0005());
    if ((double) this.\u0001.Width < 0.0 | (double) this.\u0001.Height < 0.0)
    {
      int num1 = (int) \u0004\u0003.\u0083\u0004((object) \u0001.\u0004.\u0002(1015), MsgBoxStyle.OkOnly, (object) null);
    }
    if (checked (obj0.\u0002()[obj1].\u0004().Count + obj0.\u0002()[obj1].\u0003().Count) == 0)
      return;
    int num2 = checked (obj0.\u0002()[obj1].\u0004().Count - 1);
    int index1 = 0;
    while (index1 <= num2)
    {
      if (obj0.\u0002()[(int) obj0.\u0002()[obj1].\u0004()[index1]].\u0002())
        objList1.Add(new \u0004.\u0005.\u0002(obj0.\u0002()[(int) obj0.\u0002()[obj1].\u0004()[index1]].\u0002(), obj0.\u0002()[(int) obj0.\u0002()[obj1].\u0004()[index1]].\u0003(), \u0004.\u0005.\u0001.\u0004, index1));
      else
        objList1.Add(new \u0004.\u0005.\u0002(obj0.\u0002()[(int) obj0.\u0002()[obj1].\u0004()[index1]].\u0002(), obj0.\u0002()[(int) obj0.\u0002()[obj1].\u0004()[index1]].\u0003(), \u0004.\u0005.\u0001.\u0001));
      checked { ++index1; }
    }
    int num3 = checked (obj0.\u0002()[obj1].\u0003().Count - 1);
    int index2 = 0;
    while (index2 <= num3)
    {
      if (obj0.\u0002()[(int) obj0.\u0002()[obj1].\u0003()[index2]].\u0002())
        objList1.Add(new \u0004.\u0005.\u0002(obj0.\u0002()[(int) obj0.\u0002()[obj1].\u0003()[index2]].\u0002(), obj0.\u0002()[(int) obj0.\u0002()[obj1].\u0003()[index2]].\u0003(), \u0004.\u0005.\u0001.\u0003, index2));
      else
        objList1.Add(new \u0004.\u0005.\u0002(obj0.\u0002()[(int) obj0.\u0002()[obj1].\u0003()[index2]].\u0002(), obj0.\u0002()[(int) obj0.\u0002()[obj1].\u0003()[index2]].\u0003(), \u0004.\u0005.\u0001.\u0001));
      checked { ++index2; }
    }
    PointF pointF1;
    try
    {
      foreach (ushort index3 in obj2.\u0002())
      {
        \u0006.\u0003 obj3 = obj0.\u0002(ref obj0.\u0002()[(int) index3], ref \u0005.\u0005.\u0001);
        try
        {
          foreach (\u0006.\u0003.\u0002 obj4 in obj3.\u0002)
          {
            if (obj4.\u0002() != (byte) 16 /*0x10*/)
            {
              if (obj3.\u0001 | obj3.\u0002)
              {
                PointF pt1 = obj3.\u0001[(int) obj4.\u0002()].\u0002();
                PointF pt2 = obj3.\u0001[(int) obj4.\u0003()].\u0002();
                sbyte index4 = 1;
                PointF[] pointFArray = new PointF[2];
                PointF pointF2 = new PointF(obj2.\u0002(), obj2.\u0004());
                PointF pointF3 = pointF2;
                ref PointF local1 = ref pointF3;
                PointF pointF4 = new PointF(obj2.\u0003(), obj2.\u0004());
                pointF1 = pointF4;
                ref PointF local2 = ref pointF1;
                ref PointF local3 = ref pt1;
                ref PointF local4 = ref pt2;
                ref PointF local5 = ref pointFArray[(int) index4];
                \u0004.\u0005.\u0003 obj5 = \u0004.\u0005.\u0002(ref local1, ref local2, ref local3, ref local4, ref local5);
                if (obj5 == \u0004.\u0005.\u0003.\u0001)
                  checked { index4 += (sbyte) -1; }
                if (index4 >= (sbyte) 0 & obj5 < \u0004.\u0005.\u0003.\u0004)
                {
                  pointF1 = new PointF(obj2.\u0003(), obj2.\u0004());
                  pointF4 = pointF1;
                  ref PointF local6 = ref pointF4;
                  pointF3 = new PointF(obj2.\u0003(), obj2.\u0005());
                  pointF2 = pointF3;
                  ref PointF local7 = ref pointF2;
                  ref PointF local8 = ref pt1;
                  ref PointF local9 = ref pt2;
                  ref PointF local10 = ref pointFArray[(int) index4];
                  obj5 = \u0004.\u0005.\u0002(ref local6, ref local7, ref local8, ref local9, ref local10);
                  if (obj5 == \u0004.\u0005.\u0003.\u0001)
                    checked { index4 += (sbyte) -1; }
                }
                if (index4 >= (sbyte) 0 & obj5 < \u0004.\u0005.\u0003.\u0004)
                {
                  pointF1 = new PointF(obj2.\u0003(), obj2.\u0005());
                  pointF4 = pointF1;
                  ref PointF local11 = ref pointF4;
                  pointF3 = new PointF(obj2.\u0002(), obj2.\u0005());
                  pointF2 = pointF3;
                  ref PointF local12 = ref pointF2;
                  ref PointF local13 = ref pt1;
                  ref PointF local14 = ref pt2;
                  ref PointF local15 = ref pointFArray[(int) index4];
                  obj5 = \u0004.\u0005.\u0002(ref local11, ref local12, ref local13, ref local14, ref local15);
                  if (obj5 == \u0004.\u0005.\u0003.\u0001)
                    checked { index4 += (sbyte) -1; }
                }
                if (index4 >= (sbyte) 0 & obj5 < \u0004.\u0005.\u0003.\u0004)
                {
                  pointF1 = new PointF(obj2.\u0002(), obj2.\u0005());
                  pointF4 = pointF1;
                  ref PointF local16 = ref pointF4;
                  pointF3 = new PointF(obj2.\u0002(), obj2.\u0004());
                  pointF2 = pointF3;
                  ref PointF local17 = ref pointF2;
                  ref PointF local18 = ref pt1;
                  ref PointF local19 = ref pt2;
                  ref PointF local20 = ref pointFArray[(int) index4];
                  if (\u0004.\u0005.\u0002(ref local16, ref local17, ref local18, ref local19, ref local20) == \u0004.\u0005.\u0003.\u0001)
                    checked { index4 += (sbyte) -1; }
                }
                switch ((sbyte) ((int) index4 - -1))
                {
                  case 0:
                    if (obj4.\u0002() == (byte) 0)
                    {
                      objList1.Add(new \u0004.\u0005.\u0002(pointFArray[1], pointFArray[0], \u0004.\u0005.\u0001.\u0002, (int) index3));
                      break;
                    }
                    objList1.Add(new \u0004.\u0005.\u0002(pointFArray[1], pointFArray[0], \u0004.\u0005.\u0001.\u0001));
                    break;
                  case 1:
                    if (this.\u0001.Contains(pt1))
                    {
                      if (obj4.\u0002() == (byte) 0)
                      {
                        objList1.Add(new \u0004.\u0005.\u0002(pt1, pointFArray[1], \u0004.\u0005.\u0001.\u0002, (int) index3));
                        break;
                      }
                      objList1.Add(new \u0004.\u0005.\u0002(pt1, pointFArray[1], \u0004.\u0005.\u0001.\u0001));
                      break;
                    }
                    if (this.\u0001.Contains(pt2))
                    {
                      if (obj4.\u0002() == (byte) 0)
                      {
                        objList1.Add(new \u0004.\u0005.\u0002(pt2, pointFArray[1], \u0004.\u0005.\u0001.\u0002, (int) index3));
                        break;
                      }
                      objList1.Add(new \u0004.\u0005.\u0002(pt2, pointFArray[1], \u0004.\u0005.\u0001.\u0001));
                      break;
                    }
                    int num4 = (int) \u0004\u0003.\u0083\u0004((object) \u0001.\u0004.\u0002(1032), MsgBoxStyle.OkOnly, (object) null);
                    break;
                  case 2:
                    if (this.\u0001.Contains(pt1))
                    {
                      if (obj4.\u0002() == (byte) 0)
                        objList1.Add(new \u0004.\u0005.\u0002(pt1, pt2, \u0004.\u0005.\u0001.\u0002, (int) index3));
                      else
                        objList1.Add(new \u0004.\u0005.\u0002(pt1, pt2, \u0004.\u0005.\u0001.\u0001));
                      break;
                    }
                    break;
                }
              }
              else
                break;
            }
          }
        }
        finally
        {
          List<\u0006.\u0003.\u0002>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
    }
    finally
    {
      List<ushort>.Enumerator enumerator;
      enumerator.Dispose();
    }
    List<int> intList1 = new List<int>();
    int index5 = -1;
label_57:
    while (true)
    {
      checked { ++index5; }
      if (index5 != objList1.Count)
      {
        int index6 = checked (index5 - 1);
        List<PointF> pointFList;
        while (true)
        {
          do
          {
            checked { ++index6; }
            if (index6 == objList1.Count)
              goto label_57;
          }
          while (index5 == index6);
          List<\u0004.\u0005.\u0002> objList2 = objList1;
          List<\u0004.\u0005.\u0002> objList3 = objList2;
          int index7 = index5;
          int index8 = index7;
          \u0004.\u0005.\u0002 obj6 = objList3[index8];
          ref \u0004.\u0005.\u0002 local21 = ref obj6;
          List<\u0004.\u0005.\u0002> objList4 = objList1;
          List<\u0004.\u0005.\u0002> objList5 = objList4;
          int index9 = index6;
          int index10 = index9;
          \u0004.\u0005.\u0002 obj7 = objList5[index10];
          ref \u0004.\u0005.\u0002 local22 = ref obj7;
          PointF pointF5;
          ref PointF local23 = ref pointF5;
          int num5 = (int) this.\u0002(ref local21, ref local22, ref local23);
          objList4[index9] = obj7;
          objList2[index7] = obj6;
          switch (num5)
          {
            case -1:
              objList1.Add(new \u0004.\u0005.\u0002(pointF5, objList1[index5].\u0001, objList1[index5].\u0001, objList1[index5].\u0001));
              objList1[index5].\u0001 = pointF5;
              objList1.Add(new \u0004.\u0005.\u0002(pointF5, objList1[index6].\u0001, objList1[index6].\u0001, objList1[index6].\u0001));
              objList1[index6].\u0001 = pointF5;
              break;
            case 0:
              if (\u0003\u0005.\u0094\u000E(objList1[index5].\u0001, objList1[index6].\u0001) & \u0003\u0005.\u0094\u000E(objList1[index5].\u0002, objList1[index6].\u0002) | \u0003\u0005.\u0094\u000E(objList1[index5].\u0002, objList1[index6].\u0001) & \u0003\u0005.\u0094\u000E(objList1[index5].\u0001, objList1[index6].\u0002))
              {
                objList1.RemoveAt(index6);
                checked { --index6; }
                continue;
              }
              break;
            case 1:
              if (\u0003\u0005.\u0094\u000E(objList1[index5].\u0001, objList1[index6].\u0001) & \u0003\u0005.\u0094\u000E(objList1[index5].\u0002, objList1[index6].\u0002) | \u0003\u0005.\u0094\u000E(objList1[index5].\u0002, objList1[index6].\u0001) & \u0003\u0005.\u0094\u000E(objList1[index5].\u0001, objList1[index6].\u0002))
              {
                objList1.RemoveAt(index6);
                checked { --index6; }
                continue;
              }
              pointFList = new List<PointF>();
              pointFList.Add(objList1[index5].\u0001);
              pointFList.Add(objList1[index5].\u0002);
              pointFList.Add(objList1[index6].\u0001);
              pointFList.Add(objList1[index6].\u0002);
              pointFList.Sort(new Comparison<PointF>(\u0004.\u0005.\u0002));
              if (!\u0003\u0005.\u0094\u000E(pointFList[1], pointFList[2]))
                goto label_72;
              break;
            case 2:
              if (\u0003\u0005.\u0095\u000E(objList1[index5].\u0002, pointF5) & \u0003\u0005.\u0095\u000E(objList1[index5].\u0001, pointF5))
              {
                objList1.Add(new \u0004.\u0005.\u0002(pointF5, objList1[index5].\u0002, objList1[index5].\u0001, objList1[index5].\u0001));
                objList1[index5].\u0002 = pointF5;
              }
              if (\u0003\u0005.\u0095\u000E(objList1[index6].\u0002, pointF5) & \u0003\u0005.\u0095\u000E(objList1[index6].\u0001, pointF5))
              {
                objList1.Add(new \u0004.\u0005.\u0002(pointF5, objList1[index6].\u0002, objList1[index6].\u0001, objList1[index6].\u0001));
                objList1[index6].\u0002 = pointF5;
                break;
              }
              break;
          }
        }
label_72:
        if (objList1[index5].\u0001 != objList1[index6].\u0001)
          \u0083\u0003.\u008E\u0005(\u0001.\u0004.\u0002(747));
        if (\u0003\u0005.\u0095\u000E(pointFList[0], pointFList[1]))
          objList1.Add(new \u0004.\u0005.\u0002(pointFList[0], pointFList[1], objList1[index5].\u0001, objList1[index5].\u0001));
        if (\u0003\u0005.\u0095\u000E(pointFList[1], pointFList[2]))
          objList1.Add(new \u0004.\u0005.\u0002(pointFList[1], pointFList[2], objList1[index5].\u0001, objList1[index5].\u0001));
        if (\u0003\u0005.\u0095\u000E(pointFList[2], pointFList[3]))
          objList1.Add(new \u0004.\u0005.\u0002(pointFList[2], pointFList[3], objList1[index5].\u0001, objList1[index5].\u0001));
        objList1.RemoveAt(index5);
        if (index5 < index6)
          objList1.RemoveAt(checked (index6 - 1));
        else
          objList1.RemoveAt(index6);
        checked { --index5; }
      }
      else
        break;
    }
    int num6 = checked (objList1.Count - 1);
    int index11 = 0;
    while (index11 <= num6)
    {
      List<int> intList2 = intList1;
      ref List<TriangulationPoint> local24 = ref triangulationPointList;
      TriangulationPoint triangulationPoint1 = new TriangulationPoint((double) objList1[index11].\u0002.X, (double) objList1[index11].\u0002.Y);
      ref TriangulationPoint local25 = ref triangulationPoint1;
      int num7 = this.\u0002(ref local24, ref local25);
      intList2.Add(num7);
      List<int> intList3 = intList1;
      ref List<TriangulationPoint> local26 = ref triangulationPointList;
      TriangulationPoint triangulationPoint2 = new TriangulationPoint((double) objList1[index11].\u0001.X, (double) objList1[index11].\u0001.Y);
      ref TriangulationPoint local27 = ref triangulationPoint2;
      int num8 = this.\u0002(ref local26, ref local27);
      intList3.Add(num8);
      checked { ++index11; }
    }
    ConstrainedPointSet constrainedPointSet;
    try
    {
      constrainedPointSet = new ConstrainedPointSet(triangulationPointList, intList1.ToArray());
      \u001A\u0002.\u0008\u0003(constrainedPointSet);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      \u0083\u0003.\u008E\u0005(\u0001.\u0004.\u0002(1041));
      \u001F\u0002.\u0082\u0004();
      return;
    }
    int num9 = checked (((PointSet) constrainedPointSet).Points.Count - 1);
    int index12 = 0;
    while (index12 <= num9)
    {
      List<PointF> pointFList = this.\u0001.\u0001;
      pointF1 = new PointF((float) ((PointSet) constrainedPointSet).Points[index12].X, (float) ((PointSet) constrainedPointSet).Points[index12].Y);
      PointF pointF6 = pointF1;
      pointFList.Add(pointF6);
      checked { ++index12; }
    }
    int num10 = checked (((PointSet) constrainedPointSet).Triangles.Count - 1);
    int index13 = 0;
    while (index13 <= num10)
    {
      DelaunayTriangle triangle = ((PointSet) constrainedPointSet).Triangles[index13];
      ushort num11 = checked ((ushort) ((PointSet) constrainedPointSet).Points.IndexOf(triangle.Points[0]));
      ushort num12 = checked ((ushort) ((PointSet) constrainedPointSet).Points.IndexOf(triangle.Points[1]));
      ushort num13 = checked ((ushort) ((PointSet) constrainedPointSet).Points.IndexOf(triangle.Points[2]));
      \u0007.\u0005.\u0001 obj8 = new \u0007.\u0005.\u0001(num11, num12);
      \u0007.\u0005.\u0001 obj9 = new \u0007.\u0005.\u0001(num12, num13);
      \u0007.\u0005.\u0001 obj10 = new \u0007.\u0005.\u0001(num13, num11);
      ushort index14 = ushort.MaxValue;
      ushort index15 = ushort.MaxValue;
      ushort index16 = ushort.MaxValue;
      int num14 = checked (this.\u0001.\u0001.Count - 1);
      int index17 = 0;
      while (index17 <= num14)
      {
        if (obj8.\u0002(obj8, this.\u0001.\u0001[index17]))
          index14 = checked ((ushort) index17);
        if (obj9.\u0002(obj9, this.\u0001.\u0001[index17]))
          index15 = checked ((ushort) index17);
        if (obj10.\u0002(obj10, this.\u0001.\u0001[index17]))
          index16 = checked ((ushort) index17);
        checked { ++index17; }
      }
      if (index14 == ushort.MaxValue)
      {
        this.\u0001.\u0001.Add(obj8);
        index14 = checked ((ushort) (this.\u0001.\u0001.Count - 1));
      }
      if (index15 == ushort.MaxValue)
      {
        this.\u0001.\u0001.Add(obj9);
        index15 = checked ((ushort) (this.\u0001.\u0001.Count - 1));
      }
      if (index16 == ushort.MaxValue)
      {
        this.\u0001.\u0001.Add(obj10);
        index16 = checked ((ushort) (this.\u0001.\u0001.Count - 1));
      }
      PointF pointF7 = this.\u0001.\u0001[(int) obj8.\u0001];
      \u008C\u0003 obj11 = \u008C\u0003.\u0005\u0006;
      \u008C\u0003 obj12 = \u008C\u0003.\u0004\u0006;
      double num15 = ((double) pointF7.X - (double) this.\u0001.\u0001[(int) obj8.\u0002].X) * ((double) this.\u0001.\u0001[(int) obj8.\u0001].X - (double) this.\u0001.\u0001[(int) obj8.\u0002].X);
      double num16 = (double) this.\u0001.\u0001[(int) obj8.\u0001].Y - (double) this.\u0001.\u0001[(int) obj8.\u0002].Y;
      double y1 = (double) this.\u0001.\u0001[(int) obj8.\u0001].Y;
      PointF pointF8 = this.\u0001.\u0001[(int) obj8.\u0002];
      double y2 = (double) pointF8.Y;
      double num17 = y1 - y2;
      double num18 = num16 * num17;
      double num19 = num15 + num18;
      double num20 = obj12(num19);
      if (obj11(num20) < 2.0)
        this.\u0001.\u0001[(int) index14].\u0001 = \u0007.\u0005.\u0003.\u0002;
      pointF8 = this.\u0001.\u0001[(int) obj9.\u0001];
      if (\u008C\u0003.\u0005\u0006(\u008C\u0003.\u0004\u0006(((double) pointF8.X - (double) this.\u0001.\u0001[(int) obj9.\u0002].X) * ((double) this.\u0001.\u0001[(int) obj9.\u0001].X - (double) this.\u0001.\u0001[(int) obj9.\u0002].X) + ((double) this.\u0001.\u0001[(int) obj9.\u0001].Y - (double) this.\u0001.\u0001[(int) obj9.\u0002].Y) * ((double) this.\u0001.\u0001[(int) obj9.\u0001].Y - (double) this.\u0001.\u0001[(int) obj9.\u0002].Y))) < 2.0)
        this.\u0001.\u0001[(int) index15].\u0001 = \u0007.\u0005.\u0003.\u0002;
      PointF pointF9 = this.\u0001.\u0001[(int) obj10.\u0001];
      if (\u008C\u0003.\u0005\u0006(\u008C\u0003.\u0004\u0006(((double) pointF9.X - (double) this.\u0001.\u0001[(int) obj10.\u0002].X) * ((double) this.\u0001.\u0001[(int) obj10.\u0001].X - (double) this.\u0001.\u0001[(int) obj10.\u0002].X) + ((double) this.\u0001.\u0001[(int) obj10.\u0001].Y - (double) this.\u0001.\u0001[(int) obj10.\u0002].Y) * ((double) this.\u0001.\u0001[(int) obj10.\u0001].Y - (double) this.\u0001.\u0001[(int) obj10.\u0002].Y))) < 2.0)
        this.\u0001.\u0001[(int) index16].\u0001 = \u0007.\u0005.\u0003.\u0002;
      this.\u0001.\u0001[(int) index14].\u0001.Add(index15);
      this.\u0001.\u0001[(int) index14].\u0001.Add(index16);
      this.\u0001.\u0001[(int) index15].\u0001.Add(index14);
      this.\u0001.\u0001[(int) index15].\u0001.Add(index16);
      this.\u0001.\u0001[(int) index16].\u0001.Add(index14);
      this.\u0001.\u0001[(int) index16].\u0001.Add(index15);
      this.\u0001.\u0001.Add(new \u0007.\u0005.\u0002(num11, num12, num13, index14, index15, index16));
      checked { ++index13; }
    }
    int num21 = checked (objList1.Count - 1);
    int index18 = 0;
    while (index18 <= num21)
    {
      int num22 = this.\u0001.\u0001.IndexOf(objList1[index18].\u0001);
      int num23 = this.\u0001.\u0001.IndexOf(objList1[index18].\u0002);
      if (num22 == -1 | num23 == -1)
        \u0083\u0003.\u008E\u0005(\u0001.\u0004.\u0002(1032));
      if (num22 == num23)
        \u0083\u0003.\u008E\u0005(\u0001.\u0004.\u0002(1032));
      bool flag = false;
      try
      {
        foreach (\u0007.\u0005.\u0001 obj13 in this.\u0001.\u0001)
        {
          if ((int) obj13.\u0001 == num22 & (int) obj13.\u0002 == num23 | (int) obj13.\u0002 == num22 & (int) obj13.\u0001 == num23)
          {
            flag = true;
            if (obj13.\u0001 == \u0007.\u0005.\u0003.\u0001)
            {
              switch (objList1[index18].\u0001)
              {
                case \u0004.\u0005.\u0001.\u0001:
                  obj13.\u0001 = \u0007.\u0005.\u0003.\u0002;
                  break;
                case \u0004.\u0005.\u0001.\u0002:
                  obj13.\u0001 = \u0007.\u0005.\u0003.\u0005;
                  break;
                case \u0004.\u0005.\u0001.\u0003:
                  obj13.\u0001 = \u0007.\u0005.\u0003.\u0003;
                  break;
                case \u0004.\u0005.\u0001.\u0004:
                  obj13.\u0001 = \u0007.\u0005.\u0003.\u0004;
                  break;
                default:
                  \u0083\u0003.\u008E\u0005(\u0001.\u0004.\u0002(746));
                  break;
              }
              obj13.\u0003 = checked ((ushort) objList1[index18].\u0001);
            }
            else
              goto label_136;
          }
label_136:;
        }
      }
      finally
      {
        List<\u0007.\u0005.\u0001>.Enumerator enumerator;
        enumerator.Dispose();
      }
      if (!flag)
        \u0083\u0003.\u008E\u0005(\u0001.\u0004.\u0002(746));
      checked { ++index18; }
    }
  }

  public int \u0002([In] ref List<TriangulationPoint> obj0, [In] ref TriangulationPoint obj1)
  {
    int num = 0;
    try
    {
      foreach (TriangulationPoint triangulationPoint in obj0)
      {
        if (obj1.X == triangulationPoint.X & obj1.Y == triangulationPoint.Y)
          return num;
        checked { ++num; }
      }
    }
    finally
    {
      List<TriangulationPoint>.Enumerator enumerator;
      enumerator.Dispose();
    }
    obj0.Add(obj1);
    return num;
  }

  public \u0004.\u0005.\u0003 \u0002(
    [In] ref \u0004.\u0005.\u0002 obj0,
    [In] ref \u0004.\u0005.\u0002 obj1,
    [In] ref PointF obj2)
  {
    return \u0004.\u0005.\u0002(ref obj0.\u0001, ref obj0.\u0002, ref obj1.\u0001, ref obj1.\u0002, ref obj2);
  }

  public static \u0004.\u0005.\u0003 \u0002(
    [In] ref PointF obj0,
    [In] ref PointF obj1,
    [In] ref PointF obj2,
    [In] ref PointF obj3,
    [In] ref PointF obj4)
  {
    double num1 = (double) obj1.X - (double) obj0.X;
    double num2 = (double) obj1.Y - (double) obj0.Y;
    double num3 = (double) obj3.X - (double) obj2.X;
    double num4 = (double) obj3.Y - (double) obj2.Y;
    double num5 = num4 * num1 - num3 * num2;
    if (num5 == 0.0)
      return (double) obj0.X * ((double) obj1.Y - (double) obj2.Y) + (double) obj1.X * ((double) obj2.Y - (double) obj0.Y) + (double) obj2.X * ((double) obj0.Y - (double) obj1.Y) == 0.0 && ((double) obj0.X >= (double) obj2.X && (double) obj0.X <= (double) obj3.X || (double) obj0.X <= (double) obj2.X && (double) obj0.X >= (double) obj3.X || (double) obj1.X >= (double) obj2.X && (double) obj1.X <= (double) obj3.X || (double) obj1.X <= (double) obj2.X && (double) obj1.X >= (double) obj3.X || (double) obj2.X >= (double) obj0.X && (double) obj2.X <= (double) obj1.X || (double) obj2.X <= (double) obj0.X && (double) obj2.X >= (double) obj1.X) && ((double) obj0.Y >= (double) obj2.Y && (double) obj0.Y <= (double) obj3.Y || (double) obj0.Y <= (double) obj2.Y && (double) obj0.Y >= (double) obj3.Y || (double) obj1.Y >= (double) obj2.Y && (double) obj1.Y <= (double) obj3.Y || (double) obj1.Y <= (double) obj2.Y && (double) obj1.Y >= (double) obj3.Y || (double) obj2.Y >= (double) obj0.Y && (double) obj2.Y <= (double) obj1.Y || (double) obj2.Y <= (double) obj0.Y && (double) obj2.Y >= (double) obj1.Y) ? \u0004.\u0005.\u0003.\u0004 : \u0004.\u0005.\u0003.\u0002;
    double num6 = (num3 * ((double) obj0.Y - (double) obj2.Y) - num4 * ((double) obj0.X - (double) obj2.X)) / num5;
    double num7 = (num1 * ((double) obj0.Y - (double) obj2.Y) - num2 * ((double) obj0.X - (double) obj2.X)) / num5;
    if (num6 < 0.0 | num6 > 1.0 | num7 < 0.0 | num7 > 1.0)
      return \u0004.\u0005.\u0003.\u0002;
    obj4.X = (float) \u008D\u0003.\u0003\u0006((double) obj0.X + num6 * ((double) obj1.X - (double) obj0.X), 4);
    obj4.Y = (float) \u008D\u0003.\u0003\u0006((double) obj0.Y + num6 * ((double) obj1.Y - (double) obj0.Y), 4);
    return \u0003\u0005.\u0094\u000E(obj4, obj2) | \u0003\u0005.\u0094\u000E(obj4, obj3) | \u0003\u0005.\u0094\u000E(obj4, obj0) | \u0003\u0005.\u0094\u000E(obj4, obj1) ? \u0004.\u0005.\u0003.\u0003 : \u0004.\u0005.\u0003.\u0001;
  }

  private static int \u0002([In] PointF obj0, [In] PointF obj1)
  {
    if ((double) obj0.X > (double) obj1.X)
      return 1;
    if ((double) obj0.X < (double) obj1.X)
      return -1;
    if ((double) obj0.Y < (double) obj1.Y)
      return 1;
    return (double) obj0.Y > (double) obj1.Y ? -1 : 0;
  }

  internal enum \u0001 : byte
  {
    \u0001,
    \u0002,
    \u0003,
    \u0004,
  }

  internal sealed class \u0002
  {
    public PointF \u0001;
    public PointF \u0002;
    public int \u0001;
    public \u0004.\u0005.\u0001 \u0001;

    public \u0002([In] PointF obj0, [In] PointF obj1, [In] \u0004.\u0005.\u0001 obj2)
    {
      this.\u0001 = new PointF((float) \u008D\u0003.\u0003\u0006((double) obj0.X, 4), (float) \u008D\u0003.\u0003\u0006((double) obj0.Y, 4));
      this.\u0002 = new PointF((float) \u008D\u0003.\u0003\u0006((double) obj1.X, 4), (float) \u008D\u0003.\u0003\u0006((double) obj1.Y, 4));
      this.\u0001 = obj2;
    }

    public \u0002([In] PointF obj0, [In] PointF obj1, [In] \u0004.\u0005.\u0001 obj2, [In] int obj3)
    {
      this.\u0001 = new PointF((float) \u008D\u0003.\u0003\u0006((double) obj0.X, 4), (float) \u008D\u0003.\u0003\u0006((double) obj0.Y, 4));
      this.\u0002 = new PointF((float) \u008D\u0003.\u0003\u0006((double) obj1.X, 4), (float) \u008D\u0003.\u0003\u0006((double) obj1.Y, 4));
      this.\u0001 = obj2;
      this.\u0001 = obj3;
    }
  }

  internal enum \u0003
  {
    \u0001 = -1, // 0xFFFFFFFF
    \u0002 = 0,
    \u0004 = 1,
    \u0003 = 2,
  }
}
