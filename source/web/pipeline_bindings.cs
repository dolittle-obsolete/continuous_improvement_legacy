/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using Dolittle.DependencyInversion;
using pipeline;

namespace web
{
    /// <summary>
    /// Provides bindings for the pipeline
    /// </summary>
    public class pipeline_bindings : ICanProvideBindings
    {
        /// <inheritdoc/>
        public void Provide(IBindingProviderBuilder builder)
        {
            builder.Bind<I_can_provide_operations>().To<operations_provider>().Singleton();
        }
    }
}