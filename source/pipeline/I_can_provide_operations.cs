/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Collections.Generic;

namespace pipeline
{
    /// <summary>
    /// Defines a system that can provide <see cref="I_perform_an_operation">operations</see>
    /// </summary>
    public interface I_can_provide_operations : IEnumerable<I_perform_an_operation>
    {
         
    }
}