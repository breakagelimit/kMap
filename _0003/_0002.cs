// Decompiled with JetBrains decompiler
// Type: .
// Assembly: kMap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB403103-24EE-4947-BAAC-163727D2381A
// Assembly location: C:\Users\Dev\Downloads\Nouveau dossier (28)\NavTestV2\kMap.exe

using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

#nullable disable
namespace \u0003;

internal sealed class \u0002
{
  private static Hashtable \u0001 = new Hashtable();

  [DllImport("kernel32", EntryPoint = "MoveFileEx")]
  private static extern bool \u0002([In] string obj0, [In] string obj1, [In] int obj2);

  [SpecialName]
  internal static bool \u0002()
  {
    try
    {
      switch (Process.GetCurrentProcess().MainModule.ModuleName.ToLower())
      {
        case "w3wp.exe":
          return true;
        case "aspnet_wp.exe":
          return true;
      }
    }
    catch
    {
    }
    return false;
  }

  internal static void \u0002()
  {
    try
    {
      AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(\u0003.\u0002.\u0002);
      if (!Assembly.GetExecutingAssembly().GlobalAssemblyCache || !\u0003.\u0002.\u0002())
        return;
      string[] strArray = "e2ViNWRjODM1LWVhNTUtNDRkOS1hNzg1LWVmMGJlZjhhMjhmM30sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{eb5dc835-ea55-44d9-a785-ef0bef8a28f3}".Split(',');
      for (int index = 0; index < strArray.Length - 1; index += 2)
      {
        try
        {
          string str1 = Encoding.UTF8.GetString(Convert.FromBase64String(strArray[index]));
          string str2 = strArray[index + 1];
          if (str2.Length > 0)
          {
            if (str2[0] == '[')
            {
              int num = str2.IndexOf(']');
              string str3 = str2.Substring(1, num - 1);
              string name = str2.Substring(num + 1);
              bool flag = str3.IndexOf('z') >= 0;
              if (str3.IndexOf('f') >= 0)
              {
                Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
                if (manifestResourceStream != null)
                {
                  int length = (int) manifestResourceStream.Length;
                  byte[] buffer = new byte[length];
                  manifestResourceStream.Read(buffer, 0, length);
                  if (flag)
                    buffer = \u0002.\u0004.\u0002(buffer);
                  try
                  {
                    string path1 = $"{Path.GetTempPath()}{name}\\";
                    Directory.CreateDirectory(path1);
                    \u0003.\u0002.\u0001 obj = new \u0003.\u0002.\u0001(str1);
                    string path2 = $"{path1}{obj.\u0001}.dll";
                    if (!File.Exists(path2))
                    {
                      FileStream fileStream = File.OpenWrite(path2);
                      fileStream.Write(buffer, 0, buffer.Length);
                      fileStream.Close();
                    }
                    try
                    {
                      File.Delete(path2);
                      Directory.Delete(path1);
                    }
                    catch
                    {
                    }
                  }
                  catch
                  {
                  }
                }
              }
            }
          }
        }
        catch (Exception ex)
        {
        }
      }
    }
    catch
    {
    }
  }

  internal static Assembly \u0002([In] object obj0, [In] ResolveEventArgs obj1)
  {
    \u0003.\u0002.\u0001 obj = new \u0003.\u0002.\u0001(obj1.Name);
    string base64String1 = Convert.ToBase64String(Encoding.UTF8.GetBytes(obj.\u0002(false)));
    string[] strArray = "e2ViNWRjODM1LWVhNTUtNDRkOS1hNzg1LWVmMGJlZjhhMjhmM30sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{eb5dc835-ea55-44d9-a785-ef0bef8a28f3}".Split(',');
    string str1 = string.Empty;
    bool flag1 = false;
    bool flag2 = false;
    for (int index = 0; index < strArray.Length - 1; index += 2)
    {
      if (strArray[index] == base64String1)
      {
        str1 = strArray[index + 1];
        break;
      }
    }
    if (str1.Length == 0 && obj.\u0003.Length == 0)
    {
      string base64String2 = Convert.ToBase64String(Encoding.UTF8.GetBytes(obj.\u0001));
      for (int index = 0; index < strArray.Length - 1; index += 2)
      {
        if (strArray[index] == base64String2)
        {
          str1 = strArray[index + 1];
          break;
        }
      }
    }
    if (str1.Length > 0)
    {
      if (str1[0] == '[')
      {
        int num = str1.IndexOf(']');
        string str2 = str1.Substring(1, num - 1);
        flag1 = str2.IndexOf('z') >= 0;
        flag2 = str2.IndexOf('t') >= 0;
        str1 = str1.Substring(num + 1);
      }
      lock (\u0003.\u0002.\u0001)
      {
        if (\u0003.\u0002.\u0001.ContainsKey((object) str1))
          return (Assembly) \u0003.\u0002.\u0001[(object) str1];
        Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(str1);
        if (manifestResourceStream != null)
        {
          int length = (int) manifestResourceStream.Length;
          byte[] numArray = new byte[length];
          manifestResourceStream.Read(numArray, 0, length);
          if (flag1)
            numArray = \u0002.\u0004.\u0002(numArray);
          Assembly assembly = (Assembly) null;
          if (!flag2)
          {
            try
            {
              assembly = Assembly.Load(numArray);
            }
            catch (FileLoadException ex)
            {
              flag2 = true;
            }
            catch (BadImageFormatException ex)
            {
              flag2 = true;
            }
          }
          if (flag2)
          {
            try
            {
              string path1 = $"{Path.GetTempPath()}{str1}\\";
              Directory.CreateDirectory(path1);
              string path2 = $"{path1}{obj.\u0001}.dll";
              if (!File.Exists(path2))
              {
                FileStream fileStream = File.OpenWrite(path2);
                fileStream.Write(numArray, 0, numArray.Length);
                fileStream.Close();
                \u0003.\u0002.\u0002(path2, (string) null, 4);
                \u0003.\u0002.\u0002(path1, (string) null, 4);
              }
              assembly = Assembly.LoadFile(path2);
            }
            catch
            {
            }
          }
          \u0003.\u0002.\u0001[(object) str1] = (object) assembly;
          return assembly;
        }
      }
    }
    return (Assembly) null;
  }

  internal struct \u0001
  {
    public string \u0001;
    public Version \u0001;
    public string \u0002;
    public string \u0003;

    public string \u0002([In] bool obj0)
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append(this.\u0001);
      if (obj0 && this.\u0001 != (Version) null)
        goto label_2;
label_1:
      stringBuilder.Append(", Culture=");
      stringBuilder.Append(this.\u0002.Length == 0 ? "neutral" : this.\u0002);
      stringBuilder.Append(", PublicKeyToken=");
      stringBuilder.Append(this.\u0003.Length == 0 ? "null" : this.\u0003);
      return stringBuilder.ToString();
label_2:
      stringBuilder.Append(", Version=");
      stringBuilder.Append((object) this.\u0001);
      goto label_1;
    }

    public \u0001([In] string obj0)
    {
      this.\u0001 = (Version) null;
      this.\u0002 = string.Empty;
      this.\u0003 = string.Empty;
      this.\u0001 = string.Empty;
      string str1 = obj0;
      char[] chArray = new char[1]{ ',' };
      foreach (string str2 in str1.Split(chArray))
      {
        string str3 = str2.Trim();
        if (str3.StartsWith("Version="))
          this.\u0001 = new Version(str3.Substring(8));
        else if (str3.StartsWith("Culture="))
        {
          this.\u0002 = str3.Substring(8);
          if (this.\u0002 == "neutral")
            this.\u0002 = string.Empty;
        }
        else if (str3.StartsWith("PublicKeyToken="))
        {
          this.\u0003 = str3.Substring(15);
          if (this.\u0003 == "null")
            this.\u0003 = string.Empty;
        }
        else
          this.\u0001 = str3;
      }
    }
  }
}
