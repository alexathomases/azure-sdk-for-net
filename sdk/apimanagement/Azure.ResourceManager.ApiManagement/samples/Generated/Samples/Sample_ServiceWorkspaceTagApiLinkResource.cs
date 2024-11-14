// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ServiceWorkspaceTagApiLinkResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetWorkspaceTagApiLink()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetWorkspaceTagApiLink.json
            // this example is just showing the usage of "WorkspaceTagApiLink_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceTagApiLinkResource created on azure
            // for more information of creating ServiceWorkspaceTagApiLinkResource, please refer to the document of ServiceWorkspaceTagApiLinkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string tagId = "tag1";
            string apiLinkId = "link1";
            ResourceIdentifier serviceWorkspaceTagApiLinkResourceId = ServiceWorkspaceTagApiLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, tagId, apiLinkId);
            ServiceWorkspaceTagApiLinkResource serviceWorkspaceTagApiLink = client.GetServiceWorkspaceTagApiLinkResource(serviceWorkspaceTagApiLinkResourceId);

            // invoke the operation
            ServiceWorkspaceTagApiLinkResource result = await serviceWorkspaceTagApiLink.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TagApiLinkContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ApiManagementCreateWorkspaceTagApiLink()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementCreateWorkspaceTagApiLink.json
            // this example is just showing the usage of "WorkspaceTagApiLink_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceTagApiLinkResource created on azure
            // for more information of creating ServiceWorkspaceTagApiLinkResource, please refer to the document of ServiceWorkspaceTagApiLinkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string tagId = "tag1";
            string apiLinkId = "link1";
            ResourceIdentifier serviceWorkspaceTagApiLinkResourceId = ServiceWorkspaceTagApiLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, tagId, apiLinkId);
            ServiceWorkspaceTagApiLinkResource serviceWorkspaceTagApiLink = client.GetServiceWorkspaceTagApiLinkResource(serviceWorkspaceTagApiLinkResourceId);

            // invoke the operation
            TagApiLinkContractData data = new TagApiLinkContractData()
            {
                ApiId = "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.ApiManagement/service/apimService1/workspaces/wks1/apis/echo-api",
            };
            ArmOperation<ServiceWorkspaceTagApiLinkResource> lro = await serviceWorkspaceTagApiLink.UpdateAsync(WaitUntil.Completed, data);
            ServiceWorkspaceTagApiLinkResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TagApiLinkContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ApiManagementDeleteWorkspaceTagApiLink()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementDeleteWorkspaceTagApiLink.json
            // this example is just showing the usage of "WorkspaceTagApiLink_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceTagApiLinkResource created on azure
            // for more information of creating ServiceWorkspaceTagApiLinkResource, please refer to the document of ServiceWorkspaceTagApiLinkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string tagId = "tag1";
            string apiLinkId = "link1";
            ResourceIdentifier serviceWorkspaceTagApiLinkResourceId = ServiceWorkspaceTagApiLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, tagId, apiLinkId);
            ServiceWorkspaceTagApiLinkResource serviceWorkspaceTagApiLink = client.GetServiceWorkspaceTagApiLinkResource(serviceWorkspaceTagApiLinkResourceId);

            // invoke the operation
            await serviceWorkspaceTagApiLink.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }
    }
}
