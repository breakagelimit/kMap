// Decompiled with JetBrains decompiler
// Type: .
// Assembly: kMap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB403103-24EE-4947-BAAC-163727D2381A
// Assembly location: C:\Users\Dev\Downloads\Nouveau dossier (28)\NavTestV2\kMap.exe

using System.IO;
using System.Runtime.InteropServices;

#nullable disable
namespace \u0006;

internal sealed class \u0004
{
  private int \u0001;
  private int \u0002;
  private int \u0003;
  private int \u0004;
  private int \u0005;
  private int \u0006;
  private int \u0007;
  private int \u0008;
  private int \u000E;
  public string \u0001;

  public \u0004([In] string obj0)
  {
    obj0 = \u0019\u0003.\u0015\u0005(\u0001.\u0004.\u0002(741), obj0);
    byte[] buffer = \u0005.\u0005.\u0002.\u0002(obj0);
    if (buffer == null)
      return;
    BinaryReader binaryReader = new BinaryReader((Stream) new MemoryStream(buffer));
    char[] chArray = \u0080\u0004.\u007E\u0010\u0008((object) binaryReader, 12);
    this.\u0001 = \u0011\u0003.\u007E\u0008\u0008((object) binaryReader);
    this.\u0002 = \u0011\u0003.\u007E\u0008\u0008((object) binaryReader);
    this.\u0003 = \u0011\u0003.\u007E\u0008\u0008((object) binaryReader);
    this.\u0004 = \u0011\u0003.\u007E\u0008\u0008((object) binaryReader);
    this.\u0005 = \u0011\u0003.\u007E\u0008\u0008((object) binaryReader);
    this.\u0006 = \u0011\u0003.\u007E\u0008\u0008((object) binaryReader);
    this.\u0007 = \u0011\u0003.\u007E\u0008\u0008((object) binaryReader);
    this.\u0008 = \u0011\u0003.\u007E\u0008\u0008((object) binaryReader);
    this.\u000E = \u0011\u0003.\u007E\u0008\u0008((object) binaryReader);
    \u0018\u0004.\u007E\u009C\u0007((object) \u001B\u0004.\u007E\u0003\u0008((object) binaryReader), (long) this.\u0002);
    \u0018\u0004.\u007E\u009C\u0007((object) \u001B\u0004.\u007E\u0003\u0008((object) binaryReader), (long) this.\u0008);
    int num = \u0011\u0003.\u007E\u0008\u0008((object) binaryReader);
    this.\u0001 = new string(\u0080\u0004.\u007E\u0010\u0008((object) binaryReader, num));
    \u008C\u0002.\u007E\u0004\u0008((object) binaryReader);
  }
}
