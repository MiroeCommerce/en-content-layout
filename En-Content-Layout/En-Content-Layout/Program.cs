using En_Content_Layout_Application_Layer;
using En_Content_Layout_Application_Layer.Interfaces;
using En_Content_Layout_Domain_Layer.Interfaces;
using En_Content_Layout_Infrastructure_Layer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<ContentLayoutContext>();

builder.Services.AddScoped<IContentLayoutService, ContentLayoutService>();

builder.Services.AddScoped<IContentLayoutRepository, ContentLayoutRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
