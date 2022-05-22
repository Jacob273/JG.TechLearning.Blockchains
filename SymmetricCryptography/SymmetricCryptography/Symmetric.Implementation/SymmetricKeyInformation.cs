namespace Symmetric.Implementation
{
    /// <summary>
    /// Generated with: openssl enc -d -a -md sha1 -aes-256-cbc -nosalt -p
    /// decryption password: 'Symmetric'
    /// </summary>
    public static class SymmetricKeyInformation
    {
        public static readonly int SymmetricKeySizeInBits = 256;
        public static readonly string AesKeyStringInHex = "20DEA5B40AA0EC8436CF915B484B1A7FE3F2305E7E387817B8AE41598C25AF8A";
        public static readonly string AesIVStringInHex = "06B76309F4870CD30763E67FDF14FDE8";

        public static readonly byte[] AesKey = HexHelper.GetByteArrayFromStringHex(AesKeyStringInHex);
        public static readonly byte[] AesIV = HexHelper.GetByteArrayFromStringHex(AesIVStringInHex);

    }
}
