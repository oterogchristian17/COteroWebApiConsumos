using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SL_WApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LectorController : ControllerBase
    {


        [HttpGet]
        [Route("api/Lector/GetAll")]
        public ActionResult GetAll()
        {
            ML.Lector lector = new ML.Lector();
            Dictionary<string, object> resultado = BL.Lector.GetAll();
            bool result = (bool)resultado["Resultado"];
            if (result)
            {
                lector = (ML.Lector)resultado["Lector"];
                //return Content(HttpStatusCode.OK, autor);
                return Ok(lector);

            }
            else
            {
                return BadRequest("Error");
            }
        }











    }
}
