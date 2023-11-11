var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();

/*
app.MapGet("/", () => "Hello World!");

app.MapGet("/nome={nome}", (string nome) => 
{
    return Results.Ok($"Olá, {nome}");
});

List<Usuario> listaUsuarios = new List<Usuario>();

app.MapGet("/usuario/", () => 
{
    return Results.Ok(listaUsuarios);
});

app.MapPost("/", (Usuario usuario) => 
{
    usuario.Id = listaUsuarios.Count + 1;
    listaUsuarios.Add(usuario);

    return Results.Ok(usuario);
});
*/

app.Run();

// public class Usuario
// {
//     public int Id { get; set; }
//     public string Nome { get; set; }
// }
