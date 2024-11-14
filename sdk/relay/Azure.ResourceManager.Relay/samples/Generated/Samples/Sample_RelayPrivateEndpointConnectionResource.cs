// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Relay.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Relay.Samples
{
    public partial class Sample_RelayPrivateEndpointConnectionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_NameSpacePrivateEndPointConnectionCreate()
        {
            // Generated from example definition: specification/relay/resource-manager/Microsoft.Relay/stable/2021-11-01/examples/PrivateEndpointConnections/PrivateEndpointConnectionsCreate.json
            // this example is just showing the usage of "PrivateEndpointConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RelayPrivateEndpointConnectionResource created on azure
            // for more information of creating RelayPrivateEndpointConnectionResource, please refer to the document of RelayPrivateEndpointConnectionResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "resourcegroup";
            string namespaceName = "example-RelayNamespace-5849";
            string privateEndpointConnectionName = "{privateEndpointConnection name}";
            ResourceIdentifier relayPrivateEndpointConnectionResourceId = RelayPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, privateEndpointConnectionName);
            RelayPrivateEndpointConnectionResource relayPrivateEndpointConnection = client.GetRelayPrivateEndpointConnectionResource(relayPrivateEndpointConnectionResourceId);

            // invoke the operation
            RelayPrivateEndpointConnectionData data = new RelayPrivateEndpointConnectionData()
            {
                PrivateEndpointId = new ResourceIdentifier("/subscriptions/ffffffff-ffff-ffff-ffff-ffffffffffff/resourceGroups/resourcegroup/providers/Microsoft.Network/privateEndpoints/ali-relay-pve-1"),
                ConnectionState = new RelayPrivateLinkServiceConnectionState()
                {
                    Status = RelayPrivateLinkConnectionStatus.Approved,
                    Description = "You may pass",
                },
            };
            ArmOperation<RelayPrivateEndpointConnectionResource> lro = await relayPrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, data);
            RelayPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RelayPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_NameSpacePrivateEndPointConnectionDelete()
        {
            // Generated from example definition: specification/relay/resource-manager/Microsoft.Relay/stable/2021-11-01/examples/PrivateEndpointConnections/PrivateEndpointConnectionsDelete.json
            // this example is just showing the usage of "PrivateEndpointConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RelayPrivateEndpointConnectionResource created on azure
            // for more information of creating RelayPrivateEndpointConnectionResource, please refer to the document of RelayPrivateEndpointConnectionResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "myResourceGroup";
            string namespaceName = "example-RelayNamespace-5849";
            string privateEndpointConnectionName = "{privateEndpointConnection name}";
            ResourceIdentifier relayPrivateEndpointConnectionResourceId = RelayPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, privateEndpointConnectionName);
            RelayPrivateEndpointConnectionResource relayPrivateEndpointConnection = client.GetRelayPrivateEndpointConnectionResource(relayPrivateEndpointConnectionResourceId);

            // invoke the operation
            await relayPrivateEndpointConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_NameSpacePrivateEndPointConnectionGet()
        {
            // Generated from example definition: specification/relay/resource-manager/Microsoft.Relay/stable/2021-11-01/examples/PrivateEndpointConnections/PrivateEndpointConnectionsGet.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RelayPrivateEndpointConnectionResource created on azure
            // for more information of creating RelayPrivateEndpointConnectionResource, please refer to the document of RelayPrivateEndpointConnectionResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "myResourceGroup";
            string namespaceName = "example-RelayNamespace-5849";
            string privateEndpointConnectionName = "{privateEndpointConnection name}";
            ResourceIdentifier relayPrivateEndpointConnectionResourceId = RelayPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, privateEndpointConnectionName);
            RelayPrivateEndpointConnectionResource relayPrivateEndpointConnection = client.GetRelayPrivateEndpointConnectionResource(relayPrivateEndpointConnectionResourceId);

            // invoke the operation
            RelayPrivateEndpointConnectionResource result = await relayPrivateEndpointConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RelayPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
