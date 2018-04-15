/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using Dolittle.Concepts;

namespace concepts
{
    /// <summary>
    /// The concept of a unique identifier for an application
    /// </summary>
    public class project_id : ConceptAs<Guid>
    {
        /// <summary>
        /// Implicitly convert from <see cref="Guid"/> to <see cref="project_id"/>
        /// </summary>
        /// <param name="id"><see cref="Guid">Unique identifier</see></param>
        public static implicit operator project_id(Guid id) => new project_id { Value = id };
    }
}