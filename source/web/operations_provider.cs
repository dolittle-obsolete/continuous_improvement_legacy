/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using System.Collections;
using System.Collections.Generic;
using Dolittle.DependencyInversion;
using pipeline;

namespace web
{
    /// <summary>
    /// Represents an implementation of <see cref="I_can_provide_operations"/>
    /// </summary>
    public class operations_provider : I_can_provide_operations
    {
        readonly IContainer _container;
        readonly IEnumerable<Type> _types;

        /// <summary>
        /// Initializes a new instance of <see cref="operations_provider"/>
        /// </summary>
        /// <param name="container"><see cref="IContainer"/> to get instances of <see cref="I_can_provide_operations"/> implementations</param>
        public operations_provider(IContainer container)
        {
            _container = container;

            _types = new[] {
                typeof(github.get_code_from_repository)
            };
        }

        /// <inheritdoc/>
        public IEnumerator<I_perform_an_operation> GetEnumerator()
        {
            foreach (var type in _types) yield return _container.Get(type) as I_perform_an_operation;
        }

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var type in _types) yield return _container.Get(type);
        }
    }
}