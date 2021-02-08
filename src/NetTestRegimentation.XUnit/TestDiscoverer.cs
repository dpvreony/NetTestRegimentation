// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using Xunit.Abstractions;

namespace NetTestRegimentation.XUnit
{
    /// <summary>
    /// Concept Data Discoverer for XUnit.
    /// The issue we have
    ///
    /// 1) we want the subclass to specify the test data source.
    /// 2) we can't use generics with attributes
    /// 3) xunit memberdata requires static properties, fields or methods.
    /// 4) you can't have static members that are abstract.
    ///
    /// what we can consider:
    ///
    /// 1) inject into the test discover for facts.
    /// 2) have a class level test source attribute on the subclass that takes an interface argument that constrains the test sources.
    /// 3) we use a source generator that removes all the reflective based discovery.
    /// </summary>
    public class TestDiscoverer : global::Xunit.Sdk.IDataDiscoverer
    {
        /// <inheritdoc/>
        public IEnumerable<object[]> GetData(IAttributeInfo dataAttribute, IMethodInfo testMethod)
        {
        }

        /// <inheritdoc/>
        public bool SupportsDiscoveryEnumeration(IAttributeInfo dataAttribute, IMethodInfo testMethod)
        {
            return true;
        }
    }
}
