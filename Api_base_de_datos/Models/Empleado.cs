using System;
using System.Collections.Generic;

namespace Api_base_de_datos.Models;

public partial class Empleado
{
    public int IdEmpleados { get; set; }

    public int IdPuesto { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public DateOnly FechaContratacion { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual Puesto IdPuestoNavigation { get; set; } = null!;
}
