// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for TriggerOperator.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TriggerOperator
    {
        [EnumMember(Value = "GreaterThan")]
        GreaterThan,
        [EnumMember(Value = "LessThan")]
        LessThan,
        [EnumMember(Value = "Equal")]
        Equal,
        [EnumMember(Value = "NotEqual")]
        NotEqual
    }
    internal static class TriggerOperatorEnumExtension
    {
        internal static string ToSerializedValue(this TriggerOperator? value)
        {
            return value == null ? null : ((TriggerOperator)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this TriggerOperator value)
        {
            switch( value )
            {
                case TriggerOperator.GreaterThan:
                    return "GreaterThan";
                case TriggerOperator.LessThan:
                    return "LessThan";
                case TriggerOperator.Equal:
                    return "Equal";
                case TriggerOperator.NotEqual:
                    return "NotEqual";
            }
            return null;
        }

        internal static TriggerOperator? ParseTriggerOperator(this string value)
        {
            switch( value )
            {
                case "GreaterThan":
                    return TriggerOperator.GreaterThan;
                case "LessThan":
                    return TriggerOperator.LessThan;
                case "Equal":
                    return TriggerOperator.Equal;
                case "NotEqual":
                    return TriggerOperator.NotEqual;
            }
            return null;
        }
    }
}
