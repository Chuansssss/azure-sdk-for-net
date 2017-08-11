// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Logic;
    using Microsoft.Azure.Management.Logic.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for X12TimeFormat.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum X12TimeFormat
    {
        [EnumMember(Value = "NotSpecified")]
        NotSpecified,
        [EnumMember(Value = "HHMM")]
        HHMM,
        [EnumMember(Value = "HHMMSS")]
        HHMMSS,
        [EnumMember(Value = "HHMMSSdd")]
        HHMMSSdd,
        [EnumMember(Value = "HHMMSSd")]
        HHMMSSd
    }
    internal static class X12TimeFormatEnumExtension
    {
        internal static string ToSerializedValue(this X12TimeFormat? value)
        {
            return value == null ? null : ((X12TimeFormat)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this X12TimeFormat value)
        {
            switch( value )
            {
                case X12TimeFormat.NotSpecified:
                    return "NotSpecified";
                case X12TimeFormat.HHMM:
                    return "HHMM";
                case X12TimeFormat.HHMMSS:
                    return "HHMMSS";
                case X12TimeFormat.HHMMSSdd:
                    return "HHMMSSdd";
                case X12TimeFormat.HHMMSSd:
                    return "HHMMSSd";
            }
            return null;
        }

        internal static X12TimeFormat? ParseX12TimeFormat(this string value)
        {
            switch( value )
            {
                case "NotSpecified":
                    return X12TimeFormat.NotSpecified;
                case "HHMM":
                    return X12TimeFormat.HHMM;
                case "HHMMSS":
                    return X12TimeFormat.HHMMSS;
                case "HHMMSSdd":
                    return X12TimeFormat.HHMMSSdd;
                case "HHMMSSd":
                    return X12TimeFormat.HHMMSSd;
            }
            return null;
        }
    }
}