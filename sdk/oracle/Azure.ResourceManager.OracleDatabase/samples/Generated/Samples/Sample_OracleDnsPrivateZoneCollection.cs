// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.OracleDatabase.Samples
{
    public partial class Sample_OracleDnsPrivateZoneCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListDnsPrivateZonesByLocation()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/stable/2023-09-01/examples/dnsPrivateZones_listByLocation.json
            // this example is just showing the usage of "DnsPrivateZones_ListByLocation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this OracleDnsPrivateZoneResource
            AzureLocation location = new AzureLocation("eastus");
            OracleDnsPrivateZoneCollection collection = subscriptionResource.GetOracleDnsPrivateZones(location);

            // invoke the operation and iterate over the result
            await foreach (OracleDnsPrivateZoneResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                OracleDnsPrivateZoneData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetADnsPrivateZoneByName()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/stable/2023-09-01/examples/dnsPrivateZones_get.json
            // this example is just showing the usage of "DnsPrivateZones_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this OracleDnsPrivateZoneResource
            AzureLocation location = new AzureLocation("eastus");
            OracleDnsPrivateZoneCollection collection = subscriptionResource.GetOracleDnsPrivateZones(location);

            // invoke the operation
            string dnsprivatezonename = "example-dns-private-zone";
            OracleDnsPrivateZoneResource result = await collection.GetAsync(dnsprivatezonename);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OracleDnsPrivateZoneData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetADnsPrivateZoneByName()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/stable/2023-09-01/examples/dnsPrivateZones_get.json
            // this example is just showing the usage of "DnsPrivateZones_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this OracleDnsPrivateZoneResource
            AzureLocation location = new AzureLocation("eastus");
            OracleDnsPrivateZoneCollection collection = subscriptionResource.GetOracleDnsPrivateZones(location);

            // invoke the operation
            string dnsprivatezonename = "example-dns-private-zone";
            bool result = await collection.ExistsAsync(dnsprivatezonename);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetADnsPrivateZoneByName()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/stable/2023-09-01/examples/dnsPrivateZones_get.json
            // this example is just showing the usage of "DnsPrivateZones_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this OracleDnsPrivateZoneResource
            AzureLocation location = new AzureLocation("eastus");
            OracleDnsPrivateZoneCollection collection = subscriptionResource.GetOracleDnsPrivateZones(location);

            // invoke the operation
            string dnsprivatezonename = "example-dns-private-zone";
            NullableResponse<OracleDnsPrivateZoneResource> response = await collection.GetIfExistsAsync(dnsprivatezonename);
            OracleDnsPrivateZoneResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                OracleDnsPrivateZoneData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
