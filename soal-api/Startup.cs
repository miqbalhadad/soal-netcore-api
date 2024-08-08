using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using ProductApi.Data;
using Microsoft.OpenApi.Models;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // Metode ini digunakan untuk menambahkan layanan ke container.
    public void ConfigureServices(IServiceCollection services)
    {
        // Menambahkan layanan controller MVC ke container.
        services.AddControllers();

        // Menambahkan ProductContext ke container dan mengkonfigurasi untuk menggunakan database in-memory.
        services.AddDbContext<ProductContext>(options =>
            options.UseInMemoryDatabase("ProductList"));

        // Menambahkan Swagger
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Product API", Version = "v1" });
        });
    }

    // Metode ini digunakan untuk mengkonfigurasi pipeline HTTP request.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthorization();

        // Menggunakan middleware Swagger
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Product API V1");
            c.RoutePrefix = string.Empty; // Set Swagger UI pada root
        });

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
