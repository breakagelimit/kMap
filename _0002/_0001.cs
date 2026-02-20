// Decompiled with JetBrains decompiler
// Type: .
// Assembly: kMap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB403103-24EE-4947-BAAC-163727D2381A
// Assembly location: C:\Users\Dev\Downloads\Nouveau dossier (28)\NavTestV2\kMap.exe

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace \u0002;

internal sealed class \u0001
{
  private static Assembly \u0001 = (Assembly) null;
  private static string[] \u0001 = new string[0];

  internal static void \u0002()
  {
    try
    {
      AppDomain.CurrentDomain.ResourceResolve += new ResolveEventHandler(\u0002.\u0001.\u0002);
    }
    catch (Exception ex)
    {
    }
  }

  private static Assembly \u0002([In] object obj0, [In] ResolveEventArgs obj1)
  {
    if (\u0002.\u0001.\u0001 == null)
    {
      lock (\u0002.\u0001.\u0001)
      {
        \u0002.\u0001.\u0001 = Assembly.Load("{eb5dc835-ea55-44d9-a785-ef0bef8a28f3}, PublicKeyToken=3e56350693f7355e");
        if (\u0002.\u0001.\u0001 != null)
          \u0002.\u0001.\u0001 = \u0002.\u0001.\u0001.GetManifestResourceNames();
      }
    }
    string name = obj1.Name;
    for (int index = 0; index < \u0002.\u0001.\u0001.Length; ++index)
    {
      if (\u0002.\u0001.\u0001[index] == name)
        return !\u0002.\u0001.\u0002() ? (Assembly) null : \u0002.\u0001.\u0001;
    }
    return (Assembly) null;
  }

  private static bool \u0002()
  {
    try
    {
      StackFrame[] frames = new StackTrace().GetFrames();
      for (int index = 2; index < frames.Length; ++index)
      {
        if (frames[index].GetMethod().Module.Assembly == Assembly.GetExecutingAssembly())
          return true;
      }
      return false;
    }
    catch
    {
      return true;
    }
  }
}
