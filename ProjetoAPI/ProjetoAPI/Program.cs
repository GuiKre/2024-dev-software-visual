//Testar as APIs
// - Rest Client - Extensão do VS Code
// - Postman
// - Insomnia
//MINIMAL APIs - C# - Minimal APIs

using Microsoft.AspNetCore.Mvc;
using ProjetoAPI.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


List<Produto> produtos = new List<Produto>();
produtos.Add(new Produto()
{
    Nome = "Notebook",
    Preco = 5000,
    Quantidade = 54
});
produtos.Add(new Produto()
{
    Nome = "Desktop",
    Preco = 3500,
    Quantidade = 150
});
produtos.Add(new Produto()
{
    Nome = "Monitor",
    Preco = 1200,
    Quantidade = 15
});
produtos.Add(new Produto()
{
    Nome = "Caixa de Som",
    Preco = 650,
    Quantidade = 70
});


//EndPoints - Funcionalidades
//Request - Configurar a URL e o método/verbo HTTP
//Response - Retornar os dados (json/xml) e status
app.MapGet("/", () => "API de Produtos");

//GET: /produto/listar
app.MapGet("/produto/listar", () => 
{
    if(produtos.Count > 0)
    {
    return Results.Ok(produtos);
    }
    return Results.NotFound();
});

//GET: /produto/buscar
app.MapGet("/produto/buscar/{nome}", (string nome) =>
{
    foreach(Produto produtoCadastrado in produtos)
    {
        if(produtoCadastrado.Nome == nome)
        {
            return Results.Ok(produtoCadastrado);
        }
    }
    return Results.NotFound();
});

//POST: /produto/cadastrar
app.MapPost("/produto/cadastrar", ([FromBody] Produto produto) => 
{
    //Adicionando dentro da lista
    produtos.Add(produto);
    return Results.Created("", produto);
});

//Exercicios
// - Remover produto
// - Alterar produto

app.Run();

//C# - Utilzação dos gets e sets
//  Produto produto = new Produto();
//  produto.Preco = 5;
//  produto.
//  Console.WriteLine("Preço: " + produto.Preco);

//JAVA - Utilzação dos gets e sets
// Produto produto = new Produto();
// produto.setPreco(5);
// Console.WriteLine("Preço: " + produto.getPreco());