// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Avs.Samples
{
    public partial class Sample_ScriptCmdletCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ScriptCmdletsList()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/ScriptCmdlets_List.json
            // this example is just showing the usage of "ScriptCmdlets_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScriptPackageResource created on azure
            // for more information of creating ScriptPackageResource, please refer to the document of ScriptPackageResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string scriptPackageName = "package@1.0.2";
            ResourceIdentifier scriptPackageResourceId = ScriptPackageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, scriptPackageName);
            ScriptPackageResource scriptPackage = client.GetScriptPackageResource(scriptPackageResourceId);

            // get the collection of this ScriptCmdletResource
            ScriptCmdletCollection collection = scriptPackage.GetScriptCmdlets();

            // invoke the operation and iterate over the result
            await foreach (ScriptCmdletResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ScriptCmdletData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ScriptCmdletsGet()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/ScriptCmdlets_Get.json
            // this example is just showing the usage of "ScriptCmdlets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScriptPackageResource created on azure
            // for more information of creating ScriptPackageResource, please refer to the document of ScriptPackageResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string scriptPackageName = "package@1.0.2";
            ResourceIdentifier scriptPackageResourceId = ScriptPackageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, scriptPackageName);
            ScriptPackageResource scriptPackage = client.GetScriptPackageResource(scriptPackageResourceId);

            // get the collection of this ScriptCmdletResource
            ScriptCmdletCollection collection = scriptPackage.GetScriptCmdlets();

            // invoke the operation
            string scriptCmdletName = "New-ExternalSsoDomain";
            ScriptCmdletResource result = await collection.GetAsync(scriptCmdletName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScriptCmdletData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_ScriptCmdletsGet()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/ScriptCmdlets_Get.json
            // this example is just showing the usage of "ScriptCmdlets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScriptPackageResource created on azure
            // for more information of creating ScriptPackageResource, please refer to the document of ScriptPackageResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string scriptPackageName = "package@1.0.2";
            ResourceIdentifier scriptPackageResourceId = ScriptPackageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, scriptPackageName);
            ScriptPackageResource scriptPackage = client.GetScriptPackageResource(scriptPackageResourceId);

            // get the collection of this ScriptCmdletResource
            ScriptCmdletCollection collection = scriptPackage.GetScriptCmdlets();

            // invoke the operation
            string scriptCmdletName = "New-ExternalSsoDomain";
            bool result = await collection.ExistsAsync(scriptCmdletName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_ScriptCmdletsGet()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/ScriptCmdlets_Get.json
            // this example is just showing the usage of "ScriptCmdlets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScriptPackageResource created on azure
            // for more information of creating ScriptPackageResource, please refer to the document of ScriptPackageResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string scriptPackageName = "package@1.0.2";
            ResourceIdentifier scriptPackageResourceId = ScriptPackageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, scriptPackageName);
            ScriptPackageResource scriptPackage = client.GetScriptPackageResource(scriptPackageResourceId);

            // get the collection of this ScriptCmdletResource
            ScriptCmdletCollection collection = scriptPackage.GetScriptCmdlets();

            // invoke the operation
            string scriptCmdletName = "New-ExternalSsoDomain";
            NullableResponse<ScriptCmdletResource> response = await collection.GetIfExistsAsync(scriptCmdletName);
            ScriptCmdletResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ScriptCmdletData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
