using System;
using System.Collections.Generic;

namespace Api_base_de_datos.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string Nit { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string? Email { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}
