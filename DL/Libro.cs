using System;
using System.Collections.Generic;

namespace DL;

public partial class Libro
{
    public int IdLibro { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdGenero { get; set; }

    public int NumeroPaginas { get; set; }

    public int IdAutor { get; set; }

    public int IdEditorial { get; set; }

    public virtual Autor IdAutorNavigation { get; set; } = null!;

    public virtual Editorial IdEditorialNavigation { get; set; } = null!;

    public virtual Genero IdGeneroNavigation { get; set; } = null!;

    public virtual ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();
}
