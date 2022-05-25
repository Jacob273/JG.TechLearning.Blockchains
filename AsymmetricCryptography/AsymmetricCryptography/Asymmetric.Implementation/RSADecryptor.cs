using System.Security.Cryptography;

namespace Asymmetric.Implementation
{
    public class RSADecryptor
    {
        private readonly RSACryptoServiceProvider _rsa = new();

        public void InitializePrivateKey()
        {
            var privateKey = AsymmetricKeyInformation.RsaPrivateKeyPemInBase64;
            _rsa.ImportFromPem(privateKey);
        }

        public byte[] Decrypt(byte[] data)
        {
            return _rsa.Decrypt(data, fOAEP: false);
        }
    }
}
