using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace projetoDaniel
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<Data.ProjectTestDataContext>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, Data.ProjectTestDataContext ctx)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                Data.DbInitializer.Init(ctx); 
            }

            app.UseStaticFiles();
            app.UseNodeModules(env.ContentRootPath);

            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                context.Response.StatusCode = 404;
                await context.Response.WriteAsync("Not Found!");
            });
        }
    }
}
