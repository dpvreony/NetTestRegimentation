// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading.Tasks;

namespace NetTestRegimentation.UnitTests
{
    /// <summary>
    /// Helpers for running unit test validation.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static class ArgumentHelpers
    {
        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <typeparam name="TArg">Type for the argument.</typeparam>
        /// <param name="arg">The nullable argument.</param>
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation.
        /// </returns>
        public static async Task ThrowIfNullAsync<TArg>(TArg arg)
        {
            await Task.Run(() => ThrowIfNull(arg)).ConfigureAwait(false);
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
        /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation.
        /// </returns>
        public static async Task ThrowIfNullAsync<
            TArg1,
            TArg2>(
            TArg1 arg1,
            TArg2 arg2)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2)).ConfigureAwait(false);
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
        /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
        /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation.
        /// </returns>
        public static async Task ThrowIfNullAsync<
            TArg1,
            TArg2,
            TArg3>(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                arg3)).ConfigureAwait(false);
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
        /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
        /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
        /// <typeparam name="TArg4">Type for the 4th argument.</typeparam>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        /// <param name="arg4">The 4th nullable argument.</param>
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation.
        /// </returns>
        public static async Task ThrowIfNullAsync<
            TArg1,
            TArg2,
            TArg3,
            TArg4>(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                arg3,
                arg4)).ConfigureAwait(false);
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
        /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
        /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
        /// <typeparam name="TArg4">Type for the 4th argument.</typeparam>
        /// <typeparam name="TArg5">Type for the 5th argument.</typeparam>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        /// <param name="arg4">The 4th nullable argument.</param>
        /// <param name="arg5">The 5th nullable argument.</param>
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation.
        /// </returns>
        public static async Task ThrowIfNullAsync<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5>(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5)).ConfigureAwait(false);
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
        /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
        /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
        /// <typeparam name="TArg4">Type for the 4th argument.</typeparam>
        /// <typeparam name="TArg5">Type for the 5th argument.</typeparam>
        /// <typeparam name="TArg6">Type for the 6th argument.</typeparam>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        /// <param name="arg4">The 4th nullable argument.</param>
        /// <param name="arg5">The 5th nullable argument.</param>
        /// <param name="arg6">The 6th nullable argument.</param>
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation.
        /// </returns>
        public static async Task ThrowIfNullAsync<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6>(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6)).ConfigureAwait(false);
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
        /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
        /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
        /// <typeparam name="TArg4">Type for the 4th argument.</typeparam>
        /// <typeparam name="TArg5">Type for the 5th argument.</typeparam>
        /// <typeparam name="TArg6">Type for the 6th argument.</typeparam>
        /// <typeparam name="TArg7">Type for the 7th argument.</typeparam>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        /// <param name="arg4">The 4th nullable argument.</param>
        /// <param name="arg5">The 5th nullable argument.</param>
        /// <param name="arg6">The 6th nullable argument.</param>
        /// <param name="arg7">The 7th nullable argument.</param>
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation.
        /// </returns>
        public static async Task ThrowIfNullAsync<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7>(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                arg7)).ConfigureAwait(false);
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
        /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
        /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
        /// <typeparam name="TArg4">Type for the 4th argument.</typeparam>
        /// <typeparam name="TArg5">Type for the 5th argument.</typeparam>
        /// <typeparam name="TArg6">Type for the 6th argument.</typeparam>
        /// <typeparam name="TArg7">Type for the 7th argument.</typeparam>
        /// <typeparam name="TArg8">Type for the 8th argument.</typeparam>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        /// <param name="arg4">The 4th nullable argument.</param>
        /// <param name="arg5">The 5th nullable argument.</param>
        /// <param name="arg6">The 6th nullable argument.</param>
        /// <param name="arg7">The 7th nullable argument.</param>
        /// <param name="arg8">The 8th nullable argument.</param>
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation.
        /// </returns>
        public static async Task ThrowIfNullAsync<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8>(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            TArg8 arg8)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                arg7,
                arg8)).ConfigureAwait(false);
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
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
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        /// <param name="arg4">The 4th nullable argument.</param>
        /// <param name="arg5">The 5th nullable argument.</param>
        /// <param name="arg6">The 6th nullable argument.</param>
        /// <param name="arg7">The 7th nullable argument.</param>
        /// <param name="arg8">The 8th nullable argument.</param>
        /// <param name="arg9">The 9th nullable argument.</param>
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation.
        /// </returns>
        public static async Task ThrowIfNullAsync<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8,
            TArg9>(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            TArg8 arg8,
            TArg9 arg9)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                arg7,
                arg8,
                arg9)).ConfigureAwait(false);
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
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
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation.
        /// </returns>
        public static async Task ThrowIfNullAsync<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8,
            TArg9,
            TArg10>(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            TArg8 arg8,
            TArg9 arg9,
            TArg10 arg10)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                arg7,
                arg8,
                arg9,
                arg10)).ConfigureAwait(false);
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
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
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation.
        /// </returns>
        public static async Task ThrowIfNullAsync<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8,
            TArg9,
            TArg10,
            TArg11>(
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
            TArg11 arg11)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                arg7,
                arg8,
                arg9,
                arg10,
                arg11)).ConfigureAwait(false);
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
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
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation.
        /// </returns>
        public static async Task ThrowIfNullAsync<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8,
            TArg9,
            TArg10,
            TArg11,
            TArg12>(
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
            TArg12 arg12)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                arg7,
                arg8,
                arg9,
                arg10,
                arg11,
                arg12)).ConfigureAwait(false);
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
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
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation.
        /// </returns>
        public static async Task ThrowIfNullAsync<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8,
            TArg9,
            TArg10,
            TArg11,
            TArg12,
            TArg13>(
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
            TArg13 arg13)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                arg7,
                arg8,
                arg9,
                arg10,
                arg11,
                arg12,
                arg13)).ConfigureAwait(false);
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
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
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation.
        /// </returns>
        public static async Task ThrowIfNullAsync<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8,
            TArg9,
            TArg10,
            TArg11,
            TArg12,
            TArg13,
            TArg14>(
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
            TArg14 arg14)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                arg7,
                arg8,
                arg9,
                arg10,
                arg11,
                arg12,
                arg13,
                arg14)).ConfigureAwait(false);
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
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
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation.
        /// </returns>
        public static async Task ThrowIfNullAsync<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8,
            TArg9,
            TArg10,
            TArg11,
            TArg12,
            TArg13,
            TArg14,
            TArg15>(
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
            TArg15 arg15)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                arg7,
                arg8,
                arg9,
                arg10,
                arg11,
                arg12,
                arg13,
                arg14,
                arg15)).ConfigureAwait(false);
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
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
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation.
        /// </returns>
        public static async Task ThrowIfNullAsync<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8,
            TArg9,
            TArg10,
            TArg11,
            TArg12,
            TArg13,
            TArg14,
            TArg15,
            TArg16>(
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
            TArg16 arg16)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                arg7,
                arg8,
                arg9,
                arg10,
                arg11,
                arg12,
                arg13,
                arg14,
                arg15,
                arg16)).ConfigureAwait(false);
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <typeparam name="TArg">Type for the argument.</typeparam>
        /// <param name="arg">The nullable argument.</param>
        public static void ThrowIfNull<TArg>(TArg arg)
        {
            ThrowIfNull(arg, nameof(arg));
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
        /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        public static void ThrowIfNull<TArg1, TArg2>(
            TArg1 arg1,
            TArg2 arg2)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
        /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
        /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        public static void ThrowIfNull<
            TArg1,
            TArg2,
            TArg3>(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
            ThrowIfNull(arg3, nameof(arg3));
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
        /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
        /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
        /// <typeparam name="TArg4">Type for the 4th argument.</typeparam>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        /// <param name="arg4">The 4th nullable argument.</param>
        public static void ThrowIfNull<
            TArg1,
            TArg2,
            TArg3,
            TArg4>(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
            ThrowIfNull(arg3, nameof(arg3));
            ThrowIfNull(arg4, nameof(arg4));
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
        /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
        /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
        /// <typeparam name="TArg4">Type for the 4th argument.</typeparam>
        /// <typeparam name="TArg5">Type for the 5th argument.</typeparam>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        /// <param name="arg4">The 4th nullable argument.</param>
        /// <param name="arg5">The 5th nullable argument.</param>
        public static void ThrowIfNull<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5>(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
            ThrowIfNull(arg3, nameof(arg3));
            ThrowIfNull(arg4, nameof(arg4));
            ThrowIfNull(arg5, nameof(arg5));
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
        /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
        /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
        /// <typeparam name="TArg4">Type for the 4th argument.</typeparam>
        /// <typeparam name="TArg5">Type for the 5th argument.</typeparam>
        /// <typeparam name="TArg6">Type for the 6th argument.</typeparam>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        /// <param name="arg4">The 4th nullable argument.</param>
        /// <param name="arg5">The 5th nullable argument.</param>
        /// <param name="arg6">The 6th nullable argument.</param>
        public static void ThrowIfNull<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6>(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
            ThrowIfNull(arg3, nameof(arg3));
            ThrowIfNull(arg4, nameof(arg4));
            ThrowIfNull(arg5, nameof(arg5));
            ThrowIfNull(arg6, nameof(arg6));
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
        /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
        /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
        /// <typeparam name="TArg4">Type for the 4th argument.</typeparam>
        /// <typeparam name="TArg5">Type for the 5th argument.</typeparam>
        /// <typeparam name="TArg6">Type for the 6th argument.</typeparam>
        /// <typeparam name="TArg7">Type for the 7th argument.</typeparam>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        /// <param name="arg4">The 4th nullable argument.</param>
        /// <param name="arg5">The 5th nullable argument.</param>
        /// <param name="arg6">The 6th nullable argument.</param>
        /// <param name="arg7">The 7th nullable argument.</param>
        public static void ThrowIfNull<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7>(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
            ThrowIfNull(arg3, nameof(arg3));
            ThrowIfNull(arg4, nameof(arg4));
            ThrowIfNull(arg5, nameof(arg5));
            ThrowIfNull(arg6, nameof(arg6));
            ThrowIfNull(arg7, nameof(arg7));
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
        /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
        /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
        /// <typeparam name="TArg4">Type for the 4th argument.</typeparam>
        /// <typeparam name="TArg5">Type for the 5th argument.</typeparam>
        /// <typeparam name="TArg6">Type for the 6th argument.</typeparam>
        /// <typeparam name="TArg7">Type for the 7th argument.</typeparam>
        /// <typeparam name="TArg8">Type for the 8th argument.</typeparam>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        /// <param name="arg4">The 4th nullable argument.</param>
        /// <param name="arg5">The 5th nullable argument.</param>
        /// <param name="arg6">The 6th nullable argument.</param>
        /// <param name="arg7">The 7th nullable argument.</param>
        /// <param name="arg8">The 8th nullable argument.</param>
        public static void ThrowIfNull<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8>(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            TArg8 arg8)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
            ThrowIfNull(arg3, nameof(arg3));
            ThrowIfNull(arg4, nameof(arg4));
            ThrowIfNull(arg5, nameof(arg5));
            ThrowIfNull(arg6, nameof(arg6));
            ThrowIfNull(arg7, nameof(arg7));
            ThrowIfNull(arg8, nameof(arg8));
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
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
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        /// <param name="arg4">The 4th nullable argument.</param>
        /// <param name="arg5">The 5th nullable argument.</param>
        /// <param name="arg6">The 6th nullable argument.</param>
        /// <param name="arg7">The 7th nullable argument.</param>
        /// <param name="arg8">The 8th nullable argument.</param>
        /// <param name="arg9">The 9th nullable argument.</param>
        public static void ThrowIfNull<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8,
            TArg9>(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            TArg8 arg8,
            TArg9 arg9)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
            ThrowIfNull(arg3, nameof(arg3));
            ThrowIfNull(arg4, nameof(arg4));
            ThrowIfNull(arg5, nameof(arg5));
            ThrowIfNull(arg6, nameof(arg6));
            ThrowIfNull(arg7, nameof(arg7));
            ThrowIfNull(arg8, nameof(arg8));
            ThrowIfNull(arg9, nameof(arg9));
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
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
        public static void ThrowIfNull<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8,
            TArg9,
            TArg10>(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            TArg8 arg8,
            TArg9 arg9,
            TArg10 arg10)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
            ThrowIfNull(arg3, nameof(arg3));
            ThrowIfNull(arg4, nameof(arg4));
            ThrowIfNull(arg5, nameof(arg5));
            ThrowIfNull(arg6, nameof(arg6));
            ThrowIfNull(arg7, nameof(arg7));
            ThrowIfNull(arg8, nameof(arg8));
            ThrowIfNull(arg9, nameof(arg9));
            ThrowIfNull(arg10, nameof(arg10));
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
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
        public static void ThrowIfNull<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8,
            TArg9,
            TArg10,
            TArg11>(
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
            TArg11 arg11)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
            ThrowIfNull(arg3, nameof(arg3));
            ThrowIfNull(arg4, nameof(arg4));
            ThrowIfNull(arg5, nameof(arg5));
            ThrowIfNull(arg6, nameof(arg6));
            ThrowIfNull(arg7, nameof(arg7));
            ThrowIfNull(arg8, nameof(arg8));
            ThrowIfNull(arg9, nameof(arg9));
            ThrowIfNull(arg10, nameof(arg10));
            ThrowIfNull(arg11, nameof(arg11));
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
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
        public static void ThrowIfNull<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8,
            TArg9,
            TArg10,
            TArg11,
            TArg12>(
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
            TArg12 arg12)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
            ThrowIfNull(arg3, nameof(arg3));
            ThrowIfNull(arg4, nameof(arg4));
            ThrowIfNull(arg5, nameof(arg5));
            ThrowIfNull(arg6, nameof(arg6));
            ThrowIfNull(arg7, nameof(arg7));
            ThrowIfNull(arg8, nameof(arg8));
            ThrowIfNull(arg9, nameof(arg9));
            ThrowIfNull(arg10, nameof(arg10));
            ThrowIfNull(arg11, nameof(arg11));
            ThrowIfNull(arg12, nameof(arg12));
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
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
        public static void ThrowIfNull<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8,
            TArg9,
            TArg10,
            TArg11,
            TArg12,
            TArg13>(
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
            TArg13 arg13)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
            ThrowIfNull(arg3, nameof(arg3));
            ThrowIfNull(arg4, nameof(arg4));
            ThrowIfNull(arg5, nameof(arg5));
            ThrowIfNull(arg6, nameof(arg6));
            ThrowIfNull(arg7, nameof(arg7));
            ThrowIfNull(arg8, nameof(arg8));
            ThrowIfNull(arg9, nameof(arg9));
            ThrowIfNull(arg10, nameof(arg10));
            ThrowIfNull(arg11, nameof(arg11));
            ThrowIfNull(arg12, nameof(arg12));
            ThrowIfNull(arg13, nameof(arg13));
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
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
        public static void ThrowIfNull<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8,
            TArg9,
            TArg10,
            TArg11,
            TArg12,
            TArg13,
            TArg14>(
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
            TArg14 arg14)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
            ThrowIfNull(arg3, nameof(arg3));
            ThrowIfNull(arg4, nameof(arg4));
            ThrowIfNull(arg5, nameof(arg5));
            ThrowIfNull(arg6, nameof(arg6));
            ThrowIfNull(arg7, nameof(arg7));
            ThrowIfNull(arg8, nameof(arg8));
            ThrowIfNull(arg9, nameof(arg9));
            ThrowIfNull(arg10, nameof(arg10));
            ThrowIfNull(arg11, nameof(arg11));
            ThrowIfNull(arg12, nameof(arg12));
            ThrowIfNull(arg13, nameof(arg13));
            ThrowIfNull(arg14, nameof(arg14));
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
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
        public static void ThrowIfNull<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8,
            TArg9,
            TArg10,
            TArg11,
            TArg12,
            TArg13,
            TArg14,
            TArg15>(
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
            TArg15 arg15)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
            ThrowIfNull(arg3, nameof(arg3));
            ThrowIfNull(arg4, nameof(arg4));
            ThrowIfNull(arg5, nameof(arg5));
            ThrowIfNull(arg6, nameof(arg6));
            ThrowIfNull(arg7, nameof(arg7));
            ThrowIfNull(arg8, nameof(arg8));
            ThrowIfNull(arg9, nameof(arg9));
            ThrowIfNull(arg10, nameof(arg10));
            ThrowIfNull(arg11, nameof(arg11));
            ThrowIfNull(arg12, nameof(arg12));
            ThrowIfNull(arg13, nameof(arg13));
            ThrowIfNull(arg14, nameof(arg14));
            ThrowIfNull(arg15, nameof(arg15));
        }

        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
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
        public static void ThrowIfNull<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8,
            TArg9,
            TArg10,
            TArg11,
            TArg12,
            TArg13,
            TArg14,
            TArg15,
            TArg16>(
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
            TArg16 arg16)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
            ThrowIfNull(arg3, nameof(arg3));
            ThrowIfNull(arg4, nameof(arg4));
            ThrowIfNull(arg5, nameof(arg5));
            ThrowIfNull(arg6, nameof(arg6));
            ThrowIfNull(arg7, nameof(arg7));
            ThrowIfNull(arg8, nameof(arg8));
            ThrowIfNull(arg9, nameof(arg9));
            ThrowIfNull(arg10, nameof(arg10));
            ThrowIfNull(arg11, nameof(arg11));
            ThrowIfNull(arg12, nameof(arg12));
            ThrowIfNull(arg13, nameof(arg13));
            ThrowIfNull(arg14, nameof(arg14));
            ThrowIfNull(arg15, nameof(arg15));
            ThrowIfNull(arg16, nameof(arg16));
        }

        // ReSharper disable once ParameterOnlyUsedForPreconditionCheck.Local
        private static void ThrowIfNull<TArg>(TArg arg, string paramName)
        {
            if (arg == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }
    }
}
