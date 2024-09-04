﻿namespace ProjetoAPI.Models;

public class Produto
{
    //C# - Construtor da classe
    public Produto()
    {
        Id = Guid.NewGuid().ToString();
        CriadoEm = DateTime.Now;
    }
    //C# - Atributo com get e set
    public string? Id { get; set; }
    public string? Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }
    public DateTime CriadoEm { get; set; }

    //JAVA - Atributo com get e set
    // private double preco;
    // public double getPreco()
    // {
    //     return preco;
    // }
    // public void setPreco(double preco)
    // {
    //     this.preco = preco * 3;
    // }
}
