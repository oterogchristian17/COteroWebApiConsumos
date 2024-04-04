using System;
using System.Collections.Generic;

namespace DL;

public partial class Multum
{
    public int IdMulta { get; set; }

    public string Descripción { get; set; } = null!;

    public int? IdPrestamo { get; set; }

    public virtual Prestamo? IdPrestamoNavigation { get; set; }
}
