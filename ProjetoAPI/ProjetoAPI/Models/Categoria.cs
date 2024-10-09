using System;

namespace ProjetoAPI.Models;

public class Categoria
{
    public int CategoriaId { get; set; }
    public string? MyProperty { get; set; }
    public DateTime CriadoEm { get; set; } = DateTime.Now;
}
