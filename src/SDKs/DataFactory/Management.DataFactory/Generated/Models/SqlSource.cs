// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A copy activity SQL source.
    /// </summary>
    public partial class SqlSource : CopySource
    {
        /// <summary>
        /// Initializes a new instance of the SqlSource class.
        /// </summary>
        public SqlSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlSource class.
        /// </summary>
        /// <param name="sourceRetryCount">Source retry count. Type: integer
        /// (or Expression with resultType integer).</param>
        /// <param name="sourceRetryWait">Source retry wait. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="sqlReaderQuery">SQL reader query. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="sqlReaderStoredProcedureName">Name of the stored
        /// procedure for a SQL Database source. This cannot be used at the
        /// same time as SqlReaderQuery. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="storedProcedureParameters">Value and type setting for
        /// stored procedure parameters. Example: "{Parameter1: {value: "1",
        /// type: "int"}}".</param>
        public SqlSource(object sourceRetryCount = default(object), object sourceRetryWait = default(object), object sqlReaderQuery = default(object), object sqlReaderStoredProcedureName = default(object), IDictionary<string, StoredProcedureParameter> storedProcedureParameters = default(IDictionary<string, StoredProcedureParameter>))
            : base(sourceRetryCount, sourceRetryWait)
        {
            SqlReaderQuery = sqlReaderQuery;
            SqlReaderStoredProcedureName = sqlReaderStoredProcedureName;
            StoredProcedureParameters = storedProcedureParameters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets SQL reader query. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "sqlReaderQuery")]
        public object SqlReaderQuery { get; set; }

        /// <summary>
        /// Gets or sets name of the stored procedure for a SQL Database
        /// source. This cannot be used at the same time as SqlReaderQuery.
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "sqlReaderStoredProcedureName")]
        public object SqlReaderStoredProcedureName { get; set; }

        /// <summary>
        /// Gets or sets value and type setting for stored procedure
        /// parameters. Example: "{Parameter1: {value: "1", type: "int"}}".
        /// </summary>
        [JsonProperty(PropertyName = "storedProcedureParameters")]
        public IDictionary<string, StoredProcedureParameter> StoredProcedureParameters { get; set; }

    }
}