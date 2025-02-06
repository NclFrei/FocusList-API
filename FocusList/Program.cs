using FocusList.Shared.Dados.Banco;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<FocusListContext>();

var app = builder.Build();

app.Run();
