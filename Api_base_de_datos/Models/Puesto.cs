using System;
using System.Collections.Generic;

namespace Api_base_de_datos.Models;

public partial class Puesto
{
    public int IdPuestos { get; set; }

    public string Nombre { get; set; } = null!;

    public string SalarioBase { get; set; } = null!;

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}
