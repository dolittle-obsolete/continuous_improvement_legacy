/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using Autofac;
using Dolittle.AspNetCore.Bootstrap;
using Dolittle.DependencyInversion.Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using github;

namespace web
{
    /// <summary>
    /// The startup of the Web application
    /// </summary>
    public class Startup
    {
        BootResult _bootResult;
        
        /// <summary>
        /// Configures <see cref="IServiceCollection">services</see> for the application
        /// </summary>
        /// <param name="services"><see cref="IServiceCollection"/> to configure</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();

            _bootResult = services.AddDolittle();
        }

        /// <summary>
        /// Configure the <see cref="ContainerBuilder"/> for Autofac
        /// </summary>
        /// <param name="containerBuilder"><see cref="ContainerBuilder"/> to configure</param>
        public void ConfigureContainer(ContainerBuilder containerBuilder)
        {

            containerBuilder.AddDolittle(_bootResult.Assemblies, _bootResult.Bindings);
        }


        /// <summary>
        /// Configures the <see cref="IApplicationBuilder">application</see>
        /// </summary>
        /// <param name="app"><see cref="IApplicationBuilder"/></param>
        /// <param name="env"><see cref="IHostingEnvironment"/></param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            var routeBuilder = new RouteBuilder(app);
            routeBuilder.MapPost<github_trigger_handler>(app,$"triggers/github/{{{github_trigger_handler.project_route_value_name}:guid}}");
            app.UseRouter(routeBuilder.Build());

            //app.UseDolittle();
        }
    }
}
