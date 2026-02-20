// Decompiled with JetBrains decompiler
// Type: .
// Assembly: kMap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB403103-24EE-4947-BAAC-163727D2381A
// Assembly location: C:\Users\Dev\Downloads\Nouveau dossier (28)\NavTestV2\kMap.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace \u0005;

internal sealed class \u0003
{
  private float \u0001;
  private float \u0002;
  private float \u0003;

  public \u0003()
  {
  }

  public \u0003([In] float obj0, [In] float obj1, [In] float obj2)
  {
    this.\u0001 = obj0;
    this.\u0002 = obj1;
    this.\u0003 = obj2;
  }

  [SpecialName]
  public float \u0002() => this.\u0001;

  [SpecialName]
  public void \u0002([In] float obj0) => this.\u0001 = obj0;

  [SpecialName]
  public float \u0003() => this.\u0002;

  [SpecialName]
  public void \u0003([In] float obj0) => this.\u0002 = obj0;

  [SpecialName]
  public void \u0004([In] float obj0) => this.\u0003 = obj0;

  public byte \u0002()
  {
    return checked ((byte) \u008C\u0003.\u0002\u0006(\u008C\u0003.\u009F\u0005(unchecked ((double) this.\u0002 / 192.0 + 92.0))));
  }

  public byte \u0003()
  {
    return checked ((byte) \u008C\u0003.\u0002\u0006(\u008C\u0003.\u009F\u0005(unchecked ((double) this.\u0001 / 192.0 + 135.0))));
  }

  public int \u0002()
  {
    int num = checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked (this.\u0001 % 192f)));
    if (num < 0)
      checked { num += 192 /*0xC0*/; }
    return num;
  }

  public int \u0003()
  {
    int num = checked ((int) \u008C\u0003.\u0002\u0006((double) unchecked (this.\u0002 % 192f)));
    if (num < 0)
      checked { num += 192 /*0xC0*/; }
    return num;
  }
}
