using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Libro
    {

        public static Dictionary<string, object> GetAll()
        {
            Dictionary<string, object> diccionario = new Dictionary<string, object> { { "Libro", null }, { "Exepcion", "" }, { "Resultado", false } };
            try
            {
                using (DL.BibliotecaContext context = new DL.BibliotecaContext())
                {

                     var registros = context.Libros.FromSqlRaw("EXECUTE dbo.LibroGetAll").ToList();

                    //var registros = (from Libro in context.Libros
                    //             join Genero in context.Generos on Libro.IdGenero equals Genero.IdGenero
                    //             join Autor in context.Autors on Libro.IdAutor equals Autor.IdAutor
                    //             join Editorial in context.Editorials on Libro.IdEditorial equals Editorial.IdEditorial

                    //             select new
                    //             {
                    //                 IdLibro = Libro.IdLibro,
                    //                 Nombre = Libro.Nombre,
                    //                 IdGenero = Genero.IdGenero,
                    //                 NumeroPaginas = Libro.NumeroPaginas,
                    //                 IdAutor = Autor.IdAutor,
                    //                 IdEditorial = Editorial.IdEditorial

                    //             }).ToList();

                    if (registros != null)
                    {
                        ML.Libro libro1 = new ML.Libro();
                        libro1.Libros = new List<object>();

                        foreach (var registro in registros)
                        {
                            //Instanciar el objeto
                            ML.Libro libro = new ML.Libro();

                            libro1.IdLibro = registro.IdLibro;
                            libro1.Nombre = registro.Nombre;
                            libro1.NumPaginas = registro.NumeroPaginas;

                            //AQUI VA LA PROPIEDAD DE NAVEGACION
                            libro1.Genero = new ML.Genero();
                            libro1.Genero.IdGenero = registro.IdGenero;

                            libro1.Autor = new ML.Autor();
                            libro1.Autor.IdAutor = registro.IdAutor;

                            libro1.Editorial = new ML.Editorial();
                            libro1.Editorial.IdEditorial = registro.IdEditorial;



                            libro1.Libros.Add(registro);
                        }
                        diccionario["Resultado"] = true;
                        diccionario["Libro"] = libro1;
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception)
            {


            }
            return diccionario;
        }

    }
}
