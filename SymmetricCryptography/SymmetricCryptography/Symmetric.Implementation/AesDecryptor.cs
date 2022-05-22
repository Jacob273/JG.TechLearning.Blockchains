using System;
using System.IO;
using System.Security.Cryptography;

namespace Symmetric.Implementation
{
    public class AesDecryptor
    {
        public string DecryptData(string base64EncryptedText)
        {
            using (SymmetricAlgorithm aesAlgorithm = Aes.Create())
            {
                aesAlgorithm.Key = SymmetricKeyInformation.AesKey;
                aesAlgorithm.IV = SymmetricKeyInformation.AesIV;

                ICryptoTransform decryptor = aesAlgorithm.CreateDecryptor(aesAlgorithm.Key, aesAlgorithm.IV);
                byte[] encryptedDataBuffer = Convert.FromBase64String(base64EncryptedText);

                using (MemoryStream ms = new MemoryStream(encryptedDataBuffer))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader reader = new StreamReader(cs))
                        {
                            return reader.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
