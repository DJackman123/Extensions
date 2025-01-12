﻿//---------------------------------------------------------------------
// <copyright file="IODataClientActivator.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

namespace Microsoft.Extensions.OData.Client
{
    using System;
    using Microsoft.OData.Client;

    /// <summary>
    /// An activator that's responsible solely to create the raw <see cref="DataServiceContext"/> instances.
    /// </summary>
    public interface IODataClientActivator
    {
        /// <summary>
        /// Creates an <see cref="DataServiceContext"/> instance.
        /// </summary>
        /// <param name="serviceRoot">An absolute URI that identifies the root of a data service.</param>
        /// <typeparam name="T">The concrate type generated by the OData Client code generatator.</typeparam>
        /// <returns>The default <see cref="DataServiceContext"/> instance.</returns>
        T CreateClient<T>(Uri serviceRoot) where T : DataServiceContext;
    }
}
