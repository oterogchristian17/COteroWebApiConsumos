using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SL_WApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrestamoController : ControllerBase
    {

        [HttpPost]
        [Route("api/Prestamo/Add")]
        public IActionResult Add([FromBody] ML.Prestamo prestamo)
        {
            Dictionary<string, object> resultado = BL.Prestamo.Add(prestamo);
            bool result = (bool)resultado["Resultado"];
            if (result)
            {
                return Ok(resultado);
            }
            else
            {
                return BadRequest((string)resultado["Resultado"]);
            }
        }
    }
}
