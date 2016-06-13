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

    public partial class IssuerReference
    {
        /// <summary>
        /// Initializes a new instance of the IssuerReference class.
        /// </summary>
        public IssuerReference() { }

        /// <summary>
        /// Initializes a new instance of the IssuerReference class.
        /// </summary>
        public IssuerReference(string name = default(string))
        {
            Name = name;
        }

        /// <summary>
        /// Gets or sets name of the referenced issuer object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
