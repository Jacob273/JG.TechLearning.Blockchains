using RestEase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symmetric.Client
{
    public interface IEncryptionDecryptionApi
    {
        [Get("api/encrypt")]
        Task<string> EncryptAsync([Query] string plainText);

        [Get("api/decrypt")]
        Task<string> DecryptAsync([Query] string encryptedStringBase64);
    }
}
