/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using Microsoft.AspNetCore.Builder;
using infrastructure;

namespace Microsoft.AspNetCore.Routing
{
    /// <summary>
    /// Extensions for <see cref="RouteBuilder"/>
    /// </summary>
    public static class route_builder_extensions
    {
        /// <summary>
        /// Map a Post method to a <see cref="I_can_handle_route"/>
        /// </summary>
        /// <typeparam name="T">Type of <see cref="I_can_handle_route"/> to map to</typeparam>
        /// <param name="routeBuilder"><see cref="RouteBuilder"/> to extend</param>
        /// <param name="application"><see cref="IApplicationBuilder"/> application it is for</param>
        /// <param name="template">Path template</param>
        public static void MapPost<T>(this RouteBuilder routeBuilder, IApplicationBuilder application, string template) where T:I_can_handle_route
        {
            routeBuilder.MapPost(template, async (request, response, routeData) => {
                var handler = (T)application.ApplicationServices.GetService(typeof(T));
                await handler.handle(request, response, routeData);
            });
        }
    }
}
