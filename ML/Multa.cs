using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Multa
    {
        public int IdMulta { get; set; }

        public string Descripcion { get; set; }

        public List<object> Multas { get; set; }

        //Propiedades de Navegacion
        public ML.Prestamo Prestamo { get; set; }


    }
}
