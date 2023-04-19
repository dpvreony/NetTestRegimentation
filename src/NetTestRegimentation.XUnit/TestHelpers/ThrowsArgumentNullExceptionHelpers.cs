using System;
using Xunit;

namespace NetTestRegimentation.XUnit.TestHelpers
{
    /// <summary>
    /// Helpers for performing tests to ensure <see cref="ArgumentNullException"/> is thrown.
    /// </summary>
    public static class ThrowsArgumentNullExceptionHelpers
    {
        /// <summary>
        /// Tests a method that validates the 1 argument is not null.
        /// </summary>
        /// <param name="testCode">Code to test.</param>
        /// <param name="arg">Input for the parameter that can be null.</param>
        /// <param name="expectedParameterName"></param>
        /// <typeparam name="TInstance"></typeparam>
        /// <typeparam name="TArg">The type for the parameter that should not be null.</typeparam>
        public static void ThrowsArgumentNullException<TArg>(
            Action<TArg> testCode,
            TArg arg,
            string expectedParameterName)
        {
            var exception = Assert.Throws<ArgumentNullException>(() => testCode(arg));
            Assert.Equal(expectedParameterName, exception.ParamName);
        }
    }
}
