// Decompiled with JetBrains decompiler
// Type: .
// Assembly: kMap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB403103-24EE-4947-BAAC-163727D2381A
// Assembly location: C:\Users\Dev\Downloads\Nouveau dossier (28)\NavTestV2\kMap.exe

using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace \u0007;

internal sealed class \u0002
{
  private Dictionary<int, string> \u0001;

  public \u0002()
  {
    this.\u0001 = new Dictionary<int, string>();
    byte[] buffer = \u0005.\u0005.\u0002.\u0002(\u0001.\u0004.\u0002(2029));
    if (buffer == null)
      return;
    StreamReader streamReader = new StreamReader((Stream) new MemoryStream(buffer));
    string str1 = \u0095\u0002.\u007E\u001D\u0008((object) streamReader);
    short num1 = \u0099\u0002.\u0019\u0004(\u0095\u0002.\u007E\u001D\u0008((object) streamReader));
    short num2 = 1;
    while ((int) num2 <= (int) num1)
    {
      string str2 = \u0095\u0002.\u007E\u001D\u0008((object) streamReader);
      this.\u0001.Add(\u009A\u0002.\u001A\u0004(\u0014\u0003.\u007E\u0006\u0005((object) str2, 0, 5)), \u0014\u0003.\u007E\u0006\u0005((object) str2, checked (\u0015\u0003.\u007E\u0008\u0005((object) str2, '"') + 1), checked (\u0015\u0003.\u007E\u000E\u0005((object) str2, '"') - \u0015\u0003.\u007E\u0008\u0005((object) str2, '"') - 1)));
      checked { ++num2; }
    }
  }

  [SpecialName]
  public string \u0002([In] int obj0)
  {
    return !this.\u0001.ContainsKey(obj0) ? \u0001.\u0004.\u0002(746) : this.\u0001[obj0];
  }
}
