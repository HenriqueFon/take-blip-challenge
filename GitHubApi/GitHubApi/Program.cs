using GitHubApi.Facade;
using GitHubApi.Services;

using RestEase;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton(RestClient.For<IGitHubRepository> ("https://api.github.com")) ;
builder.Services.AddSingleton<IRepositoriesApiFacade, RepositoriesApiFacade>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
