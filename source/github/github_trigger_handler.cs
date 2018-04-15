/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using System.Text;
using System.Threading.Tasks;
using infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using pipeline;

namespace github
{
    /// <summary>
    /// <see cref="I_can_handle_route">Route handler</see> for Github triggered builds
    /// </summary>
    public class github_trigger_handler : I_can_handle_route
    {
        /// <summary>
        /// The name of the value expected in the route for project
        /// </summary>
        public const string project_route_value_name = "project";

        readonly I_can_orchestrate _orchestrator;

        /// <summary>
        /// Initializes a new instance of <see cref="github_trigger_handler"/>
        /// </summary>
        /// <param name="orchestrator"><see cref="I_can_orchestrate">Orchestrator</see></param>
        public github_trigger_handler(I_can_orchestrate orchestrator)
        {
            _orchestrator = orchestrator;
        }

        /// <inheritdoc/>
        public async Task handle(HttpRequest request, HttpResponse response, RouteData routeData)
        {
            var @event = request.Headers["X - GitHub - Event "];
            var delivery = request.Headers["X - GitHub - Delivery "];
            var signature = request.Headers["X - Hub - Signature "];

            var project_id = Guid.Parse(routeData.Values[project_route_value_name].ToString());

            var content = new byte[request.ContentLength.Value];
            await request.Body.ReadAsync(content, 0, content.Length);
            var json = Encoding.UTF8.GetString(content);
            var payload = JsonConvert.DeserializeObject<payload>(json);
            var context = _orchestrator.establish(project_id);

            response.StatusCode = StatusCodes.Status200OK;
            await Task.CompletedTask;
        }
    }
}