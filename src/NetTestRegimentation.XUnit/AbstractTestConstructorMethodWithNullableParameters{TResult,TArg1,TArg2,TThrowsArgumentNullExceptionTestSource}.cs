// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using Xunit;

namespace NetTestRegimentation.XUnit
{
    /// <summary>
    /// XUnit Tests for a constructor method that takes a nullable parameter.
    /// </summary>
    /// <typeparam name="TResult">The type being constructed.</typeparam>
    /// <typeparam name="TArg1">The type for argument 1.</typeparam>
    /// <typeparam name="TArg2">The type for argument 2.</typeparam>
    /// <typeparam name="TThrowsArgumentNullExceptionTestSource">Type for the ThrowsArgumentNullException ClassData test source.</typeparam>
    public abstract class AbstractTestConstructorMethodWithNullableParameters<TResult, TArg1, TArg2, TThrowsArgumentNullExceptionTestSource> : ITestConstructorMethodWithNullableParameters<TArg1, TArg2>
        where TResult : class
        where TThrowsArgumentNullExceptionTestSource : TheoryData<TArg1, TArg2, string>
    {
        /// <summary>
        /// Gets the Test Member Data for ThrowsArgumentNullException.
        /// </summary>
        /// <remarks>
        /// This is here to satisfy the convention based execution of XUnit member data properties.
        /// </remarks>
        public TheoryData<TArg1, TArg2, string> MemberDataThrowsArgumentNullException => this.GetThrowsArgumentNullExceptionTestSource();

        /// <inheritdoc/>
        [Fact]
        public void ReturnsInstance()
        {
            var arg1 = this.GetValidConstructorArg1();
            var arg2 = this.GetValidConstructorArg2();
            var instance = this.GetInstance(arg1, arg2);
            Assert.NotNull(instance);
        }

        /// <inheritdoc/>
        [Theory]
        public void ThrowsArgumentNullException(
            TArg1 arg1,
            TArg2 arg2,
            string expectedParameterNameForException)
        {
            var exception = Assert.Throws<ArgumentNullException>(() => this.GetInstance(arg1, arg2));

            Assert.Equal(
                expectedParameterNameForException,
                exception.ParamName);
        }

        /// <summary>
        /// Gets argument 1 to pass into the constructor.
        /// </summary>
        /// <returns>Argument 1 pass into the constructor.</returns>
        protected abstract TArg1 GetValidConstructorArg1();

        /// <summary>
        /// Gets argument 2 to pass into the constructor.
        /// </summary>
        /// <returns>Argument 1 pass into the constructor.</returns>
        protected abstract TArg2 GetValidConstructorArg2();

        /// <summary>
        /// Gets an instance of the object under test based on inputs.
        /// </summary>
        /// <param name="arg1">argument 1 for the constructed object.</param>
        /// <param name="arg2">argument 2 argument for the constructed object.</param>
        /// <returns>Instance of object to test.</returns>
        protected abstract TResult GetInstance(
            TArg1 arg1,
            TArg2 arg2);

        /// <summary>
        /// Gets the Test Member Data for ThrowsArgumentNullException.
        /// </summary>
        /// <returns>Test Member Data for ThrowsArgumentNullException.</returns>
        protected abstract TheoryData<TArg1, TArg2, string> GetThrowsArgumentNullExceptionTestSource();
    }
}
