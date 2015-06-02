﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OesTrackpointEventStream.cs" company="Solidsoft Reply Ltd.">
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

namespace SolidsoftReply.Esb.Libraries.BizTalk.Orchestration
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;

    using SolidsoftReply.Esb.Libraries.Resolution;

    /// <summary>
    /// A BAM event stream for resolution directives that uses the Orchestration
    /// Event Stream (OES) via the OesEventStream.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
    [ComVisible(true)]
    [Serializable]
    public class OesTrackpointEventStream : TrackpointDirectiveEventStream
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OesTrackpointEventStream"/> class.
        /// </summary>
        /// <param name="directive">
        /// The directive.
        /// </param>
        public OesTrackpointEventStream(Resolution.Directive directive)
            : base(directive, new OesEventStream())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OesTrackpointEventStream"/> class.
        /// </summary>
        /// <param name="directive">
        /// The directive.
        /// </param>
        /// <param name="data">Additional data for the current step.</param>
        public OesTrackpointEventStream(Resolution.Directive directive, Resolution.BamStepData data)
            : base(directive, new OesEventStream(), data)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OesTrackpointEventStream"/> class.
        /// </summary>
        /// <param name="directive">
        /// The directive.
        /// </param>
        public OesTrackpointEventStream(Directive directive)
            : base(directive, new OesEventStream())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OesTrackpointEventStream"/> class.
        /// </summary>
        /// <param name="directive">
        /// The directive.
        /// </param>
        /// <param name="data">Additional data for the current step.</param>
        public OesTrackpointEventStream(Directive directive, Resolution.BamStepData data)
            : base(directive, new OesEventStream(), data)
        {
        }
    }
}
