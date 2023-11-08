var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/nome={nome}", (string nome) => 
{
    return Results.Ok($"Olá, {nome}");
});

app.MapGet("/nome/{nome}", (string nome) => 
{
    return Results.Ok($"Olá, {nome}");
});

app.MapPost("", (Usuario usuario) => 
{
    return Results.Ok(usuario);
});

app.Run();

public class Usuario
{    
    public int Id { get; set; }
    public string Nome { get; set; }
}