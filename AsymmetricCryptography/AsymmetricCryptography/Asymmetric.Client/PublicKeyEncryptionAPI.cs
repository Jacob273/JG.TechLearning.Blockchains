using Asymmetric.Implementation;
using RestEase;
using System.Threading.Tasks;

namespace Symmetric.Client
{
    public interface PublicKeyEncryptionAPI
    {
        [Get("api/get/encrypted-message")]
        Task<string> GetMessageEncryptedWithPublicKeyAsync();

        [Get("api/get/signed-message")]
        Task<SignedMessage> GetSignedMessageAsync();
    }
}
