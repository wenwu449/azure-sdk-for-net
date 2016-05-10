// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServerManagement.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// the response to a prompt message
    /// </summary>
    public partial class PromptMessageResponse
    {
        /// <summary>
        /// Initializes a new instance of the PromptMessageResponse class.
        /// </summary>
        public PromptMessageResponse() { }

        /// <summary>
        /// Initializes a new instance of the PromptMessageResponse class.
        /// </summary>
        public PromptMessageResponse(IList<string> response = default(IList<string>))
        {
            Response = response;
        }

        /// <summary>
        /// the list of responses a cmdlet expects
        /// </summary>
        [JsonProperty(PropertyName = "response")]
        public IList<string> Response { get; set; }

    }
}