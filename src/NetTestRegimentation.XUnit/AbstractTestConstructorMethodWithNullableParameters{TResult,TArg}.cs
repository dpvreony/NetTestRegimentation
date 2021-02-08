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
    /// <typeparam name="TArg">The type for the argument.</typeparam>
    public abstract class AbstractTestConstructorMethodWithNullableParameters<TResult, TArg> : ITestConstructorMethodWithNullableParameters<TArg>
        where TResult : class
    {
        /// <inheritdoc/>
        [Fact]
        public void ReturnsInstance()
        {
            var arg = this.GetValidConstructorArg();
            var instance = this.GetInstance(arg);
            Assert.NotNull(instance);
        }

        /// <inheritdoc/>
        [Theory]
        public void ThrowsArgumentNullException(
            TArg arg,
            string expectedParameterNameForException)
        {
            var exception = Assert.Throws<ArgumentNullException>(() => this.GetInstance(arg));

            Assert.Equal(
                expectedParameterNameForException,
                exception.ParamName);
        }

        /// <summary>
        /// Gets the argument to pass into the constructor.
        /// </summary>
        /// <returns>Argument to pass into the constructor.</returns>
        protected abstract TArg GetValidConstructorArg();

        /// <summary>
        /// Gets an instance of the object under test based on inputs.
        /// </summary>
        /// <param name="arg">first argument for the constructed object.</param>
        /// <returns>Instance of object to test.</returns>
        protected abstract TResult GetInstance(TArg arg);

        /// <summary>
        /// Gets the Test Member Data for ThrowsArgumentNullException.
        /// </summary>
        /// <returns>Test Member Data for ThrowsArgumentNullException.</returns>
        protected abstract TheoryData<TArg, string> GetThrowsArgumentNullExceptionTestSource();
    }
}
