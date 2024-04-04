using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public DateTime FechaDevuelto { get; set; }

        //Propiedades de Navegacion
        public ML.Lector Lector { get; set; }
        public ML.Libro Libro { get; set; }
    }
}
