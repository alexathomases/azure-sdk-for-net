// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_WorkloadGroupCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsAWorkloadGroupForADataWarehouse()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/GetWorkloadGroup.json
            // this example is just showing the usage of "WorkloadGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string serverName = "testsvr";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this WorkloadGroupResource
            WorkloadGroupCollection collection = sqlDatabase.GetWorkloadGroups();

            // invoke the operation
            string workloadGroupName = "smallrc";
            WorkloadGroupResource result = await collection.GetAsync(workloadGroupName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetsAWorkloadGroupForADataWarehouse()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/GetWorkloadGroup.json
            // this example is just showing the usage of "WorkloadGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string serverName = "testsvr";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this WorkloadGroupResource
            WorkloadGroupCollection collection = sqlDatabase.GetWorkloadGroups();

            // invoke the operation
            string workloadGroupName = "smallrc";
            bool result = await collection.ExistsAsync(workloadGroupName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetsAWorkloadGroupForADataWarehouse()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/GetWorkloadGroup.json
            // this example is just showing the usage of "WorkloadGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string serverName = "testsvr";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this WorkloadGroupResource
            WorkloadGroupCollection collection = sqlDatabase.GetWorkloadGroups();

            // invoke the operation
            string workloadGroupName = "smallrc";
            NullableResponse<WorkloadGroupResource> response = await collection.GetIfExistsAsync(workloadGroupName);
            WorkloadGroupResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WorkloadGroupData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateAWorkloadGroupWithAllPropertiesSpecified()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/CreateOrUpdateWorkloadGroupMax.json
            // this example is just showing the usage of "WorkloadGroups_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string serverName = "testsvr";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this WorkloadGroupResource
            WorkloadGroupCollection collection = sqlDatabase.GetWorkloadGroups();

            // invoke the operation
            string workloadGroupName = "smallrc";
            WorkloadGroupData data = new WorkloadGroupData()
            {
                MinResourcePercent = 0,
                MaxResourcePercent = 100,
                MinResourcePercentPerRequest = 3,
                MaxResourcePercentPerRequest = 3,
                Importance = "normal",
                QueryExecutionTimeout = 0,
            };
            ArmOperation<WorkloadGroupResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, workloadGroupName, data);
            WorkloadGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateAWorkloadGroupWithTheRequiredPropertiesSpecified()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/CreateOrUpdateWorkloadGroupMin.json
            // this example is just showing the usage of "WorkloadGroups_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string serverName = "testsvr";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this WorkloadGroupResource
            WorkloadGroupCollection collection = sqlDatabase.GetWorkloadGroups();

            // invoke the operation
            string workloadGroupName = "smallrc";
            WorkloadGroupData data = new WorkloadGroupData()
            {
                MinResourcePercent = 0,
                MaxResourcePercent = 100,
                MinResourcePercentPerRequest = 3,
            };
            ArmOperation<WorkloadGroupResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, workloadGroupName, data);
            WorkloadGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetTheListOfWorkloadGroupsForADataWarehouse()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/GetWorkloadGroupList.json
            // this example is just showing the usage of "WorkloadGroups_ListByDatabase" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string serverName = "testsvr";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this WorkloadGroupResource
            WorkloadGroupCollection collection = sqlDatabase.GetWorkloadGroups();

            // invoke the operation and iterate over the result
            await foreach (WorkloadGroupResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WorkloadGroupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
