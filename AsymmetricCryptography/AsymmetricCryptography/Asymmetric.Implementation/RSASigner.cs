using System;
using System.Security.Cryptography;
using System.Text;

namespace Asymmetric.Implementation
{
    public class RSASigner
    {
        private readonly RSACryptoServiceProvider _rsa = new();

        public void InitializePrivateKey()
        {
            var privateKey = AsymmetricKeyInformation.RsaPrivateKeyPemInBase64;
            _rsa.ImportFromPem(privateKey);
        }

        public string Sign(string message)
        {
            byte[] rsaSignature;
            var encoder = new UTF8Encoding();
            byte[] originalData = encoder.GetBytes(message);

            try
            {
                rsaSignature = _rsa.SignData(originalData, CryptoConfig.MapNameToOID("SHA512"));
            }
            catch
            {
                return null;
            }
            return Convert.ToBase64String(rsaSignature);
        }
    }
}
