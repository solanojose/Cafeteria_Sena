using System;
using System.Collections.Generic;

namespace Gestion_Cafeteria.Models;

public partial class TTiposDoc
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<TTrabajadore> TTrabajadores { get; set; } = new List<TTrabajadore>();
}
