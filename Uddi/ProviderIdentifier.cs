﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProviderIdentifier.cs" company="Solidsoft Reply Ltd.">
//   Copyright 2015 Solidsoft Reply Limited.
// 
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
// 
//       http://www.apache.org/licenses/LICENSE-2.0
// 
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace SolidsoftReply.Esb.Libraries.Uddi
{
    /// <summary>
    /// Represents search identifiers for business entities.
    /// </summary>
    public class ProviderIdentifier : IIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderIdentifier"/> class.
        /// </summary>
        public ProviderIdentifier() 
            : this(string.Empty, false)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderIdentifier"/> class.
        /// </summary>
        /// <param name="identifier">
        /// The key.
        /// </param>
        /// <param name="isKey">
        /// The name.
        /// </param>
        public ProviderIdentifier(string identifier, bool isKey)
        {
            this.Value = identifier;
            this.IsKey = isKey;
        }

        /// <summary>
        /// Gets or sets a unique business entity identifier.  See UDDI spec, for information on V2 and V3 formats
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the Value is a business entity key or a name.
        /// </summary>
        public bool IsKey { get; set; }
    }
}
