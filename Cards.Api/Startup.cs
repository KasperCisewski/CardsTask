using Autofac;
using Cards.Domain.ActionAggregate;
using Cards.Domain.CardsAggregate.Queries;
using Cards.Domain.CardsAggregate.Services;
using Cards.Infrastructure.CardsAggregate;
using Microsoft.OpenApi.Models;

namespace MillenniumTask;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddHttpClient();
        
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo()
            {
                Title = "Millenum Task",
                Version = "v1"
            });
        });
    }

    public void ConfigureContainer(ContainerBuilder builder)
    {
        builder.RegisterType<CardDetails>()
            .As<IAllowedActionsProvider>()
            .InstancePerLifetimeScope();

        builder.RegisterType<CardService>()
            .As<ICardService>()
            .InstancePerLifetimeScope();

        builder.RegisterType<GetAllowedActionsQuery>()
            .AsSelf()
            .InstancePerLifetimeScope();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseSwagger();  

        app.UseSwaggerUI(c =>  
        {  
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Millenum Task V1");  
            c.RoutePrefix = string.Empty;
        });  
        
        app.UseRouting();  
        app.UseEndpoints(endpoints =>  
        {  
            endpoints.MapControllers();  
        });  
    }
}