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
            Console.WriteLine("Press Enter to make API CALL to retrieve message encrypted with public key.");
            Console.ReadLine();

            string encryptedTextBase64 = await GetEncryptedMessageFromAPI();

            DecryptMessage(encryptedTextBase64);

            Console.WriteLine("Press any key to close application.");
            Console.ReadLine();
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
