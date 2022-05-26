using Asymmetric.Implementation;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Asymmetric.Server.Controllers
{
    [Route("api")]
    [ApiController]
    public class SigningController : ControllerBase
    {
        [HttpGet("get/signed-message")]
        public async Task<IActionResult> GetSignedMessageAsync()
        {
            string plainMessage = "This message is signed.";

            RSASigner signer = new();
            signer.InitializePrivateKey();

            var base64Signature = signer.Sign(plainMessage);

            return Ok(await Task.Run(() => new SignedMessage()
            {
                Message = plainMessage,
                SignatureBase64 = base64Signature
            }));
        }
    }
}
