// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace NetTestRegimentation
{
#pragma warning disable SA1402 // File may only contain a single type
    /// <summary>
    /// Unit Tests for a constructor method that takes 1 nullable parameter.
    /// </summary>
    /// <typeparam name="TArg">Type for the argument.</typeparam>
    public interface ITestMethodWithNullableParameters<in TArg>
    {
        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <param name="arg">The nullable argument.</param>
        /// <param name="expectedParameterNameForException">
        /// The name of the parameter expected to throw an exception.
        /// </param>
        void ThrowsArgumentNullException(
            TArg arg,
            string expectedParameterNameForException);
    }

    /// <summary>
    /// Unit Tests for a constructor method that takes 2 nullable parameters.
    /// </summary>
    /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
    /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
    public interface ITestMethodWithNullableParameters<in TArg1, in TArg2>
    {
        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="expectedParameterNameForException">
        /// The name of the parameter expected to throw an exception.
        /// </param>
        void ThrowsArgumentNullException(
            TArg1 arg1,
            TArg2 arg2,
            string expectedParameterNameForException);
    }

    /// <summary>
    /// Unit Tests for a constructor method that takes 3 nullable parameters.
    /// </summary>
    /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
    /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
    /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
    public interface ITestMethodWithNullableParameters<in TArg1, in TArg2, in TArg3>
    {
        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        /// <param name="expectedParameterNameForException">
        /// The name of the parameter expected to throw an exception.
        /// </param>
        void ThrowsArgumentNullException(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            string expectedParameterNameForException);
    }

    /// <summary>
    /// Unit Tests for a constructor method that takes 4 nullable parameters.
    /// </summary>
    /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
    /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
    /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
    /// <typeparam name="TArg4">Type for the 4th argument.</typeparam>
    public interface ITestMethodWithNullableParameters<in TArg1, in TArg2, in TArg3, in TArg4>
    {
        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        /// <param name="arg4">The 4th nullable argument.</param>
        /// <param name="expectedParameterNameForException">
        /// The name of the parameter expected to throw an exception.
        /// </param>
        void ThrowsArgumentNullException(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            string expectedParameterNameForException);
    }

    /// <summary>
    /// Unit Tests for a constructor method that takes 5 nullable parameters.
    /// </summary>
    /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
    /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
    /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
    /// <typeparam name="TArg4">Type for the 4th argument.</typeparam>
    /// <typeparam name="TArg5">Type for the 5th argument.</typeparam>
    public interface ITestMethodWithNullableParameters<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5>
    {
        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        /// <param name="arg4">The 4th nullable argument.</param>
        /// <param name="arg5">The 5th nullable argument.</param>
        /// <param name="expectedParameterNameForException">
        /// The name of the parameter expected to throw an exception.
        /// </param>
        void ThrowsArgumentNullException(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            string expectedParameterNameForException);
    }

    /// <summary>
    /// Unit Tests for a constructor method that takes 6 nullable parameters.
    /// </summary>
    /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
    /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
    /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
    /// <typeparam name="TArg4">Type for the 4th argument.</typeparam>
    /// <typeparam name="TArg5">Type for the 5th argument.</typeparam>
    /// <typeparam name="TArg6">Type for the 6th argument.</typeparam>
    public interface ITestMethodWithNullableParameters<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6>
    {
        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        /// <param name="arg4">The 4th nullable argument.</param>
        /// <param name="arg5">The 5th nullable argument.</param>
        /// <param name="arg6">The 6th nullable argument.</param>
        /// <param name="expectedParameterNameForException">
        /// The name of the parameter expected to throw an exception.
        /// </param>
        void ThrowsArgumentNullException(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            string expectedParameterNameForException);
    }

    /// <summary>
    /// Unit Tests for a constructor method that takes 7 nullable parameters.
    /// </summary>
    /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
    /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
    /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
    /// <typeparam name="TArg4">Type for the 4th argument.</typeparam>
    /// <typeparam name="TArg5">Type for the 5th argument.</typeparam>
    /// <typeparam name="TArg6">Type for the 6th argument.</typeparam>
    /// <typeparam name="TArg7">Type for the 7th argument.</typeparam>
    public interface ITestMethodWithNullableParameters<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7>
    {
        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        /// <param name="arg4">The 4th nullable argument.</param>
        /// <param name="arg5">The 5th nullable argument.</param>
        /// <param name="arg6">The 6th nullable argument.</param>
        /// <param name="arg7">The 7th nullable argument.</param>
        /// <param name="expectedParameterNameForException">
        /// The name of the parameter expected to throw an exception.
        /// </param>
        void ThrowsArgumentNullException(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            string expectedParameterNameForException);
    }

    /// <summary>
    /// Unit Tests for a constructor method that takes 8 nullable parameters.
    /// </summary>
    /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
    /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
    /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
    /// <typeparam name="TArg4">Type for the 4th argument.</typeparam>
    /// <typeparam name="TArg5">Type for the 5th argument.</typeparam>
    /// <typeparam name="TArg6">Type for the 6th argument.</typeparam>
    /// <typeparam name="TArg7">Type for the 7th argument.</typeparam>
    /// <typeparam name="TArg8">Type for the 8th argument.</typeparam>
    public interface ITestMethodWithNullableParameters<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8>
    {
        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        /// <param name="arg4">The 4th nullable argument.</param>
        /// <param name="arg5">The 5th nullable argument.</param>
        /// <param name="arg6">The 6th nullable argument.</param>
        /// <param name="arg7">The 7th nullable argument.</param>
        /// <param name="arg8">The 8th nullable argument.</param>
        /// <param name="expectedParameterNameForException">
        /// The name of the parameter expected to throw an exception.
        /// </param>
        void ThrowsArgumentNullException(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            TArg8 arg8,
            string expectedParameterNameForException);
    }

    /// <summary>
    /// Unit Tests for a constructor method that takes 9 nullable parameters.
    /// </summary>
    /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
    /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
    /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
    /// <typeparam name="TArg4">Type for the 4th argument.</typeparam>
    /// <typeparam name="TArg5">Type for the 5th argument.</typeparam>
    /// <typeparam name="TArg6">Type for the 6th argument.</typeparam>
    /// <typeparam name="TArg7">Type for the 7th argument.</typeparam>
    /// <typeparam name="TArg8">Type for the 8th argument.</typeparam>
    /// <typeparam name="TArg9">Type for the 9th argument.</typeparam>
    public interface ITestMethodWithNullableParameters<
        in TArg1,
        in TArg2,
        in TArg3,
        in TArg4,
        in TArg5,
        in TArg6,
        in TArg7,
        in TArg8,
        in TArg9>
    {
        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        /// <param name="arg4">The 4th nullable argument.</param>
        /// <param name="arg5">The 5th nullable argument.</param>
        /// <param name="arg6">The 6th nullable argument.</param>
        /// <param name="arg7">The 7th nullable argument.</param>
        /// <param name="arg8">The 8th nullable argument.</param>
        /// <param name="arg9">The 9th nullable argument.</param>
        /// <param name="expectedParameterNameForException">
        /// The name of the parameter expected to throw an exception.
        /// </param>
        void ThrowsArgumentNullException(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            TArg8 arg8,
            TArg9 arg9,
            string expectedParameterNameForException);
    }

    /// <summary>
    /// Unit Tests for a constructor method that takes 10 nullable parameters.
    /// </summary>
    /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
    /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
    /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
    /// <typeparam name="TArg4">Type for the 4th argument.</typeparam>
    /// <typeparam name="TArg5">Type for the 5th argument.</typeparam>
    /// <typeparam name="TArg6">Type for the 6th argument.</typeparam>
    /// <typeparam name="TArg7">Type for the 7th argument.</typeparam>
    /// <typeparam name="TArg8">Type for the 8th argument.</typeparam>
    /// <typeparam name="TArg9">Type for the 9th argument.</typeparam>
    /// <typeparam name="TArg10">Type for the 10th argument.</typeparam>
    public interface ITestMethodWithNullableParameters<
        in TArg1,
        in TArg2,
        in TArg3,
        in TArg4,
        in TArg5,
        in TArg6,
        in TArg7,
        in TArg8,
        in TArg9,
        in TArg10>
    {
        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        /// <param name="arg4">The 4th nullable argument.</param>
        /// <param name="arg5">The 5th nullable argument.</param>
        /// <param name="arg6">The 6th nullable argument.</param>
        /// <param name="arg7">The 7th nullable argument.</param>
        /// <param name="arg8">The 8th nullable argument.</param>
        /// <param name="arg9">The 9th nullable argument.</param>
        /// <param name="arg10">The 10th nullable argument.</param>
        /// <param name="expectedParameterNameForException">
        /// The name of the parameter expected to throw an exception.
        /// </param>
        void ThrowsArgumentNullException(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            TArg8 arg8,
            TArg9 arg9,
            TArg10 arg10,
            string expectedParameterNameForException);
    }

    /// <summary>
    /// Unit Tests for a constructor method that takes 11 nullable parameters.
    /// </summary>
    /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
    /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
    /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
    /// <typeparam name="TArg4">Type for the 4th argument.</typeparam>
    /// <typeparam name="TArg5">Type for the 5th argument.</typeparam>
    /// <typeparam name="TArg6">Type for the 6th argument.</typeparam>
    /// <typeparam name="TArg7">Type for the 7th argument.</typeparam>
    /// <typeparam name="TArg8">Type for the 8th argument.</typeparam>
    /// <typeparam name="TArg9">Type for the 9th argument.</typeparam>
    /// <typeparam name="TArg10">Type for the 10th argument.</typeparam>
    /// <typeparam name="TArg11">Type for the 11th argument.</typeparam>
    public interface ITestMethodWithNullableParameters<
        in TArg1,
        in TArg2,
        in TArg3,
        in TArg4,
        in TArg5,
        in TArg6,
        in TArg7,
        in TArg8,
        in TArg9,
        in TArg10,
        in TArg11>
    {
        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        /// <param name="arg4">The 4th nullable argument.</param>
        /// <param name="arg5">The 5th nullable argument.</param>
        /// <param name="arg6">The 6th nullable argument.</param>
        /// <param name="arg7">The 7th nullable argument.</param>
        /// <param name="arg8">The 8th nullable argument.</param>
        /// <param name="arg9">The 9th nullable argument.</param>
        /// <param name="arg10">The 10th nullable argument.</param>
        /// <param name="arg11">The 11th nullable argument.</param>
        /// <param name="expectedParameterNameForException">
        /// The name of the parameter expected to throw an exception.
        /// </param>
        void ThrowsArgumentNullException(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            TArg8 arg8,
            TArg9 arg9,
            TArg10 arg10,
            TArg11 arg11,
            string expectedParameterNameForException);
    }

    /// <summary>
    /// Unit Tests for a constructor method that takes 13 nullable parameters.
    /// </summary>
    /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
    /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
    /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
    /// <typeparam name="TArg4">Type for the 4th argument.</typeparam>
    /// <typeparam name="TArg5">Type for the 5th argument.</typeparam>
    /// <typeparam name="TArg6">Type for the 6th argument.</typeparam>
    /// <typeparam name="TArg7">Type for the 7th argument.</typeparam>
    /// <typeparam name="TArg8">Type for the 8th argument.</typeparam>
    /// <typeparam name="TArg9">Type for the 9th argument.</typeparam>
    /// <typeparam name="TArg10">Type for the 10th argument.</typeparam>
    /// <typeparam name="TArg11">Type for the 11th argument.</typeparam>
    /// <typeparam name="TArg12">Type for the 12th argument.</typeparam>
    public interface ITestMethodWithNullableParameters<
        in TArg1,
        in TArg2,
        in TArg3,
        in TArg4,
        in TArg5,
        in TArg6,
        in TArg7,
        in TArg8,
        in TArg9,
        in TArg10,
        in TArg11,
        in TArg12>
    {
        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        /// <param name="arg4">The 4th nullable argument.</param>
        /// <param name="arg5">The 5th nullable argument.</param>
        /// <param name="arg6">The 6th nullable argument.</param>
        /// <param name="arg7">The 7th nullable argument.</param>
        /// <param name="arg8">The 8th nullable argument.</param>
        /// <param name="arg9">The 9th nullable argument.</param>
        /// <param name="arg10">The 10th nullable argument.</param>
        /// <param name="arg11">The 11th nullable argument.</param>
        /// <param name="arg12">The 12th nullable argument.</param>
        /// <param name="expectedParameterNameForException">
        /// The name of the parameter expected to throw an exception.
        /// </param>
        void ThrowsArgumentNullException(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            TArg8 arg8,
            TArg9 arg9,
            TArg10 arg10,
            TArg11 arg11,
            TArg12 arg12,
            string expectedParameterNameForException);
    }

    /// <summary>
    /// Unit Tests for a constructor method that takes 13 nullable parameters.
    /// </summary>
    /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
    /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
    /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
    /// <typeparam name="TArg4">Type for the 4th argument.</typeparam>
    /// <typeparam name="TArg5">Type for the 5th argument.</typeparam>
    /// <typeparam name="TArg6">Type for the 6th argument.</typeparam>
    /// <typeparam name="TArg7">Type for the 7th argument.</typeparam>
    /// <typeparam name="TArg8">Type for the 8th argument.</typeparam>
    /// <typeparam name="TArg9">Type for the 9th argument.</typeparam>
    /// <typeparam name="TArg10">Type for the 10th argument.</typeparam>
    /// <typeparam name="TArg11">Type for the 11th argument.</typeparam>
    /// <typeparam name="TArg12">Type for the 12th argument.</typeparam>
    /// <typeparam name="TArg13">Type for the 13th argument.</typeparam>
    public interface ITestMethodWithNullableParameters<
        in TArg1,
        in TArg2,
        in TArg3,
        in TArg4,
        in TArg5,
        in TArg6,
        in TArg7,
        in TArg8,
        in TArg9,
        in TArg10,
        in TArg11,
        in TArg12,
        in TArg13>
    {
        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        /// <param name="arg4">The 4th nullable argument.</param>
        /// <param name="arg5">The 5th nullable argument.</param>
        /// <param name="arg6">The 6th nullable argument.</param>
        /// <param name="arg7">The 7th nullable argument.</param>
        /// <param name="arg8">The 8th nullable argument.</param>
        /// <param name="arg9">The 9th nullable argument.</param>
        /// <param name="arg10">The 10th nullable argument.</param>
        /// <param name="arg11">The 11th nullable argument.</param>
        /// <param name="arg12">The 12th nullable argument.</param>
        /// <param name="arg13">The 13th nullable argument.</param>
        /// <param name="expectedParameterNameForException">
        /// The name of the parameter expected to throw an exception.
        /// </param>
        void ThrowsArgumentNullException(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            TArg8 arg8,
            TArg9 arg9,
            TArg10 arg10,
            TArg11 arg11,
            TArg12 arg12,
            TArg13 arg13,
            string expectedParameterNameForException);
    }

    /// <summary>
    /// Unit Tests for a constructor method that takes 14 nullable parameters.
    /// </summary>
    /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
    /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
    /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
    /// <typeparam name="TArg4">Type for the 4th argument.</typeparam>
    /// <typeparam name="TArg5">Type for the 5th argument.</typeparam>
    /// <typeparam name="TArg6">Type for the 6th argument.</typeparam>
    /// <typeparam name="TArg7">Type for the 7th argument.</typeparam>
    /// <typeparam name="TArg8">Type for the 8th argument.</typeparam>
    /// <typeparam name="TArg9">Type for the 9th argument.</typeparam>
    /// <typeparam name="TArg10">Type for the 10th argument.</typeparam>
    /// <typeparam name="TArg11">Type for the 11th argument.</typeparam>
    /// <typeparam name="TArg12">Type for the 12th argument.</typeparam>
    /// <typeparam name="TArg13">Type for the 13th argument.</typeparam>
    /// <typeparam name="TArg14">Type for the 14th argument.</typeparam>
    public interface ITestMethodWithNullableParameters<
        in TArg1,
        in TArg2,
        in TArg3,
        in TArg4,
        in TArg5,
        in TArg6,
        in TArg7,
        in TArg8,
        in TArg9,
        in TArg10,
        in TArg11,
        in TArg12,
        in TArg13,
        in TArg14>
    {
        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        /// <param name="arg4">The 4th nullable argument.</param>
        /// <param name="arg5">The 5th nullable argument.</param>
        /// <param name="arg6">The 6th nullable argument.</param>
        /// <param name="arg7">The 7th nullable argument.</param>
        /// <param name="arg8">The 8th nullable argument.</param>
        /// <param name="arg9">The 9th nullable argument.</param>
        /// <param name="arg10">The 10th nullable argument.</param>
        /// <param name="arg11">The 11th nullable argument.</param>
        /// <param name="arg12">The 12th nullable argument.</param>
        /// <param name="arg13">The 13th nullable argument.</param>
        /// <param name="arg14">The 14th nullable argument.</param>
        /// <param name="expectedParameterNameForException">
        /// The name of the parameter expected to throw an exception.
        /// </param>
        void ThrowsArgumentNullException(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            TArg8 arg8,
            TArg9 arg9,
            TArg10 arg10,
            TArg11 arg11,
            TArg12 arg12,
            TArg13 arg13,
            TArg14 arg14,
            string expectedParameterNameForException);
    }

    /// <summary>
    /// Unit Tests for a constructor method that takes 15 nullable parameters.
    /// </summary>
    /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
    /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
    /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
    /// <typeparam name="TArg4">Type for the 4th argument.</typeparam>
    /// <typeparam name="TArg5">Type for the 5th argument.</typeparam>
    /// <typeparam name="TArg6">Type for the 6th argument.</typeparam>
    /// <typeparam name="TArg7">Type for the 7th argument.</typeparam>
    /// <typeparam name="TArg8">Type for the 8th argument.</typeparam>
    /// <typeparam name="TArg9">Type for the 9th argument.</typeparam>
    /// <typeparam name="TArg10">Type for the 10th argument.</typeparam>
    /// <typeparam name="TArg11">Type for the 11th argument.</typeparam>
    /// <typeparam name="TArg12">Type for the 12th argument.</typeparam>
    /// <typeparam name="TArg13">Type for the 13th argument.</typeparam>
    /// <typeparam name="TArg14">Type for the 14th argument.</typeparam>
    /// <typeparam name="TArg15">Type for the 15th argument.</typeparam>
    public interface ITestMethodWithNullableParameters<
        in TArg1,
        in TArg2,
        in TArg3,
        in TArg4,
        in TArg5,
        in TArg6,
        in TArg7,
        in TArg8,
        in TArg9,
        in TArg10,
        in TArg11,
        in TArg12,
        in TArg13,
        in TArg14,
        in TArg15>
    {
        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        /// <param name="arg4">The 4th nullable argument.</param>
        /// <param name="arg5">The 5th nullable argument.</param>
        /// <param name="arg6">The 6th nullable argument.</param>
        /// <param name="arg7">The 7th nullable argument.</param>
        /// <param name="arg8">The 8th nullable argument.</param>
        /// <param name="arg9">The 9th nullable argument.</param>
        /// <param name="arg10">The 10th nullable argument.</param>
        /// <param name="arg11">The 11th nullable argument.</param>
        /// <param name="arg12">The 12th nullable argument.</param>
        /// <param name="arg13">The 13th nullable argument.</param>
        /// <param name="arg14">The 14th nullable argument.</param>
        /// <param name="arg15">The 15th nullable argument.</param>
        /// <param name="expectedParameterNameForException">
        /// The name of the parameter expected to throw an exception.
        /// </param>
        void ThrowsArgumentNullException(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            TArg8 arg8,
            TArg9 arg9,
            TArg10 arg10,
            TArg11 arg11,
            TArg12 arg12,
            TArg13 arg13,
            TArg14 arg14,
            TArg15 arg15,
            string expectedParameterNameForException);
    }

    /// <summary>
    /// Unit Tests for a constructor method that takes 16 nullable parameters.
    /// </summary>
    /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
    /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
    /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
    /// <typeparam name="TArg4">Type for the 4th argument.</typeparam>
    /// <typeparam name="TArg5">Type for the 5th argument.</typeparam>
    /// <typeparam name="TArg6">Type for the 6th argument.</typeparam>
    /// <typeparam name="TArg7">Type for the 7th argument.</typeparam>
    /// <typeparam name="TArg8">Type for the 8th argument.</typeparam>
    /// <typeparam name="TArg9">Type for the 9th argument.</typeparam>
    /// <typeparam name="TArg10">Type for the 10th argument.</typeparam>
    /// <typeparam name="TArg11">Type for the 11th argument.</typeparam>
    /// <typeparam name="TArg12">Type for the 12th argument.</typeparam>
    /// <typeparam name="TArg13">Type for the 13th argument.</typeparam>
    /// <typeparam name="TArg14">Type for the 14th argument.</typeparam>
    /// <typeparam name="TArg15">Type for the 15th argument.</typeparam>
    /// <typeparam name="TArg16">Type for the 16th argument.</typeparam>
    public interface ITestMethodWithNullableParameters<
        in TArg1,
        in TArg2,
        in TArg3,
        in TArg4,
        in TArg5,
        in TArg6,
        in TArg7,
        in TArg8,
        in TArg9,
        in TArg10,
        in TArg11,
        in TArg12,
        in TArg13,
        in TArg14,
        in TArg15,
        in TArg16>
    {
        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        /// <param name="arg4">The 4th nullable argument.</param>
        /// <param name="arg5">The 5th nullable argument.</param>
        /// <param name="arg6">The 6th nullable argument.</param>
        /// <param name="arg7">The 7th nullable argument.</param>
        /// <param name="arg8">The 8th nullable argument.</param>
        /// <param name="arg9">The 9th nullable argument.</param>
        /// <param name="arg10">The 10th nullable argument.</param>
        /// <param name="arg11">The 11th nullable argument.</param>
        /// <param name="arg12">The 12th nullable argument.</param>
        /// <param name="arg13">The 13th nullable argument.</param>
        /// <param name="arg14">The 14th nullable argument.</param>
        /// <param name="arg15">The 15th nullable argument.</param>
        /// <param name="arg16">The 16th nullable argument.</param>
        /// <param name="expectedParameterNameForException">
        /// The name of the parameter expected to throw an exception.
        /// </param>
        void ThrowsArgumentNullException(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            TArg8 arg8,
            TArg9 arg9,
            TArg10 arg10,
            TArg11 arg11,
            TArg12 arg12,
            TArg13 arg13,
            TArg14 arg14,
            TArg15 arg15,
            TArg16 arg16,
            string expectedParameterNameForException);
    }
#pragma warning restore SA1402 // File may only contain a single type
}
