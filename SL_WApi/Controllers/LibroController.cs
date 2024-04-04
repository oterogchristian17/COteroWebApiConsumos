using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SL_WApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        //[HttpGet]
        //[Route("api/Librp/GetAll")]
        //public ActionResult GetAll()
        //{
        //    ML.Libro libro = new ML.Libro();
        //    Dictionary<string, object> resultado = BL.Libro.GetAll();
        //    bool result = (bool)resultado["Resultado"];
        //    if (result)
        //    {
        //        libro = (ML.Libro)resultado["Libro"];
        //        //return Content(HttpStatusCode.OK, autor);
        //        return Ok(libro);

        //    }
        //    else
        //    {
        //        return BadRequest("Error");
        //    }
        //}


    }
}
