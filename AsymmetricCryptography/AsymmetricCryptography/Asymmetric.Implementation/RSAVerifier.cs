using System;
using System.Security.Cryptography;
using System.Text;

namespace Asymmetric.Implementation
{
    public class RSAVerifier
    {
        private readonly RSACryptoServiceProvider _rsa = new();

        public void InitializePublicKey()
        {
            var publicKey = AsymmetricKeyInformation.RsaPublicKeyPemInBase64;
            _rsa.ImportFromPem(publicKey);
        }

        public bool Verify(string originalMessage, string signature)
        {
            byte[] bytesToVerify = Encoding.UTF8.GetBytes(originalMessage);
            byte[] signedBytes = Convert.FromBase64String(signature);
            try
            {
                SHA512Managed Hash = new SHA512Managed();
                byte[] hashedData = Hash.ComputeHash(signedBytes);
                return _rsa.VerifyData(bytesToVerify, CryptoConfig.MapNameToOID("SHA512"), signedBytes);
            }
            catch
            {
                return false;
            }
        }
    }
}
