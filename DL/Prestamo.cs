using System;
using System.Collections.Generic;

namespace DL;

public partial class Prestamo
{
    public int IdPrestamo { get; set; }

    public int IdLector { get; set; }

    public int IdLibro { get; set; }

    public DateTime FechaPrestamo { get; set; }

    public DateTime FechaDevolucion { get; set; }

    public DateTime FechaDevuelto { get; set; }

    public virtual Lector IdLectorNavigation { get; set; } = null!;

    public virtual Libro IdLibroNavigation { get; set; } = null!;

    public virtual ICollection<Multum> Multa { get; set; } = new List<Multum>();
}
