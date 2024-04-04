using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Lector
    {
        public static Dictionary<string, object> GetAll()
        {
            Dictionary<string, object> diccionario = new Dictionary<string, object> { { "Lector", null }, { "Exepcion", "" }, { "Resultado", false } };
            try
            {
                using (DL.BibliotecaContext context = new DL.BibliotecaContext())
                {

                    var registros = context.Lectors.FromSqlRaw("EXECUTE dbo.LectorGetAll").ToList();

                    if (registros.Count > 0)
                    {
                        ML.Lector lector1 = new ML.Lector();
                        lector1.Lectores = new List<object>();

                        foreach (var registro in registros)
                        {
                            lector1.IdLector = registro.IdLector;
                            lector1.Nombre = registro.Nombre;
                            lector1.ApellidoPaterno = registro.ApellidoPaterno;
                            lector1.ApellidoMaterno = registro.ApellidoMaterno;

                            lector1.Lectores.Add(registro);
                        }
                        diccionario["Resultado"] = true;
                        diccionario["Lector"] = lector1;
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










    }
}
