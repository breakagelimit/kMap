// Decompiled with JetBrains decompiler
// Type: .
// Assembly: kMap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB403103-24EE-4947-BAAC-163727D2381A
// Assembly location: C:\Users\Dev\Downloads\Nouveau dossier (28)\NavTestV2\kMap.exe

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace \u0001;

internal sealed class \u0001
{
  private static \u0001.\u0001 \u0001;
  private long \u0001 = DateTime.Now.Ticks;

  [DllImport("kernel32", EntryPoint = "SetProcessWorkingSetSize")]
  private static extern int \u0002(
    IntPtr process,
    int minimumWorkingSetSize,
    int maximumWorkingSetSize);

  private void \u0002()
  {
    try
    {
      using (Process currentProcess = Process.GetCurrentProcess())
        \u0001.\u0001.\u0002(currentProcess.Handle, -1, -1);
    }
    catch
    {
    }
  }

  private void \u0002(object sender, EventArgs e)
  {
    try
    {
      long ticks = DateTime.Now.Ticks;
      if (ticks - this.\u0001 <= 10000000L)
        return;
      this.\u0001 = ticks;
      this.\u0002();
    }
    catch
    {
    }
  }

  private \u0001()
  {
    // ISSUE: method pointer
    Application.Idle += new EventHandler((object) this, __methodptr(\u0002));
    this.\u0002();
  }

  public static void \u0003()
  {
    try
    {
      if (Environment.OSVersion.Platform != PlatformID.Win32NT)
        return;
      \u0001.\u0001.\u0001 = new \u0001.\u0001();
    }
    catch
    {
    }
  }
}
