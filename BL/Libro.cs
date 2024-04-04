using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Libro
    {

        //public static Dictionary<string, object> GetAll()
        //{
        //    Dictionary<string, object> diccionario = new Dictionary<string, object> { { "Libro", null }, { "Exepcion", "" }, { "Resultado", false } };
        //    try
        //    {
        //        using (DL.BibliotecaContext context = new DL.BibliotecaContext())
        //        {
        //            var registros = (from libro in context.Libros
        //                             select new
        //                             {
        //                                 IdAutor = autor.IdAutor,
        //                                 Nombre = autor.Nombre,
        //                                 ApellidoPaterno = autor.ApellidoPaterno,
        //                                 ApellidoMaterno = autor.ApellidoMaterno,
        //                             }).ToList();

        //            if (registros.Count > 0)
        //            {
        //                ML.Autor autor1 = new ML.Autor();
        //                autor1.Autores = new List<object>();

        //                foreach (var registro in registros)
        //                {
        //                    autor1.IdAutor = registro.IdAutor;
        //                    autor1.Nombre = registro.Nombre;
        //                    autor1.ApellidoPaterno = registro.ApellidoPaterno;
        //                    autor1.ApellidoMaterno = registro.ApellidoMaterno;

        //                    autor1.Autores.Add(registro);
        //                }
        //                diccionario["Resultado"] = true;
        //                diccionario["Autor"] = autor1;
        //            }
        //            else
        //            {

        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        diccionario["Excepcion"] = ex;

        //    }
        //    return diccionario;
        //}














    }
}
