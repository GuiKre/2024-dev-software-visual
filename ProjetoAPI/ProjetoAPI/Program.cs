//Testar as APIs
// - Rest Client - Extensão do VS Code
// - Postman
// - Insomnia
//MINIMAL APIs - C# - Minimal APIs

using Microsoft.AspNetCore.Mvc;
using ProjetoAPI.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDataContext>();
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
//Response - Retornar os dados (json/xml) e códigos de status HTTP
app.MapGet("/", () => "API de Produtos");

//GET: /produto/listar
app.MapGet("/produto/listar", ([FromServices] AppDataContext ctx) => 
{
    if(ctx.Produtos.Any())
    {
    return Results.Ok(ctx.Produtos.ToList());
    }
    return Results.NotFound();
});

//GET: /produto/buscar
app.MapGet("/produto/buscar/{id}", ([FromRoute] string id, [FromServices] AppDataContext ctx) =>
{
    //Expressão lambda em C#
    //Produto? produto = ctx.Produtos.FirstOrDefault(x => x.Nome == "Variável com o nome do produto");
    //List<Produto> lista = ctx.Produtos.Where(x => x.Quantidade > 10).ToList();
    Produto? produto = ctx.Produtos.Find(id);
    if (produto == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(produto);
});

//BUSCAR PELO ID
// app.MapGet("/produto/buscar/{id}", ([FromRoute] string id) =>
// {
//     Expressão lambda em C#    
//     Produto? produto = produtos.Find(x => x.Id == id);
//     if (produto ==null)
//     {
//         return Results.NotFound();
//     }
//     return Results.Ok(produto);
// });

//POST: /produto/cadastrar
app.MapPost("/produto/cadastrar", ([FromBody] Produto produto, [FromServices] AppDataContext ctx) => 
{
    //Adicionando dentro da lista
    ctx.Produtos.Add(produto);
    ctx.SaveChanges();
    return Results.Created("", produto);
});

//DELETE: /produto/deletar/{id}
app.MapDelete("/produto/deletar/{id}", ([FromRoute] string id) =>
{
    Produto? produto = produtos.Find(x => x.Id == id);
    if (produto == null)
    {
        return Results.NotFound();
    }
    produtos.Remove(produto);
    return Results.Ok(produto);
});

//PUT: /produto/alterar/{id}
app.MapPut("/produto/alterar/{id}", ([FromRoute] string id, [FromBody] Produto produtoAlterado) =>
{
    Produto? produto = produtos.Find(x => x.Id == id);
    if (produto == null)
    {
        return Results.NotFound();
    }
    produto.Nome = produtoAlterado.Nome;
    produto.Quantidade = produtoAlterado.Quantidade;
    produto.Preco = produtoAlterado.Preco;
    return Results.Ok(produto);
});

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