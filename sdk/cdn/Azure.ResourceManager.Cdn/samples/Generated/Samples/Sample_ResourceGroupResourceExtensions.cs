// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Cdn.Samples
{
    public partial class Sample_ResourceGroupResourceExtensions
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CheckEndpointNameAvailability_CheckEndpointNameAvailability()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2024-02-01/examples/CheckEndpointNameAvailability.json
            // this example is just showing the usage of "CheckEndpointNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation
            EndpointNameAvailabilityContent content = new EndpointNameAvailabilityContent("sampleName", CdnResourceType.FrontDoorEndpoints)
            {
                AutoGeneratedDomainNameLabelScope = DomainNameLabelScope.TenantReuse,
            };
            EndpointNameAvailabilityResult result = await resourceGroupResource.CheckEndpointNameAvailabilityAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
