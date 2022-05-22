using System;

namespace Symmetric.Implementation
{
    public static class HexHelper
    {
        public static byte[] GetByteArrayFromStringHex(string hexString)
        {
            int charactersCount = hexString.Length;
            byte[] bytes = new byte[charactersCount / 2];
            for (int i = 0; i < charactersCount; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
            }

            return bytes;
        }
    }
}
