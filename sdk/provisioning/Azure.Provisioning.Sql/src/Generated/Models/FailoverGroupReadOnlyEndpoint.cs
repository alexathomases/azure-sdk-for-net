// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;

namespace Azure.Provisioning.Sql;

/// <summary>
/// Read-only endpoint of the failover group instance.
/// </summary>
public partial class FailoverGroupReadOnlyEndpoint : ProvisionableConstruct
{
    /// <summary>
    /// Failover policy of the read-only endpoint for the failover group.
    /// </summary>
    public BicepValue<ReadOnlyEndpointFailoverPolicy> FailoverPolicy 
    {
        get { Initialize(); return _failoverPolicy!; }
        set { Initialize(); _failoverPolicy!.Assign(value); }
    }
    private BicepValue<ReadOnlyEndpointFailoverPolicy>? _failoverPolicy;

    /// <summary>
    /// The target partner server where the read-only endpoint points to.
    /// </summary>
    public BicepValue<ResourceIdentifier> TargetServer 
    {
        get { Initialize(); return _targetServer!; }
        set { Initialize(); _targetServer!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _targetServer;

    /// <summary>
    /// Creates a new FailoverGroupReadOnlyEndpoint.
    /// </summary>
    public FailoverGroupReadOnlyEndpoint()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// FailoverGroupReadOnlyEndpoint.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _failoverPolicy = DefineProperty<ReadOnlyEndpointFailoverPolicy>("FailoverPolicy", ["failoverPolicy"]);
        _targetServer = DefineProperty<ResourceIdentifier>("TargetServer", ["targetServer"]);
    }
}
