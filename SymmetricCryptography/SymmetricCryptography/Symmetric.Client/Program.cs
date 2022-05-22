using RestEase;
using System;
using System.Threading.Tasks;

namespace Symmetric.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Press Enter to make API CALL to encrypt data and then decrypt afterwards.");
            Console.ReadLine();

            await VerifyEncryptionDecryptionAPIAsync();

            Console.WriteLine("Press any key to close application.");
            Console.ReadLine();
        }

        public static async Task VerifyEncryptionDecryptionAPIAsync()
        {
            IEncryptionDecryptionApi api = RestClient.For<IEncryptionDecryptionApi>("http://localhost:6200");

            var plainTextForEncryption = "I am symmetric..";
            Console.WriteLine($"original text: {plainTextForEncryption}");

            var encryptedText = await api.EncryptAsync(plainTextForEncryption);
            Console.WriteLine($"encrypted text: {encryptedText}");

            var decryptedText = await api.DecryptAsync(encryptedText);
            Console.WriteLine($"decrypted data: {decryptedText}");
        }
    }
}
