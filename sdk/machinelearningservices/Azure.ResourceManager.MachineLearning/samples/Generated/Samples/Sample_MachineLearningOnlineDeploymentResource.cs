// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MachineLearning.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.MachineLearning.Samples
{
    public partial class Sample_MachineLearningOnlineDeploymentResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetKubernetesOnlineDeployment()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/OnlineDeployment/KubernetesOnlineDeployment/get.json
            // this example is just showing the usage of "OnlineDeployments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningOnlineDeploymentResource created on azure
            // for more information of creating MachineLearningOnlineDeploymentResource, please refer to the document of MachineLearningOnlineDeploymentResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string endpointName = "testEndpointName";
            string deploymentName = "testDeploymentName";
            ResourceIdentifier machineLearningOnlineDeploymentResourceId = MachineLearningOnlineDeploymentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, endpointName, deploymentName);
            MachineLearningOnlineDeploymentResource machineLearningOnlineDeployment = client.GetMachineLearningOnlineDeploymentResource(machineLearningOnlineDeploymentResourceId);

            // invoke the operation
            MachineLearningOnlineDeploymentResource result = await machineLearningOnlineDeployment.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningOnlineDeploymentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetManagedOnlineDeployment()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/OnlineDeployment/ManagedOnlineDeployment/get.json
            // this example is just showing the usage of "OnlineDeployments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningOnlineDeploymentResource created on azure
            // for more information of creating MachineLearningOnlineDeploymentResource, please refer to the document of MachineLearningOnlineDeploymentResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string endpointName = "testEndpointName";
            string deploymentName = "testDeploymentName";
            ResourceIdentifier machineLearningOnlineDeploymentResourceId = MachineLearningOnlineDeploymentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, endpointName, deploymentName);
            MachineLearningOnlineDeploymentResource machineLearningOnlineDeployment = client.GetMachineLearningOnlineDeploymentResource(machineLearningOnlineDeploymentResourceId);

            // invoke the operation
            MachineLearningOnlineDeploymentResource result = await machineLearningOnlineDeployment.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningOnlineDeploymentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteWorkspaceOnlineDeployment()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/OnlineDeployment/delete.json
            // this example is just showing the usage of "OnlineDeployments_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningOnlineDeploymentResource created on azure
            // for more information of creating MachineLearningOnlineDeploymentResource, please refer to the document of MachineLearningOnlineDeploymentResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg123";
            string workspaceName = "workspace123";
            string endpointName = "testEndpoint";
            string deploymentName = "testDeployment";
            ResourceIdentifier machineLearningOnlineDeploymentResourceId = MachineLearningOnlineDeploymentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, endpointName, deploymentName);
            MachineLearningOnlineDeploymentResource machineLearningOnlineDeployment = client.GetMachineLearningOnlineDeploymentResource(machineLearningOnlineDeploymentResourceId);

            // invoke the operation
            await machineLearningOnlineDeployment.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateKubernetesOnlineDeployment()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/OnlineDeployment/KubernetesOnlineDeployment/update.json
            // this example is just showing the usage of "OnlineDeployments_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningOnlineDeploymentResource created on azure
            // for more information of creating MachineLearningOnlineDeploymentResource, please refer to the document of MachineLearningOnlineDeploymentResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string endpointName = "testEndpointName";
            string deploymentName = "testDeploymentName";
            ResourceIdentifier machineLearningOnlineDeploymentResourceId = MachineLearningOnlineDeploymentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, endpointName, deploymentName);
            MachineLearningOnlineDeploymentResource machineLearningOnlineDeployment = client.GetMachineLearningOnlineDeploymentResource(machineLearningOnlineDeploymentResourceId);

            // invoke the operation
            MachineLearningOnlineDeploymentPatch patch = new MachineLearningOnlineDeploymentPatch
            {
                Sku = new MachineLearningSkuPatch
                {
                    Name = "string",
                    Tier = MachineLearningSkuTier.Free,
                    Size = "string",
                    Family = "string",
                    Capacity = 1,
                },
                Tags = { },
            };
            ArmOperation<MachineLearningOnlineDeploymentResource> lro = await machineLearningOnlineDeployment.UpdateAsync(WaitUntil.Completed, patch);
            MachineLearningOnlineDeploymentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningOnlineDeploymentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateManagedOnlineDeployment()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/OnlineDeployment/ManagedOnlineDeployment/update.json
            // this example is just showing the usage of "OnlineDeployments_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningOnlineDeploymentResource created on azure
            // for more information of creating MachineLearningOnlineDeploymentResource, please refer to the document of MachineLearningOnlineDeploymentResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string endpointName = "testEndpointName";
            string deploymentName = "testDeploymentName";
            ResourceIdentifier machineLearningOnlineDeploymentResourceId = MachineLearningOnlineDeploymentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, endpointName, deploymentName);
            MachineLearningOnlineDeploymentResource machineLearningOnlineDeployment = client.GetMachineLearningOnlineDeploymentResource(machineLearningOnlineDeploymentResourceId);

            // invoke the operation
            MachineLearningOnlineDeploymentPatch patch = new MachineLearningOnlineDeploymentPatch
            {
                Sku = new MachineLearningSkuPatch
                {
                    Name = "string",
                    Tier = MachineLearningSkuTier.Free,
                    Size = "string",
                    Family = "string",
                    Capacity = 1,
                },
                Tags = { },
            };
            ArmOperation<MachineLearningOnlineDeploymentResource> lro = await machineLearningOnlineDeployment.UpdateAsync(WaitUntil.Completed, patch);
            MachineLearningOnlineDeploymentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningOnlineDeploymentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetLogs_GetOnlineDeploymentLogs()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/OnlineDeployment/getLogs.json
            // this example is just showing the usage of "OnlineDeployments_GetLogs" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningOnlineDeploymentResource created on azure
            // for more information of creating MachineLearningOnlineDeploymentResource, please refer to the document of MachineLearningOnlineDeploymentResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg123";
            string workspaceName = "workspace123";
            string endpointName = "testEndpoint";
            string deploymentName = "testDeployment";
            ResourceIdentifier machineLearningOnlineDeploymentResourceId = MachineLearningOnlineDeploymentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, endpointName, deploymentName);
            MachineLearningOnlineDeploymentResource machineLearningOnlineDeployment = client.GetMachineLearningOnlineDeploymentResource(machineLearningOnlineDeploymentResourceId);

            // invoke the operation
            MachineLearningDeploymentLogsContent content = new MachineLearningDeploymentLogsContent
            {
                ContainerType = MachineLearningContainerType.StorageInitializer,
                Tail = 0,
            };
            MachineLearningDeploymentLogs result = await machineLearningOnlineDeployment.GetLogsAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetSkus_ListKubernetesOnlineDeploymentSkus()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/OnlineDeployment/KubernetesOnlineDeployment/listSkus.json
            // this example is just showing the usage of "OnlineDeployments_ListSkus" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningOnlineDeploymentResource created on azure
            // for more information of creating MachineLearningOnlineDeploymentResource, please refer to the document of MachineLearningOnlineDeploymentResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string endpointName = "testEndpointName";
            string deploymentName = "testDeploymentName";
            ResourceIdentifier machineLearningOnlineDeploymentResourceId = MachineLearningOnlineDeploymentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, endpointName, deploymentName);
            MachineLearningOnlineDeploymentResource machineLearningOnlineDeployment = client.GetMachineLearningOnlineDeploymentResource(machineLearningOnlineDeploymentResourceId);

            // invoke the operation and iterate over the result
            int? count = 1;
            await foreach (MachineLearningSkuDetail item in machineLearningOnlineDeployment.GetSkusAsync(count: count))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetSkus_ListManagedOnlineDeploymentSkus()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/OnlineDeployment/ManagedOnlineDeployment/listSkus.json
            // this example is just showing the usage of "OnlineDeployments_ListSkus" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningOnlineDeploymentResource created on azure
            // for more information of creating MachineLearningOnlineDeploymentResource, please refer to the document of MachineLearningOnlineDeploymentResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string endpointName = "testEndpointName";
            string deploymentName = "testDeploymentName";
            ResourceIdentifier machineLearningOnlineDeploymentResourceId = MachineLearningOnlineDeploymentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, endpointName, deploymentName);
            MachineLearningOnlineDeploymentResource machineLearningOnlineDeployment = client.GetMachineLearningOnlineDeploymentResource(machineLearningOnlineDeploymentResourceId);

            // invoke the operation and iterate over the result
            int? count = 1;
            await foreach (MachineLearningSkuDetail item in machineLearningOnlineDeployment.GetSkusAsync(count: count))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
