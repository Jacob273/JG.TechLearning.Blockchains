using System.Security.Cryptography;

namespace Asymmetric.Implementation
{
    public class RSAEncryptor
    {
        private readonly RSACryptoServiceProvider _rsa = new();

        public void InitializePublicKey()
        {
            var publicKey = AsymmetricKeyInformation.RsaPublicKeyPemInBase64;
            _rsa.ImportFromPem(publicKey);
        }

        public byte[] Encrypt(byte[] data)
        {
            return _rsa.Encrypt(data, fOAEP: false); ;
        }
    }
}
