// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Deidentification
{
    /// <summary> Paginated details of all documents in a job. </summary>
    public partial class PagedDocumentDetails
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PagedDocumentDetails"/>. </summary>
        /// <param name="nextLink"> Token to continue a previous query. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        internal PagedDocumentDetails(string nextLink)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));

            Value = new ChangeTrackingList<DocumentDetails>();
            NextLink = nextLink;
        }

        /// <summary> Initializes a new instance of <see cref="PagedDocumentDetails"/>. </summary>
        /// <param name="value"> List of documents. </param>
        /// <param name="nextLink"> Token to continue a previous query. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PagedDocumentDetails(IReadOnlyList<DocumentDetails> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PagedDocumentDetails"/> for deserialization. </summary>
        internal PagedDocumentDetails()
        {
        }

        /// <summary> List of documents. </summary>
        public IReadOnlyList<DocumentDetails> Value { get; }
        /// <summary> Token to continue a previous query. </summary>
        public string NextLink { get; }
    }
}
