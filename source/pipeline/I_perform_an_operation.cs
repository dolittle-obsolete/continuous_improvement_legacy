/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Threading.Tasks;

namespace pipeline
{
    /// <summary>
    /// Defines an operation in the pipeline
    /// </summary>
    public interface I_perform_an_operation
    {
        /// <summary>
        /// Perform the task
        /// </summary>
        /// <param name="context"></param>
        /// <returns>Async <see cref="Task"/>></returns>
        Task perform(context context);
    }
}