/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using concepts;

namespace pipeline
{
    /// <summary>
    /// Represents an implementation of <see cref="I_can_orchestrate"/>
    /// </summary>
    public class orchestrator : I_can_orchestrate
    {
        /// <inheritdoc/>
        public void execute(context context)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public context establish(project_id project)
        {
            throw new System.NotImplementedException();
        }
    }
}