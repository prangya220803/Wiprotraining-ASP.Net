using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddHttpsRedirection(options => { options.HttpsPort = 5001; });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Middleware 1: Log request + response
        app.Use(async (context, next) =>
        {
            Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");
            await next.Invoke();
            Console.WriteLine($"Response: {context.Response.StatusCode}");
        });

        // Middleware 2: Error page
        app.UseExceptionHandler("/error.html");

        // Middleware 3: Force HTTPS
        app.UseHttpsRedirection();

        // Middleware 4: Security (CSP)
        app.Use(async (context, next) =>
        {
            context.Response.Headers.Add("Content-Security-Policy", "default-src 'self'");
            await next();
        });

        // Middleware 5: Serve static files
        app.UseStaticFiles();

        // Middleware 6: Default response
        app.Run(async context =>
        {
            await context.Response.WriteAsync("Hello from Middleware!");
        });
    }
}