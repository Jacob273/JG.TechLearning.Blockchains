using System;
using System.IO;
using System.Security.Cryptography;

namespace Symmetric.Implementation
{
    public class AesEncryptor
    {
        public string EncryptString(string plainText)
        {
            byte[] encryptedByteArray;

            using (SymmetricAlgorithm aesAlgorithm = Aes.Create())
            {
                aesAlgorithm.KeySize = SymmetricKeyInformation.SymmetricKeySizeInBits;
                aesAlgorithm.Key = SymmetricKeyInformation.AesKey;
                aesAlgorithm.IV = SymmetricKeyInformation.AesIV;

                ICryptoTransform encryptor = aesAlgorithm.CreateEncryptor(aesAlgorithm.Key, aesAlgorithm.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        encryptedByteArray = memoryStream.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(encryptedByteArray);
        }
    }
}
