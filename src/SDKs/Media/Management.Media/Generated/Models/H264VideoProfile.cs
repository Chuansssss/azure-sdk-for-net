// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for H264VideoProfile.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(H264VideoProfileConverter))]
    public struct H264VideoProfile : System.IEquatable<H264VideoProfile>
    {
        private H264VideoProfile(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// Tells the encoder to automatically determine the appropriate H.264
        /// profile.
        /// </summary>
        public static readonly H264VideoProfile Auto = "Auto";

        /// <summary>
        /// Baseline profile
        /// </summary>
        public static readonly H264VideoProfile Baseline = "Baseline";

        /// <summary>
        /// Main profile
        /// </summary>
        public static readonly H264VideoProfile Main = "Main";

        /// <summary>
        /// High profile.
        /// </summary>
        public static readonly H264VideoProfile High = "High";

        /// <summary>
        /// High 4:2:2 profile.
        /// </summary>
        public static readonly H264VideoProfile High422 = "High422";

        /// <summary>
        /// High 4:4:4 predictive profile.
        /// </summary>
        public static readonly H264VideoProfile High444 = "High444";


        /// <summary>
        /// Underlying value of enum H264VideoProfile
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for H264VideoProfile
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type H264VideoProfile
        /// </summary>
        public bool Equals(H264VideoProfile e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to H264VideoProfile
        /// </summary>
        public static implicit operator H264VideoProfile(string value)
        {
            return new H264VideoProfile(value);
        }

        /// <summary>
        /// Implicit operator to convert H264VideoProfile to string
        /// </summary>
        public static implicit operator string(H264VideoProfile e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum H264VideoProfile
        /// </summary>
        public static bool operator == (H264VideoProfile e1, H264VideoProfile e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum H264VideoProfile
        /// </summary>
        public static bool operator != (H264VideoProfile e1, H264VideoProfile e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for H264VideoProfile
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is H264VideoProfile && Equals((H264VideoProfile)obj);
        }

        /// <summary>
        /// Returns for hashCode H264VideoProfile
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}