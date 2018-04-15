/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Threading.Tasks;
using concepts;
using Dolittle.Collections;

namespace pipeline
{
    /// <summary>
    /// Represents an implementation of <see cref="I_can_orchestrate"/>
    /// </summary>
    public class orchestrator : I_can_orchestrate
    {
        readonly I_can_provide_operations _operations;

        /// <summary>
        /// Initializes a new instance of <see cref="orchestrator"/>
        /// </summary>
        /// <param name="operations"><see cref="I_can_provide_operations"/></param>
        public orchestrator(I_can_provide_operations operations)
        {
            _operations = operations;
        }

        /// <inheritdoc/>
        public void execute(context context)
        {
            Task.Run(() => {
                _operations.ForEach(operation => {
                    operation.perform(context);
                });
            });
        }

        /// <inheritdoc/>
        public context establish(project_id project)
        {
            var context = new context(project);
            return context;
        }
    }
}