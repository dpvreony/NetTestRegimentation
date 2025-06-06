// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

#if IS_EXTERNAL_INIT_SHIM
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace System.Runtime.CompilerServices
{
    /// <summary>
    /// Enables support for C# 9/10 records on older frameworks.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ExcludeFromCodeCoverage]
    internal static class IsExternalInit
    {
    }
}
#endif
