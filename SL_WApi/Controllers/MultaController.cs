using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SL_WApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultaController : ControllerBase
    {

        [HttpPost]
        [Route("api/Multa/Add")]
        public IActionResult Add([FromBody] ML.Multa multa)
        {
            Dictionary<string, object> resultado = BL.Multa.Add(multa);
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
