// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Workloads.Samples
{
    public partial class Sample_SapMonitorResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetSapMonitors_ListAllSAPMonitorsInASubscription()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/workloadmonitor/monitors_List.json
            // this example is just showing the usage of "monitors_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (SapMonitorResource item in subscriptionResource.GetSapMonitorsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SapMonitorData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetPropertiesOfASAPMonitor()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/workloadmonitor/monitors_Get.json
            // this example is just showing the usage of "monitors_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapMonitorResource created on azure
            // for more information of creating SapMonitorResource, please refer to the document of SapMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "mySapMonitor";
            ResourceIdentifier sapMonitorResourceId = SapMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            SapMonitorResource sapMonitor = client.GetSapMonitorResource(sapMonitorResourceId);

            // invoke the operation
            SapMonitorResource result = await sapMonitor.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SapMonitorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeletesASAPMonitor()
        {
            // Generated from example definition: specification/workloads/resource-manager/Microsoft.Workloads/stable/2023-04-01/examples/workloadmonitor/monitors_Delete.json
            // this example is just showing the usage of "monitors_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapMonitorResource created on azure
            // for more information of creating SapMonitorResource, please refer to the document of SapMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "mySapMonitor";
            ResourceIdentifier sapMonitorResourceId = SapMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            SapMonitorResource sapMonitor = client.GetSapMonitorResource(sapMonitorResourceId);

            // invoke the operation
            ArmOperation<OperationStatusResult> lro = await sapMonitor.DeleteAsync(WaitUntil.Completed);
            OperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
