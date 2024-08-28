//Testar as APIs
// - Rest Client - Extensão do VS Code
// - Postman
// - Insomnia
//MINIMAL APIs
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//EndPoints - Funcionalidades
//Configurar a URL e o método/verbo
app.MapGet("/", () => "Primeira funcionalidade");

app.MapGet("/segundafuncionalidade", () => "Segunda funcionalidade");

app.MapGet("/retornarendereco", () =>
{
    dynamic endereco = new {
        rua = "Parigot de Souza",
        numero = 5300,
        cep = "81290-350"
    };
    return endereco;
});

//Criar uma funcionalidade para receber informações
// - Receber informações pela URL da requisição
// - Receber informações pelo corpo da requisição
// - Guardar as informações em uma lista

app.Run();
