// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.CosmosDB.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.CosmosDB.Samples
{
    public partial class Sample_MongoDBRoleDefinitionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_CosmosDBMongoRoleDefinitionGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-09-01-preview/examples/CosmosDBMongoDBRoleDefinitionGet.json
            // this example is just showing the usage of "MongoDBResources_GetMongoRoleDefinition" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBAccountResource created on azure
            // for more information of creating CosmosDBAccountResource, please refer to the document of CosmosDBAccountResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string accountName = "myAccountName";
            ResourceIdentifier cosmosDBAccountResourceId = CosmosDBAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CosmosDBAccountResource cosmosDBAccount = client.GetCosmosDBAccountResource(cosmosDBAccountResourceId);

            // get the collection of this MongoDBRoleDefinitionResource
            MongoDBRoleDefinitionCollection collection = cosmosDBAccount.GetMongoDBRoleDefinitions();

            // invoke the operation
            string mongoRoleDefinitionId = "myMongoRoleDefinitionId";
            MongoDBRoleDefinitionResource result = await collection.GetAsync(mongoRoleDefinitionId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MongoDBRoleDefinitionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_CosmosDBMongoRoleDefinitionGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-09-01-preview/examples/CosmosDBMongoDBRoleDefinitionGet.json
            // this example is just showing the usage of "MongoDBResources_GetMongoRoleDefinition" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBAccountResource created on azure
            // for more information of creating CosmosDBAccountResource, please refer to the document of CosmosDBAccountResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string accountName = "myAccountName";
            ResourceIdentifier cosmosDBAccountResourceId = CosmosDBAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CosmosDBAccountResource cosmosDBAccount = client.GetCosmosDBAccountResource(cosmosDBAccountResourceId);

            // get the collection of this MongoDBRoleDefinitionResource
            MongoDBRoleDefinitionCollection collection = cosmosDBAccount.GetMongoDBRoleDefinitions();

            // invoke the operation
            string mongoRoleDefinitionId = "myMongoRoleDefinitionId";
            bool result = await collection.ExistsAsync(mongoRoleDefinitionId);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_CosmosDBMongoRoleDefinitionGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-09-01-preview/examples/CosmosDBMongoDBRoleDefinitionGet.json
            // this example is just showing the usage of "MongoDBResources_GetMongoRoleDefinition" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBAccountResource created on azure
            // for more information of creating CosmosDBAccountResource, please refer to the document of CosmosDBAccountResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string accountName = "myAccountName";
            ResourceIdentifier cosmosDBAccountResourceId = CosmosDBAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CosmosDBAccountResource cosmosDBAccount = client.GetCosmosDBAccountResource(cosmosDBAccountResourceId);

            // get the collection of this MongoDBRoleDefinitionResource
            MongoDBRoleDefinitionCollection collection = cosmosDBAccount.GetMongoDBRoleDefinitions();

            // invoke the operation
            string mongoRoleDefinitionId = "myMongoRoleDefinitionId";
            NullableResponse<MongoDBRoleDefinitionResource> response = await collection.GetIfExistsAsync(mongoRoleDefinitionId);
            MongoDBRoleDefinitionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MongoDBRoleDefinitionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CosmosDBMongoDBRoleDefinitionCreateUpdate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-09-01-preview/examples/CosmosDBMongoDBRoleDefinitionCreateUpdate.json
            // this example is just showing the usage of "MongoDBResources_CreateUpdateMongoRoleDefinition" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBAccountResource created on azure
            // for more information of creating CosmosDBAccountResource, please refer to the document of CosmosDBAccountResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string accountName = "myAccountName";
            ResourceIdentifier cosmosDBAccountResourceId = CosmosDBAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CosmosDBAccountResource cosmosDBAccount = client.GetCosmosDBAccountResource(cosmosDBAccountResourceId);

            // get the collection of this MongoDBRoleDefinitionResource
            MongoDBRoleDefinitionCollection collection = cosmosDBAccount.GetMongoDBRoleDefinitions();

            // invoke the operation
            string mongoRoleDefinitionId = "myMongoRoleDefinitionId";
            MongoDBRoleDefinitionCreateOrUpdateContent content = new MongoDBRoleDefinitionCreateOrUpdateContent()
            {
                RoleName = "myRoleName",
                DatabaseName = "sales",
                Privileges =
{
new MongoDBPrivilege()
{
Resource = new MongoDBPrivilegeResourceInfo()
{
DBName = "sales",
Collection = "sales",
},
Actions =
{
"insert","find"
},
}
},
                Roles =
{
new MongoDBRole()
{
DBName = "sales",
Role = "myInheritedRole",
}
},
            };
            ArmOperation<MongoDBRoleDefinitionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, mongoRoleDefinitionId, content);
            MongoDBRoleDefinitionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MongoDBRoleDefinitionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_CosmosDBMongoDBRoleDefinitionList()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-09-01-preview/examples/CosmosDBMongoDBRoleDefinitionList.json
            // this example is just showing the usage of "MongoDBResources_ListMongoRoleDefinitions" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBAccountResource created on azure
            // for more information of creating CosmosDBAccountResource, please refer to the document of CosmosDBAccountResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string accountName = "myAccountName";
            ResourceIdentifier cosmosDBAccountResourceId = CosmosDBAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CosmosDBAccountResource cosmosDBAccount = client.GetCosmosDBAccountResource(cosmosDBAccountResourceId);

            // get the collection of this MongoDBRoleDefinitionResource
            MongoDBRoleDefinitionCollection collection = cosmosDBAccount.GetMongoDBRoleDefinitions();

            // invoke the operation and iterate over the result
            await foreach (MongoDBRoleDefinitionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MongoDBRoleDefinitionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
