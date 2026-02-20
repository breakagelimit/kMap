// Decompiled with JetBrains decompiler
// Type: .
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

internal sealed class \u0001 : Form
{
  private static List<WeakReference> \u0001 = new List<WeakReference>();
  private IContainer \u0001;
  private Button \u0001;
  private Panel \u0001;
  private Panel \u0002;
  private Panel \u0003;
  private Button \u0002;
  private Button \u0003;
  private Button \u0004;
  private Button \u0005;
  private Panel \u0004;
  private Panel \u0005;
  private Panel \u0006;
  private Panel \u0007;
  private Panel \u0008;
  private Panel \u000E;
  private CheckBox \u0001;
  private CheckBox \u0002;
  private CheckBox \u0003;
  private CheckBox \u0004;
  private CheckBox \u0005;
  private CheckBox \u0006;
  private CheckBox \u0007;
  private CheckBox \u0008;
  private PictureBox \u0001;
  private Button \u0006;
  private Label \u0001;
  private TextBox \u0001;
  private int \u0001;
  private int \u0002;
  private \u0005.\u0004.\u0001 \u0001;
  private \u0005.\u0003 \u0001;
  private \u0005.\u0003 \u0002;
  private \u0005.\u0003[] \u0001;
  private \u0005.\u0003[] \u0002;
  private \u0005.\u0003[] \u0003;
  private \u0004.\u0004 \u0001;

  [DebuggerNonUserCode]
  static \u0001()
  {
  }

  public \u0001()
  {
    \u008A\u0002 obj1 = \u008A\u0002.\u000E\u0004;
    \u0005.\u0001 obj2 = this;
    // ISSUE: virtual method pointer
    EventHandler eventHandler = new EventHandler((object) obj2, __vmethodptr(obj2, \u0002));
    obj1((object) this, eventHandler);
    \u0005.\u0001.\u0002((object) this);
    this.\u0001 = 153;
    this.\u0002 = 102;
    this.\u0001 = \u0005.\u0004.\u0001.\u0001 | \u0005.\u0004.\u0001.\u0002 | \u0005.\u0004.\u0001.\u0003 | \u0005.\u0004.\u0001.\u0004;
    this.\u0001 = new \u0005.\u0003();
    this.\u0002 = new \u0005.\u0003();
    this.\u0001 = new \u0004.\u0004();
    this.\u0002();
  }

  [DebuggerNonUserCode]
  private static void \u0002([In] object obj0)
  {
    List<WeakReference> weakReferenceList = \u0005.\u0001.\u0001;
    \u008C\u0002.\u001D\u0006((object) weakReferenceList);
    try
    {
      if (\u0005.\u0001.\u0001.Count == \u0005.\u0001.\u0001.Capacity)
      {
        int index1 = 0;
        int num = checked (\u0005.\u0001.\u0001.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          WeakReference weakReference = \u0005.\u0001.\u0001[index2];
          if (\u0092\u0002.\u007E\u001C\u0006((object) weakReference))
          {
            if (index2 != index1)
              \u0005.\u0001.\u0001[index1] = \u0005.\u0001.\u0001[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        \u0005.\u0001.\u0001.RemoveRange(index1, checked (\u0005.\u0001.\u0001.Count - index1));
        \u0005.\u0001.\u0001.Capacity = \u0005.\u0001.\u0001.Count;
      }
      \u0005.\u0001.\u0001.Add(new WeakReference(\u000E\u0003.\u001F\u0008(obj0)));
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
    this.\u0002(new Button());
    this.\u0002(new Panel());
    this.\u0003(new Panel());
    this.\u0004(new Panel());
    this.\u0003(new Button());
    this.\u0004(new Button());
    this.\u0005(new Button());
    this.\u0006(new Button());
    this.\u0005(new Panel());
    this.\u0006(new Panel());
    this.\u0007(new Panel());
    this.\u0008(new Panel());
    this.\u000E(new Panel());
    this.\u000F(new Panel());
    this.\u0002(new CheckBox());
    this.\u0003(new CheckBox());
    this.\u0004(new CheckBox());
    this.\u0005(new CheckBox());
    this.\u0006(new CheckBox());
    this.\u0007(new CheckBox());
    this.\u0008(new CheckBox());
    this.\u000E(new CheckBox());
    this.\u0002(new PictureBox());
    this.\u0007(new Button());
    this.\u0002(new Label());
    this.\u0002(new TextBox());
    \u008C\u0002.\u007E\u009E\u0008((object) this.\u0002());
    \u008C\u0002.\u007E\u008B\u0003((object) this);
    \u0080\u0002.\u007E\u0091\u0003((object) this.\u0002(), \u0098\u0004.\u0014\u000E());
    \u0086\u0002 obj1 = \u0086\u0002.\u007E\u001F\u0003;
    Button button1 = this.\u0002();
    Point point1 = new Point(908, 44);
    Point point2 = point1;
    obj1((object) button1, point2);
    \u0087\u0002.\u007E\u007F\u0003((object) this.\u0002(), \u0001.\u0004.\u0002(1070));
    \u0088\u0002 obj2 = \u0088\u0002.\u007E\u0080\u0003;
    Button button2 = this.\u0002();
    Size size1 = new Size(23, 23);
    Size size2 = size1;
    obj2((object) button2, size2);
    \u0089\u0002.\u007E\u0081\u0003((object) this.\u0002(), 0);
    \u0087\u0002.\u007E\u0092\u0003((object) this.\u0002(), \u0001.\u0004.\u0002(1083));
    \u008D\u0002.\u007E\u0093\u0003((object) this.\u0002(), false);
    \u0080\u0002.\u007E\u0019\u0003((object) this.\u0002(), \u0098\u0004.\u0013\u000E());
    \u0082\u0002.\u007E\u001B\u0003((object) this.\u0002(), ImageLayout.None);
    \u0086\u0002 obj3 = \u0086\u0002.\u007E\u001F\u0003;
    Panel panel1 = this.\u0002();
    point1 = new Point(8, 12);
    Point point3 = point1;
    obj3((object) panel1, point3);
    \u0087\u0002.\u007E\u007F\u0003((object) this.\u0002(), \u0001.\u0004.\u0002(1088));
    \u0088\u0002 obj4 = \u0088\u0002.\u007E\u0080\u0003;
    Panel panel2 = this.\u0002();
    size1 = new Size(289, 289);
    Size size3 = size1;
    obj4((object) panel2, size3);
    \u0089\u0002.\u007E\u0081\u0003((object) this.\u0002(), 1);
    \u0080\u0002.\u007E\u0019\u0003((object) this.\u0003(), \u0098\u0004.\u0013\u000E());
    \u0082\u0002.\u007E\u001B\u0003((object) this.\u0003(), ImageLayout.None);
    \u0086\u0002 obj5 = \u0086\u0002.\u007E\u001F\u0003;
    Panel panel3 = this.\u0003();
    point1 = new Point(297, 12);
    Point point4 = point1;
    obj5((object) panel3, point4);
    \u0087\u0002.\u007E\u007F\u0003((object) this.\u0003(), \u0001.\u0004.\u0002(1097));
    \u0088\u0002 obj6 = \u0088\u0002.\u007E\u0080\u0003;
    Panel panel4 = this.\u0003();
    size1 = new Size(289, 289);
    Size size4 = size1;
    obj6((object) panel4, size4);
    \u0089\u0002.\u007E\u0081\u0003((object) this.\u0003(), 2);
    \u0080\u0002.\u007E\u0019\u0003((object) this.\u0004(), \u0098\u0004.\u0013\u000E());
    \u0082\u0002.\u007E\u001B\u0003((object) this.\u0004(), ImageLayout.None);
    \u0086\u0002 obj7 = \u0086\u0002.\u007E\u001F\u0003;
    Panel panel5 = this.\u0004();
    point1 = new Point(586, 12);
    Point point5 = point1;
    obj7((object) panel5, point5);
    \u0087\u0002.\u007E\u007F\u0003((object) this.\u0004(), \u0001.\u0004.\u0002(1106));
    \u0088\u0002 obj8 = \u0088\u0002.\u007E\u0080\u0003;
    Panel panel6 = this.\u0004();
    size1 = new Size(289, 289);
    Size size5 = size1;
    obj8((object) panel6, size5);
    \u0089\u0002.\u007E\u0081\u0003((object) this.\u0004(), 3);
    \u0080\u0002.\u007E\u0091\u0003((object) this.\u0003(), \u0098\u0004.\u0014\u000E());
    \u0086\u0002 obj9 = \u0086\u0002.\u007E\u001F\u0003;
    Button button3 = this.\u0003();
    point1 = new Point(908, 21);
    Point point6 = point1;
    obj9((object) button3, point6);
    \u0087\u0002.\u007E\u007F\u0003((object) this.\u0003(), \u0001.\u0004.\u0002(1115));
    \u0088\u0002 obj10 = \u0088\u0002.\u007E\u0080\u0003;
    Button button4 = this.\u0003();
    size1 = new Size(23, 23);
    Size size6 = size1;
    obj10((object) button4, size6);
    \u0089\u0002.\u007E\u0081\u0003((object) this.\u0003(), 4);
    \u0087\u0002.\u007E\u0092\u0003((object) this.\u0003(), \u0001.\u0004.\u0002(1083));
    \u008D\u0002.\u007E\u0093\u0003((object) this.\u0003(), false);
    \u0080\u0002.\u007E\u0091\u0003((object) this.\u0004(), \u0098\u0004.\u0014\u000E());
    \u0086\u0002 obj11 = \u0086\u0002.\u007E\u001F\u0003;
    Button button5 = this.\u0004();
    point1 = new Point(908, 67);
    Point point7 = point1;
    obj11((object) button5, point7);
    \u0087\u0002.\u007E\u007F\u0003((object) this.\u0004(), \u0001.\u0004.\u0002(1128));
    \u0088\u0002 obj12 = \u0088\u0002.\u007E\u0080\u0003;
    Button button6 = this.\u0004();
    size1 = new Size(23, 23);
    Size size7 = size1;
    obj12((object) button6, size7);
    \u0089\u0002.\u007E\u0081\u0003((object) this.\u0004(), 5);
    \u0087\u0002.\u007E\u0092\u0003((object) this.\u0004(), \u0001.\u0004.\u0002(1083));
    \u008D\u0002.\u007E\u0093\u0003((object) this.\u0004(), false);
    \u0080\u0002.\u007E\u0091\u0003((object) this.\u0005(), \u0098\u0004.\u0014\u000E());
    \u0086\u0002 obj13 = \u0086\u0002.\u007E\u001F\u0003;
    Button button7 = this.\u0005();
    point1 = new Point(885, 44);
    Point point8 = point1;
    obj13((object) button7, point8);
    \u0087\u0002.\u007E\u007F\u0003((object) this.\u0005(), \u0001.\u0004.\u0002(1141));
    \u0088\u0002 obj14 = \u0088\u0002.\u007E\u0080\u0003;
    Button button8 = this.\u0005();
    size1 = new Size(23, 23);
    Size size8 = size1;
    obj14((object) button8, size8);
    \u0089\u0002.\u007E\u0081\u0003((object) this.\u0005(), 6);
    \u0087\u0002.\u007E\u0092\u0003((object) this.\u0005(), \u0001.\u0004.\u0002(1083));
    \u008D\u0002.\u007E\u0093\u0003((object) this.\u0005(), false);
    \u0080\u0002.\u007E\u0091\u0003((object) this.\u0006(), \u0098\u0004.\u0014\u000E());
    \u0086\u0002 obj15 = \u0086\u0002.\u007E\u001F\u0003;
    Button button9 = this.\u0006();
    point1 = new Point(931, 44);
    Point point9 = point1;
    obj15((object) button9, point9);
    \u0087\u0002.\u007E\u007F\u0003((object) this.\u0006(), \u0001.\u0004.\u0002(1154));
    \u0088\u0002 obj16 = \u0088\u0002.\u007E\u0080\u0003;
    Button button10 = this.\u0006();
    size1 = new Size(23, 23);
    Size size9 = size1;
    obj16((object) button10, size9);
    \u0089\u0002.\u007E\u0081\u0003((object) this.\u0006(), 7);
    \u0087\u0002.\u007E\u0092\u0003((object) this.\u0006(), \u0001.\u0004.\u0002(1083));
    \u008D\u0002.\u007E\u0093\u0003((object) this.\u0006(), false);
    \u0080\u0002.\u007E\u0019\u0003((object) this.\u0005(), \u0098\u0004.\u0013\u000E());
    \u0082\u0002.\u007E\u001B\u0003((object) this.\u0005(), ImageLayout.None);
    \u0086\u0002 obj17 = \u0086\u0002.\u007E\u001F\u0003;
    Panel panel7 = this.\u0005();
    point1 = new Point(8, 301);
    Point point10 = point1;
    obj17((object) panel7, point10);
    \u0087\u0002.\u007E\u007F\u0003((object) this.\u0005(), \u0001.\u0004.\u0002(1167));
    \u0088\u0002 obj18 = \u0088\u0002.\u007E\u0080\u0003;
    Panel panel8 = this.\u0005();
    size1 = new Size(289, 289);
    Size size10 = size1;
    obj18((object) panel8, size10);
    \u0089\u0002.\u007E\u0081\u0003((object) this.\u0005(), 5);
    \u0080\u0002.\u007E\u0019\u0003((object) this.\u0006(), \u0098\u0004.\u0013\u000E());
    \u0082\u0002.\u007E\u001B\u0003((object) this.\u0006(), ImageLayout.None);
    \u0086\u0002 obj19 = \u0086\u0002.\u007E\u001F\u0003;
    Panel panel9 = this.\u0006();
    point1 = new Point(297, 301);
    Point point11 = point1;
    obj19((object) panel9, point11);
    \u0087\u0002.\u007E\u007F\u0003((object) this.\u0006(), \u0001.\u0004.\u0002(1176));
    \u0088\u0002 obj20 = \u0088\u0002.\u007E\u0080\u0003;
    Panel panel10 = this.\u0006();
    size1 = new Size(289, 289);
    Size size11 = size1;
    obj20((object) panel10, size11);
    \u0089\u0002.\u007E\u0081\u0003((object) this.\u0006(), 6);
    \u0080\u0002.\u007E\u0019\u0003((object) this.\u0007(), \u0098\u0004.\u0013\u000E());
    \u0082\u0002.\u007E\u001B\u0003((object) this.\u0007(), ImageLayout.None);
    \u0086\u0002 obj21 = \u0086\u0002.\u007E\u001F\u0003;
    Panel panel11 = this.\u0007();
    point1 = new Point(586, 301);
    Point point12 = point1;
    obj21((object) panel11, point12);
    \u0087\u0002.\u007E\u007F\u0003((object) this.\u0007(), \u0001.\u0004.\u0002(1185));
    \u0088\u0002 obj22 = \u0088\u0002.\u007E\u0080\u0003;
    Panel panel12 = this.\u0007();
    size1 = new Size(289, 289);
    Size size12 = size1;
    obj22((object) panel12, size12);
    \u0089\u0002.\u007E\u0081\u0003((object) this.\u0007(), 4);
    \u0080\u0002.\u007E\u0019\u0003((object) this.\u0008(), \u0098\u0004.\u0013\u000E());
    \u0082\u0002.\u007E\u001B\u0003((object) this.\u0008(), ImageLayout.None);
    \u0086\u0002 obj23 = \u0086\u0002.\u007E\u001F\u0003;
    Panel panel13 = this.\u0008();
    point1 = new Point(8, 590);
    Point point13 = point1;
    obj23((object) panel13, point13);
    \u0087\u0002.\u007E\u007F\u0003((object) this.\u0008(), \u0001.\u0004.\u0002(1194));
    \u0088\u0002 obj24 = \u0088\u0002.\u007E\u0080\u0003;
    Panel panel14 = this.\u0008();
    size1 = new Size(289, 289);
    Size size13 = size1;
    obj24((object) panel14, size13);
    \u0089\u0002.\u007E\u0081\u0003((object) this.\u0008(), 8);
    \u0080\u0002.\u007E\u0019\u0003((object) this.\u000E(), \u0098\u0004.\u0013\u000E());
    \u0082\u0002.\u007E\u001B\u0003((object) this.\u000E(), ImageLayout.None);
    \u0086\u0002 obj25 = \u0086\u0002.\u007E\u001F\u0003;
    Panel panel15 = this.\u000E();
    point1 = new Point(297, 590);
    Point point14 = point1;
    obj25((object) panel15, point14);
    \u0087\u0002.\u007E\u007F\u0003((object) this.\u000E(), \u0001.\u0004.\u0002(1203));
    \u0088\u0002 obj26 = \u0088\u0002.\u007E\u0080\u0003;
    Panel panel16 = this.\u000E();
    size1 = new Size(289, 289);
    Size size14 = size1;
    obj26((object) panel16, size14);
    \u0089\u0002.\u007E\u0081\u0003((object) this.\u000E(), 9);
    \u0080\u0002.\u007E\u0019\u0003((object) this.\u000F(), \u0098\u0004.\u0013\u000E());
    \u0082\u0002.\u007E\u001B\u0003((object) this.\u000F(), ImageLayout.None);
    \u0086\u0002 obj27 = \u0086\u0002.\u007E\u001F\u0003;
    Panel panel17 = this.\u000F();
    point1 = new Point(586, 590);
    Point point15 = point1;
    obj27((object) panel17, point15);
    \u0087\u0002.\u007E\u007F\u0003((object) this.\u000F(), \u0001.\u0004.\u0002(1212));
    \u0088\u0002 obj28 = \u0088\u0002.\u007E\u0080\u0003;
    Panel panel18 = this.\u000F();
    size1 = new Size(289, 289);
    Size size15 = size1;
    obj28((object) panel18, size15);
    \u0089\u0002.\u007E\u0081\u0003((object) this.\u000F(), 7);
    \u008D\u0002.\u007E\u0090\u0003((object) this.\u0002(), true);
    \u0080\u0002.\u007E\u0091\u0003((object) this.\u0002(), \u0098\u0004.\u0011\u000E());
    \u008D\u0002.\u007E\u0097\u0003((object) this.\u0002(), true);
    \u0093\u0002.\u007E\u0098\u0003((object) this.\u0002(), CheckState.Checked);
    \u0080\u0002.\u007E\u001E\u0003((object) this.\u0002(), \u0098\u0004.\u0014\u000E());
    \u0086\u0002 obj29 = \u0086\u0002.\u007E\u001F\u0003;
    CheckBox checkBox1 = this.\u0002();
    point1 = new Point(885, 126);
    Point point16 = point1;
    obj29((object) checkBox1, point16);
    \u0087\u0002.\u007E\u007F\u0003((object) this.\u0002(), \u0001.\u0004.\u0002(1221));
    \u0088\u0002 obj30 = \u0088\u0002.\u007E\u0080\u0003;
    CheckBox checkBox2 = this.\u0002();
    size1 = new Size(57, 17);
    Size size16 = size1;
    obj30((object) checkBox2, size16);
    \u0089\u0002.\u007E\u0081\u0003((object) this.\u0002(), 10);
    \u0087\u0002.\u007E\u0092\u0003((object) this.\u0002(), \u0001.\u0004.\u0002(1234));
    \u008D\u0002.\u007E\u0093\u0003((object) this.\u0002(), false);
    \u008D\u0002.\u007E\u0090\u0003((object) this.\u0003(), true);
    \u0080\u0002.\u007E\u0091\u0003((object) this.\u0003(), \u0098\u0004.\u0011\u000E());
    \u008D\u0002.\u007E\u0097\u0003((object) this.\u0003(), true);
    \u0093\u0002.\u007E\u0098\u0003((object) this.\u0003(), CheckState.Checked);
    \u0080\u0002.\u007E\u001E\u0003((object) this.\u0003(), \u0098\u0004.\u0014\u000E());
    \u0086\u0002 obj31 = \u0086\u0002.\u007E\u001F\u0003;
    CheckBox checkBox3 = this.\u0003();
    point1 = new Point(885, 149);
    Point point17 = point1;
    obj31((object) checkBox3, point17);
    \u0087\u0002.\u007E\u007F\u0003((object) this.\u0003(), \u0001.\u0004.\u0002(1243));
    \u0088\u0002 obj32 = \u0088\u0002.\u007E\u0080\u0003;
    CheckBox checkBox4 = this.\u0003();
    size1 = new Size(57, 17);
    Size size17 = size1;
    obj32((object) checkBox4, size17);
    \u0089\u0002.\u007E\u0081\u0003((object) this.\u0003(), 12);
    \u0087\u0002.\u007E\u0092\u0003((object) this.\u0003(), \u0001.\u0004.\u0002(1256));
    \u008D\u0002.\u007E\u0093\u0003((object) this.\u0003(), false);
    \u008D\u0002.\u007E\u0090\u0003((object) this.\u0004(), true);
    \u0080\u0002.\u007E\u0091\u0003((object) this.\u0004(), \u0098\u0004.\u0011\u000E());
    \u008D\u0002.\u007E\u0097\u0003((object) this.\u0004(), true);
    \u0093\u0002.\u007E\u0098\u0003((object) this.\u0004(), CheckState.Checked);
    \u0080\u0002.\u007E\u001E\u0003((object) this.\u0004(), \u0098\u0004.\u0014\u000E());
    \u0086\u0002 obj33 = \u0086\u0002.\u007E\u001F\u0003;
    CheckBox checkBox5 = this.\u0004();
    point1 = new Point(885, 172);
    Point point18 = point1;
    obj33((object) checkBox5, point18);
    \u0087\u0002.\u007E\u007F\u0003((object) this.\u0004(), \u0001.\u0004.\u0002(1265));
    \u0088\u0002 obj34 = \u0088\u0002.\u007E\u0080\u0003;
    CheckBox checkBox6 = this.\u0004();
    size1 = new Size(57, 17);
    Size size18 = size1;
    obj34((object) checkBox6, size18);
    \u0089\u0002.\u007E\u0081\u0003((object) this.\u0004(), 13);
    \u0087\u0002.\u007E\u0092\u0003((object) this.\u0004(), \u0001.\u0004.\u0002(1278));
    \u008D\u0002.\u007E\u0093\u0003((object) this.\u0004(), false);
    \u008D\u0002.\u007E\u0090\u0003((object) this.\u0005(), true);
    \u0080\u0002.\u007E\u0091\u0003((object) this.\u0005(), \u0098\u0004.\u0011\u000E());
    \u008D\u0002.\u007E\u0097\u0003((object) this.\u0005(), true);
    \u0093\u0002.\u007E\u0098\u0003((object) this.\u0005(), CheckState.Checked);
    \u0080\u0002.\u007E\u001E\u0003((object) this.\u0005(), \u0098\u0004.\u0014\u000E());
    \u0086\u0002 obj35 = \u0086\u0002.\u007E\u001F\u0003;
    CheckBox checkBox7 = this.\u0005();
    point1 = new Point(885, 195);
    Point point19 = point1;
    obj35((object) checkBox7, point19);
    \u0087\u0002.\u007E\u007F\u0003((object) this.\u0005(), \u0001.\u0004.\u0002(1287));
    \u0088\u0002 obj36 = \u0088\u0002.\u007E\u0080\u0003;
    CheckBox checkBox8 = this.\u0005();
    size1 = new Size(99, 17);
    Size size19 = size1;
    obj36((object) checkBox8, size19);
    \u0089\u0002.\u007E\u0081\u0003((object) this.\u0005(), 14);
    \u0087\u0002.\u007E\u0092\u0003((object) this.\u0005(), \u0001.\u0004.\u0002(1312));
    \u008D\u0002.\u007E\u0093\u0003((object) this.\u0005(), false);
    \u008D\u0002.\u007E\u0090\u0003((object) this.\u0006(), true);
    \u0080\u0002.\u007E\u0091\u0003((object) this.\u0006(), \u0098\u0004.\u0011\u000E());
    \u0080\u0002.\u007E\u001E\u0003((object) this.\u0006(), \u0098\u0004.\u0014\u000E());
    \u0086\u0002 obj37 = \u0086\u0002.\u007E\u001F\u0003;
    CheckBox checkBox9 = this.\u0006();
    point1 = new Point(885, 218);
    Point point20 = point1;
    obj37((object) checkBox9, point20);
    \u0087\u0002.\u007E\u007F\u0003((object) this.\u0006(), \u0001.\u0004.\u0002(1333));
    \u0088\u0002 obj38 = \u0088\u0002.\u007E\u0080\u0003;
    CheckBox checkBox10 = this.\u0006();
    size1 = new Size(91, 17);
    Size size20 = size1;
    obj38((object) checkBox10, size20);
    \u0089\u0002.\u007E\u0081\u0003((object) this.\u0006(), 15);
    \u0087\u0002.\u007E\u0092\u0003((object) this.\u0006(), \u0001.\u0004.\u0002(1354));
    \u008D\u0002.\u007E\u0093\u0003((object) this.\u0006(), false);
    \u008D\u0002.\u007E\u0090\u0003((object) this.\u0007(), true);
    \u0080\u0002.\u007E\u0091\u0003((object) this.\u0007(), \u0098\u0004.\u0011\u000E());
    \u0080\u0002.\u007E\u001E\u0003((object) this.\u0007(), \u0098\u0004.\u0014\u000E());
    \u0086\u0002 obj39 = \u0086\u0002.\u007E\u001F\u0003;
    CheckBox checkBox11 = this.\u0007();
    point1 = new Point(885, 241);
    Point point21 = point1;
    obj39((object) checkBox11, point21);
    \u0087\u0002.\u007E\u007F\u0003((object) this.\u0007(), \u0001.\u0004.\u0002(1375));
    \u0088\u0002 obj40 = \u0088\u0002.\u007E\u0080\u0003;
    CheckBox checkBox12 = this.\u0007();
    size1 = new Size(71, 17);
    Size size21 = size1;
    obj40((object) checkBox12, size21);
    \u0089\u0002.\u007E\u0081\u0003((object) this.\u0007(), 16 /*0x10*/);
    \u0087\u0002.\u007E\u0092\u0003((object) this.\u0007(), \u0001.\u0004.\u0002(1392));
    \u008D\u0002.\u007E\u0093\u0003((object) this.\u0007(), false);
    \u008D\u0002.\u007E\u0090\u0003((object) this.\u0008(), true);
    \u0080\u0002.\u007E\u0091\u0003((object) this.\u0008(), \u0098\u0004.\u0011\u000E());
    \u008D\u0002.\u007E\u0097\u0003((object) this.\u0008(), true);
    \u0093\u0002.\u007E\u0098\u0003((object) this.\u0008(), CheckState.Checked);
    \u0080\u0002.\u007E\u001E\u0003((object) this.\u0008(), \u0098\u0004.\u0014\u000E());
    \u0086\u0002 obj41 = \u0086\u0002.\u007E\u001F\u0003;
    CheckBox checkBox13 = this.\u0008();
    point1 = new Point(885, 103);
    Point point22 = point1;
    obj41((object) checkBox13, point22);
    \u0087\u0002.\u007E\u007F\u0003((object) this.\u0008(), \u0001.\u0004.\u0002(1405));
    \u0088\u0002 obj42 = \u0088\u0002.\u007E\u0080\u0003;
    CheckBox checkBox14 = this.\u0008();
    size1 = new Size(55, 17);
    Size size22 = size1;
    obj42((object) checkBox14, size22);
    \u0089\u0002.\u007E\u0081\u0003((object) this.\u0008(), 17);
    \u0087\u0002.\u007E\u0092\u0003((object) this.\u0008(), \u0001.\u0004.\u0002(1418));
    \u008D\u0002.\u007E\u0093\u0003((object) this.\u0008(), false);
    \u008D\u0002.\u007E\u0090\u0003((object) this.\u000E(), true);
    \u0080\u0002.\u007E\u0091\u0003((object) this.\u000E(), \u0098\u0004.\u0011\u000E());
    \u0080\u0002.\u007E\u001E\u0003((object) this.\u000E(), \u0098\u0004.\u0014\u000E());
    \u0086\u0002 obj43 = \u0086\u0002.\u007E\u001F\u0003;
    CheckBox checkBox15 = this.\u000E();
    point1 = new Point(885, 264);
    Point point23 = point1;
    obj43((object) checkBox15, point23);
    \u0087\u0002.\u007E\u007F\u0003((object) this.\u000E(), \u0001.\u0004.\u0002(1427));
    \u0088\u0002 obj44 = \u0088\u0002.\u007E\u0080\u0003;
    CheckBox checkBox16 = this.\u000E();
    size1 = new Size(92, 17);
    Size size23 = size1;
    obj44((object) checkBox16, size23);
    \u0089\u0002.\u007E\u0081\u0003((object) this.\u000E(), 18);
    \u0087\u0002.\u007E\u0092\u0003((object) this.\u000E(), \u0001.\u0004.\u0002(1448));
    \u008D\u0002.\u007E\u0093\u0003((object) this.\u000E(), false);
    // ISSUE: reference to a compiler-generated method
    \u0081\u0002.\u007E\u001A\u0003((object) this.\u0002(), (Image) \u0006.\u0001.\u0002());
    \u0082\u0002.\u007E\u001B\u0003((object) this.\u0002(), ImageLayout.Zoom);
    \u0086\u0002 obj45 = \u0086\u0002.\u007E\u001F\u0003;
    PictureBox pictureBox1 = this.\u0002();
    point1 = new Point(881, 590);
    Point point24 = point1;
    obj45((object) pictureBox1, point24);
    \u0087\u0002.\u007E\u007F\u0003((object) this.\u0002(), \u0001.\u0004.\u0002(1465));
    \u0088\u0002 obj46 = \u0088\u0002.\u007E\u0080\u0003;
    PictureBox pictureBox2 = this.\u0002();
    size1 = new Size(250, 287);
    Size size24 = size1;
    obj46((object) pictureBox2, size24);
    \u0089\u0002.\u007E\u0016\u0004((object) this.\u0002(), 19);
    \u008D\u0002.\u007E\u0015\u0004((object) this.\u0002(), false);
    \u0086\u0002 obj47 = \u0086\u0002.\u007E\u001F\u0003;
    Button button11 = this.\u0007();
    point1 = new Point(1019, 295);
    Point point25 = point1;
    obj47((object) button11, point25);
    \u0087\u0002.\u007E\u007F\u0003((object) this.\u0007(), \u0001.\u0004.\u0002(1482));
    \u0088\u0002 obj48 = \u0088\u0002.\u007E\u0080\u0003;
    Button button12 = this.\u0007();
    size1 = new Size(89, 23);
    Size size25 = size1;
    obj48((object) button12, size25);
    \u0089\u0002.\u007E\u0081\u0003((object) this.\u0007(), 20);
    \u0087\u0002.\u007E\u0092\u0003((object) this.\u0007(), \u0001.\u0004.\u0002(1495));
    \u008D\u0002.\u007E\u0093\u0003((object) this.\u0007(), true);
    \u008D\u0002.\u007E\u0011\u0004((object) this.\u0002(), true);
    \u0080\u0002.\u007E\u001E\u0003((object) this.\u0002(), \u0098\u0004.\u0014\u000E());
    \u0086\u0002 obj49 = \u0086\u0002.\u007E\u001F\u0003;
    Label label1 = this.\u0002();
    point1 = new Point(882, 301);
    Point point26 = point1;
    obj49((object) label1, point26);
    \u0087\u0002.\u007E\u007F\u0003((object) this.\u0002(), \u0001.\u0004.\u0002(1508));
    \u0088\u0002 obj50 = \u0088\u0002.\u007E\u0080\u0003;
    Label label2 = this.\u0002();
    size1 = new Size(78, 13);
    Size size26 = size1;
    obj50((object) label2, size26);
    \u0089\u0002.\u007E\u0081\u0003((object) this.\u0002(), 21);
    \u0087\u0002.\u007E\u0012\u0004((object) this.\u0002(), \u0001.\u0004.\u0002(1517));
    \u0086\u0002 obj51 = \u0086\u0002.\u007E\u001F\u0003;
    TextBox textBox1 = this.\u0002();
    point1 = new Point(966, 298);
    Point point27 = point1;
    obj51((object) textBox1, point27);
    \u0087\u0002.\u007E\u007F\u0003((object) this.\u0002(), \u0001.\u0004.\u0002(1538));
    \u0088\u0002 obj52 = \u0088\u0002.\u007E\u0080\u0003;
    TextBox textBox2 = this.\u0002();
    size1 = new Size(47, 20);
    Size size27 = size1;
    obj52((object) textBox2, size27);
    \u0089\u0002.\u007E\u0081\u0003((object) this.\u0002(), 22);
    \u0087\u0002.\u007E\u009C\u0003((object) this.\u0002(), \u0001.\u0004.\u0002(1555));
    \u0090\u0002.\u007E\u008E\u0003((object) this, new SizeF(6f, 13f));
    \u0091\u0002.\u007E\u008F\u0003((object) this, AutoScaleMode.Font);
    \u0080\u0002.\u007E\u0006\u0004((object) this, \u0098\u0004.\u0012\u000E());
    \u0088\u0002 obj53 = \u0088\u0002.\u007E\u0007\u0004;
    size1 = new Size(1143, 889);
    Size size28 = size1;
    obj53((object) this, size28);
    \u008E\u0002.\u007E\u008C\u0003((object) \u0083\u0002.\u007E\u001C\u0003((object) this), (Control) this.\u0002());
    \u008E\u0002.\u007E\u008C\u0003((object) \u0083\u0002.\u007E\u001C\u0003((object) this), (Control) this.\u0002());
    \u008E\u0002.\u007E\u008C\u0003((object) \u0083\u0002.\u007E\u001C\u0003((object) this), (Control) this.\u0007());
    \u008E\u0002.\u007E\u008C\u0003((object) \u0083\u0002.\u007E\u001C\u0003((object) this), (Control) this.\u0002());
    \u008E\u0002.\u007E\u008C\u0003((object) \u0083\u0002.\u007E\u001C\u0003((object) this), (Control) this.\u000E());
    \u008E\u0002.\u007E\u008C\u0003((object) \u0083\u0002.\u007E\u001C\u0003((object) this), (Control) this.\u0008());
    \u008E\u0002.\u007E\u008C\u0003((object) \u0083\u0002.\u007E\u001C\u0003((object) this), (Control) this.\u0007());
    \u008E\u0002.\u007E\u008C\u0003((object) \u0083\u0002.\u007E\u001C\u0003((object) this), (Control) this.\u0006());
    \u008E\u0002.\u007E\u008C\u0003((object) \u0083\u0002.\u007E\u001C\u0003((object) this), (Control) this.\u0005());
    \u008E\u0002.\u007E\u008C\u0003((object) \u0083\u0002.\u007E\u001C\u0003((object) this), (Control) this.\u0004());
    \u008E\u0002.\u007E\u008C\u0003((object) \u0083\u0002.\u007E\u001C\u0003((object) this), (Control) this.\u0003());
    \u008E\u0002.\u007E\u008C\u0003((object) \u0083\u0002.\u007E\u001C\u0003((object) this), (Control) this.\u0002());
    \u008E\u0002.\u007E\u008C\u0003((object) \u0083\u0002.\u007E\u001C\u0003((object) this), (Control) this.\u0008());
    \u008E\u0002.\u007E\u008C\u0003((object) \u0083\u0002.\u007E\u001C\u0003((object) this), (Control) this.\u0005());
    \u008E\u0002.\u007E\u008C\u0003((object) \u0083\u0002.\u007E\u001C\u0003((object) this), (Control) this.\u000E());
    \u008E\u0002.\u007E\u008C\u0003((object) \u0083\u0002.\u007E\u001C\u0003((object) this), (Control) this.\u0006());
    \u008E\u0002.\u007E\u008C\u0003((object) \u0083\u0002.\u007E\u001C\u0003((object) this), (Control) this.\u000F());
    \u008E\u0002.\u007E\u008C\u0003((object) \u0083\u0002.\u007E\u001C\u0003((object) this), (Control) this.\u0007());
    \u008E\u0002.\u007E\u008C\u0003((object) \u0083\u0002.\u007E\u001C\u0003((object) this), (Control) this.\u0006());
    \u008E\u0002.\u007E\u008C\u0003((object) \u0083\u0002.\u007E\u001C\u0003((object) this), (Control) this.\u0003());
    \u008E\u0002.\u007E\u008C\u0003((object) \u0083\u0002.\u007E\u001C\u0003((object) this), (Control) this.\u0005());
    \u008E\u0002.\u007E\u008C\u0003((object) \u0083\u0002.\u007E\u001C\u0003((object) this), (Control) this.\u0004());
    \u008E\u0002.\u007E\u008C\u0003((object) \u0083\u0002.\u007E\u001C\u0003((object) this), (Control) this.\u0003());
    \u008E\u0002.\u007E\u008C\u0003((object) \u0083\u0002.\u007E\u001C\u0003((object) this), (Control) this.\u0004());
    \u008E\u0002.\u007E\u008C\u0003((object) \u0083\u0002.\u007E\u001C\u0003((object) this), (Control) this.\u0002());
    \u008E\u0002.\u007E\u008C\u0003((object) \u0083\u0002.\u007E\u001C\u0003((object) this), (Control) this.\u0002());
    \u0087\u0002.\u007E\u007F\u0003((object) this, \u0001.\u0004.\u0002(1560));
    \u0087\u0002.\u007E\u0008\u0004((object) this, \u0001.\u0004.\u0002(1569));
    \u008C\u0002.\u007E\u009F\u0008((object) this.\u0002());
    \u008D\u0002.\u007E\u0089\u0003((object) this, false);
    \u008C\u0002.\u007E\u0087\u0003((object) this);
  }

  [DebuggerNonUserCode]
  [SpecialName]
  internal virtual Button \u0002() => this.\u0001;

  [DebuggerNonUserCode]
  [SpecialName]
  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void \u0002([In] Button obj0)
  {
    \u0005.\u0001 obj = this;
    // ISSUE: virtual method pointer
    EventHandler eventHandler = new EventHandler((object) obj, __vmethodptr(obj, \u0003));
    if (this.\u0001 != null)
      \u008A\u0002.\u007E\u0083\u0003((object) this.\u0001, eventHandler);
    this.\u0001 = obj0;
    if (this.\u0001 == null)
      return;
    \u008A\u0002.\u007E\u0082\u0003((object) this.\u0001, eventHandler);
  }

  [DebuggerNonUserCode]
  [SpecialName]
  internal virtual Panel \u0002() => this.\u0001;

  [DebuggerNonUserCode]
  [SpecialName]
  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void \u0002([In] Panel obj0)
  {
    \u0005.\u0001 obj1 = this;
    // ISSUE: virtual method pointer
    PaintEventHandler paintEventHandler = new PaintEventHandler((object) obj1, __vmethodptr(obj1, \u0002));
    \u0005.\u0001 obj2 = this;
    // ISSUE: virtual method pointer
    EventHandler eventHandler = new EventHandler((object) obj2, __vmethodptr(obj2, \u0008));
    if (this.\u0001 != null)
    {
      \u008B\u0002.\u007E\u0086\u0003((object) this.\u0001, paintEventHandler);
      \u008A\u0002.\u007E\u0083\u0003((object) this.\u0001, eventHandler);
    }
    this.\u0001 = obj0;
    if (this.\u0001 == null)
      return;
    \u008B\u0002.\u007E\u0084\u0003((object) this.\u0001, paintEventHandler);
    \u008A\u0002.\u007E\u0082\u0003((object) this.\u0001, eventHandler);
  }

  [DebuggerNonUserCode]
  [SpecialName]
  internal virtual Panel \u0003() => this.\u0002;

  [DebuggerNonUserCode]
  [SpecialName]
  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void \u0003([In] Panel obj0)
  {
    \u0005.\u0001 obj1 = this;
    // ISSUE: virtual method pointer
    PaintEventHandler paintEventHandler = new PaintEventHandler((object) obj1, __vmethodptr(obj1, \u0002));
    \u0005.\u0001 obj2 = this;
    // ISSUE: virtual method pointer
    EventHandler eventHandler = new EventHandler((object) obj2, __vmethodptr(obj2, \u0008));
    if (this.\u0002 != null)
    {
      \u008B\u0002.\u007E\u0086\u0003((object) this.\u0002, paintEventHandler);
      \u008A\u0002.\u007E\u0083\u0003((object) this.\u0002, eventHandler);
    }
    this.\u0002 = obj0;
    if (this.\u0002 == null)
      return;
    \u008B\u0002.\u007E\u0084\u0003((object) this.\u0002, paintEventHandler);
    \u008A\u0002.\u007E\u0082\u0003((object) this.\u0002, eventHandler);
  }

  [DebuggerNonUserCode]
  [SpecialName]
  internal virtual Panel \u0004() => this.\u0003;

  [DebuggerNonUserCode]
  [SpecialName]
  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void \u0004([In] Panel obj0)
  {
    \u0005.\u0001 obj1 = this;
    // ISSUE: virtual method pointer
    PaintEventHandler paintEventHandler = new PaintEventHandler((object) obj1, __vmethodptr(obj1, \u0002));
    \u0005.\u0001 obj2 = this;
    // ISSUE: virtual method pointer
    EventHandler eventHandler = new EventHandler((object) obj2, __vmethodptr(obj2, \u0008));
    if (this.\u0003 != null)
    {
      \u008B\u0002.\u007E\u0086\u0003((object) this.\u0003, paintEventHandler);
      \u008A\u0002.\u007E\u0083\u0003((object) this.\u0003, eventHandler);
    }
    this.\u0003 = obj0;
    if (this.\u0003 == null)
      return;
    \u008B\u0002.\u007E\u0084\u0003((object) this.\u0003, paintEventHandler);
    \u008A\u0002.\u007E\u0082\u0003((object) this.\u0003, eventHandler);
  }

  [DebuggerNonUserCode]
  [SpecialName]
  internal virtual Button \u0003() => this.\u0002;

  [DebuggerNonUserCode]
  [SpecialName]
  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void \u0003([In] Button obj0)
  {
    \u0005.\u0001 obj = this;
    // ISSUE: virtual method pointer
    EventHandler eventHandler = new EventHandler((object) obj, __vmethodptr(obj, \u0004));
    if (this.\u0002 != null)
      \u008A\u0002.\u007E\u0083\u0003((object) this.\u0002, eventHandler);
    this.\u0002 = obj0;
    if (this.\u0002 == null)
      return;
    \u008A\u0002.\u007E\u0082\u0003((object) this.\u0002, eventHandler);
  }

  [DebuggerNonUserCode]
  [SpecialName]
  internal virtual Button \u0004() => this.\u0003;

  [DebuggerNonUserCode]
  [SpecialName]
  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void \u0004([In] Button obj0)
  {
    \u0005.\u0001 obj = this;
    // ISSUE: virtual method pointer
    EventHandler eventHandler = new EventHandler((object) obj, __vmethodptr(obj, \u0005));
    if (this.\u0003 != null)
      \u008A\u0002.\u007E\u0083\u0003((object) this.\u0003, eventHandler);
    this.\u0003 = obj0;
    if (this.\u0003 == null)
      return;
    \u008A\u0002.\u007E\u0082\u0003((object) this.\u0003, eventHandler);
  }

  [DebuggerNonUserCode]
  [SpecialName]
  internal virtual Button \u0005() => this.\u0004;

  [DebuggerNonUserCode]
  [SpecialName]
  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void \u0005([In] Button obj0)
  {
    \u0005.\u0001 obj = this;
    // ISSUE: virtual method pointer
    EventHandler eventHandler = new EventHandler((object) obj, __vmethodptr(obj, \u0007));
    if (this.\u0004 != null)
      \u008A\u0002.\u007E\u0083\u0003((object) this.\u0004, eventHandler);
    this.\u0004 = obj0;
    if (this.\u0004 == null)
      return;
    \u008A\u0002.\u007E\u0082\u0003((object) this.\u0004, eventHandler);
  }

  [DebuggerNonUserCode]
  [SpecialName]
  internal virtual Button \u0006() => this.\u0005;

  [DebuggerNonUserCode]
  [SpecialName]
  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void \u0006([In] Button obj0)
  {
    \u0005.\u0001 obj = this;
    // ISSUE: virtual method pointer
    EventHandler eventHandler = new EventHandler((object) obj, __vmethodptr(obj, \u0006));
    if (this.\u0005 != null)
      \u008A\u0002.\u007E\u0083\u0003((object) this.\u0005, eventHandler);
    this.\u0005 = obj0;
    if (this.\u0005 == null)
      return;
    \u008A\u0002.\u007E\u0082\u0003((object) this.\u0005, eventHandler);
  }

  [DebuggerNonUserCode]
  [SpecialName]
  internal virtual Panel \u0005() => this.\u0004;

  [DebuggerNonUserCode]
  [SpecialName]
  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void \u0005([In] Panel obj0)
  {
    \u0005.\u0001 obj1 = this;
    // ISSUE: virtual method pointer
    PaintEventHandler paintEventHandler = new PaintEventHandler((object) obj1, __vmethodptr(obj1, \u0002));
    \u0005.\u0001 obj2 = this;
    // ISSUE: virtual method pointer
    EventHandler eventHandler = new EventHandler((object) obj2, __vmethodptr(obj2, \u0008));
    if (this.\u0004 != null)
    {
      \u008B\u0002.\u007E\u0086\u0003((object) this.\u0004, paintEventHandler);
      \u008A\u0002.\u007E\u0083\u0003((object) this.\u0004, eventHandler);
    }
    this.\u0004 = obj0;
    if (this.\u0004 == null)
      return;
    \u008B\u0002.\u007E\u0084\u0003((object) this.\u0004, paintEventHandler);
    \u008A\u0002.\u007E\u0082\u0003((object) this.\u0004, eventHandler);
  }

  [DebuggerNonUserCode]
  [SpecialName]
  internal virtual Panel \u0006() => this.\u0005;

  [DebuggerNonUserCode]
  [SpecialName]
  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void \u0006([In] Panel obj0)
  {
    \u0005.\u0001 obj1 = this;
    // ISSUE: virtual method pointer
    PaintEventHandler paintEventHandler = new PaintEventHandler((object) obj1, __vmethodptr(obj1, \u0002));
    \u0005.\u0001 obj2 = this;
    // ISSUE: virtual method pointer
    EventHandler eventHandler = new EventHandler((object) obj2, __vmethodptr(obj2, \u0008));
    if (this.\u0005 != null)
    {
      \u008B\u0002.\u007E\u0086\u0003((object) this.\u0005, paintEventHandler);
      \u008A\u0002.\u007E\u0083\u0003((object) this.\u0005, eventHandler);
    }
    this.\u0005 = obj0;
    if (this.\u0005 == null)
      return;
    \u008B\u0002.\u007E\u0084\u0003((object) this.\u0005, paintEventHandler);
    \u008A\u0002.\u007E\u0082\u0003((object) this.\u0005, eventHandler);
  }

  [DebuggerNonUserCode]
  [SpecialName]
  internal virtual Panel \u0007() => this.\u0006;

  [DebuggerNonUserCode]
  [SpecialName]
  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void \u0007([In] Panel obj0)
  {
    \u0005.\u0001 obj1 = this;
    // ISSUE: virtual method pointer
    PaintEventHandler paintEventHandler = new PaintEventHandler((object) obj1, __vmethodptr(obj1, \u0002));
    \u0005.\u0001 obj2 = this;
    // ISSUE: virtual method pointer
    EventHandler eventHandler = new EventHandler((object) obj2, __vmethodptr(obj2, \u0008));
    if (this.\u0006 != null)
    {
      \u008B\u0002.\u007E\u0086\u0003((object) this.\u0006, paintEventHandler);
      \u008A\u0002.\u007E\u0083\u0003((object) this.\u0006, eventHandler);
    }
    this.\u0006 = obj0;
    if (this.\u0006 == null)
      return;
    \u008B\u0002.\u007E\u0084\u0003((object) this.\u0006, paintEventHandler);
    \u008A\u0002.\u007E\u0082\u0003((object) this.\u0006, eventHandler);
  }

  [DebuggerNonUserCode]
  [SpecialName]
  internal virtual Panel \u0008() => this.\u0007;

  [DebuggerNonUserCode]
  [SpecialName]
  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void \u0008([In] Panel obj0)
  {
    \u0005.\u0001 obj1 = this;
    // ISSUE: virtual method pointer
    PaintEventHandler paintEventHandler = new PaintEventHandler((object) obj1, __vmethodptr(obj1, \u0002));
    \u0005.\u0001 obj2 = this;
    // ISSUE: virtual method pointer
    EventHandler eventHandler = new EventHandler((object) obj2, __vmethodptr(obj2, \u0008));
    if (this.\u0007 != null)
    {
      \u008B\u0002.\u007E\u0086\u0003((object) this.\u0007, paintEventHandler);
      \u008A\u0002.\u007E\u0083\u0003((object) this.\u0007, eventHandler);
    }
    this.\u0007 = obj0;
    if (this.\u0007 == null)
      return;
    \u008B\u0002.\u007E\u0084\u0003((object) this.\u0007, paintEventHandler);
    \u008A\u0002.\u007E\u0082\u0003((object) this.\u0007, eventHandler);
  }

  [DebuggerNonUserCode]
  [SpecialName]
  internal virtual Panel \u000E() => this.\u0008;

  [DebuggerNonUserCode]
  [SpecialName]
  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void \u000E([In] Panel obj0)
  {
    \u0005.\u0001 obj1 = this;
    // ISSUE: virtual method pointer
    PaintEventHandler paintEventHandler = new PaintEventHandler((object) obj1, __vmethodptr(obj1, \u0002));
    \u0005.\u0001 obj2 = this;
    // ISSUE: virtual method pointer
    EventHandler eventHandler = new EventHandler((object) obj2, __vmethodptr(obj2, \u0008));
    if (this.\u0008 != null)
    {
      \u008B\u0002.\u007E\u0086\u0003((object) this.\u0008, paintEventHandler);
      \u008A\u0002.\u007E\u0083\u0003((object) this.\u0008, eventHandler);
    }
    this.\u0008 = obj0;
    if (this.\u0008 == null)
      return;
    \u008B\u0002.\u007E\u0084\u0003((object) this.\u0008, paintEventHandler);
    \u008A\u0002.\u007E\u0082\u0003((object) this.\u0008, eventHandler);
  }

  [DebuggerNonUserCode]
  [SpecialName]
  internal virtual Panel \u000F() => this.\u000E;

  [DebuggerNonUserCode]
  [SpecialName]
  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void \u000F([In] Panel obj0)
  {
    \u0005.\u0001 obj1 = this;
    // ISSUE: virtual method pointer
    PaintEventHandler paintEventHandler = new PaintEventHandler((object) obj1, __vmethodptr(obj1, \u0002));
    \u0005.\u0001 obj2 = this;
    // ISSUE: virtual method pointer
    EventHandler eventHandler = new EventHandler((object) obj2, __vmethodptr(obj2, \u0008));
    if (this.\u000E != null)
    {
      \u008B\u0002.\u007E\u0086\u0003((object) this.\u000E, paintEventHandler);
      \u008A\u0002.\u007E\u0083\u0003((object) this.\u000E, eventHandler);
    }
    this.\u000E = obj0;
    if (this.\u000E == null)
      return;
    \u008B\u0002.\u007E\u0084\u0003((object) this.\u000E, paintEventHandler);
    \u008A\u0002.\u007E\u0082\u0003((object) this.\u000E, eventHandler);
  }

  [DebuggerNonUserCode]
  [SpecialName]
  internal virtual CheckBox \u0002() => this.\u0001;

  [DebuggerNonUserCode]
  [SpecialName]
  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void \u0002([In] CheckBox obj0) => this.\u0001 = obj0;

  [DebuggerNonUserCode]
  [SpecialName]
  internal virtual CheckBox \u0003() => this.\u0002;

  [DebuggerNonUserCode]
  [SpecialName]
  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void \u0003([In] CheckBox obj0) => this.\u0002 = obj0;

  [DebuggerNonUserCode]
  [SpecialName]
  internal virtual CheckBox \u0004() => this.\u0003;

  [DebuggerNonUserCode]
  [SpecialName]
  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void \u0004([In] CheckBox obj0) => this.\u0003 = obj0;

  [DebuggerNonUserCode]
  [SpecialName]
  internal virtual CheckBox \u0005() => this.\u0004;

  [DebuggerNonUserCode]
  [SpecialName]
  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void \u0005([In] CheckBox obj0) => this.\u0004 = obj0;

  [DebuggerNonUserCode]
  [SpecialName]
  internal virtual CheckBox \u0006() => this.\u0005;

  [DebuggerNonUserCode]
  [SpecialName]
  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void \u0006([In] CheckBox obj0) => this.\u0005 = obj0;

  [DebuggerNonUserCode]
  [SpecialName]
  internal virtual CheckBox \u0007() => this.\u0006;

  [DebuggerNonUserCode]
  [SpecialName]
  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void \u0007([In] CheckBox obj0) => this.\u0006 = obj0;

  [DebuggerNonUserCode]
  [SpecialName]
  internal virtual CheckBox \u0008() => this.\u0007;

  [DebuggerNonUserCode]
  [SpecialName]
  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void \u0008([In] CheckBox obj0) => this.\u0007 = obj0;

  [DebuggerNonUserCode]
  [SpecialName]
  internal virtual CheckBox \u000E() => this.\u0008;

  [DebuggerNonUserCode]
  [SpecialName]
  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void \u000E([In] CheckBox obj0) => this.\u0008 = obj0;

  [DebuggerNonUserCode]
  [SpecialName]
  internal virtual PictureBox \u0002() => this.\u0001;

  [DebuggerNonUserCode]
  [SpecialName]
  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void \u0002([In] PictureBox obj0) => this.\u0001 = obj0;

  [DebuggerNonUserCode]
  [SpecialName]
  internal virtual Button \u0007() => this.\u0006;

  [DebuggerNonUserCode]
  [SpecialName]
  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void \u0007([In] Button obj0)
  {
    \u0005.\u0001 obj = this;
    // ISSUE: virtual method pointer
    EventHandler eventHandler = new EventHandler((object) obj, __vmethodptr(obj, \u000E));
    if (this.\u0006 != null)
      \u008A\u0002.\u007E\u0083\u0003((object) this.\u0006, eventHandler);
    this.\u0006 = obj0;
    if (this.\u0006 == null)
      return;
    \u008A\u0002.\u007E\u0082\u0003((object) this.\u0006, eventHandler);
  }

  [DebuggerNonUserCode]
  [SpecialName]
  internal virtual Label \u0002() => this.\u0001;

  [DebuggerNonUserCode]
  [SpecialName]
  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void \u0002([In] Label obj0)
  {
    \u0005.\u0001 obj = this;
    // ISSUE: virtual method pointer
    EventHandler eventHandler = new EventHandler((object) obj, __vmethodptr(obj, \u000F));
    if (this.\u0001 != null)
      \u008A\u0002.\u007E\u0083\u0003((object) this.\u0001, eventHandler);
    this.\u0001 = obj0;
    if (this.\u0001 == null)
      return;
    \u008A\u0002.\u007E\u0082\u0003((object) this.\u0001, eventHandler);
  }

  [DebuggerNonUserCode]
  [SpecialName]
  internal virtual TextBox \u0002() => this.\u0001;

  [DebuggerNonUserCode]
  [SpecialName]
  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void \u0002([In] TextBox obj0) => this.\u0001 = obj0;

  private void \u0002([In] object obj0, [In] EventArgs obj1) => this.\u0003();

  private void \u0003([In] object obj0, [In] EventArgs obj1) => this.\u0003();

  private void \u0004([In] object obj0, [In] EventArgs obj1)
  {
    checked { ++this.\u0002; }
    this.\u0003();
  }

  private void \u0005([In] object obj0, [In] EventArgs obj1)
  {
    checked { --this.\u0002; }
    this.\u0003();
  }

  private void \u0006([In] object obj0, [In] EventArgs obj1)
  {
    checked { ++this.\u0001; }
    this.\u0003();
  }

  private void \u0007([In] object obj0, [In] EventArgs obj1)
  {
    checked { --this.\u0001; }
    this.\u0003();
  }

  public void \u0003()
  {
    this.\u0004();
    \u0081\u0002.\u007E\u001A\u0003((object) this.\u0002(), (Image) \u0005.\u0004.\u0002(checked (this.\u0001 - 1), checked (this.\u0002 + 1), this.\u0001, 1.5f));
    \u0081\u0002.\u007E\u001A\u0003((object) this.\u0003(), (Image) \u0005.\u0004.\u0002(this.\u0001, checked (this.\u0002 + 1), this.\u0001, 1.5f));
    \u0081\u0002.\u007E\u001A\u0003((object) this.\u0004(), (Image) \u0005.\u0004.\u0002(checked (this.\u0001 + 1), checked (this.\u0002 + 1), this.\u0001, 1.5f));
    \u0081\u0002.\u007E\u001A\u0003((object) this.\u0005(), (Image) \u0005.\u0004.\u0002(checked (this.\u0001 - 1), checked (this.\u0002 - 0), this.\u0001, 1.5f));
    \u0081\u0002.\u007E\u001A\u0003((object) this.\u0006(), (Image) \u0005.\u0004.\u0002(this.\u0001, checked (this.\u0002 - 0), this.\u0001, 1.5f));
    \u0081\u0002.\u007E\u001A\u0003((object) this.\u0007(), (Image) \u0005.\u0004.\u0002(checked (this.\u0001 + 1), checked (this.\u0002 - 0), this.\u0001, 1.5f));
    \u0081\u0002.\u007E\u001A\u0003((object) this.\u0008(), (Image) \u0005.\u0004.\u0002(checked (this.\u0001 - 1), checked (this.\u0002 - 1), this.\u0001, 1.5f));
    \u0081\u0002.\u007E\u001A\u0003((object) this.\u000E(), (Image) \u0005.\u0004.\u0002(this.\u0001, checked (this.\u0002 - 1), this.\u0001, 1.5f));
    \u0081\u0002.\u007E\u001A\u0003((object) this.\u000F(), (Image) \u0005.\u0004.\u0002(checked (this.\u0001 + 1), checked (this.\u0002 - 1), this.\u0001, 1.5f));
  }

  public void \u0004()
  {
    this.\u0001 = (\u0005.\u0004.\u0001) 0;
    if (\u0092\u0002.\u007E\u0096\u0003((object) this.\u0008()))
      this.\u0001 |= \u0005.\u0004.\u0001.\u0001;
    if (\u0092\u0002.\u007E\u0096\u0003((object) this.\u000E()))
      this.\u0001 |= \u0005.\u0004.\u0001.\u0005;
    if (\u0092\u0002.\u007E\u0096\u0003((object) this.\u0006()))
      this.\u0001 |= \u0005.\u0004.\u0001.\u0006;
    if (\u0092\u0002.\u007E\u0096\u0003((object) this.\u0005()))
      this.\u0001 |= \u0005.\u0004.\u0001.\u0007;
    if (\u0092\u0002.\u007E\u0096\u0003((object) this.\u0002()))
      this.\u0001 |= \u0005.\u0004.\u0001.\u0002;
    if (\u0092\u0002.\u007E\u0096\u0003((object) this.\u0003()))
      this.\u0001 |= \u0005.\u0004.\u0001.\u0003;
    if (\u0092\u0002.\u007E\u0096\u0003((object) this.\u0004()))
      this.\u0001 |= \u0005.\u0004.\u0001.\u0004;
    if (!\u0092\u0002.\u007E\u0096\u0003((object) this.\u0007()))
      return;
    this.\u0001 |= \u0005.\u0004.\u0001.\u0008;
  }

  private void \u0008([In] object obj0, [In] EventArgs obj1)
  {
    MouseEventArgs mouseEventArgs = (MouseEventArgs) obj1;
    if (\u0001\u0003.\u007F\u0004(\u009F\u0002.\u001F\u0004(obj0, (System.Type) null, \u0001.\u0004.\u0002(1610), new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) \u0001.\u0004.\u0002(1088), false))
      this.\u0002(mouseEventArgs, checked ((byte) (this.\u0001 - 1)), checked ((byte) (this.\u0002 + 1)));
    else if (\u0001\u0003.\u007F\u0004(\u009F\u0002.\u001F\u0004(obj0, (System.Type) null, \u0001.\u0004.\u0002(1610), new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) \u0001.\u0004.\u0002(1097), false))
      this.\u0002(mouseEventArgs, checked ((byte) this.\u0001), checked ((byte) (this.\u0002 + 1)));
    else if (\u0001\u0003.\u007F\u0004(\u009F\u0002.\u001F\u0004(obj0, (System.Type) null, \u0001.\u0004.\u0002(1610), new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) \u0001.\u0004.\u0002(1106), false))
      this.\u0002(mouseEventArgs, checked ((byte) (this.\u0001 + 1)), checked ((byte) (this.\u0002 + 1)));
    else if (\u0001\u0003.\u007F\u0004(\u009F\u0002.\u001F\u0004(obj0, (System.Type) null, \u0001.\u0004.\u0002(1610), new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) \u0001.\u0004.\u0002(1167), false))
      this.\u0002(mouseEventArgs, checked ((byte) (this.\u0001 - 1)), checked ((byte) this.\u0002));
    else if (\u0001\u0003.\u007F\u0004(\u009F\u0002.\u001F\u0004(obj0, (System.Type) null, \u0001.\u0004.\u0002(1610), new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) \u0001.\u0004.\u0002(1176), false))
      this.\u0002(mouseEventArgs, checked ((byte) this.\u0001), checked ((byte) this.\u0002));
    else if (\u0001\u0003.\u007F\u0004(\u009F\u0002.\u001F\u0004(obj0, (System.Type) null, \u0001.\u0004.\u0002(1610), new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) \u0001.\u0004.\u0002(1185), false))
      this.\u0002(mouseEventArgs, checked ((byte) (this.\u0001 + 1)), checked ((byte) this.\u0002));
    else if (\u0001\u0003.\u007F\u0004(\u009F\u0002.\u001F\u0004(obj0, (System.Type) null, \u0001.\u0004.\u0002(1610), new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) \u0001.\u0004.\u0002(1194), false))
      this.\u0002(mouseEventArgs, checked ((byte) (this.\u0001 - 1)), checked ((byte) (this.\u0002 - 1)));
    else if (\u0001\u0003.\u007F\u0004(\u009F\u0002.\u001F\u0004(obj0, (System.Type) null, \u0001.\u0004.\u0002(1610), new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) \u0001.\u0004.\u0002(1203), false))
      this.\u0002(mouseEventArgs, checked ((byte) this.\u0001), checked ((byte) (this.\u0002 - 1)));
    else if (\u0001\u0003.\u007F\u0004(\u009F\u0002.\u001F\u0004(obj0, (System.Type) null, \u0001.\u0004.\u0002(1610), new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) \u0001.\u0004.\u0002(1212), false))
      this.\u0002(mouseEventArgs, checked ((byte) (this.\u0001 + 1)), checked ((byte) (this.\u0002 - 1)));
    \u008C\u0002.\u007E\u0088\u0003((object) this.\u0002());
    \u008C\u0002.\u007E\u0088\u0003((object) this.\u0003());
    \u008C\u0002.\u007E\u0088\u0003((object) this.\u0004());
    \u008C\u0002.\u007E\u0088\u0003((object) this.\u0005());
    \u008C\u0002.\u007E\u0088\u0003((object) this.\u0006());
    \u008C\u0002.\u007E\u0088\u0003((object) this.\u0007());
    \u008C\u0002.\u007E\u0088\u0003((object) this.\u0008());
    \u008C\u0002.\u007E\u0088\u0003((object) this.\u000E());
    \u008C\u0002.\u007E\u0088\u0003((object) this.\u000F());
  }

  public void \u0002([In] MouseEventArgs obj0, [In] byte obj1, [In] byte obj2)
  {
    if (\u0096\u0002.\u007E\u009D\u0003((object) obj0) != MouseButtons.Middle)
    {
      if (\u0096\u0002.\u007E\u009D\u0003((object) obj0) == MouseButtons.Left)
      {
        this.\u0001.\u0002((float) checked ((int) obj1 - 135 * 192 /*0xC0*/) + (float) \u0097\u0002.\u007E\u009E\u0003((object) obj0).X / 1.5f);
        this.\u0001.\u0003((float) checked ((int) obj2 - 92 * 192 /*0xC0*/) + (float) checked (288 - \u0097\u0002.\u007E\u009E\u0003((object) obj0).Y) / 1.5f);
        \u0086\u0003.\u0090\u0005(\u0001.\u0004.\u0002(1619), (object) this.\u0001.\u0002(), (object) this.\u0001.\u0003());
      }
      else
      {
        if (\u0096\u0002.\u007E\u009D\u0003((object) obj0) != MouseButtons.Right)
          return;
        this.\u0002.\u0002((float) checked ((int) obj1 - 135 * 192 /*0xC0*/) + (float) \u0097\u0002.\u007E\u009E\u0003((object) obj0).X / 1.5f);
        this.\u0002.\u0003((float) checked ((int) obj2 - 92 * 192 /*0xC0*/) + (float) checked (288 - \u0097\u0002.\u007E\u009E\u0003((object) obj0).Y) / 1.5f);
        \u0086\u0003.\u0090\u0005(\u0001.\u0004.\u0002(1640), (object) this.\u0002.\u0002(), (object) this.\u0002.\u0003());
      }
    }
    else
    {
      \u0005.\u0002 obj3 = new \u0005.\u0002();
      \u0005.\u0002 obj4 = obj3;
      Bitmap bitmap = \u0005.\u0004.\u0002((int) obj1, (int) obj2, this.\u0001, 5f);
      ref Bitmap local = ref bitmap;
      \u0005.\u0003 obj5 = this.\u0001;
      \u0005.\u0003 obj6 = this.\u0002;
      \u0005.\u0003[] objArray = this.\u0001;
      int num1 = (int) obj1;
      int num2 = (int) obj2;
      obj4.\u0002(ref local, obj5, obj6, objArray, (byte) num1, (byte) num2);
      \u008C\u0002.\u007E\u008A\u0003((object) obj3);
    }
  }

  private void \u0002([In] object obj0, [In] PaintEventArgs obj1)
  {
    if (!\u0001\u0003.\u007F\u0004(\u009F\u0002.\u001F\u0004(obj0, (System.Type) null, \u0001.\u0004.\u0002(1610), new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) \u0001.\u0004.\u0002(1088), false))
    {
      if (\u0001\u0003.\u007F\u0004(\u009F\u0002.\u001F\u0004(obj0, (System.Type) null, \u0001.\u0004.\u0002(1610), new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) \u0001.\u0004.\u0002(1097), false))
      {
        Graphics graphics = \u008F\u0002.\u007E\u008D\u0003((object) obj1);
        this.\u0002(ref graphics, checked ((byte) this.\u0001), checked ((byte) (this.\u0002 + 1)));
      }
      else if (\u0001\u0003.\u007F\u0004(\u009F\u0002.\u001F\u0004(obj0, (System.Type) null, \u0001.\u0004.\u0002(1610), new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) \u0001.\u0004.\u0002(1106), false))
      {
        Graphics graphics = \u008F\u0002.\u007E\u008D\u0003((object) obj1);
        this.\u0002(ref graphics, checked ((byte) (this.\u0001 + 1)), checked ((byte) (this.\u0002 + 1)));
      }
      else if (\u0001\u0003.\u007F\u0004(\u009F\u0002.\u001F\u0004(obj0, (System.Type) null, \u0001.\u0004.\u0002(1610), new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) \u0001.\u0004.\u0002(1167), false))
      {
        Graphics graphics = \u008F\u0002.\u007E\u008D\u0003((object) obj1);
        this.\u0002(ref graphics, checked ((byte) (this.\u0001 - 1)), checked ((byte) this.\u0002));
      }
      else if (\u0001\u0003.\u007F\u0004(\u009F\u0002.\u001F\u0004(obj0, (System.Type) null, \u0001.\u0004.\u0002(1610), new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) \u0001.\u0004.\u0002(1176), false))
      {
        Graphics graphics = \u008F\u0002.\u007E\u008D\u0003((object) obj1);
        this.\u0002(ref graphics, checked ((byte) this.\u0001), checked ((byte) this.\u0002));
      }
      else if (\u0001\u0003.\u007F\u0004(\u009F\u0002.\u001F\u0004(obj0, (System.Type) null, \u0001.\u0004.\u0002(1610), new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) \u0001.\u0004.\u0002(1185), false))
      {
        Graphics graphics = \u008F\u0002.\u007E\u008D\u0003((object) obj1);
        this.\u0002(ref graphics, checked ((byte) (this.\u0001 + 1)), checked ((byte) this.\u0002));
      }
      else if (\u0001\u0003.\u007F\u0004(\u009F\u0002.\u001F\u0004(obj0, (System.Type) null, \u0001.\u0004.\u0002(1610), new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) \u0001.\u0004.\u0002(1194), false))
      {
        Graphics graphics = \u008F\u0002.\u007E\u008D\u0003((object) obj1);
        this.\u0002(ref graphics, checked ((byte) (this.\u0001 - 1)), checked ((byte) (this.\u0002 - 1)));
      }
      else if (\u0001\u0003.\u007F\u0004(\u009F\u0002.\u001F\u0004(obj0, (System.Type) null, \u0001.\u0004.\u0002(1610), new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) \u0001.\u0004.\u0002(1203), false))
      {
        Graphics graphics = \u008F\u0002.\u007E\u008D\u0003((object) obj1);
        this.\u0002(ref graphics, checked ((byte) this.\u0001), checked ((byte) (this.\u0002 - 1)));
      }
      else
      {
        if (!\u0001\u0003.\u007F\u0004(\u009F\u0002.\u001F\u0004(obj0, (System.Type) null, \u0001.\u0004.\u0002(1610), new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) \u0001.\u0004.\u0002(1212), false))
          return;
        Graphics graphics = \u008F\u0002.\u007E\u008D\u0003((object) obj1);
        this.\u0002(ref graphics, checked ((byte) (this.\u0001 + 1)), checked ((byte) (this.\u0002 - 1)));
      }
    }
    else
    {
      Graphics graphics = \u008F\u0002.\u007E\u008D\u0003((object) obj1);
      this.\u0002(ref graphics, checked ((byte) (this.\u0001 - 1)), checked ((byte) (this.\u0002 + 1)));
    }
  }

  public void \u0002([In] ref Graphics obj0, [In] byte obj1, [In] byte obj2)
  {
    if ((int) obj1 == (int) this.\u0001.\u0003() & (int) obj2 == (int) this.\u0001.\u0002())
      \u009B\u0004.\u007E\u0019\u000E((object) obj0, \u0002\u0005.\u0089\u000E(), checked ((int) \u008C\u0003.\u0002\u0006(unchecked ((double) this.\u0001.\u0002() * 1.5))), checked ((int) \u008C\u0003.\u0002\u0006(unchecked ((double) checked (192 /*0xC0*/ - this.\u0001.\u0003()) * 1.5))), 2, 2);
    if ((int) obj1 == (int) this.\u0002.\u0003() & (int) obj2 == (int) this.\u0002.\u0002())
      \u009B\u0004.\u007E\u0019\u000E((object) obj0, \u0002\u0005.\u007F\u000E(), checked ((int) \u008C\u0003.\u0002\u0006(unchecked ((double) this.\u0002.\u0002() * 1.5))), checked ((int) \u008C\u0003.\u0002\u0006(unchecked ((double) checked (192 /*0xC0*/ - this.\u0002.\u0003()) * 1.5))), 2, 2);
    if (this.\u0001 != null)
    {
      int num1 = checked (this.\u0001.Length - 2);
      int index = 0;
      while (index <= num1)
      {
        try
        {
          int num2 = checked ((int) \u008C\u0003.\u0002\u0006(unchecked ((double) checked ((int) obj1 - 135 * 192 /*0xC0*/) - (double) this.\u0001[index].\u0002() * -1.5)));
          int num3 = checked ((int) \u008C\u0003.\u0002\u0006(unchecked ((double) checked ((int) obj2 - 92 * 192 /*0xC0*/) - (double) this.\u0001[index].\u0003() * 1.5)));
          int num4 = checked ((int) \u008C\u0003.\u0002\u0006(unchecked ((double) checked ((int) obj1 - 135 * 192 /*0xC0*/) - (double) this.\u0001[checked (index + 1)].\u0002() * -1.5)));
          int num5 = checked ((int) \u008C\u0003.\u0002\u0006(unchecked ((double) checked ((int) obj2 - 92 * 192 /*0xC0*/) - (double) this.\u0001[checked (index + 1)].\u0003() * 1.5)));
          \u009B\u0004.\u007E\u0017\u000E((object) obj0, \u0002\u0005.\u001F\u000E(), num2, checked (288 + num3), num4, checked (288 + num5));
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          \u001F\u0002.\u0082\u0004();
        }
        checked { ++index; }
      }
    }
    if (this.\u0003 != null)
    {
      int num6 = checked (this.\u0003.Length - 1);
      int index = 0;
      while (index <= num6)
      {
        try
        {
          int num7 = checked ((int) \u008C\u0003.\u0002\u0006(unchecked ((double) checked ((int) obj1 - 135 * 192 /*0xC0*/) - (double) this.\u0003[index].\u0002() * -1.5)));
          int num8 = checked ((int) \u008C\u0003.\u0002\u0006(unchecked ((double) checked ((int) obj2 - 92 * 192 /*0xC0*/) - (double) this.\u0003[index].\u0003() * 1.5)));
          \u009B\u0004.\u007E\u0019\u000E((object) obj0, \u0002\u0005.\u0080\u000E(), checked (num7 - 1), checked (288 + num8 - 1), 2, 2);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          \u001F\u0002.\u0082\u0004();
        }
        checked { ++index; }
      }
    }
    if (this.\u0002 == null)
      return;
    int num9 = checked (this.\u0002.Length - 1);
    int index1 = 0;
    while (index1 <= num9)
    {
      try
      {
        int num10 = checked ((int) \u008C\u0003.\u0002\u0006(unchecked ((double) checked ((int) obj1 - 135 * 192 /*0xC0*/) - (double) this.\u0002[index1].\u0002() * -1.5)));
        int num11 = checked ((int) \u008C\u0003.\u0002\u0006(unchecked ((double) checked ((int) obj2 - 92 * 192 /*0xC0*/) - (double) this.\u0002[index1].\u0003() * 1.5)));
        \u009B\u0004.\u007E\u0019\u000E((object) obj0, \u0002\u0005.\u001F\u000E(), checked (num10 - 1), checked (288 + num11 - 1), 2, 2);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        \u001F\u0002.\u0082\u0004();
      }
      checked { ++index1; }
    }
  }

  private void \u000E([In] object obj0, [In] EventArgs obj1)
  {
    float num;
    try
    {
      num = \u009B\u0002.\u001B\u0004(\u0095\u0002.\u007E\u009B\u0003((object) this.\u0002()));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      \u0083\u0003.\u008E\u0005(\u0001.\u0004.\u0002(1657));
      num = 1f;
      \u001F\u0002.\u0082\u0004();
    }
    DateTime dateTime = \u0098\u0002.\u0017\u0004();
    this.\u0001.\u0002(ref this.\u0001, ref this.\u0002, ref this.\u0001, num);
    \u0084\u0003.\u008F\u0005(\u0001.\u0004.\u0002(1738), (object) \u0098\u0002.\u0017\u0004().Subtract(dateTime).TotalMilliseconds);
    \u008C\u0002.\u007E\u0088\u0003((object) this.\u0002());
    \u008C\u0002.\u007E\u0088\u0003((object) this.\u0003());
    \u008C\u0002.\u007E\u0088\u0003((object) this.\u0004());
    \u008C\u0002.\u007E\u0088\u0003((object) this.\u0005());
    \u008C\u0002.\u007E\u0088\u0003((object) this.\u0006());
    \u008C\u0002.\u007E\u0088\u0003((object) this.\u0007());
    \u008C\u0002.\u007E\u0088\u0003((object) this.\u0008());
    \u008C\u0002.\u007E\u0088\u0003((object) this.\u000E());
    \u008C\u0002.\u007E\u0088\u0003((object) this.\u000F());
  }

  private void \u000F([In] object obj0, [In] EventArgs obj1)
  {
  }
}
