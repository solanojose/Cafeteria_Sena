using System;
using System.Collections.Generic;

namespace Gestion_Cafeteria.Models;

public partial class TGenero
{
    public int Id { get; set; }

    public string? Genero { get; set; }

    public virtual ICollection<TTrabajadore> TTrabajadores { get; set; } = new List<TTrabajadore>();
}
