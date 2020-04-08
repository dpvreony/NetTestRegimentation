// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace NetTestRegimentation
{
    /// <summary>
    /// Unit Tests for an Entity Framework DB Set Property.
    /// </summary>
    public interface ITestEntityFrameworkDbSetProperty
    {
        /// <summary>
        /// Tests to ensure a DBSet allows insert.
        /// </summary>
        void AllowsInsert();

        /// <summary>
        /// Test to ensure a DBSet doesn't allow inserts of duplicate keys.
        /// </summary>
        void PreventsDuplicateInsert();
    }
}
