/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Collections.Generic;
using concepts;

namespace pipeline
{
    /// <summary>
    /// Represents the context for a pipe orchestration
    /// </summary>
    public class context
    {
        Dictionary<string, object>  _values = new Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of <see cref="context"/>
        /// </summary>
        /// <param name="project"><see cref="project_id">Project identifier</see></param>
        public context(project_id project)
        {
            project_id = project;
        }

        /// <summary>
        /// Gets the <see cref="project_id"/> for the project
        /// </summary>
        public project_id project_id { get;}


        /// <summary>
        /// Set a value with a given key
        /// </summary>
        /// <param name="key">Key of the value to set</param>
        /// <param name="value">Value - any type</param>
        public void set<T>(string key, T value)
        {
            _values[key] = value;
        }

        /// <summary>
        /// Get a value with a specific key and specified type
        /// </summary>
        /// <param name="key">Key representing the value</param>
        /// <returns>Type specific value</returns>
        public T get<T>(string key)
        {
            return (T)_values[key];
        }
    }
}