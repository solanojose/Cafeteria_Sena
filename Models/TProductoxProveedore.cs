using System;
using System.Collections.Generic;

namespace Gestion_Cafeteria.Models;

public partial class TProductoxProveedore
{
    public int Id { get; set; }

    public int? IdProducto { get; set; }

    public int? IdProveedor { get; set; }

    public virtual TProducto? IdProductoNavigation { get; set; }

    public virtual TProveedore? IdProveedorNavigation { get; set; }
}
