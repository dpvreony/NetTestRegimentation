// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace NetTestRegimentation.XUnit.Theories.ArgumentNullException
{
    /// <summary>
    /// Theory Data for testing a method that validates the 2 arguments that are not null.
    /// </summary>
    /// <typeparam name="T1">The type for the 1st parameter that should not be null.</typeparam>
    /// <typeparam name="T2">The type for the 2nd parameter that should not be null.</typeparam>
    public class ArgumentNullExceptionTheoryData<T1, T2>
        : global::Xunit.TheoryData<T1?, T2?, string>
        where T1 : notnull
        where T2 : notnull
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentNullExceptionTheoryData{T1, T2}"/> class.
        /// </summary>
        /// <param name="parameter1Input">Information for the 1st parameter that should not be null.</param>
        /// <param name="parameter2Input">Information for the 2nd parameter that should not be null.</param>
        public ArgumentNullExceptionTheoryData(
            NamedParameterInput<T1> parameter1Input,
            NamedParameterInput<T2> parameter2Input)
        {
            Whipstaff.Runtime.Exceptions.ArgumentNullException.ThrowIfNull(parameter1Input);

            Whipstaff.Runtime.Exceptions.ArgumentNullException.ThrowIfNull(parameter2Input);

            Add(default, parameter2Input.ValidValue(), parameter1Input.Name);
            Add(parameter1Input.ValidValue(), default, parameter2Input.Name);
        }
    }
}
