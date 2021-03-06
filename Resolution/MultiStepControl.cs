﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MultiStepControl.cs" company="Solidsoft Reply Ltd.">
//   Copyright (c) 2015 Solidsoft Reply Limited. All rights reserved.
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

namespace SolidsoftReply.Esb.Libraries.Resolution
{
    /// <summary>
    /// Specifies the depth of processing required when calling OnStep
    /// on a Directives collection.
    /// </summary>
    public enum MultiStepControl
    {
        /// <summary>
        /// Process all BAM steps across the collection of directives.
        /// </summary>
        AllSteps,

        /// <summary>
        /// Process all BAM steps across the collection of directives.
        /// </summary>
        AllStepsWithExtensions,

        /// <summary>
        /// Process the first BAM step, only.  The is for the first directive
        /// found in the collection with a BAM step.
        /// </summary>
        FirstStepOnly,

        /// <summary>
        /// Process the first BAM step, only.  The is for the first directive
        /// found in the collection with a BAM step.
        /// </summary>
        FirstStepWithExtensions
    }
}
