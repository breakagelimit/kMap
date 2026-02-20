// Decompiled with JetBrains decompiler
// Type: .
// Assembly: kMap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB403103-24EE-4947-BAAC-163727D2381A
// Assembly location: C:\Users\Dev\Downloads\Nouveau dossier (28)\NavTestV2\kMap.exe

using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

#nullable disable
namespace \u0005;

internal sealed class \u0005
{
  public static string \u0001 = \u0001.\u0004.\u0002(1870);
  public static \u0004.\u0003 \u0001;
  public static \u0004.\u0003 \u0002;
  public static \u0007.\u0002 \u0001;

  public static void \u0002()
  {
    if (!\u0083\u0004.\u0015\u0008(\u0019\u0003.\u0015\u0005(\u0005.\u0005.\u0001, \u0001.\u0004.\u0002(1903))))
      goto label_3;
label_2:
    \u0005.\u0005.\u0001 = new \u0004.\u0003(\u0019\u0003.\u0015\u0005(\u0005.\u0005.\u0001, \u0001.\u0004.\u0002(1903)));
    \u0005.\u0005.\u0002 = new \u0004.\u0003(\u0019\u0003.\u0015\u0005(\u0005.\u0005.\u0001, \u0001.\u0004.\u0002(1990)));
    \u0005.\u0005.\u0001 = new \u0007.\u0002();
    return;
label_3:
    FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
    \u0087\u0002.\u007E\u0004\u0004((object) folderBrowserDialog, \u0001.\u0004.\u0002(1920));
    \u0087\u0002.\u007E\u0003\u0004((object) folderBrowserDialog, \u0005.\u0005.\u0001);
    int num1 = (int) \u0094\u0002.\u007E\u0099\u0003((object) folderBrowserDialog);
    \u0005.\u0005.\u0001 = \u0095\u0002.\u007E\u0002\u0004((object) folderBrowserDialog);
    if (!\u0083\u0004.\u0015\u0008(\u0019\u0003.\u0015\u0005(\u0005.\u0005.\u0001, \u0001.\u0004.\u0002(1903))))
    {
      int num2 = (int) \u0004\u0003.\u0083\u0004((object) \u0001.\u0004.\u0002(1961), MsgBoxStyle.OkOnly, (object) null);
    }
    else
      goto label_2;
  }

  [STAThread]
  public static void \u0003()
  {
    \u0005.\u0005.\u0002();
    \u001F\u0002.\u0017\u0003();
    \u007F\u0002.\u0018\u0003((Form) new \u0005.\u0001());
  }
}
