using Microsoft.AspNetCore.Mvc;
using Symmetric.Implementation;
using System.Threading.Tasks;

namespace Symmetric.Server.Controllers
{
    [Route("api")]
    [ApiController]
    public class SymmetricEncryptionController : ControllerBase
    {
        [HttpGet("encrypt")]
        public async Task<IActionResult> EncryptAsync([FromQuery]  string plainText)
        {
            if (string.IsNullOrEmpty(plainText))
            {
                return NotFound();
            }

            AesEncryptor aesEncryptor = new AesEncryptor();
            return Ok(await Task.Run(() => aesEncryptor.EncryptString(plainText)));
        }
    }
}
