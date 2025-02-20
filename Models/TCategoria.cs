﻿using System;
using System.Collections.Generic;

namespace Gestion_Cafeteria.Models;

public partial class TCategoria
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<TProducto> TProductos { get; set; } = new List<TProducto>();
}
