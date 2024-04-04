using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace SL_WApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        [HttpGet]
        [Route("api/Autor/GetAllAutor")]
        public ActionResult GetAll()
        {
            ML.Autor autor = new ML.Autor();
            Dictionary<string, object> resultado = BL.Autor.GetAll();
            bool result = (bool)resultado["Resultado"];
            if (result)
            {
                autor = (ML.Autor)resultado["Autor"];
               //return Content(HttpStatusCode.OK, autor);
                return Ok(autor);

            }
            else
            {
                return BadRequest("Error");
            }
        }


        [HttpPost]
        [Route("api/Autor/Add")]
        public IActionResult Add([FromBody] ML.Autor autor)
        {
            Dictionary<string, object> resultado = BL.Autor.Add(autor);
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

        [HttpDelete]
        [Route("api/Autor/Delete/{IdAutor}")]
        public IActionResult Delete(int IdAutor)
        {
            Dictionary<string, object> resultado = BL.Autor.Delete(IdAutor);
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
