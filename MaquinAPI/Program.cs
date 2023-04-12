// APPLICATION BUILDER
var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
}

// REQUEST MANAGEMENT
var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
