// Decompiled with JetBrains decompiler
// Type: .
// Assembly: kMap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB403103-24EE-4947-BAAC-163727D2381A
// Assembly location: C:\Users\Dev\Downloads\Nouveau dossier (28)\NavTestV2\kMap.exe

using System.Runtime.InteropServices;

#nullable disable
namespace \u0004;

internal sealed class \u0001 : \u0003.\u0005
{
  private uint \u0001;
  private uint \u0002;

  public void \u0002([In] byte[] obj0, [In] int obj1)
  {
    this.\u0001 = (uint) ((int) obj0[obj1] << 24 | (int) obj0[obj1 + 1] << 16 /*0x10*/ | (int) obj0[obj1 + 2] << 8) | (uint) obj0[obj1 + 3];
    this.\u0002 = (uint) ((int) obj0[obj1 + 4] << 24 | (int) obj0[obj1 + 5] << 16 /*0x10*/ | (int) obj0[obj1 + 6] << 8) | (uint) obj0[obj1 + 7];
  }

  public \u0001([In] byte[] obj0, [In] int obj1, [In] int obj2)
    : base(obj0, obj1, obj2)
  {
  }

  public \u0001()
    : base((byte[]) null, 0, 0)
  {
  }

  public int \u0005([In] byte[] obj0, [In] int obj1, [In] byte[] obj2, [In] int obj3, [In] int obj4)
  {
    uint[] numArray1 = base.\u0002;
    uint[] numArray2 = this.\u0003;
    uint[] numArray3 = this.\u0004;
    uint[] numArray4 = this.\u0005;
    uint[] numArray5 = base.\u0001;
    uint num1 = numArray5[0];
    uint num2 = numArray5[1];
    uint num3 = numArray5[2];
    uint num4 = numArray5[3];
    uint num5 = numArray5[4];
    uint num6 = numArray5[5];
    uint num7 = numArray5[6];
    uint num8 = numArray5[7];
    uint num9 = numArray5[8];
    uint num10 = numArray5[9];
    uint num11 = numArray5[10];
    uint num12 = numArray5[11];
    uint num13 = numArray5[12];
    uint num14 = numArray5[13];
    uint num15 = numArray5[14];
    uint num16 = numArray5[15];
    uint num17 = numArray5[16 /*0x10*/];
    uint num18 = numArray5[17];
    uint num19 = this.\u0001;
    uint num20 = this.\u0002;
    obj4 &= -8;
    int num21 = obj1 + obj4;
    while (obj1 < num21)
    {
      uint num22 = num19 ^ ((uint) ((int) obj0[obj1 + 3] << 24 | (int) obj0[obj1 + 2] << 16 /*0x10*/ | (int) obj0[obj1 + 1] << 8) | (uint) obj0[obj1]);
      uint num23 = num20 ^ ((uint) ((int) obj0[obj1 + 7] << 24 | (int) obj0[obj1 + 6] << 16 /*0x10*/ | (int) obj0[obj1 + 5] << 8) | (uint) obj0[obj1 + 4]);
      obj1 += 8;
      uint num24 = num22 ^ num1;
      uint num25 = num23 ^ (numArray1[(int) (num24 >> 24)] + numArray2[(int) (num24 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num24 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num24 & (int) byte.MaxValue] ^ num2;
      uint num26 = num24 ^ (numArray1[(int) (num25 >> 24)] + numArray2[(int) (num25 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num25 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num25 & (int) byte.MaxValue] ^ num3;
      uint num27 = num25 ^ (numArray1[(int) (num26 >> 24)] + numArray2[(int) (num26 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num26 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num26 & (int) byte.MaxValue] ^ num4;
      uint num28 = num26 ^ (numArray1[(int) (num27 >> 24)] + numArray2[(int) (num27 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num27 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num27 & (int) byte.MaxValue] ^ num5;
      uint num29 = num27 ^ (numArray1[(int) (num28 >> 24)] + numArray2[(int) (num28 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num28 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num28 & (int) byte.MaxValue] ^ num6;
      uint num30 = num28 ^ (numArray1[(int) (num29 >> 24)] + numArray2[(int) (num29 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num29 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num29 & (int) byte.MaxValue] ^ num7;
      uint num31 = num29 ^ (numArray1[(int) (num30 >> 24)] + numArray2[(int) (num30 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num30 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num30 & (int) byte.MaxValue] ^ num8;
      uint num32 = num30 ^ (numArray1[(int) (num31 >> 24)] + numArray2[(int) (num31 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num31 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num31 & (int) byte.MaxValue] ^ num9;
      uint num33 = num31 ^ (numArray1[(int) (num32 >> 24)] + numArray2[(int) (num32 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num32 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num32 & (int) byte.MaxValue] ^ num10;
      uint num34 = num32 ^ (numArray1[(int) (num33 >> 24)] + numArray2[(int) (num33 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num33 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num33 & (int) byte.MaxValue] ^ num11;
      uint num35 = num33 ^ (numArray1[(int) (num34 >> 24)] + numArray2[(int) (num34 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num34 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num34 & (int) byte.MaxValue] ^ num12;
      uint num36 = num34 ^ (numArray1[(int) (num35 >> 24)] + numArray2[(int) (num35 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num35 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num35 & (int) byte.MaxValue] ^ num13;
      uint num37 = num35 ^ (numArray1[(int) (num36 >> 24)] + numArray2[(int) (num36 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num36 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num36 & (int) byte.MaxValue] ^ num14;
      uint num38 = num36 ^ (numArray1[(int) (num37 >> 24)] + numArray2[(int) (num37 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num37 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num37 & (int) byte.MaxValue] ^ num15;
      uint num39 = num37 ^ (numArray1[(int) (num38 >> 24)] + numArray2[(int) (num38 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num38 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num38 & (int) byte.MaxValue] ^ num16;
      uint num40 = num38 ^ (numArray1[(int) (num39 >> 24)] + numArray2[(int) (num39 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num39 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num39 & (int) byte.MaxValue] ^ num17;
      uint num41 = num39 ^ num18;
      num20 = num40;
      num19 = num41;
      obj2[obj3 + 3] = (byte) (num19 >> 24);
      obj2[obj3 + 2] = (byte) (num19 >> 16 /*0x10*/);
      obj2[obj3 + 1] = (byte) (num19 >> 8);
      obj2[obj3] = (byte) num19;
      obj2[obj3 + 7] = (byte) (num20 >> 24);
      obj2[obj3 + 6] = (byte) (num20 >> 16 /*0x10*/);
      obj2[obj3 + 5] = (byte) (num20 >> 8);
      obj2[obj3 + 4] = (byte) num20;
      obj3 += 8;
    }
    this.\u0001 = num19;
    this.\u0002 = num20;
    return obj4;
  }

  public int \u0006([In] byte[] obj0, [In] int obj1, [In] byte[] obj2, [In] int obj3, [In] int obj4)
  {
    uint[] numArray1 = base.\u0002;
    uint[] numArray2 = this.\u0003;
    uint[] numArray3 = this.\u0004;
    uint[] numArray4 = this.\u0005;
    uint[] numArray5 = base.\u0001;
    uint num1 = numArray5[0];
    uint num2 = numArray5[1];
    uint num3 = numArray5[2];
    uint num4 = numArray5[3];
    uint num5 = numArray5[4];
    uint num6 = numArray5[5];
    uint num7 = numArray5[6];
    uint num8 = numArray5[7];
    uint num9 = numArray5[8];
    uint num10 = numArray5[9];
    uint num11 = numArray5[10];
    uint num12 = numArray5[11];
    uint num13 = numArray5[12];
    uint num14 = numArray5[13];
    uint num15 = numArray5[14];
    uint num16 = numArray5[15];
    uint num17 = numArray5[16 /*0x10*/];
    uint num18 = numArray5[17];
    uint num19 = this.\u0001;
    uint num20 = this.\u0002;
    obj4 &= -8;
    int num21 = obj1 + obj4;
    while (obj1 < num21)
    {
      uint num22;
      uint num23 = num22 = (uint) ((int) obj0[obj1 + 3] << 24 | (int) obj0[obj1 + 2] << 16 /*0x10*/ | (int) obj0[obj1 + 1] << 8) | (uint) obj0[obj1];
      uint num24;
      uint num25 = num24 = (uint) ((int) obj0[obj1 + 7] << 24 | (int) obj0[obj1 + 6] << 16 /*0x10*/ | (int) obj0[obj1 + 5] << 8) | (uint) obj0[obj1 + 4];
      obj1 += 8;
      uint num26 = num23 ^ num18;
      uint num27 = num25 ^ (numArray1[(int) (num26 >> 24)] + numArray2[(int) (num26 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num26 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num26 & (int) byte.MaxValue] ^ num17;
      uint num28 = num26 ^ (numArray1[(int) (num27 >> 24)] + numArray2[(int) (num27 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num27 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num27 & (int) byte.MaxValue] ^ num16;
      uint num29 = num27 ^ (numArray1[(int) (num28 >> 24)] + numArray2[(int) (num28 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num28 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num28 & (int) byte.MaxValue] ^ num15;
      uint num30 = num28 ^ (numArray1[(int) (num29 >> 24)] + numArray2[(int) (num29 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num29 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num29 & (int) byte.MaxValue] ^ num14;
      uint num31 = num29 ^ (numArray1[(int) (num30 >> 24)] + numArray2[(int) (num30 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num30 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num30 & (int) byte.MaxValue] ^ num13;
      uint num32 = num30 ^ (numArray1[(int) (num31 >> 24)] + numArray2[(int) (num31 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num31 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num31 & (int) byte.MaxValue] ^ num12;
      uint num33 = num31 ^ (numArray1[(int) (num32 >> 24)] + numArray2[(int) (num32 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num32 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num32 & (int) byte.MaxValue] ^ num11;
      uint num34 = num32 ^ (numArray1[(int) (num33 >> 24)] + numArray2[(int) (num33 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num33 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num33 & (int) byte.MaxValue] ^ num10;
      uint num35 = num33 ^ (numArray1[(int) (num34 >> 24)] + numArray2[(int) (num34 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num34 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num34 & (int) byte.MaxValue] ^ num9;
      uint num36 = num34 ^ (numArray1[(int) (num35 >> 24)] + numArray2[(int) (num35 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num35 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num35 & (int) byte.MaxValue] ^ num8;
      uint num37 = num35 ^ (numArray1[(int) (num36 >> 24)] + numArray2[(int) (num36 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num36 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num36 & (int) byte.MaxValue] ^ num7;
      uint num38 = num36 ^ (numArray1[(int) (num37 >> 24)] + numArray2[(int) (num37 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num37 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num37 & (int) byte.MaxValue] ^ num6;
      uint num39 = num37 ^ (numArray1[(int) (num38 >> 24)] + numArray2[(int) (num38 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num38 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num38 & (int) byte.MaxValue] ^ num5;
      uint num40 = num38 ^ (numArray1[(int) (num39 >> 24)] + numArray2[(int) (num39 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num39 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num39 & (int) byte.MaxValue] ^ num4;
      uint num41 = num39 ^ (numArray1[(int) (num40 >> 24)] + numArray2[(int) (num40 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num40 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num40 & (int) byte.MaxValue] ^ num3;
      uint num42 = num40 ^ (numArray1[(int) (num41 >> 24)] + numArray2[(int) (num41 >> 16 /*0x10*/) & (int) byte.MaxValue] ^ numArray3[(int) (num41 >> 8) & (int) byte.MaxValue]) + numArray4[(int) num41 & (int) byte.MaxValue] ^ num2;
      uint num43 = num41 ^ num19 ^ num1;
      uint num44 = num42 ^ num20;
      obj2[obj3 + 3] = (byte) (num43 >> 24);
      obj2[obj3 + 2] = (byte) (num43 >> 16 /*0x10*/);
      obj2[obj3 + 1] = (byte) (num43 >> 8);
      obj2[obj3] = (byte) num43;
      obj2[obj3 + 7] = (byte) (num44 >> 24);
      obj2[obj3 + 6] = (byte) (num44 >> 16 /*0x10*/);
      obj2[obj3 + 5] = (byte) (num44 >> 8);
      obj2[obj3 + 4] = (byte) num44;
      num19 = num22;
      num20 = num24;
      obj3 += 8;
    }
    this.\u0001 = num19;
    this.\u0002 = num20;
    return obj4;
  }
}
