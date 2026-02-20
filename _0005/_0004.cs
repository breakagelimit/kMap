// Decompiled with JetBrains decompiler
// Type: .
// Assembly: kMap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB403103-24EE-4947-BAAC-163727D2381A
// Assembly location: C:\Users\Dev\Downloads\Nouveau dossier (28)\NavTestV2\kMap.exe

using FreeImageAPI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

#nullable disable
namespace \u0005;

internal sealed class \u0004
{
  private static float \u0001 = 2f;

  public static Bitmap \u0002([In] int obj0, [In] int obj1)
  {
    \u0004.\u0003 obj2 = \u0005.\u0005.\u0001;
    string[] strArray = new string[5]
    {
      \u0001.\u0004.\u0002(1772),
      \u009D\u0002.\u001D\u0004(obj0),
      \u0001.\u0004.\u0002(1785),
      \u009D\u0002.\u001D\u0004(obj1),
      \u0001.\u0004.\u0002(1790)
    };
    string str = \u001C\u0003.\u0018\u0005(strArray);
    byte[] buffer = obj2.\u0002(str);
    Bitmap bitmap;
    if (buffer == null)
    {
      bitmap = new Bitmap(checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked (192f * \u0005.\u0004.\u0001))), checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked (192f * \u0005.\u0004.\u0001))), PixelFormat.Format16bppArgb1555);
    }
    else
    {
      Stream stream1 = (Stream) new MemoryStream(buffer, 20, checked (\u0008\u0003.\u007E\u009C\u0004((object) buffer, 0) - 19));
      try
      {
        \u001D\u0002 obj3 = \u001D\u0002.\u0014\u0003;
        Stream stream2 = stream1;
        FREE_IMAGE_FORMAT freeImageFormat = (FREE_IMAGE_FORMAT) 24;
        ref FREE_IMAGE_FORMAT local = ref freeImageFormat;
        FIBITMAP fibitmap = obj3(stream2, (FREE_IMAGE_LOAD_FLAGS) 0, ref local);
        bitmap = \u001B\u0002.\u0012\u0003(fibitmap);
        \u001C\u0002.\u0013\u0003(ref fibitmap);
        \u008C\u0002.\u007E\u009D\u0007((object) stream1);
      }
      finally
      {
        if (stream1 != null)
          \u008C\u0002.\u007E\u009F\u0004((object) stream1);
      }
    }
    return bitmap;
  }

  public static Bitmap \u0002([In] int obj0, [In] int obj1, [In] \u0005.\u0004.\u0001 obj2, [In] float obj3)
  {
    \u0005.\u0004.\u0001 = obj3;
    Bitmap bitmap = new Bitmap(checked ((int) \u008C\u0003.\u0002\u0006(unchecked (192.0 * (double) \u0005.\u0004.\u0001 + 1.0))), checked ((int) \u008C\u0003.\u0002\u0006(unchecked (192.0 * (double) \u0005.\u0004.\u0001 + 1.0))), PixelFormat.Format16bppRgb555);
    Graphics graphics1 = \u0099\u0004.\u0015\u000E((Image) bitmap);
    try
    {
      if ((obj2 & \u0005.\u0004.\u0001.\u0001) != (\u0005.\u0004.\u0001) 0)
        \u0001\u0005.\u007E\u001D\u000E((object) graphics1, (Image) \u0005.\u0004.\u0002(obj0, obj1), 0.0f, 0.0f, 192f * \u0005.\u0004.\u0001, 192f * \u0005.\u0004.\u0001);
      Graphics graphics2 = graphics1;
      \u0005.\u0004.\u0002(ref graphics2, obj0, obj1, obj2);
    }
    finally
    {
      if (graphics1 != null)
        \u008C\u0002.\u007E\u009F\u0004((object) graphics1);
    }
    \u001F\u0002.\u009B\u0005();
    return bitmap;
  }

  public static void \u0002([In] ref Graphics obj0, [In] int obj1, [In] int obj2, [In] \u0005.\u0004.\u0001 obj3)
  {
    DateTime dateTime1 = \u0098\u0002.\u0017\u0004();
    \u0007.\u0003 obj4 = new \u0007.\u0003(checked ((byte) obj1), checked ((byte) obj2));
    if (obj4.\u0002() == null)
      return;
    \u0084\u0003 obj5 = \u0084\u0003.\u008F\u0005;
    string str1 = \u0001.\u0004.\u0002(1799);
    DateTime dateTime2 = \u0098\u0002.\u0017\u0004();
    // ISSUE: variable of a boxed type
    __Boxed<double> totalMilliseconds1 = (ValueType) dateTime2.Subtract(dateTime1).TotalMilliseconds;
    obj5(str1, (object) totalMilliseconds1);
    DateTime dateTime3;
    if ((obj3 & \u0005.\u0004.\u0001.\u0002) != (\u0005.\u0004.\u0001) 0)
    {
      dateTime3 = \u0098\u0002.\u0017\u0004();
      uint num = checked ((uint) (obj4.\u0002().Length - 1));
      uint index = 0;
      while (index <= num)
      {
        RectangleF[] rectangleFArray = new RectangleF[1]
        {
          obj4.\u0002()[checked ((int) index)].\u0002(\u0005.\u0004.\u0001)
        };
        \u009D\u0004.\u007E\u001A\u000E((object) obj0, \u0002\u0005.\u001E\u000E(), rectangleFArray);
        checked { ++index; }
      }
    }
    PointF pointF1;
    PointF pointF2;
    PointF pointF3;
    PointF pointF4;
    if ((obj3 & \u0005.\u0004.\u0001.\u0003) != (\u0005.\u0004.\u0001) 0)
    {
      \u0006.\u0005[] objArray = obj4.\u0002();
      int index = 0;
      while (index < objArray.Length)
      {
        \u0006.\u0005 obj6 = objArray[index];
        if (obj6.\u0002())
        {
          \u009A\u0004 obj7 = \u009A\u0004.\u007E\u0016\u000E;
          Graphics graphics = obj0;
          Pen pen = \u0002\u0005.\u0081\u000E();
          pointF1 = obj6.\u0002();
          double num1 = (double) pointF1.X * (double) \u0005.\u0004.\u0001;
          pointF2 = obj6.\u0002();
          double num2 = (double) pointF2.Y * (double) \u0005.\u0004.\u0001;
          pointF3 = obj6.\u0003();
          double num3 = (double) pointF3.X * (double) \u0005.\u0004.\u0001;
          pointF4 = obj6.\u0003();
          double num4 = (double) pointF4.Y * (double) \u0005.\u0004.\u0001;
          obj7((object) graphics, pen, (float) num1, (float) num2, (float) num3, (float) num4);
        }
        else
        {
          \u009A\u0004 obj8 = \u009A\u0004.\u007E\u0016\u000E;
          Graphics graphics = obj0;
          Pen pen = \u0002\u0005.\u0083\u000E();
          pointF4 = obj6.\u0002();
          double num5 = (double) pointF4.X * (double) \u0005.\u0004.\u0001;
          pointF3 = obj6.\u0002();
          double num6 = (double) pointF3.Y * (double) \u0005.\u0004.\u0001;
          pointF2 = obj6.\u0003();
          double num7 = (double) pointF2.X * (double) \u0005.\u0004.\u0001;
          pointF1 = obj6.\u0003();
          double num8 = (double) pointF1.Y * (double) \u0005.\u0004.\u0001;
          obj8((object) graphics, pen, (float) num5, (float) num6, (float) num7, (float) num8);
        }
        checked { ++index; }
      }
    }
    if ((obj3 & \u0005.\u0004.\u0001.\u0004) != (\u0005.\u0004.\u0001) 0)
    {
      \u0006.\u0002[] objArray = obj4.\u0002();
      int index = 0;
      while (index < objArray.Length)
      {
        \u0006.\u0002 obj9 = objArray[index];
        if (obj9.\u0002())
        {
          \u009A\u0004 obj10 = \u009A\u0004.\u007E\u0016\u000E;
          Graphics graphics = obj0;
          Pen pen = \u0002\u0005.\u0081\u000E();
          pointF4 = obj9.\u0002();
          double num9 = (double) pointF4.X * (double) \u0005.\u0004.\u0001;
          pointF3 = obj9.\u0002();
          double num10 = (double) pointF3.Y * (double) \u0005.\u0004.\u0001;
          pointF2 = obj9.\u0003();
          double num11 = (double) pointF2.X * (double) \u0005.\u0004.\u0001;
          pointF1 = obj9.\u0003();
          double num12 = (double) pointF1.Y * (double) \u0005.\u0004.\u0001;
          obj10((object) graphics, pen, (float) num9, (float) num10, (float) num11, (float) num12);
        }
        else
        {
          \u009A\u0004 obj11 = \u009A\u0004.\u007E\u0016\u000E;
          Graphics graphics = obj0;
          Pen pen = \u0002\u0005.\u0083\u000E();
          pointF4 = obj9.\u0002();
          double num13 = (double) pointF4.X * (double) \u0005.\u0004.\u0001;
          pointF3 = obj9.\u0002();
          double num14 = (double) pointF3.Y * (double) \u0005.\u0004.\u0001;
          pointF2 = obj9.\u0003();
          double num15 = (double) pointF2.X * (double) \u0005.\u0004.\u0001;
          pointF1 = obj9.\u0003();
          double num16 = (double) pointF1.Y * (double) \u0005.\u0004.\u0001;
          obj11((object) graphics, pen, (float) num13, (float) num14, (float) num15, (float) num16);
        }
        checked { ++index; }
      }
    }
    if ((obj3 & \u0005.\u0004.\u0001.\u0005) != (\u0005.\u0004.\u0001) 0)
    {
      \u0007.\u0001[] objArray = obj4.\u0002();
      int index = 0;
      while (index < objArray.Length)
      {
        \u0007.\u0001 obj12 = objArray[index];
        \u0006.\u0003 obj13 = obj4.\u0002(ref obj12, ref \u0005.\u0005.\u0001);
        if (obj13 == null)
          return;
        try
        {
          foreach (\u0006.\u0003.\u0003 obj14 in obj13.\u0001)
          {
            \u009E\u0004 obj15 = \u009E\u0004.\u007E\u001B\u000E;
            Graphics graphics = obj0;
            Brush brush = \u0097\u0004.\u0010\u000E();
            PointF[] pointFArray1 = new PointF[3];
            ref PointF local1 = ref pointFArray1[0];
            pointF4 = new PointF(obj13.\u0001[(int) obj14.\u0002()].\u0002() * \u0005.\u0004.\u0001, obj13.\u0001[(int) obj14.\u0002()].\u0003() * \u0005.\u0004.\u0001);
            PointF pointF5 = pointF4;
            local1 = pointF5;
            ref PointF local2 = ref pointFArray1[1];
            pointF3 = new PointF(obj13.\u0001[(int) obj14.\u0003()].\u0002() * \u0005.\u0004.\u0001, obj13.\u0001[(int) obj14.\u0003()].\u0003() * \u0005.\u0004.\u0001);
            PointF pointF6 = pointF3;
            local2 = pointF6;
            ref PointF local3 = ref pointFArray1[2];
            pointF2 = new PointF(obj13.\u0001[(int) obj14.\u0004()].\u0002() * \u0005.\u0004.\u0001, obj13.\u0001[(int) obj14.\u0004()].\u0003() * \u0005.\u0004.\u0001);
            PointF pointF7 = pointF2;
            local3 = pointF7;
            PointF[] pointFArray2 = pointFArray1;
            obj15((object) graphics, brush, pointFArray2);
          }
        }
        finally
        {
          List<\u0006.\u0003.\u0003>.Enumerator enumerator;
          enumerator.Dispose();
        }
        checked { ++index; }
      }
    }
    \u0007.\u0001[] objArray1 = obj4.\u0002();
    int index1 = 0;
    while (index1 < objArray1.Length)
    {
      \u0007.\u0001 obj16 = objArray1[index1];
      \u0006.\u0003 obj17 = obj4.\u0002(ref obj16, ref \u0005.\u0005.\u0001);
      if (obj17 != null)
      {
        if ((obj3 & \u0005.\u0004.\u0001.\u0006) != (\u0005.\u0004.\u0001) 0)
        {
          try
          {
            foreach (\u0006.\u0003.\u0002 obj18 in obj17.\u0001)
            {
              if (obj18.\u0002() == (byte) 4)
                \u009A\u0004.\u007E\u0016\u000E((object) obj0, \u0002\u0005.\u0087\u000E(), obj17.\u0001[(int) obj18.\u0002()].\u0002() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj18.\u0002()].\u0003() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj18.\u0003()].\u0002() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj18.\u0003()].\u0003() * \u0005.\u0004.\u0001);
              else if (obj18.\u0002() == (byte) 20)
                \u009A\u0004.\u007E\u0016\u000E((object) obj0, \u0002\u0005.\u0088\u000E(), obj17.\u0001[(int) obj18.\u0002()].\u0002() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj18.\u0002()].\u0003() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj18.\u0003()].\u0002() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj18.\u0003()].\u0003() * \u0005.\u0004.\u0001);
              else if (obj18.\u0002() == (byte) 7)
                \u009A\u0004.\u007E\u0016\u000E((object) obj0, \u0002\u0005.\u0083\u000E(), obj17.\u0001[(int) obj18.\u0002()].\u0002() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj18.\u0002()].\u0003() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj18.\u0003()].\u0002() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj18.\u0003()].\u0003() * \u0005.\u0004.\u0001);
              else if (obj18.\u0002() == (byte) 135)
                \u009A\u0004.\u007E\u0016\u000E((object) obj0, \u0002\u0005.\u0083\u000E(), obj17.\u0001[(int) obj18.\u0002()].\u0002() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj18.\u0002()].\u0003() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj18.\u0003()].\u0002() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj18.\u0003()].\u0003() * \u0005.\u0004.\u0001);
              else
                \u009A\u0004.\u007E\u0016\u000E((object) obj0, \u0002\u0005.\u0083\u000E(), obj17.\u0001[(int) obj18.\u0002()].\u0002() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj18.\u0002()].\u0003() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj18.\u0003()].\u0002() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj18.\u0003()].\u0003() * \u0005.\u0004.\u0001);
            }
          }
          finally
          {
            List<\u0006.\u0003.\u0002>.Enumerator enumerator;
            enumerator.Dispose();
          }
        }
        if ((obj3 & \u0005.\u0004.\u0001.\u0007) != (\u0005.\u0004.\u0001) 0)
        {
          try
          {
            foreach (\u0006.\u0003.\u0002 obj19 in obj17.\u0002)
            {
              if (obj19.\u0002() == (byte) 3)
                \u009A\u0004.\u007E\u0016\u000E((object) obj0, \u0002\u0005.\u0083\u000E(), obj17.\u0001[(int) obj19.\u0002()].\u0002() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj19.\u0002()].\u0003() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj19.\u0003()].\u0002() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj19.\u0003()].\u0003() * \u0005.\u0004.\u0001);
              else if (obj19.\u0002() == (byte) 0)
                \u009A\u0004.\u007E\u0016\u000E((object) obj0, \u0002\u0005.\u0089\u000E(), obj17.\u0001[(int) obj19.\u0002()].\u0002() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj19.\u0002()].\u0003() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj19.\u0003()].\u0002() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj19.\u0003()].\u0003() * \u0005.\u0004.\u0001);
              else if (obj19.\u0002() == (byte) 16 /*0x10*/)
                \u009A\u0004.\u007E\u0016\u000E((object) obj0, \u0002\u0005.\u0088\u000E(), obj17.\u0001[(int) obj19.\u0002()].\u0002() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj19.\u0002()].\u0003() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj19.\u0003()].\u0002() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj19.\u0003()].\u0003() * \u0005.\u0004.\u0001);
              else if (obj19.\u0002() == (byte) 8)
                \u009A\u0004.\u007E\u0016\u000E((object) obj0, \u0002\u0005.\u0082\u000E(), obj17.\u0001[(int) obj19.\u0002()].\u0002() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj19.\u0002()].\u0003() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj19.\u0003()].\u0002() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj19.\u0003()].\u0003() * \u0005.\u0004.\u0001);
              else if (obj19.\u0002() == (byte) 131)
                \u009A\u0004.\u007E\u0016\u000E((object) obj0, \u0002\u0005.\u0087\u000E(), obj17.\u0001[(int) obj19.\u0002()].\u0002() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj19.\u0002()].\u0003() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj19.\u0003()].\u0002() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj19.\u0003()].\u0003() * \u0005.\u0004.\u0001);
              else
                \u009A\u0004.\u007E\u0016\u000E((object) obj0, \u0002\u0005.\u0084\u000E(), obj17.\u0001[(int) obj19.\u0002()].\u0002() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj19.\u0002()].\u0003() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj19.\u0003()].\u0002() * \u0005.\u0004.\u0001, obj17.\u0001[(int) obj19.\u0003()].\u0003() * \u0005.\u0004.\u0001);
            }
          }
          finally
          {
            List<\u0006.\u0003.\u0002>.Enumerator enumerator;
            enumerator.Dispose();
          }
        }
        checked { ++index1; }
      }
      else
        break;
    }
    dateTime3 = \u0098\u0002.\u0017\u0004();
    if ((obj3 & \u0005.\u0004.\u0001.\u0008) != (\u0005.\u0004.\u0001) 0)
    {
      DateTime dateTime4 = \u0098\u0002.\u0017\u0004();
      uint num = checked ((uint) (obj4.\u0002().Length - 1));
      uint index2 = 0;
      while (index2 <= num)
      {
        \u0007.\u0004 obj20 = obj4.\u0002()[checked ((int) index2)];
        \u009F\u0004 obj21 = \u009F\u0004.\u007E\u001C\u000E;
        Graphics graphics1 = obj0;
        string str2 = \u009E\u0002.\u001E\u0004(index2);
        Font font = new Font(\u0001.\u0004.\u0002(1828), 8f);
        Brush brush = \u0097\u0004.\u000F\u000E();
        pointF4 = new PointF(obj4.\u0002()[checked ((int) index2)].\u0002() * \u0005.\u0004.\u0001, obj4.\u0002()[checked ((int) index2)].\u0005() * \u0005.\u0004.\u0001);
        PointF pointF8 = pointF4;
        obj21((object) graphics1, str2, font, brush, pointF8);
        if (obj20.\u0002())
        {
          \u0004.\u0005 obj22 = new \u0004.\u0005(ref obj4, checked ((int) index2));
          if (obj22.\u0001 != null)
          {
            try
            {
              foreach (\u0007.\u0005.\u0001 obj23 in obj22.\u0001.\u0001)
              {
                Point point1;
                Point point2;
                if (obj23.\u0001 == \u0007.\u0005.\u0003.\u0002)
                {
                  \u009C\u0004 obj24 = \u009C\u0004.\u007E\u0018\u000E;
                  Graphics graphics2 = obj0;
                  Pen pen = \u0002\u0005.\u0083\u000E();
                  ref Point local4 = ref point1;
                  pointF4 = obj22.\u0001.\u0001[(int) obj23.\u0001];
                  int x1 = checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked (pointF4.X * \u0005.\u0004.\u0001)));
                  pointF3 = obj22.\u0001.\u0001[(int) obj23.\u0001];
                  int y1 = checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked (pointF3.Y * \u0005.\u0004.\u0001)));
                  local4 = new Point(x1, y1);
                  Point point3 = point1;
                  ref Point local5 = ref point2;
                  PointF pointF9 = obj22.\u0001.\u0001[(int) obj23.\u0002];
                  int x2 = checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked (pointF9.X * \u0005.\u0004.\u0001)));
                  pointF1 = obj22.\u0001.\u0001[(int) obj23.\u0002];
                  int y2 = checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked (pointF1.Y * \u0005.\u0004.\u0001)));
                  local5 = new Point(x2, y2);
                  Point point4 = point2;
                  obj24((object) graphics2, pen, point3, point4);
                }
                if (obj23.\u0001 == \u0007.\u0005.\u0003.\u0004)
                {
                  \u009C\u0004 obj25 = \u009C\u0004.\u007E\u0018\u000E;
                  Graphics graphics3 = obj0;
                  Pen pen = \u0002\u0005.\u0088\u000E();
                  ref Point local6 = ref point2;
                  pointF4 = obj22.\u0001.\u0001[(int) obj23.\u0001];
                  int x3 = checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked (pointF4.X * \u0005.\u0004.\u0001)));
                  pointF3 = obj22.\u0001.\u0001[(int) obj23.\u0001];
                  int y3 = checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked (pointF3.Y * \u0005.\u0004.\u0001)));
                  local6 = new Point(x3, y3);
                  Point point5 = point2;
                  ref Point local7 = ref point1;
                  PointF pointF10 = obj22.\u0001.\u0001[(int) obj23.\u0002];
                  int x4 = checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked (pointF10.X * \u0005.\u0004.\u0001)));
                  pointF1 = obj22.\u0001.\u0001[(int) obj23.\u0002];
                  int y4 = checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked (pointF1.Y * \u0005.\u0004.\u0001)));
                  local7 = new Point(x4, y4);
                  Point point6 = point1;
                  obj25((object) graphics3, pen, point5, point6);
                }
                if (obj23.\u0001 == \u0007.\u0005.\u0003.\u0003)
                {
                  \u009C\u0004 obj26 = \u009C\u0004.\u007E\u0018\u000E;
                  Graphics graphics4 = obj0;
                  Pen pen = \u0002\u0005.\u0089\u000E();
                  ref Point local8 = ref point2;
                  pointF4 = obj22.\u0001.\u0001[(int) obj23.\u0001];
                  int x5 = checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked (pointF4.X * \u0005.\u0004.\u0001)));
                  pointF3 = obj22.\u0001.\u0001[(int) obj23.\u0001];
                  int y5 = checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked (pointF3.Y * \u0005.\u0004.\u0001)));
                  local8 = new Point(x5, y5);
                  Point point7 = point2;
                  ref Point local9 = ref point1;
                  PointF pointF11 = obj22.\u0001.\u0001[(int) obj23.\u0002];
                  int x6 = checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked (pointF11.X * \u0005.\u0004.\u0001)));
                  pointF1 = obj22.\u0001.\u0001[(int) obj23.\u0002];
                  int y6 = checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked (pointF1.Y * \u0005.\u0004.\u0001)));
                  local9 = new Point(x6, y6);
                  Point point8 = point1;
                  obj26((object) graphics4, pen, point7, point8);
                }
                if (obj23.\u0001 == \u0007.\u0005.\u0003.\u0005)
                {
                  \u009C\u0004 obj27 = \u009C\u0004.\u007E\u0018\u000E;
                  Graphics graphics5 = obj0;
                  Pen pen = \u0002\u0005.\u0087\u000E();
                  ref Point local10 = ref point2;
                  pointF4 = obj22.\u0001.\u0001[(int) obj23.\u0001];
                  int x7 = checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked (pointF4.X * \u0005.\u0004.\u0001)));
                  pointF3 = obj22.\u0001.\u0001[(int) obj23.\u0001];
                  int y7 = checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked (pointF3.Y * \u0005.\u0004.\u0001)));
                  local10 = new Point(x7, y7);
                  Point point9 = point2;
                  ref Point local11 = ref point1;
                  PointF pointF12 = obj22.\u0001.\u0001[(int) obj23.\u0002];
                  int x8 = checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked (pointF12.X * \u0005.\u0004.\u0001)));
                  pointF1 = obj22.\u0001.\u0001[(int) obj23.\u0002];
                  int y8 = checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked (pointF1.Y * \u0005.\u0004.\u0001)));
                  local11 = new Point(x8, y8);
                  Point point10 = point1;
                  obj27((object) graphics5, pen, point9, point10);
                }
                if (obj23.\u0001 == \u0007.\u0005.\u0003.\u0001)
                {
                  \u009C\u0004 obj28 = \u009C\u0004.\u007E\u0018\u000E;
                  Graphics graphics6 = obj0;
                  Pen pen = \u0002\u0005.\u0086\u000E();
                  ref Point local12 = ref point2;
                  pointF4 = obj22.\u0001.\u0001[(int) obj23.\u0001];
                  int x9 = checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked (pointF4.X * \u0005.\u0004.\u0001)));
                  pointF3 = obj22.\u0001.\u0001[(int) obj23.\u0001];
                  int y9 = checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked (pointF3.Y * \u0005.\u0004.\u0001)));
                  local12 = new Point(x9, y9);
                  Point point11 = point2;
                  ref Point local13 = ref point1;
                  PointF pointF13 = obj22.\u0001.\u0001[(int) obj23.\u0002];
                  int x10 = checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked (pointF13.X * \u0005.\u0004.\u0001)));
                  pointF1 = obj22.\u0001.\u0001[(int) obj23.\u0002];
                  int y10 = checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked (pointF1.Y * \u0005.\u0004.\u0001)));
                  local13 = new Point(x10, y10);
                  Point point12 = point1;
                  obj28((object) graphics6, pen, point11, point12);
                }
              }
            }
            finally
            {
              List<\u0007.\u0005.\u0001>.Enumerator enumerator;
              enumerator.Dispose();
            }
          }
        }
        checked { ++index2; }
      }
      \u0084\u0003 obj29 = \u0084\u0003.\u008F\u0005;
      string str3 = \u0001.\u0004.\u0002(1837);
      dateTime2 = \u0098\u0002.\u0017\u0004();
      // ISSUE: variable of a boxed type
      __Boxed<double> totalMilliseconds2 = (ValueType) dateTime2.Subtract(dateTime4).TotalMilliseconds;
      obj29(str3, (object) totalMilliseconds2);
    }
  }

  [Flags]
  public enum \u0001
  {
    \u0001 = 1,
    \u0002 = 2,
    \u0003 = 4,
    \u0004 = 8,
    \u0005 = 16, // 0x00000010
    \u0006 = 32, // 0x00000020
    \u0007 = 64, // 0x00000040
    \u0008 = 128, // 0x00000080
  }
}
