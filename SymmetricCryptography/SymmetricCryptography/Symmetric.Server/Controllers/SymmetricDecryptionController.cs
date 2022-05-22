using Microsoft.AspNetCore.Mvc;
using Symmetric.Implementation;
using System.Threading.Tasks;

namespace Symmetric.Server.Controllers
{
    [Route("api")]
    [ApiController]
    public class SymmetricDecryptionController : ControllerBase
    {
        [HttpGet("decrypt")]
        public async Task<IActionResult> DecryptAsync([FromQuery] string encryptedStringBase64)
        {
            if (string.IsNullOrEmpty(encryptedStringBase64))
            {
                return NotFound();
            }

            AesDecryptor aesDecryptor = new AesDecryptor();
            return Ok(await Task.Run(() => aesDecryptor.DecryptData(encryptedStringBase64)));
        }
    }
}
