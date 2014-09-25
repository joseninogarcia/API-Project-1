using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

/// <summary>
/// Summary description for CodeProcessor
/// </summary>
public class CodeProcessor
{
    public static string Encrypt(string plainData)
    {
        RijndaelManaged rijndaelCipher = new RijndaelManaged();
        rijndaelCipher.Mode = CipherMode.CBC;
        rijndaelCipher.Padding = PaddingMode.PKCS7;
        rijndaelCipher.KeySize = 128;
        rijndaelCipher.BlockSize = 128;

        byte[] pwdBytes = Encoding.UTF8.GetBytes("xuenn");
        byte[] keyBytes = new byte[16];
        int len = pwdBytes.Length;
        if (len > keyBytes.Length) len = keyBytes.Length;
        Array.Copy(pwdBytes, keyBytes, len);

        rijndaelCipher.Key = keyBytes;

        byte[] ivBytes1 = Encoding.UTF8.GetBytes("1234567890ABCDEF");
        byte[] keyBytes1 = new byte[16];
        int len1 = ivBytes1.Length;
        if (len1 > keyBytes1.Length) len1 = keyBytes1.Length;
        Array.Copy(ivBytes1, keyBytes1, len1);
        rijndaelCipher.IV = ivBytes1;
        ICryptoTransform transform = rijndaelCipher.CreateEncryptor();
        byte[] plainText = Encoding.UTF8.GetBytes(plainData);
        byte[] cipherBytes = transform.TransformFinalBlock(plainText, 0, plainText.Length);

        return Convert.ToBase64String(cipherBytes);
    }

    public static string Decrypt(string encryptedData)
    {
        RijndaelManaged rijndaelCipher = new RijndaelManaged();
        rijndaelCipher.Mode = CipherMode.CBC;
        rijndaelCipher.Padding = PaddingMode.PKCS7;
        rijndaelCipher.KeySize = 128;
        rijndaelCipher.BlockSize = 128;

        byte[] encryptedByte = Convert.FromBase64String(encryptedData);
        byte[] pwdBytes = Encoding.UTF8.GetBytes("xuenn");
        byte[] keyBytes = new byte[16];
        int len = pwdBytes.Length;
        if (len > keyBytes.Length) len = keyBytes.Length;
        Array.Copy(pwdBytes, keyBytes, len);

        rijndaelCipher.Key = keyBytes;
        byte[] ivBytes1 = Encoding.UTF8.GetBytes("1234567890ABCDEF");

        byte[] keyBytes1 = new byte[16];
        int len1 = ivBytes1.Length;
        if (len1 > keyBytes1.Length) len1 = keyBytes1.Length;
        Array.Copy(ivBytes1, keyBytes1, len1);

        rijndaelCipher.IV = keyBytes1;

        ICryptoTransform transform = rijndaelCipher.CreateDecryptor();
        byte[] plainText = transform.TransformFinalBlock(encryptedByte, 0, encryptedByte.Length);

        return Encoding.UTF8.GetString(plainText);
    }
}