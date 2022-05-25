using Asymmetric.Implementation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Asymmetric.Server.Controllers
{
    [Route("api")]
    [ApiController]
    public class PublicKeyEncryptionController : ControllerBase
    {
        [HttpGet("get/encrypted-message")]
        public async Task<IActionResult> GetMessageEncryptedWithPublicKeyAsync()
        {
            string secretMessage = "This message is very urgent.";

            RSAEncryptor cryptor = new();
            cryptor.InitializePublicKey();

            var messageAsBytes = Encoding.UTF8.GetBytes(secretMessage);
            var encryptedBytes = cryptor.Encrypt(messageAsBytes);
            var encryptedTextBase64 = Convert.ToBase64String(encryptedBytes);
            return Ok(await Task.Run(() => encryptedTextBase64));
        }
    }
}
