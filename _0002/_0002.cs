// Decompiled with JetBrains decompiler
// Type: .
// Assembly: kMap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB403103-24EE-4947-BAAC-163727D2381A
// Assembly location: C:\Users\Dev\Downloads\Nouveau dossier (28)\NavTestV2\kMap.exe

using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

#nullable disable
namespace \u0002;

internal sealed class \u0002
{
  private readonly Type \u0001;
  private readonly object \u0001;

  public \u0002()
  {
    try
    {
      this.\u0001 = Assembly.Load("System.Core, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e").GetType("System.Security.Cryptography.AesManaged");
    }
    catch (FileNotFoundException ex)
    {
      this.\u0001 = Assembly.Load("mscorlib").GetType("System.Security.Cryptography.RijndaelManaged");
    }
    this.\u0001 = Activator.CreateInstance(this.\u0001);
  }

  public ICryptoTransform \u0002([In] byte[] obj0, [In] byte[] obj1, [In] bool obj2)
  {
    this.\u0001.GetProperty("Key").GetSetMethod().Invoke(this.\u0001, new object[1]
    {
      (object) obj0
    });
    this.\u0001.GetProperty("IV").GetSetMethod().Invoke(this.\u0001, new object[1]
    {
      (object) obj1
    });
    return (ICryptoTransform) this.\u0001.GetMethod(obj2 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]).Invoke(this.\u0001, new object[0]);
  }

  public void \u0002() => this.\u0001.GetMethod("Clear").Invoke(this.\u0001, new object[0]);
}
