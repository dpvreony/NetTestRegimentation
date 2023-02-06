// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace NetTestRegimentation.XUnit.Theories.ArgumentNullException
{
    /// <summary>
    /// Theory Data for testing a method that validates the 8 arguments that are not null.
    /// </summary>
    /// <typeparam name="T1">The type for the 1st parameter that should not be null.</typeparam>
    /// <typeparam name="T2">The type for the 2nd parameter that should not be null.</typeparam>
    /// <typeparam name="T3">The type for the 3rd parameter that should not be null.</typeparam>
    /// <typeparam name="T4">The type for the 4th parameter that should not be null.</typeparam>
    /// <typeparam name="T5">The type for the 5th parameter that should not be null.</typeparam>
    /// <typeparam name="T6">The type for the 6th parameter that should not be null.</typeparam>
    /// <typeparam name="T7">The type for the 7th parameter that should not be null.</typeparam>
    /// <typeparam name="T8">The type for the 8th parameter that should not be null.</typeparam>
    public class ArgumentNullExceptionTheoryData<T1, T2, T3, T4, T5, T6, T7, T8>
        : global::Xunit.TheoryData<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, string>
        where T1 : notnull
        where T2 : notnull
        where T3 : notnull
        where T4 : notnull
        where T5 : notnull
        where T6 : notnull
        where T7 : notnull
        where T8 : notnull
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentNullExceptionTheoryData{T1, T2, T3, T4, T5, T6, T7, T8}"/> class.
        /// </summary>
        /// <param name="parameter1Input">Information for the 1st parameter that should not be null.</param>
        /// <param name="parameter2Input">Information for the 2nd parameter that should not be null.</param>
        /// <param name="parameter3Input">Information for the 3rd parameter that should not be null.</param>
        /// <param name="parameter4Input">Information for the 4th parameter that should not be null.</param>
        /// <param name="parameter5Input">Information for the 5th parameter that should not be null.</param>
        /// <param name="parameter6Input">Information for the 6th parameter that should not be null.</param>
        /// <param name="parameter7Input">Information for the 7th parameter that should not be null.</param>
        /// <param name="parameter8Input">Information for the 8th parameter that should not be null.</param>
        public ArgumentNullExceptionTheoryData(
            NamedParameterInput<T1> parameter1Input,
            NamedParameterInput<T2> parameter2Input,
            NamedParameterInput<T3> parameter3Input,
            NamedParameterInput<T4> parameter4Input,
            NamedParameterInput<T5> parameter5Input,
            NamedParameterInput<T6> parameter6Input,
            NamedParameterInput<T7> parameter7Input,
            NamedParameterInput<T8> parameter8Input)
        {
            if (parameter1Input == null)
            {
                throw new System.ArgumentNullException(nameof(parameter1Input));
            }

            if (parameter2Input == null)
            {
                throw new System.ArgumentNullException(nameof(parameter2Input));
            }

            if (parameter3Input == null)
            {
                throw new System.ArgumentNullException(nameof(parameter3Input));
            }

            if (parameter4Input == null)
            {
                throw new System.ArgumentNullException(nameof(parameter4Input));
            }

            if (parameter5Input == null)
            {
                throw new System.ArgumentNullException(nameof(parameter5Input));
            }

            if (parameter6Input == null)
            {
                throw new System.ArgumentNullException(nameof(parameter6Input));
            }

            if (parameter7Input == null)
            {
                throw new System.ArgumentNullException(nameof(parameter7Input));
            }

            if (parameter8Input == null)
            {
                throw new System.ArgumentNullException(nameof(parameter8Input));
            }

            Add(
                default,
                parameter2Input.ValidValue(),
                parameter3Input.ValidValue(),
                parameter4Input.ValidValue(),
                parameter5Input.ValidValue(),
                parameter6Input.ValidValue(),
                parameter7Input.ValidValue(),
                parameter8Input.ValidValue(),
                parameter1Input.Name);

            Add(
                parameter1Input.ValidValue(),
                default,
                parameter3Input.ValidValue(),
                parameter4Input.ValidValue(),
                parameter5Input.ValidValue(),
                parameter6Input.ValidValue(),
                parameter7Input.ValidValue(),
                parameter8Input.ValidValue(),
                parameter2Input.Name);

            Add(
                parameter1Input.ValidValue(),
                parameter2Input.ValidValue(),
                default,
                parameter4Input.ValidValue(),
                parameter5Input.ValidValue(),
                parameter6Input.ValidValue(),
                parameter7Input.ValidValue(),
                parameter8Input.ValidValue(),
                parameter3Input.Name);

            Add(
                parameter1Input.ValidValue(),
                parameter2Input.ValidValue(),
                parameter3Input.ValidValue(),
                default,
                parameter5Input.ValidValue(),
                parameter6Input.ValidValue(),
                parameter7Input.ValidValue(),
                parameter8Input.ValidValue(),
                parameter4Input.Name);

            Add(
                parameter1Input.ValidValue(),
                parameter2Input.ValidValue(),
                parameter3Input.ValidValue(),
                parameter4Input.ValidValue(),
                default,
                parameter6Input.ValidValue(),
                parameter7Input.ValidValue(),
                parameter8Input.ValidValue(),
                parameter5Input.Name);

            Add(
                parameter1Input.ValidValue(),
                parameter2Input.ValidValue(),
                parameter3Input.ValidValue(),
                parameter4Input.ValidValue(),
                parameter5Input.ValidValue(),
                default,
                parameter7Input.ValidValue(),
                parameter8Input.ValidValue(),
                parameter6Input.Name);

            Add(
                parameter1Input.ValidValue(),
                parameter2Input.ValidValue(),
                parameter3Input.ValidValue(),
                parameter4Input.ValidValue(),
                parameter5Input.ValidValue(),
                parameter6Input.ValidValue(),
                default,
                parameter8Input.ValidValue(),
                parameter7Input.Name);

            Add(
                parameter1Input.ValidValue(),
                parameter2Input.ValidValue(),
                parameter3Input.ValidValue(),
                parameter4Input.ValidValue(),
                parameter5Input.ValidValue(),
                parameter6Input.ValidValue(),
                parameter7Input.ValidValue(),
                default,
                parameter8Input.Name);
        }
    }
}
