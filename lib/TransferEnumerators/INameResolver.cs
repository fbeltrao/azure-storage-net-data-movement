//------------------------------------------------------------------------------
// <copyright file="INameResolver.cs" company="Microsoft">
//    Copyright (c) Microsoft Corporation
// </copyright>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Storage.DataMovement.TransferEnumerators
{
    /// <summary>
    /// INameResolver interface.
    /// </summary>
    public interface INameResolver
    {
        /// <summary>
        /// Resolve the destination name.
        /// </summary>
        /// <param name="sourceEntry">The transfer entity to resolve name for.</param>
        /// <returns>The blob resolved name.</returns>
        string ResolveName(TransferEntry sourceEntry);
    }
}
