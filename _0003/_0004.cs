// Decompiled with JetBrains decompiler
// Type: .
// Assembly: kMap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB403103-24EE-4947-BAAC-163727D2381A
// Assembly location: C:\Users\Dev\Downloads\Nouveau dossier (28)\NavTestV2\kMap.exe

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

#nullable disable
namespace \u0003;

internal sealed class \u0004 : SymmetricAlgorithm, ICryptoTransform, IDisposable
{
  private \u0005 \u0001;
  private \u0004.\u0001 \u0001;
  private bool \u0001;
  private byte[] \u0001;
  private RNGCryptoServiceProvider \u0001;

  public \u0004()
  {
    this.KeySizeValue = 448;
    this.LegalBlockSizesValue = new KeySizes[1];
    this.LegalBlockSizesValue[0] = new KeySizes(\u0011\u0003.\u007E\u0095\u0008((object) this), \u0011\u0003.\u007E\u0095\u0008((object) this), 8);
    this.LegalKeySizesValue = new KeySizes[1];
    this.LegalKeySizesValue[0] = new KeySizes(0, 448, 8);
    this.ModeValue = CipherMode.ECB;
  }

  private \u0004([In] byte[] obj0, [In] byte[] obj1, [In] bool obj2, [In] bool obj3)
  {
    if (obj0 == null)
      \u008C\u0002.\u007E\u009B\u0008((object) this);
    else
      \u008F\u0004.\u007E\u0097\u0008((object) this, obj0);
    if (obj2)
    {
      \u008F\u0004.\u007E\u0096\u0008((object) this, obj1);
      this.\u0001 = new \u0004.\u0001(this.KeyValue, 0, this.KeyValue.Length);
      this.\u0001.\u0002(this.IVValue, 0);
    }
    else
      this.\u0001 = new \u0005(this.KeyValue, 0, this.KeyValue.Length);
    this.\u0001 = obj3;
  }

  [SpecialName]
  public override int get_BlockSize() => 64 /*0x40*/;

  [SpecialName]
  public override void set_BlockSize([In] int obj0)
  {
    if (obj0 != 64 /*0x40*/)
    {
      // ISSUE: reference to a compiler-generated method
      throw new CryptographicException(\u0003.\u0003.\u0002());
    }
  }

  [SpecialName]
  public override byte[] get_IV()
  {
    if (this.IVValue == null)
      \u008C\u0002.\u007E\u009C\u0008((object) this);
    return (byte[]) \u000E\u0003.\u007E\u009D\u0004((object) this.IVValue);
  }

  [SpecialName]
  public override void set_IV([In] byte[] obj0)
  {
    if (obj0 == null)
      throw new ArgumentNullException();
    if (obj0.Length != 8)
    {
      // ISSUE: reference to a compiler-generated method
      throw new CryptographicException(\u0003.\u0003.\u0004());
    }
    this.IVValue = (byte[]) \u000E\u0003.\u007E\u009D\u0004((object) obj0);
  }

  [SpecialName]
  public override byte[] get_Key() => this.KeyValue;

  [SpecialName]
  public override void set_Key([In] byte[] obj0) => this.KeyValue = obj0;

  [SpecialName]
  public override int get_KeySize() => this.KeySizeValue;

  [SpecialName]
  public override void set_KeySize([In] int obj0)
  {
    KeySizes keySizes = \u0090\u0004.\u007E\u0098\u0008((object) this)[0];
    if (obj0 % \u0011\u0003.\u007E\u008C\u0008((object) keySizes) != 0 || obj0 > \u0011\u0003.\u007E\u008B\u0008((object) keySizes) || obj0 < \u0011\u0003.\u007E\u008A\u0008((object) keySizes))
    {
      // ISSUE: reference to a compiler-generated method
      throw new CryptographicException(\u0003.\u0003.\u0005());
    }
    this.KeySizeValue = obj0;
  }

  [SpecialName]
  public override CipherMode get_Mode() => this.ModeValue;

  [SpecialName]
  public override void set_Mode([In] CipherMode obj0)
  {
    // ISSUE: reference to a compiler-generated method
    this.ModeValue = obj0 == CipherMode.CBC || obj0 == CipherMode.ECB ? obj0 : throw new CryptographicException(\u0003.\u0003.\u0003());
  }

  private void \u0002([In] \u0003.\u0004 obj0)
  {
    switch (\u0091\u0004.\u007E\u0099\u0008((object) this))
    {
      case PaddingMode.PKCS7:
      case PaddingMode.Zeros:
      case PaddingMode.ANSIX923:
      case PaddingMode.ISO10126:
        \u0092\u0004.\u007E\u009A\u0008((object) obj0, \u0091\u0004.\u007E\u0099\u0008((object) this));
        break;
      default:
        // ISSUE: reference to a compiler-generated method
        throw new CryptographicException(\u0017\u0003.\u0013\u0005(\u0003.\u0003.\u0012(), (object) \u0091\u0004.\u007E\u0099\u0008((object) this)));
    }
  }

  public override ICryptoTransform CreateEncryptor([In] byte[] obj0, [In] byte[] obj1)
  {
    \u0003.\u0004 encryptor = new \u0003.\u0004(obj0, obj1, CipherMode.CBC == this.ModeValue, true);
    this.\u0002(encryptor);
    return (ICryptoTransform) encryptor;
  }

  public override ICryptoTransform CreateDecryptor([In] byte[] obj0, [In] byte[] obj1)
  {
    \u0003.\u0004 decryptor = new \u0003.\u0004(obj0, obj1, CipherMode.CBC == this.ModeValue, false);
    this.\u0002(decryptor);
    return (ICryptoTransform) decryptor;
  }

  public override void GenerateKey()
  {
    if (this.\u0001 == null)
      goto label_2;
label_1:
    this.KeyValue = new byte[this.KeySizeValue >> 3];
    \u008F\u0004.\u007E\u0091\u0008((object) this.\u0001, this.KeyValue);
    return;
label_2:
    this.\u0001 = new RNGCryptoServiceProvider();
    goto label_1;
  }

  public override void GenerateIV()
  {
    if (this.\u0001 == null)
      goto label_2;
label_1:
    this.IVValue = new byte[8];
    \u008F\u0004.\u007E\u0091\u0008((object) this.\u0001, this.IVValue);
    return;
label_2:
    this.\u0001 = new RNGCryptoServiceProvider();
    goto label_1;
  }

  [SpecialName]
  public bool get_CanReuseTransform() => true;

  [SpecialName]
  public bool get_CanTransformMultipleBlocks() => true;

  [SpecialName]
  public int get_InputBlockSize() => 8;

  [SpecialName]
  public int get_OutputBlockSize() => 8;

  public int TransformBlock([In] byte[] obj0, [In] int obj1, [In] int obj2, [In] byte[] obj3, [In] int obj4)
  {
    if (obj2 == 0)
      return 0;
    if (obj2 % 8 != 0)
      throw new CryptographicException(\u0001.\u0004.\u0002(704));
    if (this.\u0001)
      return this.\u0001 == null ? this.\u0001.\u0005(obj0, obj1, obj3, obj4, obj2) : this.\u0001.\u0002(obj0, obj1, obj3, obj4, obj2);
    int num = 0;
    if (this.\u0001 == null)
    {
      this.\u0001 = new byte[8];
    }
    else
    {
      if (this.\u0001 == null)
        this.\u0001.\u0006(this.\u0001, 0, obj3, obj4, 8);
      else
        this.\u0001.\u0003(this.\u0001, 0, obj3, obj4, 8);
      obj4 += 8;
      num += 8;
    }
    obj2 -= 8;
    \u0007\u0003.\u009B\u0004((Array) obj0, obj1 + obj2, (Array) this.\u0001, 0, this.\u0001.Length);
    return this.\u0001 == null ? num + this.\u0001.\u0006(obj0, obj1, obj3, obj4, obj2) : num + this.\u0001.\u0003(obj0, obj1, obj3, obj4, obj2);
  }

  public byte[] TransformFinalBlock([In] byte[] obj0, [In] int obj1, [In] int obj2)
  {
    if (8 < obj2)
    {
      // ISSUE: reference to a compiler-generated method
      throw new CryptographicException(\u0017\u0003.\u0013\u0005(\u0003.\u0003.\u000F(), (object) obj2));
    }
    byte[] numArray1;
    if (this.\u0001)
    {
      int length = 8 + (8 == obj2 ? 8 : 0);
      numArray1 = new byte[length];
      if (PaddingMode.PKCS7 == this.PaddingValue)
      {
        byte num = (byte) (length - obj2);
        for (int index = obj2; index < length; ++index)
          numArray1[index] = num;
      }
      else if (PaddingMode.Zeros == this.PaddingValue)
      {
        for (int index = obj2; index < length; ++index)
          numArray1[index] = (byte) 0;
      }
      else if (PaddingMode.ANSIX923 == this.PaddingValue)
      {
        for (int index = obj2; index < length - 1; ++index)
          numArray1[index] = (byte) 0;
        numArray1[length - 1] = (byte) (length - obj2);
      }
      else
      {
        if (PaddingMode.ISO10126 != this.PaddingValue)
        {
          // ISSUE: reference to a compiler-generated method
          throw new CryptographicException(\u0017\u0003.\u0013\u0005(\u0003.\u0003.\u0011(), (object) this.PaddingValue));
        }
        \u008F\u0004.\u007E\u0091\u0008((object) \u008E\u0004.\u0090\u0008(), numArray1);
      }
      \u0007\u0003.\u009B\u0004((Array) obj0, obj1, (Array) numArray1, 0, obj2);
      if (this.\u0001 == null)
        this.\u0001.\u0005(numArray1, 0, numArray1, 0, 8);
      else
        this.\u0001.\u0002(numArray1, 0, numArray1, 0, 8);
    }
    else
    {
      byte[] numArray2;
      if (obj2 == 0)
      {
        if ((numArray2 = this.\u0001) == null)
          return new byte[0];
      }
      else
      {
        if (this.\u0001 == null)
          this.\u0001.\u0006(this.\u0001, 0, this.\u0001, 0, 8);
        else
          this.\u0001.\u0003(this.\u0001, 0, this.\u0001, 0, 8);
        numArray2 = new byte[8];
        \u0007\u0003.\u009B\u0004((Array) obj0, obj1, (Array) numArray2, 0, obj2);
      }
      if (this.\u0001 == null)
        this.\u0001.\u0006(numArray2, 0, numArray2, 0, 8);
      else
        this.\u0001.\u0003(numArray2, 0, numArray2, 0, 8);
      int length;
      if (PaddingMode.PKCS7 == this.PaddingValue)
      {
        byte num = numArray2[numArray2.Length - 1];
        if ((byte) 8 < num)
        {
          // ISSUE: reference to a compiler-generated method
          throw new CryptographicException(\u0017\u0003.\u0013\u0005(\u0003.\u0003.\u0008(), (object) num));
        }
        length = numArray2.Length - (int) num;
        for (int index = numArray2.Length - 2; index >= length; --index)
        {
          if ((int) numArray2[index] != (int) num)
          {
            // ISSUE: reference to a compiler-generated method
            throw new CryptographicException(\u0018\u0003.\u0014\u0005(\u0003.\u0003.\u0006(), (object) num, (object) index));
          }
        }
      }
      else if (PaddingMode.Zeros == this.PaddingValue || PaddingMode.ISO10126 == this.PaddingValue)
      {
        length = numArray2.Length;
      }
      else
      {
        if (PaddingMode.ANSIX923 != this.PaddingValue)
        {
          // ISSUE: reference to a compiler-generated method
          throw new CryptographicException(\u0017\u0003.\u0013\u0005(\u0003.\u0003.\u0010(), (object) this.PaddingValue));
        }
        byte num = numArray2[numArray2.Length - 1];
        if ((byte) 8 < num)
        {
          // ISSUE: reference to a compiler-generated method
          throw new CryptographicException(\u0017\u0003.\u0013\u0005(\u0003.\u0003.\u0007(), (object) num));
        }
        length = numArray2.Length - (int) num;
        for (int index = numArray2.Length - 2; index >= length; --index)
        {
          if (numArray2[index] != (byte) 0)
          {
            // ISSUE: reference to a compiler-generated method
            throw new CryptographicException(\u0018\u0003.\u0014\u0005(\u0003.\u0003.\u000E(), (object) num, (object) index));
          }
        }
      }
      if (numArray2 == this.\u0001)
      {
        numArray1 = new byte[length];
        \u0007\u0003.\u009B\u0004((Array) numArray2, 0, (Array) numArray1, 0, length);
      }
      else
      {
        numArray1 = new byte[8 + length];
        \u0007\u0003.\u009B\u0004((Array) this.\u0001, 0, (Array) numArray1, 0, 8);
        \u0007\u0003.\u009B\u0004((Array) numArray2, 0, (Array) numArray1, 8, length);
      }
    }
    return numArray1;
  }
}
