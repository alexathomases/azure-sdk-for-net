// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> Get Operation response object. </summary>
    public partial class DocumentClassifierBuildOperationDetails : DocumentIntelligenceOperationDetails
    {
        /// <summary> Initializes a new instance of <see cref="DocumentClassifierBuildOperationDetails"/>. </summary>
        /// <param name="operationId"> Operation ID. </param>
        /// <param name="status"> Operation status.  notStarted, running, completed, or failed. </param>
        /// <param name="createdOn"> Date and time (UTC) when the operation was created. </param>
        /// <param name="lastUpdatedOn"> Date and time (UTC) when the status was last updated. </param>
        /// <param name="resourceLocation"> URL of the resource targeted by this operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> or <paramref name="resourceLocation"/> is null. </exception>
        internal DocumentClassifierBuildOperationDetails(string operationId, DocumentIntelligenceOperationStatus status, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn, Uri resourceLocation) : base(operationId, status, createdOn, lastUpdatedOn, resourceLocation)
        {
            Argument.AssertNotNull(operationId, nameof(operationId));
            Argument.AssertNotNull(resourceLocation, nameof(resourceLocation));

            Kind = OperationKind.DocumentClassifierBuild;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentClassifierBuildOperationDetails"/>. </summary>
        /// <param name="operationId"> Operation ID. </param>
        /// <param name="status"> Operation status.  notStarted, running, completed, or failed. </param>
        /// <param name="percentCompleted"> Operation progress (0-100). </param>
        /// <param name="createdOn"> Date and time (UTC) when the operation was created. </param>
        /// <param name="lastUpdatedOn"> Date and time (UTC) when the status was last updated. </param>
        /// <param name="kind"> Type of operation. </param>
        /// <param name="resourceLocation"> URL of the resource targeted by this operation. </param>
        /// <param name="apiVersion"> API version used to create this operation. </param>
        /// <param name="tags"> List of key-value tag attributes associated with the document model. </param>
        /// <param name="error"> Encountered error. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="result"> Operation result upon success. </param>
        internal DocumentClassifierBuildOperationDetails(string operationId, DocumentIntelligenceOperationStatus status, int? percentCompleted, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn, OperationKind kind, Uri resourceLocation, string apiVersion, IReadOnlyDictionary<string, string> tags, DocumentIntelligenceError error, IDictionary<string, BinaryData> serializedAdditionalRawData, DocumentClassifierDetails result) : base(operationId, status, percentCompleted, createdOn, lastUpdatedOn, kind, resourceLocation, apiVersion, tags, error, serializedAdditionalRawData)
        {
            Result = result;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentClassifierBuildOperationDetails"/> for deserialization. </summary>
        internal DocumentClassifierBuildOperationDetails()
        {
        }

        /// <summary> Operation result upon success. </summary>
        public DocumentClassifierDetails Result { get; }
    }
}
