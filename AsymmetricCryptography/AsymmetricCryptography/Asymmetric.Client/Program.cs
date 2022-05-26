using Asymmetric.Implementation;
using RestEase;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Symmetric.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("1# Press Enter to make API CALL to retrieve message encrypted with public key.");
            Console.ReadLine();

            string encryptedTextBase64 = await GetEncryptedMessageFromAPI();
            DecryptMessage(encryptedTextBase64);

            Console.WriteLine("2# Press Enter to make API CALL to retrieve signed message.");

            SignedMessage signedMessage = await GetSignedMessageAsync();
            VerifyMessage(signedMessage);

            Console.WriteLine("Press any key to close application.");
            Console.ReadLine();
        }

        private static void VerifyMessage(SignedMessage signedMessage)
        {
            Console.WriteLine("Verifying signed message.");

            RSAVerifier verifier = new();
            verifier.InitializePublicKey();

            var messageVerificationResult = verifier.Verify(signedMessage.Message, signedMessage.SignatureBase64);
            Console.WriteLine($"Message, is from a trustful source: [{messageVerificationResult}]");
        }

        private static async Task<SignedMessage> GetSignedMessageAsync()
        {
            PublicKeyEncryptionAPI api = RestClient.For<PublicKeyEncryptionAPI>("http://localhost:6300");
            var signedMessage = await api.GetSignedMessageAsync();
            Console.WriteLine($"message text: {signedMessage.Message}");
            Console.WriteLine($"signature: {signedMessage.SignatureBase64}");
            return signedMessage;
        }

        private static void DecryptMessage(string encryptedTextBase64)
        {
            RSADecryptor decryptor = new();
            decryptor.InitializePrivateKey();

            var decryptedDataBytes = decryptor.Decrypt(System.Convert.FromBase64String(encryptedTextBase64));
            Console.WriteLine($"decrypted data: {Encoding.UTF8.GetString(decryptedDataBytes)}");
        }

        private static async Task<string> GetEncryptedMessageFromAPI()
        {
            PublicKeyEncryptionAPI api = RestClient.For<PublicKeyEncryptionAPI>("http://localhost:6300");
            var encryptedTextBase64 = await api.GetMessageEncryptedWithPublicKeyAsync();
            Console.WriteLine($"encrypted text: {encryptedTextBase64}");
            return encryptedTextBase64;
        }
    }
}
