using System;
using System.Collections.Generic;

namespace Api_base_de_datos.Models;

public partial class DetalleFactura
{
    public int IdDetalles { get; set; }

    public int IdFactura { get; set; }

    public int IdProducto { get; set; }

    public int Cantidad { get; set; }

    public float PrecioUnitario { get; set; }

    public float Subtotal { get; set; }

    public virtual Factura IdFacturaNavigation { get; set; } = null!;

    public virtual Producto IdProductoNavigation { get; set; } = null!;
}
