// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using Microsoft;
using NetTestRegimentation.XUnit.Runtime;

namespace NetTestRegimentation.XUnit.Theories.ArgumentNullException
{
    /// <summary>
    /// Theory Data for testing a method that validates the 1 argument is not null.
    /// </summary>
    /// <typeparam name="T">The type for the parameter that should not be null.</typeparam>
    public class ArgumentNullExceptionTheoryData<T>
        : global::Xunit.TheoryData<T?, string>
        where T : notnull
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentNullExceptionTheoryData{T}"/> class.
        /// </summary>
        /// <param name="parameterName">Name of the parameter that should throw the <see cref="ArgumentNullException"/>.</param>
        public ArgumentNullExceptionTheoryData([ValidatedNotNull]string parameterName)
        {
            parameterName.ThrowIfNullOrWhitespace(nameof(parameterName));

            Add(default, parameterName);
        }
    }
}
