using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Konfigurer tjenester her, f.eks. autentificering, autorisation osv.
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            // Konfigurer fejlhåndtering i produktionsmiljøet
        }

        // Konfigurer middleware og rutehåndtering her
    }
}
