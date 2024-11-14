// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Resources.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Cdn.Samples
{
    public partial class Sample_CdnOriginGroupResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_OriginGroupsGet()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2024-02-01/examples/OriginGroups_Get.json
            // this example is just showing the usage of "CdnOriginGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CdnOriginGroupResource created on azure
            // for more information of creating CdnOriginGroupResource, please refer to the document of CdnOriginGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string endpointName = "endpoint1";
            string originGroupName = "originGroup1";
            ResourceIdentifier cdnOriginGroupResourceId = CdnOriginGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, endpointName, originGroupName);
            CdnOriginGroupResource cdnOriginGroup = client.GetCdnOriginGroupResource(cdnOriginGroupResourceId);

            // invoke the operation
            CdnOriginGroupResource result = await cdnOriginGroup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CdnOriginGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_OriginGroupsUpdate()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2024-02-01/examples/OriginGroups_Update.json
            // this example is just showing the usage of "CdnOriginGroups_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CdnOriginGroupResource created on azure
            // for more information of creating CdnOriginGroupResource, please refer to the document of CdnOriginGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string endpointName = "endpoint1";
            string originGroupName = "originGroup1";
            ResourceIdentifier cdnOriginGroupResourceId = CdnOriginGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, endpointName, originGroupName);
            CdnOriginGroupResource cdnOriginGroup = client.GetCdnOriginGroupResource(cdnOriginGroupResourceId);

            // invoke the operation
            CdnOriginGroupPatch patch = new CdnOriginGroupPatch()
            {
                HealthProbeSettings = new HealthProbeSettings()
                {
                    ProbePath = "/health.aspx",
                    ProbeRequestType = HealthProbeRequestType.Get,
                    ProbeProtocol = HealthProbeProtocol.Http,
                    ProbeIntervalInSeconds = 120,
                },
                Origins =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/RG/providers/Microsoft.Cdn/profiles/profile1/endpoints/endpoint1/origins/origin2"),
}
},
            };
            ArmOperation<CdnOriginGroupResource> lro = await cdnOriginGroup.UpdateAsync(WaitUntil.Completed, patch);
            CdnOriginGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CdnOriginGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_OriginGroupsDelete()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2024-02-01/examples/OriginGroups_Delete.json
            // this example is just showing the usage of "CdnOriginGroups_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CdnOriginGroupResource created on azure
            // for more information of creating CdnOriginGroupResource, please refer to the document of CdnOriginGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string endpointName = "endpoint1";
            string originGroupName = "originGroup1";
            ResourceIdentifier cdnOriginGroupResourceId = CdnOriginGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, endpointName, originGroupName);
            CdnOriginGroupResource cdnOriginGroup = client.GetCdnOriginGroupResource(cdnOriginGroupResourceId);

            // invoke the operation
            await cdnOriginGroup.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }
    }
}
