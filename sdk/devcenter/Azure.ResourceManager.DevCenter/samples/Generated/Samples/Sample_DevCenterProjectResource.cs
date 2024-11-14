// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DevCenter.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.DevCenter.Samples
{
    public partial class Sample_DevCenterProjectResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetDevCenterProjects_ProjectsListBySubscription()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/Projects_ListBySubscription.json
            // this example is just showing the usage of "Projects_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "0ac520ee-14c0-480f-b6c9-0a90c58ffff";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (DevCenterProjectResource item in subscriptionResource.GetDevCenterProjectsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DevCenterProjectData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ProjectsGet()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/Projects_Get.json
            // this example is just showing the usage of "Projects_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterProjectResource created on azure
            // for more information of creating DevCenterProjectResource, please refer to the document of DevCenterProjectResource
            string subscriptionId = "0ac520ee-14c0-480f-b6c9-0a90c58ffff";
            string resourceGroupName = "rg1";
            string projectName = "DevProject";
            ResourceIdentifier devCenterProjectResourceId = DevCenterProjectResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName);
            DevCenterProjectResource devCenterProject = client.GetDevCenterProjectResource(devCenterProjectResourceId);

            // invoke the operation
            DevCenterProjectResource result = await devCenterProject.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevCenterProjectData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ProjectsUpdate()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/Projects_Patch.json
            // this example is just showing the usage of "Projects_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterProjectResource created on azure
            // for more information of creating DevCenterProjectResource, please refer to the document of DevCenterProjectResource
            string subscriptionId = "0ac520ee-14c0-480f-b6c9-0a90c58ffff";
            string resourceGroupName = "rg1";
            string projectName = "DevProject";
            ResourceIdentifier devCenterProjectResourceId = DevCenterProjectResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName);
            DevCenterProjectResource devCenterProject = client.GetDevCenterProjectResource(devCenterProjectResourceId);

            // invoke the operation
            DevCenterProjectPatch patch = new DevCenterProjectPatch()
            {
                Description = "This is my first project.",
                Tags =
{
["CostCenter"] = "R&D",
},
            };
            ArmOperation<DevCenterProjectResource> lro = await devCenterProject.UpdateAsync(WaitUntil.Completed, patch);
            DevCenterProjectResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevCenterProjectData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ProjectsDelete()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/Projects_Delete.json
            // this example is just showing the usage of "Projects_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterProjectResource created on azure
            // for more information of creating DevCenterProjectResource, please refer to the document of DevCenterProjectResource
            string subscriptionId = "0ac520ee-14c0-480f-b6c9-0a90c58ffff";
            string resourceGroupName = "rg1";
            string projectName = "DevProject";
            ResourceIdentifier devCenterProjectResourceId = DevCenterProjectResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName);
            DevCenterProjectResource devCenterProject = client.GetDevCenterProjectResource(devCenterProjectResourceId);

            // invoke the operation
            await devCenterProject.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }
    }
}
