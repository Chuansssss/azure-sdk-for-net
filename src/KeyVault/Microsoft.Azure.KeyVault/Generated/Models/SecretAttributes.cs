// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.KeyVault.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class SecretAttributes : Attributes
    {
        /// <summary>
        /// Initializes a new instance of the SecretAttributes class.
        /// </summary>
        public SecretAttributes() { }

        /// <summary>
        /// Initializes a new instance of the SecretAttributes class.
        /// </summary>
        public SecretAttributes(bool? enabled = default(bool?), DateTime? notBefore = default(DateTime?), DateTime? expires = default(DateTime?), DateTime? created = default(DateTime?), DateTime? updated = default(DateTime?))
            : base(enabled, notBefore, expires, created, updated)
        {
        }

    }
}
