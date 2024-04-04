using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Prestamo
    {
        public static Dictionary<string, object> Add(ML.Prestamo prestamo)
        {
            Dictionary<string, object> diccionario = new Dictionary<string, object> { { "Excepcion", "" }, { "Resultado", false } };

            try
            {
                //AQUI CAMBIA EL USING A DL
                using (DL.BibliotecaContext context = new DL.BibliotecaContext())
                {

                    //AQUI CAMBIA LA SENTENCIA PARA LLAMAR AL STORE PROCEDURE
                    var filasAfectadas = context.Database.ExecuteSqlRaw($"PrestamoAdd '{prestamo.Lector.IdLector}', '{prestamo.Libro.IdLibro}','{prestamo.FechaPrestamo}','{prestamo.FechaDevolucion}','{prestamo.FechaDevuelto}'");

                    //Validar si las filas fueron afectadas
                    if (filasAfectadas > 0)
                    {
                        diccionario["Resultado"] = true;
                    }
                    else
                    {
                        diccionario["Resultado"] = false;
                    }
                }
            }
            catch (Exception ex) //SI FALLÓ ALGO
            {
                diccionario["Resultado"] = false;
                diccionario["Excepcion"] = ex.Message;

            }
            return diccionario;
        }


    }
}
