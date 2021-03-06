// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Values returned by the Get Subscription Quotas operation.
    /// </summary>
    public partial class SubscriptionQuotasGetResult
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionQuotasGetResult
        /// class.
        /// </summary>
        public SubscriptionQuotasGetResult() { }

        /// <summary>
        /// Initializes a new instance of the SubscriptionQuotasGetResult
        /// class.
        /// </summary>
        public SubscriptionQuotasGetResult(int? accountQuota = default(int?))
        {
            AccountQuota = accountQuota;
        }

        /// <summary>
        /// Gets or sets the number of Batch accounts that may be created
        /// under the subscription in the specified region.
        /// </summary>
        [JsonProperty(PropertyName = "accountQuota")]
        public int? AccountQuota { get; set; }

    }
}
