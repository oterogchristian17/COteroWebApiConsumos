using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BL
{
    public class Autor
    {

        public static Dictionary<string, object> GetAll()
        {
            Dictionary<string, object> diccionario = new Dictionary<string, object> { { "Autor", null }, { "Exepcion", "" }, { "Resultado", false } };
            try
            {
                using (DL.BibliotecaContext context = new DL.BibliotecaContext())
                {

                    var registros = context.Autors.FromSqlRaw("EXECUTE dbo.AutorGetAll").ToList();
                  
                    if (registros.Count > 0)
                    {
                        ML.Autor autor1 = new ML.Autor();
                        autor1.Autores = new List<object>();

                        foreach (var registro in registros)
                        {
                            autor1.IdAutor = registro.IdAutor;
                            autor1.Nombre = registro.Nombre;
                            autor1.ApellidoPaterno = registro.ApellidoPaterno;
                            autor1.ApellidoMaterno = registro.ApellidoMaterno;

                            autor1.Autores.Add(registro);
                        }
                        diccionario["Resultado"] = true;
                        diccionario["Autor"] = autor1;
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                diccionario["Excepcion"] = ex;

            }
            return diccionario;
        }


        public static Dictionary<string, object> Add(ML.Autor autor)
        {
            Dictionary<string, object> diccionario = new Dictionary<string, object> { { "Excepcion", "" }, { "Resultado", false } };

            try
            {
                //AQUI CAMBIA EL USING A DL
                using (DL.BibliotecaContext context = new DL.BibliotecaContext())
                {

                    //AQUI CAMBIA LA SENTENCIA PARA LLAMAR AL STORE PROCEDURE
                    var filasAfectadas = context.Database.ExecuteSqlRaw($"AutorAdd '{autor.Nombre}', '{autor.ApellidoPaterno}','{autor.ApellidoMaterno}'");

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


        public static Dictionary<string, object> Delete(int IdUsuario)
        {

            Dictionary<string, object> diccionario = new Dictionary<string, object> { { "Exepcion", "" }, { "Resultado", false } };
            try
            {
                using (DL.BibliotecaContext context = new DL.BibliotecaContext())
                {
                    var filasAfectadas = context.Database.ExecuteSqlRaw($"AutorDelete {IdUsuario}");

                    if (filasAfectadas > 0)
                    {
                        diccionario["Resultado"] = true;
                    }
                    else
                    {

                    }
                }

            }
            catch (Exception ex)
            {
                diccionario["Exepcion"] = ex;
            }
            return diccionario;
        }





    }



}
