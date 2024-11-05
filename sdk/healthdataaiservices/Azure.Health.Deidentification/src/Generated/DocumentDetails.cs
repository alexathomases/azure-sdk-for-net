// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Deidentification
{
    /// <summary> Details of a single document in a job. </summary>
    public partial class DocumentDetails
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

        /// <summary> Initializes a new instance of <see cref="DocumentDetails"/>. </summary>
        /// <param name="id"> Id of the document details. </param>
        /// <param name="input"> Location for the input. </param>
        /// <param name="status"> Status of the document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="input"/> is null. </exception>
        internal DocumentDetails(string id, DocumentLocation input, OperationState status)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(input, nameof(input));

            Id = id;
            Input = input;
            Status = status;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentDetails"/>. </summary>
        /// <param name="id"> Id of the document details. </param>
        /// <param name="input"> Location for the input. </param>
        /// <param name="output"> Location for the output. </param>
        /// <param name="status"> Status of the document. </param>
        /// <param name="error"> Error when document fails. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentDetails(string id, DocumentLocation input, DocumentLocation output, OperationState status, ResponseError error, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Input = input;
            Output = output;
            Status = status;
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentDetails"/> for deserialization. </summary>
        internal DocumentDetails()
        {
        }

        /// <summary> Id of the document details. </summary>
        public string Id { get; }
        /// <summary> Location for the input. </summary>
        public DocumentLocation Input { get; }
        /// <summary> Location for the output. </summary>
        public DocumentLocation Output { get; }
        /// <summary> Status of the document. </summary>
        public OperationState Status { get; }
        /// <summary> Error when document fails. </summary>
        public ResponseError Error { get; }
    }
}
