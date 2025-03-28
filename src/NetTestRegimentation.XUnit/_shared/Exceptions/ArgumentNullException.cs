﻿// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.Runtime.CompilerServices;

#if ARGUMENT_NULL_EXCEPTION_SHIM
namespace Whipstaff.Runtime.Exceptions
{
    /// <summary>
    /// Shims for ArgumentNullException to provide compatibility with NET48.
    /// </summary>
#pragma warning disable S2166 // Classes named like "Exception" should extend "Exception" or a subclass
    internal static class ArgumentNullException
#pragma warning restore S2166 // Classes named like "Exception" should extend "Exception" or a subclass
    {
        /// <summary>Throws a <see cref="T:System.ArgumentNullException" /> if <paramref name="argument" /> is <see langword="null" />.</summary>
        /// <param name="argument">The reference type argument to validate as non-null.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="argument" /> corresponds.</param>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="argument" /> is <see langword="null" />.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void ThrowIfNull(object? argument, [CallerArgumentExpression(nameof(argument))] string? paramName = null)
        {
            if (argument != null)
            {
                return;
            }

            throw new global::System.ArgumentNullException(paramName);
        }
    }
}
#endif
