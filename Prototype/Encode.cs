using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;// need to call RC2 CryptoServiceProvider
using System.IO;

namespace Prototype
{
    class Encode
    {
        public static byte[] Byte_IV;//defines for use in every aspect of code
        //public static string IV;//defines for use in every aspect of code
        public static RC2CryptoServiceProvider rc2CSP = new RC2CryptoServiceProvider();//defines for use in every aspect of code
        //public static byte[] Byte_key = rc2CSP.Key;
        //public static byte[] Byte_IV = rc2CSP.IV;
        public static string Key = "zsT8Xt4dk3ecUpu6P4TC2g==";//Convert.ToBase64String(Byte_key); key can be same every time but must be secret
        //public static string IV = Convert.ToBase64String(Byte_IV);//iv must be unique but doesnt need to be secret

        public static string EncryptText(string openText, string IV)
        {
            ICryptoTransform encryptor = rc2CSP.CreateEncryptor(Convert.FromBase64String(Key), Convert.FromBase64String(IV));
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    byte[] toEncrypt = Encoding.Unicode.GetBytes(openText);

                    csEncrypt.Write(toEncrypt, 0, toEncrypt.Length);
                    csEncrypt.FlushFinalBlock();

                    byte[] encrypted = msEncrypt.ToArray();

                    return Convert.ToBase64String(encrypted);
                }
            }
        }

        public static string DecryptText(string encryptedText, string IV)
        {
            ICryptoTransform decryptor = rc2CSP.CreateDecryptor(Convert.FromBase64String(Key), Convert.FromBase64String(IV));
            using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(encryptedText)))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    List<Byte> bytes = new List<byte>();
                    int b;
                    do
                    {
                        b = csDecrypt.ReadByte();
                        if (b != -1)
                        {
                            bytes.Add(Convert.ToByte(b));
                        }

                    }
                    while (b != -1);

                    return Encoding.Unicode.GetString(bytes.ToArray());
                }
            }
        }
    }
}
