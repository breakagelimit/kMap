// Decompiled with JetBrains decompiler
// Type: .
// Assembly: kMap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB403103-24EE-4947-BAAC-163727D2381A
// Assembly location: C:\Users\Dev\Downloads\Nouveau dossier (28)\NavTestV2\kMap.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace \u0005;

internal sealed class \u0002 : Form
{
  private static List<WeakReference> \u0001 = new List<WeakReference>();
  private IContainer \u0001;
  private Panel \u0001;
  private \u0003 \u0001;
  private \u0003 \u0002;
  private \u0003[] \u0001;
  private byte \u0001;
  private byte \u0002;
  private uint \u0001;
  private float \u0001;

  [DebuggerNonUserCode]
  static \u0002()
  {
  }

  public \u0002()
  {
    \u008A\u0002 obj1 = \u008A\u0002.\u000E\u0004;
    \u0005.\u0002 obj2 = this;
    // ISSUE: virtual method pointer
    EventHandler eventHandler = new EventHandler((object) obj2, __vmethodptr(obj2, \u0002));
    obj1((object) this, eventHandler);
    \u0005.\u0002.\u0002((object) this);
    this.\u0001 = new \u0003();
    this.\u0002 = new \u0003();
    this.\u0002();
  }

  [DebuggerNonUserCode]
  private static void \u0002([In] object obj0)
  {
    List<WeakReference> weakReferenceList = \u0005.\u0002.\u0001;
    \u008C\u0002.\u001D\u0006((object) weakReferenceList);
    try
    {
      if (\u0005.\u0002.\u0001.Count == \u0005.\u0002.\u0001.Capacity)
      {
        int index1 = 0;
        int num = checked (\u0005.\u0002.\u0001.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          WeakReference weakReference = \u0005.\u0002.\u0001[index2];
          if (\u0092\u0002.\u007E\u001C\u0006((object) weakReference))
          {
            if (index2 != index1)
              \u0005.\u0002.\u0001[index1] = \u0005.\u0002.\u0001[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        \u0005.\u0002.\u0001.RemoveRange(index1, checked (\u0005.\u0002.\u0001.Count - index1));
        \u0005.\u0002.\u0001.Capacity = \u0005.\u0002.\u0001.Count;
      }
      \u0005.\u0002.\u0001.Add(new WeakReference(\u000E\u0003.\u001F\u0008(obj0)));
    }
    finally
    {
      \u008C\u0002.\u001E\u0006((object) weakReferenceList);
    }
  }

  [DebuggerNonUserCode]
  protected override void Dispose([In] bool obj0)
  {
    try
    {
      if (!obj0 || this.\u0001 == null)
        return;
      \u008C\u0002.\u007E\u009F\u0004((object) this.\u0001);
    }
    finally
    {
      \u008D\u0002.\u000F\u0004((object) this, obj0);
    }
  }

  private void \u0002()
  {
    this.\u0002(new Panel());
    \u008C\u0002.\u007E\u008B\u0003((object) this);
    \u0080\u0002.\u007E\u0019\u0003((object) this.\u0002(), \u0098\u0004.\u0012\u000E());
    \u0082\u0002.\u007E\u001B\u0003((object) this.\u0002(), ImageLayout.Center);
    \u0084\u0002.\u007E\u001D\u0003((object) this.\u0002(), DockStyle.Fill);
    \u0086\u0002.\u007E\u001F\u0003((object) this.\u0002(), new Point(0, 0));
    \u0087\u0002.\u007E\u007F\u0003((object) this.\u0002(), \u0001.\u0004.\u0002(1088));
    \u0088\u0002 obj1 = \u0088\u0002.\u007E\u0080\u0003;
    Panel panel = this.\u0002();
    Size size1 = new Size(605, 464);
    Size size2 = size1;
    obj1((object) panel, size2);
    \u0089\u0002.\u007E\u0081\u0003((object) this.\u0002(), 0);
    \u0090\u0002.\u007E\u008E\u0003((object) this, new SizeF(6f, 13f));
    \u0091\u0002.\u007E\u008F\u0003((object) this, AutoScaleMode.Font);
    \u0088\u0002 obj2 = \u0088\u0002.\u007E\u0007\u0004;
    size1 = new Size(605, 464);
    Size size3 = size1;
    obj2((object) this, size3);
    \u008E\u0002.\u007E\u008C\u0003((object) \u0083\u0002.\u007E\u001C\u0003((object) this), (Control) this.\u0002());
    \u0087\u0002.\u007E\u007F\u0003((object) this, \u0001.\u0004.\u0002(1763));
    \u0087\u0002.\u007E\u0008\u0004((object) this, \u0001.\u0004.\u0002(1763));
    \u008D\u0002.\u007E\u0089\u0003((object) this, false);
  }

  [DebuggerNonUserCode]
  [SpecialName]
  internal virtual Panel \u0002() => this.\u0001;

  [DebuggerNonUserCode]
  [SpecialName]
  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void \u0002([In] Panel obj0) => this.\u0001 = obj0;

  public void \u0002(
    [In] ref Bitmap obj0,
    [In] \u0003 obj1,
    [In] \u0003 obj2,
    [In] \u0003[] obj3,
    [In] byte obj4,
    [In] byte obj5)
  {
    this.\u0001 = obj4;
    this.\u0002 = obj5;
    this.\u0001 = obj3;
    this.\u0002 = obj2;
    this.\u0001 = obj1;
    this.\u0001 = checked ((uint) \u0011\u0003.\u007E\u0008\u000E((object) obj0));
    this.\u0001 = (float) this.\u0001 / 192f;
    this.\u0002(\u0099\u0004.\u0015\u000E((Image) obj0));
    \u0081\u0002.\u007E\u001A\u0003((object) this.\u0002(), (Image) obj0);
    \u008C\u0002.\u007E\u0088\u0003((object) this.\u0002());
  }

  private void \u0002([In] object obj0, [In] EventArgs obj1)
  {
  }

  private void \u0002([In] Graphics obj0)
  {
    if ((int) this.\u0001 == (int) this.\u0001.\u0003() & (int) this.\u0002 == (int) this.\u0001.\u0002())
      \u009B\u0004.\u007E\u0019\u000E((object) obj0, \u0002\u0005.\u0089\u000E(), checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked ((float) this.\u0001.\u0002() * this.\u0001))), checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked ((float) checked (192 /*0xC0*/ - this.\u0001.\u0003()) * this.\u0001))), 2, 2);
    if ((int) this.\u0001 == (int) this.\u0002.\u0003() & (int) this.\u0002 == (int) this.\u0002.\u0002())
      \u009B\u0004.\u007E\u0019\u000E((object) obj0, \u0002\u0005.\u007F\u000E(), checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked ((float) this.\u0002.\u0002() * this.\u0001))), checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked ((float) checked (192 /*0xC0*/ - this.\u0002.\u0003()) * this.\u0001))), 2, 2);
    if (this.\u0001 == null)
      return;
    int num1 = checked (this.\u0001.Length - 2);
    int index = 0;
    while (index <= num1)
    {
      try
      {
        int num2 = checked ((int) \u008C\u0003.\u0002\u0006(unchecked ((double) checked ((int) this.\u0001 - 135 * 192 /*0xC0*/) - (double) this.\u0001[index].\u0002() * -(double) this.\u0001)));
        int num3 = checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked ((float) checked ((int) this.\u0002 - 92 * 192 /*0xC0*/) - this.\u0001[index].\u0003() * this.\u0001)));
        int num4 = checked ((int) \u008C\u0003.\u0002\u0006(unchecked ((double) checked ((int) this.\u0001 - 135 * 192 /*0xC0*/) - (double) this.\u0001[checked (index + 1)].\u0002() * -(double) this.\u0001)));
        int num5 = checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked ((float) checked ((int) this.\u0002 - 92 * 192 /*0xC0*/) - this.\u0001[checked (index + 1)].\u0003() * this.\u0001)));
        \u009A\u0004.\u007E\u0016\u000E((object) obj0, \u0002\u0005.\u001F\u000E(), (float) num2, (float) checked ((long) this.\u0001 + (long) num3), (float) num4, (float) checked ((long) this.\u0001 + (long) num5));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        \u001F\u0002.\u0082\u0004();
      }
      checked { ++index; }
    }
  }
}
