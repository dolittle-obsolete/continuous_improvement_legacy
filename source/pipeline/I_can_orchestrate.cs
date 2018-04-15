/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using concepts;

namespace pipeline
{
    /// <summary>
    /// Defines the orchestrator for the pipeline
    /// </summary>
    public interface I_can_orchestrate
    {
        /// <summary>
        /// Establish an orchestration context
        /// </summary>
        /// <param name="project"><see cref="project_id"/> for the project</param>
        /// <returns><see cref="context"/> for the orchestration</returns>
        context establish(project_id project);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        void execute(context context);
    }
}