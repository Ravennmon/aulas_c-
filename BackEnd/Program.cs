var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Produto> produto = new List<Produto>(){

    new Produto("Celular", "Android"),
    new Produto("Notebook", "Dell"),
    new Produto("Garrafa", "Stanley"),
};

//End Point = Funcionalidades

app.MapGet("/", () => "Projeto A de backend!");

app.MapGet("/api/produto", () => produto);

app.Run();

public record Produto(string Nome, string Descricao);


