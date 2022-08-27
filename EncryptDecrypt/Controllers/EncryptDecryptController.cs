using EncryptDecrypt.Models;
using Microsoft.AspNetCore.Mvc;

namespace EncryptDecrypt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EncryptDecryptController : ControllerBase
    {
        [HttpGet, Route("Encrypt")]
        public string Encrypt(string text)
        {
            var encryptString = EncryptDecryptManager.Encrypt(text);
            return encryptString;
        }

        [HttpGet, Route("Decrypt")]
        public string Decrypt(string text)
        {
            var decryptString = EncryptDecryptManager.Decrypt(text);
            return decryptString;
        }
    }
}
