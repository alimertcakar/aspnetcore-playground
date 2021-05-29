using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Api.Models;

namespace Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpGet]
        public IActionResult Hi()
        {
            return Ok("İşlem Başarılı.");
        }

        [HttpPost]
        public IActionResult Hi2([FromBody] BookPost value)
        {
            return Ok("İşlem Başarılı.");
        }
    }
}