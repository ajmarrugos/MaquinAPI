using MaquinAPI.Services;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers().AddNewtonsoftJson();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
            {
                Title = "MaquinAPI",
                Description = "A simple REST API project demo, engineered in C# and assembled with ASP.NET Core",
                Contact = new Microsoft.OpenApi.Models.OpenApiContact
                {
                    Name = "Alberto Marrugo",
                    Url = new Uri("https://github.com/ajmarrugos/MaquinAPI"),
                },
                License = new Microsoft.OpenApi.Models.OpenApiLicense
                {
                    Name = "MIT License",
                    Url = new Uri("https://opensource.org/licenses/MIT"),
                },
                Version = "v1"
            });

            // Generate XML Doc to drive swagger docs
            var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

            c.IncludeXmlComments(xmlPath);
        });
        builder.Services.AddHttpClient("jsonplaceholder", c =>
        {
            c.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
        });
        builder.Services.AddScoped<ApiService>();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}
